using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backMusic;

    private void Awake()
    {
        BackgroundMusic = GameObject.Find("BackgroundMusic");
        backMusic = BackgroundMusic.GetComponent<AudioSource>();
        if (backMusic.isPlaying) return;
        else
        {
            backMusic.Play();
            DontDestroyOnLoad(BackgroundMusic);
        }
    }

    public void BackGroundMusicOffButton()
    {
        BackgroundMusic = GameObject.Find("BackgroundMusic");
        backMusic = BackgroundMusic.GetComponent<AudioSource>();
        if (backMusic.isPlaying) backMusic.Pause();
        else backMusic.Play();
    }
}
