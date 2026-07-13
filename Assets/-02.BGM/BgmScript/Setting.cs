using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public AudioSource bgmSource;
    public Slider bgmVolumeSlider;


    public AudioClip clip;

    private void Awake()
    {
        bgmSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        bgmSource.Stop();
        bgmVolumeSlider.value = bgmSource.volume;
        bgmSource.clip = this.clip;
        bgmSource.loop = true;
        StartCoroutine(StartBGM());
    }

    void Update()
    {
        bgmSource.volume = bgmVolumeSlider.value;
    }

    IEnumerator StartBGM()
    {
        yield return new WaitForSeconds(9.5f);
        bgmSource.Play();
    }
}
