using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource _audiosource;
    public AudioClip ac;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Score.clicked += PlayAudio;
        Health.clicked += PlayAudio;
    }

    private void OnDisable()
    {
        Score.clicked -= PlayAudio;
        Health.clicked -= PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.PlayOneShot(ac);
    }
}