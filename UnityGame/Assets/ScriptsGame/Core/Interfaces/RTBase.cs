using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTBase : MonoBehaviour
{
    private RectTransform _rt;
    public RectTransform RT {
        get
        {
            if(_rt == null)
            {
                _rt = GetComponent<RectTransform>();
            }
            return _rt;
        }
    }
}
