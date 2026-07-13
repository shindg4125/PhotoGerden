using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class OutHouse : MonoBehaviour
{
    public GameObject _playerTrm;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TurnOn());
        }
    }
    
    IEnumerator TurnOn()
    {
        yield return new WaitForSeconds(1f);
        _playerTrm.transform.position = new Vector3(-5.2f, -25.06f, 0.1625217f);
    }
}
