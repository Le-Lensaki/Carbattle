using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static public AudioManager instance;
    public List<Sound> music, sfx;
    public AudioSource musicSource, sFXSource;

    private void Awake()
    {
        AudioManager.instance = this;
        this.musicSource = GameObject.Find("MusicSource").GetComponent<AudioSource>();
        this.sFXSource = GameObject.Find("SFXSource").GetComponent<AudioSource>();

       
    }

    private void Start()
    {
        PlayMusic("CarRun");
        musicSource.loop = true;
    }

    public virtual void StopMusic()
    {
        musicSource.Stop();
    }

    public virtual void PlayMusic(string name)
    {
        foreach (Sound sound in this.music)
        {
            if (sound.name == name)
            {
                musicSource.clip = sound.clip;
                musicSource.Play();
            }
        }
    }

    public virtual void PlaySFX(string name)
    {
        foreach (Sound sound in this.sfx)
        {
            if (sound.name == name)
            {
                
                sFXSource.PlayOneShot(sound.clip);
            }
        }
    }
}
