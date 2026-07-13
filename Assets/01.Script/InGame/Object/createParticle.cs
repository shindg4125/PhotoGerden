using System.Collections;
using TMPro;
using UnityEngine;

public class createParticle : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI text;

    private void Awake()
    {
        panel.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            panel.SetActive(true);
            StartCoroutine(TxT());
        }
    }

    IEnumerator TxT()
    {
        yield return new WaitForSeconds(2f);
        text.text = "음..? 이 것도 보물인가?";
        yield return new WaitForSeconds(2f);
        text.text = "안에 있는 편지는 나중에 확인하자.";
        yield return new WaitForSeconds(2f);
        panel.SetActive(false);
    }
}
