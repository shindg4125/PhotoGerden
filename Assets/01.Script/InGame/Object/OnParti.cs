using System;
using UnityEngine;

public class OnParti : MonoBehaviour
{
    [SerializeField] private GameObject _particlesOne;
    [SerializeField] private GameObject _particlesTwo;

    private void Update()
    {
        if (_particlesOne.activeSelf == false)
        {
            _particlesTwo.SetActive(true);
        }
    }
}
