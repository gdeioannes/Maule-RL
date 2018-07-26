using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;
    public List<AudioClip> audioClipsMusic;
    public List<AudioClip> audioClipsSfx;
    AudioSource sfx;
    AudioSource music;

	// Use this for initialization
	void Start () {
        if(instance==null){
            instance = this;
        }
        sfx = gameObject.GetComponents<AudioSource>()[1];
        music = gameObject.GetComponents<AudioSource>()[2];
        playClipMusic(1);
	}


    public void playClipMusic(int num){
        music.clip = audioClipsMusic[num];
        music.Play();
    }

    public void playClipSfx(int num)
    {
        sfx.clip = audioClipsSfx[num];
        sfx.Play();
    }



}
