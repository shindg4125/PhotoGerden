using System.Collections;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    [SerializeField] private GameObject startImage;
    [SerializeField] private AudioClip carCrashAudio;

    
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void Start()
    {
        startImage.SetActive(true);
        StartCoroutine(CloseScene());
        StartCoroutine(CarCrash());
    }


    IEnumerator CloseScene()
    {
        yield return new WaitForSeconds(9.5f);
        startImage.SetActive(false);
    }
    IEnumerator CarCrash()
    {
        yield return new WaitForSeconds(2.4f); 
        _audio.clip = carCrashAudio;
        _audio.Play();
    }
}
