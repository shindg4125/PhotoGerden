using System.Collections;
using TMPro;
using UnityEngine;

public class StartPlayerDialog : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private TextMeshProUGUI _TXT;
    [SerializeField] private GameObject _dontMove;


    private void Start()
    {
        _dontMove.SetActive(true);
        StartCoroutine(Dialog());
    }


    IEnumerator Dialog()
    {
        yield return new WaitForSeconds(10f);
        _panel.SetActive(true);
        _TXT.text = "여긴 어디지..?";
        yield return new WaitForSeconds(2f);
        _TXT.text = "내가 뭘 하고있던 건지도 기억이 안 나..";
        yield return new WaitForSeconds(2f);
        _TXT.text = "일단 저기 저 사람한테 가볼까?";
        yield return new WaitForSeconds(2f);
        _panel.SetActive(false);
        _dontMove.SetActive(false);
    }
}
