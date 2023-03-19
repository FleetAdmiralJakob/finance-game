using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip moneySound;
    private const float VolumeMoneySound = 500f;

    public AudioClip backgroundMusicClip;
    private const float VolumeBackgroundMusic = 0.06f;
    private AudioSource _backgroundMusicSource;

    private void Start()
    {
        _backgroundMusicSource = GetComponent<AudioSource>();
        
        _backgroundMusicSource.clip = backgroundMusicClip;
        _backgroundMusicSource.volume = VolumeBackgroundMusic;
        _backgroundMusicSource.loop = true;
        
        _backgroundMusicSource.Play();
    }

    public void PlayMoneySound()
    {
        AudioSource.PlayClipAtPoint(moneySound, new Vector3(0, 0, 0), VolumeMoneySound);
    }
}
