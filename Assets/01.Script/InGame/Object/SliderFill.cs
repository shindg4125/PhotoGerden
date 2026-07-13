using UnityEngine;
using UnityEngine.UI;

public class SliderFill : MonoBehaviour
{
    public Slider _slider;
    private bool fullValue = false;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pit"))
        {
            SliderF();
        }
    }

    private void SliderF()
    {
        while (fullValue == false)
        {
            _slider.value += 1f;
            if (_slider.value >= 1)
            { 
                fullValue = true; 
                _slider.value = 0; 
            }
            break;
        }
    }
}
