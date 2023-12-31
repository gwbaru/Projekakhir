using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AudioManagerLobby : MonoBehaviour
{
    public static AudioManagerLobby instance;

    public SoundLobby[] bgmSound, sfxSound;
    public AudioSource bgmSource, sfxSource;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySFX(string nama)
    {
        SoundLobby s = Array.Find(sfxSound, x => x.nama == nama);

        if (s == null)
        {
            Debug.Log("Sfx 404");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

    public void PlayBGM(string nama)
    {
        SoundLobby s = Array.Find(bgmSound, x => x.nama == nama);

        if (s == null)
        {
            Debug.Log("Sfx 404");
        }
        else
        {
            bgmSource.PlayOneShot(s.clip);
        }
    }

    public void BGMVolume(float volume)
    {
        bgmSource.volume = volume;
    }
}
