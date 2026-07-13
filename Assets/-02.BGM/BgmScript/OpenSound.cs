using UnityEngine;
using UnityEngine.InputSystem;

public class OpenSound : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    private int _count= 0;
    
    private void Awake()
    {
        Canvas.SetActive(false);
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Canvas.SetActive(true);
            _count++;
            if (_count == 2)
            {
                _count = 0;
                Canvas.SetActive(false);
            }
        }
    }
}
