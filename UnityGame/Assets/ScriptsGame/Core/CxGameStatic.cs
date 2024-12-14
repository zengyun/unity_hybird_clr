using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class CxGameStatic : MonoBehaviour
    {
        private static CxGameStatic _instance;
        public static CxGameStatic Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.AddComponent<CxGameStatic>();
                }
                return _instance;
            }
        }

        public static bool Valied
        {
            get
            {
                return _instance != null;
            }
        }
        public static GameObject CreateNode()
        {
            CxGameStatic parent = Instance;
            GameObject obj = new GameObject();
            obj.transform.SetParent(parent.transform);
            return obj;
        }

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                GameObject.Destroy(gameObject);
                return;
            }
            name = "CxGameStatic";
            DontDestroyOnLoad(gameObject);
            _instance = this;
        }
        private void OnDestroy()
        {
            if (_instance != null && _instance == this)
            {
                _instance = null;
            }
        }
    }

}
