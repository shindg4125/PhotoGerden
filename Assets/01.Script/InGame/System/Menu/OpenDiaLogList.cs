using System;
using UnityEngine;

public class OpenDiaLogList : MonoBehaviour
{
    [SerializeField] private GameObject _questList;
    
    private void Awake()
    {
        _questList.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            OnUI();
    }

    private void OnUI()
    {
        _questList.SetActive(true);
    }
}
