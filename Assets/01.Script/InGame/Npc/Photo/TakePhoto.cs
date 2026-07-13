using System;
using UnityEngine;

public class TakePhoto : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _SurveyRen;
    [SerializeField] private GameObject _PhotoParticles;
    [SerializeField] private GameObject[] _delNPC = new GameObject[0];

    private int _count = 0;
    
    //[SerializeField] private GameObject PhotoOne;

    private void Awake()
    {
        _PhotoParticles.SetActive(false);
    }

    private void Update()
    {
        if (_SurveyRen.enabled == false)
        {
            _count++;
            if (_count == 1)
            {
                _PhotoParticles.SetActive(true);
            }
            _delNPC[0].SetActive(false);
            _delNPC[1].SetActive(false);
        }
    }
}
