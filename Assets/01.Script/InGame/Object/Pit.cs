using System.Collections;
using TMPro;
using UnityEngine;

public class Pit : MonoBehaviour
{
    public GameObject _panel;
    public TextMeshProUGUI _surveytext;
    public string[] tips = { "구겨진 플라스틱을 얻었다.", "부서진 철 조각을 얻었다.", "비닐봉지를 얻었다." };
    private int lastIndex = -1;
    private Coroutine tipCoroutine;

    
    private void Start()
    {
        _panel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tipCoroutine != null)
        {
            StopCoroutine(tipCoroutine);
        }
        tipCoroutine = StartCoroutine(WaitAndShowTip());
    }

    private IEnumerator WaitAndShowTip()
    {
        yield return new WaitForSeconds(2.0f);

        if (tips == null || tips.Length == 0)
        {
            tipCoroutine = null;
            yield break;
        }

        int randomIndex;
        
        if (tips.Length == 1)
        {
            randomIndex = 0;
        }
        else
        {
            do {
                randomIndex = Random.Range(0, tips.Length);
            } while (randomIndex == lastIndex);
        }

        lastIndex = randomIndex;
        _panel.SetActive(true);
        _surveytext.text = tips[randomIndex];
        StartCoroutine(End());
        
        tipCoroutine = null; // 코루틴 종료 시 초기화
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(1.0f);
    }
}
