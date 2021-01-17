using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    public sound[] sound;

    public static audiomanager instance;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        foreach(sound s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
   public void play(string name)
    {
       sound s= Array.Find(sound, sound => sound.name == name);
        s.source.Play();
    }
}
