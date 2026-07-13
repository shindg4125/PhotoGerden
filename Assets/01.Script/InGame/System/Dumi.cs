using System;
using UnityEngine;

public class Dumi : MonoBehaviour
{
    [SerializeField] private GameObject _dumi;


    private void Start()
    {
        _dumi.SetActive(false);
    }
}
