using System.Collections;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.InputSystem;

public class TXTskip : MonoBehaviour
{
    [SerializeField] private GameObject[] _txtScene1;
    [SerializeField] private GameObject _thanks;

    private int _count = 0;

    private void Awake()
    {
        if (_txtScene1 == null || _txtScene1.Length == 0) return;

        for (int i = 0; i < _txtScene1.Length; i++)
        {
            if (_txtScene1[i] != null)
                _txtScene1[i].SetActive(false);;
        }
    }

    private void Update()
    {
        Enter();
    }

    private void FadeIn()
    {
        if (_count >= _txtScene1.Length || _txtScene1[_count] == null) return;

        _txtScene1[_count].SetActive(true);
    }

    private void Enter()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            if (_count < _txtScene1.Length)
            {
                FadeIn();
                _count++;
            }
            else if (_count >= _txtScene1.Length)
            {
                _count = 0;
                
                for (int i = 0; i < _txtScene1.Length; i++)
                {
                    if (_txtScene1[i] != null)
                    {
                        _txtScene1[i].SetActive(false);
                    }
                }
            }
        }

        if (_txtScene1[_txtScene1.Length-1].activeSelf == true)
        {
            _thanks.SetActive(true);
        }
    }

}