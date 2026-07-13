using UnityEngine;
using UnityEngine.InputSystem;

public class OpenQuest : MonoBehaviour
{
    [SerializeField] private GameObject questPanel;
    private int _count;
    
    void Update()
    {
        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            questPanel.SetActive(true);
            _count++;

            if (_count == 2)
            {
                questPanel.SetActive(false);
                _count = 0;
            }
        }
    }
}
