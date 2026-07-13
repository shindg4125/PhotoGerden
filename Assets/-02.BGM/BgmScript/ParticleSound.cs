using UnityEngine;
using UnityEngine.InputSystem;

public class ParticleSound : MonoBehaviour
{
    [SerializeField] private AudioClip surveySound;
    private AudioSource _audio;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _audio.clip = surveySound;
            _audio.Play();
        }
    }
}
