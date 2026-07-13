using System;
using System.Collections;
using UnityEngine;
using DG.Tweening;

public class StartFadeOut : MonoBehaviour
{ 
    [SerializeField] private SpriteRenderer _fadeObj;

    private void Awake()
    {
        _fadeObj = _fadeObj.GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        FadeIn();
    }

    private void FadeIn()
    {
        _fadeObj.enabled = true;
            
        _fadeObj.DOFade(10f, 3f).SetEase(Ease.InOutCubic).SetUpdate(true);
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        _fadeObj.enabled = true;
            
        yield return new WaitForSeconds(2f);
        _fadeObj.DOFade(0f, 3f).SetEase(Ease.InOutCubic);
    }
}
