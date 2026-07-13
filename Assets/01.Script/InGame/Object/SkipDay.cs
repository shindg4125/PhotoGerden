using TMPro;
using UnityEngine;

public class SkipDay : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject[] _days;
    [SerializeField] private GameObject[] _doors;
    [SerializeField] private TextMeshProUGUI _daysText;
    
    
    [SerializeField] private GameObject _lastbutton;

    private int _currentIndex = 0; 
    public bool _dayFour = false;

    private void Start()
    {
        _lastbutton.SetActive(false);
        if (_days == null || _days.Length == 0 || _doors == null || _doors.Length < 2)
        {
            Debug.LogError("인펙터 창에서 _days와 _doors 배열을 채워주세요!");
            return;
        }

        for (int i = 1; i < _days.Length; i++)
        {
            _days[i].SetActive(false); 
        }

        _doors[0].SetActive(true);
        _doors[1].SetActive(false);
    }

    public void OnClick()
    {
        NextDay();
    }

    private void NextDay()
    {
        if (_currentIndex + 1 >= _days.Length) 
        {
            _lastbutton.SetActive(true);
            
            Debug.Log("마지막 날입니다!");
            return; 
        }

        _days[_currentIndex].SetActive(false);

        _currentIndex++;
        _days[_currentIndex].SetActive(true);

        if (_currentIndex == 1)
            _daysText.text = "둘째날";
        if (_currentIndex == 2)
            _daysText.text = "셋째날";
        if (_currentIndex == 3)
            _daysText.text = "넷째날";
        
        if (_currentIndex >= 3) 
        {
            _dayFour = true;
            
            _doors[1].SetActive(true);
            _doors[0].SetActive(false);
        }
    }
}