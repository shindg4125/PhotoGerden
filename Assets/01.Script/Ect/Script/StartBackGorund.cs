using System;
using UnityEngine;

public class StartBackGorund : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _fadeObj;

    [SerializeField] private GameObject _ectObj;
    
    
    private void Awake()
    {
        _fadeObj = _fadeObj.GetComponent<SpriteRenderer>();
    }
    
    private void Update()
    {
        IsFalse();
    }

    private void IsFalse()
    {
        if (_fadeObj.color.a == 0f)
        {
            _ectObj.SetActive(true);
        }
    }
    
    
}
