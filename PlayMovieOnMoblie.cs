using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayMovieOnMoblie : MonoBehaviour
    {
    public int scencenum = 2;
    public float Timer = 10;
    public string mp4name;
    void Start()
        {
            Handheld.PlayFullScreenMovie(mp4name, Color.black, FullScreenMovieControlMode.Hidden, FullScreenMovieScalingMode.AspectFit);
    }
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            SceneManager.LoadScene(scencenum);
        }

    }
}


