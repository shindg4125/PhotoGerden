using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EndingFadeInOut : MonoBehaviour
{
    [Header("Anything")]
    [SerializeField] private SpriteRenderer _nextDay;
    [SerializeField] private GameObject _lastAnimation;
    
    [Header("Buttons")]
    [SerializeField] private GameObject _nextDayButton;
    [SerializeField] private GameObject _lastbutton;
    
    [Header("Text")]
    [SerializeField] private GameObject _panel;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TextMeshProUGUI _textButtonOne;
    [SerializeField] private TextMeshProUGUI _textButtonTwo;
    
    private void Awake()
    {
        if (_nextDay == null)
        {
            _nextDay = GetComponent<SpriteRenderer>();
        }

        if (_lastAnimation != null) _lastAnimation.SetActive(false);
        if (_lastbutton != null) _lastbutton.SetActive(false);
        
        CloseButton();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_lastbutton != null) _lastbutton.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartButton();
            if (_text != null) _text.text = " 꿈에서 깰까..? ";
            if (_textButtonOne != null) _textButtonOne.text = " 깨어나자 ";
            if (_textButtonTwo != null) _textButtonTwo.text = " 남아있자 ";
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CloseButton();
    }

    public void OnClick()
    {
        CloseButton(); 
        SceneManager.LoadScene("EndScene");
    }
    
    public void Realized()
    {
        CloseButton();
        FadeIn();
        StartCoroutine(FadeOut());
    }

    private void FadeIn()
    {
        if (_nextDay != null)
        {
            _nextDay.DOFade(1f, 3f).SetEase(Ease.InOutCubic).SetUpdate(true);
        }
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(2f);
        if (_nextDay != null) _nextDay.DOFade(0f, 3f).SetEase(Ease.InOutCubic);
        if (_lastAnimation != null) _lastAnimation.SetActive(true);
    }

    private void StartButton()
    {
        if (_panel != null) _panel.SetActive(true);
        if (_nextDayButton != null) _nextDayButton.SetActive(true);
    }

    private void CloseButton()
    {
        if (_panel != null) _panel.SetActive(false);
        if (_nextDayButton != null) _nextDayButton.SetActive(false);
    }
}