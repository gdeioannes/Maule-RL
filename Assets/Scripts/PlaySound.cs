using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public int music;

    private void Start()
    {
        playMusic(music);
    }



    public void playMusic(int snd)
    {
        SoundManager.instance.playClipMusic(snd);
    }
}
