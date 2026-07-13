using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenAlbum : MonoBehaviour
{
    [SerializeField] private GameObject albumPanel;
    private int _count;
    
    private void Update()
    {
        if (Keyboard.current.gKey.wasPressedThisFrame)
        {
            albumPanel.SetActive(true);
            _count++;

            if (_count == 2)
            {
                albumPanel.SetActive(false);
                _count = 0;
            }
        }
    }
}
