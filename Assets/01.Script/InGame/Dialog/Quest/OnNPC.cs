using UnityEngine;

public class OnNPC : MonoBehaviour
{
    [SerializeField] private GameObject _secondNPC;

    private void Awake()
    {
        _secondNPC.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            _secondNPC.SetActive(true);
    }
}
