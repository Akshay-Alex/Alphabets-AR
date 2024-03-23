using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource source;
    void Start()
    {
        Instance = this;
    }

    public void PlayAudio(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }
}
