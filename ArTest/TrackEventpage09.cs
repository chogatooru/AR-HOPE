using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class TrackEventpage09 : DefaultTrackableEventHandler
{
    public GameObject pages;
    public GameObject qr;
    public int scencenum = 1;
    public float Timer = 4;
    bool Isfound = false;
    public GameObject text;
    public TypewriterEffect typewriterEffect;
    private AudioSource _audioSource;
    AudioClip audioClip;
    public GameControl gameControl;
    public int globalnum;
    // Start is called before the first frame update
    protected override void OnTrackingFound()
    {

        base.OnTrackingFound();
        if (Globaldatas.num == globalnum)
        {
            Isfound = true;
            text.SetActive(true);
            pages.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Isfound&& gameControl.isonpage9&& typewriterEffect.Isqr)
        {
            qr.SetActive(true);
            Timer -= Time.deltaTime;

            if (Timer <= 0)
            {
                Globaldatas.num += 1;
                SceneManager.LoadScene(scencenum);
            }
        }

    }

    protected override void OnTrackingLost()
    {
        Isfound = false;
        Timer = 4;
        text.SetActive(false);
        qr.SetActive(false);
        pages.SetActive(false);
        base.OnTrackingLost();
    }
}
