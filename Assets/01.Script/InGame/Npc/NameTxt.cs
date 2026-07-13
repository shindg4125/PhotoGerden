using TMPro;
using UnityEngine;

public class NameTxt : MonoBehaviour
{
    [SerializeField] private GameObject _namePanel;
    [SerializeField] private TextMeshProUGUI _nameTxt;
    
    private string _name;
    private string _gameObjName;

    private void Awake()
    {
        _namePanel.SetActive(false);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        ChName();
        if (collision.gameObject.CompareTag("Player"))
        {
            _namePanel.SetActive(true);
            _nameTxt.text = _name;
        }
        _namePanel.SetActive(false);
    }
    //
    // private void OnTriggerStay2D(Collider2D collision)
    // {
    //     ChName();
    //     if (collision.CompareTag("Player"))
    //     {
    //         _namePanel.SetActive(true);
    //         _nameTxt.text = _name;
    //     }
    //     _namePanel.SetActive(false);
    // }

    private void ChName()
    {
        if (gameObject.name == "NPC1")
        {
            _name = " 장현식 ";
        }
        
        else if (gameObject.name == "NPC2")
        {
            _name = " 장대한 ";
        }
        
        else if (gameObject.name == "NPC3")
        {
            _name = " 김재훈 ";
        }
        
        else if (gameObject.name == "NPC4")
        {
            _name = " 안지수 ";
        }
        
        else if (gameObject.name == "NPC5")
        {
            _name = " 박상혁 ";
        }
        
        else if (gameObject.name == "NPC6")
        {
            _name = " 최창호 ";
        }
        else
        {
            _namePanel.SetActive(false);
        }
    }
}
