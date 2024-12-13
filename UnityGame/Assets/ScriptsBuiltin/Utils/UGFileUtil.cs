using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class UGFileUtil
{
    public static string WriteablePath(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return ResPath_OutApp;

        return Path.Combine(ResPath_OutApp, fileName);
    }
    public static string ResPath_InApp
    {
        get
        {
            return Application.streamingAssetsPath;
        }
    }
    public static string ResPath_OutApp
    {
        get
        {
            if (Application.isMobilePlatform)
            {
                return Application.persistentDataPath;
            }
            return Path.Combine(Application.dataPath, "../WritablePath/");
        }
    }
    public static string ResPath_InApp_WWW
    {
        get
        {
            if (Application.isMobilePlatform && Application.platform == RuntimePlatform.Android)
            {
                return Application.streamingAssetsPath;
            }
            return "file://" + Application.streamingAssetsPath;
        }
    }
    public static string ResPath_OutApp_WWW
    {
        get
        {
            if (Application.isMobilePlatform)
            {
                return "file://" + Application.persistentDataPath + "/";
            }
            if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer)
            {
                return "file://" + Path.Combine(Application.dataPath, "../WritablePath/");
            }
            return Path.Combine(Application.dataPath, "../WritablePath/");
        }
    }
    public static string ResPath_LoadFromFile_inApp
    {
        get
        {
            //if (Application.isMobilePlatform && Application.platform == RuntimePlatform.Android)
            //{
            //    return Application.dataPath + "!assets/";
            //}
            return Application.streamingAssetsPath;
        }
    }
    public static string ResPath_LoadFromFile_outApp
    {
        get
        {
            if (Application.isMobilePlatform)
            {
                return Application.persistentDataPath;
            }
            return Path.Combine(Application.dataPath, "../WritablePath/");
        }
    }

    public static void GetAllDirs(string basePath, List<string> result, bool includeSubDir = false)
    {
        DirectoryInfo dir = new DirectoryInfo(basePath);
        if (!dir.Exists)
        {
            return;
        }
        _getAllDirs(dir, "", result, includeSubDir);
    }

    private static void _getAllDirs(DirectoryInfo dir, string prePath, List<string> result, bool includeSubDir)
    {
        if (!dir.Exists)
        {
            return;
        }
        string head = prePath;
        if (head.Length > 0)
        {
            head += "/";
        }

        DirectoryInfo[] dirs = dir.GetDirectories();
        for (int i = 0; i < dirs.Length; ++i)
        {
            result.Add(head + dirs[i].Name);
            if (includeSubDir)
            {
                _getAllDirs(dirs[i], head + dirs[i].Name, result, includeSubDir);
            }
        }
    }

    public static void GetAllFiles(string basePath, bool inChildDir, string extList, List<string> result, bool noExt = false)
    {
        DirectoryInfo dir = new DirectoryInfo(basePath);
        if (!dir.Exists)
        {
            return;
        }
        List<string> ext = new List<string>();
        if (extList.Length > 0)
        {
            string[] strs = extList.Split('|');
            for (int i = 0; i < strs.Length; ++i)
            {
                ext.Add(strs[i]);
            }
        }
        _getAllFiles(dir, inChildDir, "", ext, result, noExt);
    }

    private static void _getAllFiles(DirectoryInfo dir, bool inChildDir, string prePath, List<string> extList, List<string> result, bool noExt = false)
    {
        if (!dir.Exists)
        {
            return;
        }
        string head = prePath;
        if (head.Length > 0)
        {
            head += "/";
        }
        if (extList.Count > 0)
        {
            for (int i = 0; i < extList.Count; ++i)
            {
                FileInfo[] files = dir.GetFiles(extList[i]);
                for (int j = 0; j < files.Length; ++j)
                {
                    result.Add(head + (noExt ? _fileNameNoExt(files[j].Name) : files[j].Name));
                }
            }
        }
        else
        {
            FileInfo[] files = dir.GetFiles();
            for (int j = 0; j < files.Length; ++j)
            {
                result.Add(head + (noExt ? _fileNameNoExt(files[j].Name) : files[j].Name));
            }
        }
        if (inChildDir)
        {
            DirectoryInfo[] dirs = dir.GetDirectories();
            for (int i = 0; i < dirs.Length; ++i)
            {
                _getAllFiles(dirs[i], inChildDir, head + dirs[i].Name, extList, result, noExt);
            }
        }
    }

    private static string _fileNameNoExt(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return "";
        int index = fileName.LastIndexOf(".");
        if (index >= 0)
        {
            return fileName.Substring(0, index);
        }
        return fileName;
    }
    public static string MD5EncryptFile(string fileName, bool upper = true)
    {
        try
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(fs);
            fs.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            string ret = sb.ToString();
            return upper ? ret.ToUpper() : ret.ToLower();
        }
        catch (Exception ex)
        {
            throw new Exception("md5file() fail, error:" + ex.Message);
        }
    }

    public static string MD5EncryptBytes(byte[] b, bool upper = true)
    {
        MD5 md5Hash = new MD5CryptoServiceProvider();
        byte[] data = md5Hash.ComputeHash(b);
        md5Hash.Clear();
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        string ret = sBuilder.ToString();
        if (ret.Length != 32)
        {
            Debug.LogError("md5 error");
        }
        //Debug.Log("ret:" + ret);
        if (upper)
        {
            return ret.ToUpper();
        }
        return ret.ToLower();
    }

    public static string MD5EncryptString(string str, bool upper = true)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "";
        }

        MD5 md5Hash = new MD5CryptoServiceProvider();
        byte[] b = Encoding.UTF8.GetBytes(str);

        //Debug.Log("md5:" + str);
        byte[] data = md5Hash.ComputeHash(b);
        md5Hash.Clear();
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        string ret = sBuilder.ToString();
        if (ret.Length != 32)
        {
            Debug.LogError("md5 error");
        }
        //Debug.Log("ret:" + ret);
        if (upper)
        {
            return ret.ToUpper();
        }
        return ret.ToLower();
    }

    /// <summary>
    /// 截取文字，中英混排，中文算两个长度
    /// </summary>
    /// <param name="text"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public static string GetStringForLen(string text, int length)
    {
        int strLength = 0;
        StringBuilder strb = new StringBuilder();
        char[] Temp = text.ToCharArray();
        for (int i = 0; i != Temp.Length; i++)
        {
            if (strLength >= length)
            {
                break;
            }
            else
            {
                if (((int)Temp[i]) < 255)
                { //大于255的都是汉字或者特殊字符
                    strLength++;
                }
                else
                {
                    strLength = strLength + 2;
                }
                strb.Append(Temp[i]);
            }
        }
        return strb.ToString();
    }


    /// <summary>
    /// 拷贝文件夹
    /// </summary>
    /// <param name="srcdir"></param>
    /// <param name="desdir"></param>
    public static void CopyDirectory(string srcdir, string desdir)
    {
        if (Directory.Exists(srcdir) == false)
        {
            return;
        }
        if (Directory.Exists(desdir) == false)
        {
            Directory.CreateDirectory(desdir);
        }

        string[] filenames = Directory.GetFileSystemEntries(srcdir);
        foreach (string file in filenames)
        { // 遍历所有的文件和目录
            if (Directory.Exists(file))
            {
                // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                string currentdir = Path.Combine(desdir, Path.GetFileName(file));
                CopyDirectory(file, currentdir);
            }
            else
            {
                // 否则直接copy文件
                string currentdir = Path.Combine(desdir, Path.GetFileName(file));
                if (File.Exists(currentdir))
                {
                    File.Delete(currentdir);
                }
                File.Copy(file, currentdir);
#if UNITY_EDITOR
                Debug.Log("copy file:" + currentdir);
#endif
            }
        } //foreach 
    }
    public static void CopyFile(string srcDir, string desDir, string fileName)
    {
        string src = Path.Combine(srcDir, fileName);
        string des = Path.Combine(desDir, fileName);
        if (File.Exists(des))
        {
            File.Delete(des);
        }
        File.Copy(src, des);
#if UNITY_EDITOR
        Debug.Log("copy file:" + src + " to: " + des);
#endif
    }

    public static void CopyFile_CreateDir(string srcDir, string desDir, string fileName)
    {
        string src = Path.Combine(srcDir, fileName);
        string des = Path.Combine(desDir, fileName);
        string dir = Path.GetDirectoryName(des);
        CreateDir(dir);
        if (File.Exists(des))
        {
            File.Delete(des);
        }
        File.Copy(src, des);
#if UNITY_EDITOR
        Debug.Log("copy file:" + src + " to: " + des);
#endif
    }

    public static void CopyFile_CreateDir(string src, string des)
    {
        string dir = Path.GetDirectoryName(des);
        CreateDir(dir);
        if (File.Exists(des))
        {
            File.Delete(des);
        }
        File.Copy(src, des);
#if UNITY_EDITOR
        Debug.Log("copy file:" + src + " to: " + des);
#endif
    }
    //function end

    public static string Combine(string basepath, string path)
    {
        basepath = basepath.Replace('\\', '/');
        path = path.Replace('\\', '/');
        while (basepath.EndsWith("/") == true)
        {
            basepath = basepath.Substring(0, basepath.Length - 1);
        }
        return basepath + "/" + path;
    }

    public static string PathCombine(string root, params string[] paths)
    {
        StringBuilder path = new StringBuilder(root);

        var iter = paths.GetEnumerator();
        while (iter.MoveNext())
        {
            string subPath = (string)iter.Current;
            if (path.Length < 1)
            {
                path.Append(subPath);
            }
            else
            {
                if (path[path.Length - 1] != '/') path.Append('/');
                if (!string.IsNullOrEmpty(subPath)) path.Append(subPath);
            }
        }
        return path.ToString();
    }

    public static bool CreateDir(string path)
    {
        if (Directory.Exists(path))
        {
            return true;
        }
        DirectoryInfo myDirectoryInfo = Directory.CreateDirectory(path);
        return myDirectoryInfo.Exists;
    }

    public static bool ReDreateDir(string path)
    {
        DeleteDir(path);
        DirectoryInfo myDirectoryInfo = Directory.CreateDirectory(path);
        return myDirectoryInfo.Exists;
    }

    public static bool DeleteDir(string path)
    {
        if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
        }
        return true;
    }

    public static void MoveFile(string from, string to)
    {
        File.Move(from, to);
    }

    public static void Rename(string path, string fromfile, string tofile)
    {
        fromfile = Combine(path, fromfile);
        if (!File.Exists(fromfile))
        {
            return;
        }
        tofile = Combine(path, tofile);
        if (fromfile.CompareTo(tofile) == 0)
        {
            return;
        }
        if (File.Exists(tofile))
        {
            DeleteFile(tofile);
        }
        MoveFile(fromfile, tofile);
    }

    public static void Rename(string fromfile, string tofile)
    {
        if (!File.Exists(fromfile))
        {
            return;
        }
        if (fromfile.CompareTo(tofile) == 0)
        {
            return;
        }
        if (File.Exists(tofile))
        {
            DeleteFile(tofile);
        }
        MoveFile(fromfile, tofile);
    }

    public static bool DeleteFile(string path)
    {
        FileInfo fi = new FileInfo(path);
        if (fi.Exists)
        {
            try
            {
                if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                {
                    fi.Attributes = FileAttributes.Normal;
                }
                fi.Delete();
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return false;
            }
        }
        return true;
    }

    public static bool ExitsDir(string dirName)
    {
        DirectoryInfo di = new DirectoryInfo(dirName);
        return di.Exists;
    }

    public static bool ExitsFile(string fileName)
    {
        return File.Exists(fileName);
    }

    public static long FileSize(string fileName)
    {
        FileInfo fi = new FileInfo(fileName);
        if (fi.Exists)
        {
            return fi.Length;
        }
        return 0;
    }
    public static void WriteString(string fileName, string data)
    {
        DeleteFile(fileName);
        using (StreamWriter writer = new StreamWriter(fileName, false))
        {
            writer.WriteLine(data);
            writer.Flush();
            writer.Close();
        }
    }

    public static void AppendString(string fileName, string data)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine(data);
            writer.Flush();
            writer.Close();
        }
    }

    public static void WriteBytes(string fileName, byte[] data)
    {
        DeleteFile(fileName);
        using (FileStream fs = new FileStream(fileName, FileMode.Create))
        {
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }
    }
    public static void WriteLine(string fileName, string data)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine(data);
            writer.Close();
            return;
        }
    }

    public static string ReadString(string fileName)
    {
        if (File.Exists(fileName))
        {
            return File.ReadAllText(fileName);
        }
        return "";
    }

    public static byte[] ReadBytes(string fileName)
    {
        if (File.Exists(fileName))
        {
            return File.ReadAllBytes(fileName);
        }
        return null;
    }
}
