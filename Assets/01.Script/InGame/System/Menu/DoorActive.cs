using System;
using UnityEngine;

public class DoorActive : MonoBehaviour
{
    [SerializeField] private GameObject _nextDayButton;
    
    [SerializeField] private GameObject photo;
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject area;

    private void Awake()
    {
        door.SetActive(false);
        _nextDayButton.SetActive(false);
    }

    private void Update()
    {
        if (photo.activeSelf == true)
        {
            door.SetActive(true);
            area.SetActive(true);
        }
    }
}
