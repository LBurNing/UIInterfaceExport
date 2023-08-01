using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager
{
    public static T GetComponentByName<T>(string name) where T : Component
    {
        Type type = typeof(T);

        #region 获取到对应的component
        Component c = null;
        #endregion

        return (T)c;

    }

    public static T GetComponentByPath<T>(string path) where T : Component
    {
        RectTransform rt = null; //实现一个通过路径获取RectTransform的接口
        if (rt == null)
            return null;

        T com = rt.GetComponent<T>();
        if (com == null)
        {
            Debug.LogError("GetComponentByPath Error, com is null, path:" + path + " com:" + com.GetType().Name);
            return null;
        }

        return com;
    }

    public static T GetComponentByOrgin<T>(string name, string path) where T : Component
    {
        RectTransform rt = null; //实现一个通过相对路径获取RectTransform的接口
        if (rt == null)
            return null;

        T com = rt.GetComponent<T>();
        if (com == null)
        {
            Debug.LogError("GetComponentByOrgin Error, com is null, name:" + name + " path:" + path);
            return null;
        }

        return com;
    }
}
