using TMPro;
using UnityEngine;

public class Box : MonoBehaviour
{
    public TextMeshProUGUI _talkText;
    public GameObject _talkPanel;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        _talkText.text = "평범한 나무상자다.";
        _talkPanel.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _talkPanel.SetActive(false);
    }
}
