using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Networking;
using System.IO;
using LuaInterface;
namespace Game
{
    public class ComTools : MonoBehaviour
    {
        private static ComTools _instance;
        public static ComTools Instance
        {
            get
            {
                if (_instance == null)
                {
                    CxGameStatic.CreateNode().AddComponent<ComTools>();
                }
                return _instance;
            }
        }
        public static bool Valied { get { return _instance != null; } }
        private void Awake()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
                return;
            }
            _instance = this;
            name = "ComTools";
        }

        public void SetCopyBuffer(string str)
        {
            UnityEngine.GUIUtility.systemCopyBuffer = str;
        }
        public string GetCopyBuffer()
        {
            return UnityEngine.GUIUtility.systemCopyBuffer;
        }
        public float GetCharWidth(Font font,char ch,int size,int style)
        {
            CharacterInfo info;
            font.GetCharacterInfo(ch, out info, size, (FontStyle)style);
            return info.advance;
        }
        public float GetCharWidth(Font font, char ch, Text text)
        {
            CharacterInfo info;
            font.GetCharacterInfo(ch, out info, text.fontSize, text.fontStyle);
            return info.advance;
        }
        public void SetRigidbodyFreeze(Rigidbody body, int value)
        {
            body.constraints = (RigidbodyConstraints)value;
        }
        public void SetTextHorizontalOverflow(Text text, int type)
        {
            text.horizontalOverflow = (HorizontalWrapMode)type;
        }

        public void SetAnimationSpeed(Animation ani, string stateName,float speed)
        {
            AnimationState state = ani[stateName];
            if(state != null)
            {
                state.speed = speed;
            }
        }

        public String GetParaString(String str, Text text, int windowwidth)
        {
            // Debug.LogError("GetParaString...... " + str + " " + windowwidth);
            int maxWidth = windowwidth;
            CharacterInfo info;
            Font useFont = text.font;
            useFont.RequestCharactersInTexture(str, text.fontSize, text.fontStyle);
            char[] arr = str.ToCharArray();
            String parStr = "";
            foreach(char c in arr)
            {
                useFont.GetCharacterInfo(c, out info, text.fontSize, text.fontStyle);
                int charWidth = info.advance;
                if (maxWidth < charWidth)
                {
                    if (Char.IsPunctuation(c))
                    {
                        parStr = parStr + c + "\n";
                        maxWidth = windowwidth;
                        continue;
                    }else
                    {
                        parStr = parStr + "\n";
                        maxWidth = windowwidth;
                    }
                }
                maxWidth = maxWidth - charWidth;
                parStr = parStr + c;
            }
            return parStr;
        }

        public void VideoPlayOrStop(RectTransform RT, int state)
        {
            if (state == 0)
            {
                RT.GetComponent<VideoPlayer>().Pause();
            }
            else if(state == 1){
                RT.GetComponent<VideoPlayer>().Play();
            }
        }
        public void SetTextFontStyle(Text text, int style)
        {
            text.fontStyle = (FontStyle)style;
        }

        public void DumpTime(string msg)
        {
            Debug.Log("GameTools dump time: msg = " + msg + " point = " + Time.realtimeSinceStartup);
        }

        public void HttpGet(string url,LuaInterface.LuaFunction func)
        {
            StartCoroutine(_httpGet(url, func,null));
        }
        public void HttpGetBytes(string url, LuaInterface.LuaFunction func)
        {
            StartCoroutine(_httpGet_buffer(url, func, null));
        }

        [LuaInterface.NoToLua]
        public void HttpGet(string url, Action<bool, string> func)
        {
            StartCoroutine(_httpGet(url, null, func));
        }
        [LuaInterface.NoToLua]
        public void HttpGetBytes(string url, Action<bool, byte[]> func)
        {
            StartCoroutine(_httpGet_buffer(url, null, func));
        }
        private IEnumerator _httpGet(string url, LuaInterface.LuaFunction luafunc,Action<bool,string> sfunc)
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
            {
                yield return webRequest.SendWebRequest();

                string txt = "";
                bool ret = false;
                if (webRequest.isHttpError || webRequest.isNetworkError)
                {
                    txt = webRequest.error;
                    Debug.Log("_httpGet Error:url = " + url + ";error = " + webRequest.error);
                }
                else
                {
                    txt = webRequest.downloadHandler.text;
                    ret = true;
                }
                if(luafunc != null)
                {
                    luafunc.Call(ret, txt);
                    luafunc.Dispose();
                }
                if(sfunc != null)
                {
                    sfunc(ret, txt);
                }
                webRequest.Dispose();
            }
        }

        private IEnumerator _httpGet_buffer(string url, LuaInterface.LuaFunction luafunc, Action<bool, byte[]> sfunc)
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
            {
                DownloadHandlerBuffer dH = new DownloadHandlerBuffer();
                webRequest.downloadHandler = dH;
                yield return webRequest.SendWebRequest();

                byte[] bytes = null;
                bool ret = false;
                if (webRequest.isHttpError || webRequest.isNetworkError)
                {
                    Debug.Log("_httpGet Error:url = " + url + ";error = " + webRequest.error);
                }
                else
                {
                    bytes = webRequest.downloadHandler.data;
                    ret = true;
                }
                if (luafunc != null)
                {
                    luafunc.Call(ret, bytes);
                    luafunc.Dispose();
                }
                if (sfunc != null)
                {
                    sfunc(ret, bytes);
                }
                webRequest.Dispose();
            }
        }

        public void LoadNetTime(LuaInterface.LuaFunction luafunc, Action<long> sfunc)
        {
            StartCoroutine(_loadTime(luafunc, sfunc));
        }
        private IEnumerator _loadTime(LuaInterface.LuaFunction luafunc, Action<long> sfunc)
        {
            string url = "http://www.hko.gov.hk/cgi-bin/gts/time5a.pr?a=1";
            using (WWW www = new WWW(url))
            {
                yield return www;

                long time = 0;
                if (string.IsNullOrEmpty(www.error) == false || www.text == "" || www.text.Trim() == "")
                {
                    DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
                    time = (long)(System.DateTime.Now - startTime).TotalMilliseconds;
                }
                else
                {
                    string timeStr = www.text.Substring(2);
                    long.TryParse(timeStr, out time);
                }

                Debug.Log("time:" + time);
                if (luafunc != null)
                {
                    luafunc.Call(time.ToString());
                    luafunc.Dispose();
                }
                if (sfunc != null)
                {
                    sfunc(time);
                }
            }
        }
    }
}

