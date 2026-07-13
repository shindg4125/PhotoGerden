using UnityEngine;

public class SeaSound : MonoBehaviour
{
    public AudioSource seaBgmSource;

    private void Awake()
    {
        seaBgmSource = GetComponent<AudioSource>();
    }
    
    void Start()
    {
        seaBgmSource.Stop();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        seaBgmSource.Play();
    }
}
