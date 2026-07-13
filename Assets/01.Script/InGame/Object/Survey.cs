using System.Collections;
using TMPro;
using UnityEngine;

public class Survey : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sRenderer;
    [SerializeField] private GameObject[] _npcs;
    public GameObject _panel;
    public TextMeshProUGUI _surveytext;
    public GameObject _obj;
    

    private string _item;
    [SerializeField] private int _count;
    
    private void Awake()
    {
        _sRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _panel.SetActive(false);
    }

    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < _npcs.Length; i++)
        {
            _npcs[i].SetActive(false);
        }
        _surveytext.text = "( 스윽 스윽 )";
        _panel.SetActive(false);
        if (_count == 0)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                    if (_obj.name == "strawberry")
                    {
                        _item = "열매";
                        StartCoroutine(TurnOn());
                        Debug.Log("Berry");
                    }

                    if (_obj.name == "Straw")
                    {
                        _item = "지푸라기";
                        StartCoroutine(TurnOn());
                        Debug.Log("Straw");
                    }
            }
        }
    }
    
    private IEnumerator TurnOn()
    {
        Debug.Log("TurnOn");
        yield return new WaitForSeconds(1f);
        OnSurvey();
        yield return new WaitForSeconds(1.4f);
        _panel.SetActive(false);
        yield return new WaitForSeconds(1.4f);
        _sRenderer.enabled = false;
    }
    
    private void OnSurvey()
    {
        Debug.Log("OnSurvey");
        _panel.SetActive(true);
        if (_item == "지푸라기")
        {
            _surveytext.text = $"{_item}를 청소했다!";
        }
        _surveytext.text = $"{_item} 한 개를 얻었다!";
        _panel.SetActive(true);
        _count++;
    }
}
