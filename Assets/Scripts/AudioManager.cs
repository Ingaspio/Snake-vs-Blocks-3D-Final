using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sound;
    
    void Awake()
    {
        

        foreach (Sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sounds s = Array.Find(sound, sounds => sounds.name == name);
        if (s == null) 
        {
            Debug.LogWarning("Sound: " + name + "is missing!");
            return;
        }
        s.source.Play();
    }
}

