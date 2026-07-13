using UnityEngine;

public class DontMove : MonoBehaviour
{
    [SerializeField] private GameObject _dontMove;

    private void Awake()
    {
        _dontMove.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _dontMove.SetActive(true);
    }
}
