using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    [SerializeField] private GameObject startImage;
    [SerializeField] private AudioClip breathingAudio;
    [SerializeField] private GameObject _txtScene;

    
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void Start()
    {
        startImage.SetActive(true);
        _audio.clip = breathingAudio;
        _audio.Play();
        StartCoroutine(CloseScene());
    }


    IEnumerator CloseScene()
    {
        yield return new WaitForSeconds(9.5f);
        startImage.SetActive(false);
        _audio.Stop();
        _txtScene.SetActive(true);
    }
}
