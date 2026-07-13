using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class InHouse : MonoBehaviour
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
        _playerTrm.transform.position = new Vector3(-52.36f, 36.55f, 0.1625217f);
    }
}
