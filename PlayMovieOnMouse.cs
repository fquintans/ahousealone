using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayMovieOnMouse : MonoBehaviour
{
    public VideoPlayer vp;


    void Start()
    {
        vp.playOnAwake = false;
        vp.isLooping = true;
    }

    void OnMouseDown()
    {
        if (vp.isPlaying)
        {
            vp.Pause();
        }
        else
        {
            vp.Play();
        }
    }
}
