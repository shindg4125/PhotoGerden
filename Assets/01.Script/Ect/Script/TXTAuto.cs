using System.Collections;
using UnityEngine;

public class TXTAuto : MonoBehaviour
{
    [SerializeField] private GameObject[] _txtScene1;
    [SerializeField] private GameObject _thanks;

    private void Awake()
    {
        if (_txtScene1 == null || _txtScene1.Length == 0) return;

        for (int i = 0; i < _txtScene1.Length; i++)
        {
            if (_txtScene1[i] != null)
                _txtScene1[i].SetActive(false);
        }

        if (_thanks != null)
            _thanks.SetActive(false);
    }

    private void Start()
    {
        if (_txtScene1 != null && _txtScene1.Length > 0)
        {
            StartCoroutine(AutoTextRoutine());
        }
    }

    IEnumerator AutoTextRoutine()
    {
        for (int i = 0; i < _txtScene1.Length; i++)
        {
            yield return new WaitForSeconds(2f);

            if (_txtScene1[i] != null)
            {
                _txtScene1[i].SetActive(true);
            }
        }

        if (_thanks != null)
        {
            _thanks.SetActive(true);
        }
    }
}