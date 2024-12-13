using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TBase : MonoBehaviour
{
    private Transform _t;
    public Transform T
    {
        get
        {
            if (_t == null)
            {
                _t = transform;
            }
            return _t;
        }
    }
}
