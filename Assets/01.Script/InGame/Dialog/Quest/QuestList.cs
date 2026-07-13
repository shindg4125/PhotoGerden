using UnityEngine;

public class QuestList : MonoBehaviour
{
    [SerializeField] private GameObject questList;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            questList.SetActive(true);
        }        
    }
}
