using UnityEngine;

public class DoorActiveEND : MonoBehaviour
{
    [SerializeField] private GameObject photo1;
    [SerializeField] private GameObject photo2;
    [SerializeField] private GameObject door;

    [SerializeField] private GameObject area;
    [SerializeField] private GameObject _nextDayButton;
    

    private void Awake()
    {
        door.SetActive(false);
        _nextDayButton.SetActive(false);
    }

    private void Update()
    {
        if (photo1.activeSelf)
        {
            door.SetActive(true);
            area.SetActive(true);
        }
    }
}
