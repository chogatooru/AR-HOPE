using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class TrackEventpage01 : DefaultTrackableEventHandler
{
    public GameObject pages;
    public int scencenum = 1;
    public float Timer = 4;
    bool Isfound = false;
    public int globalnum;
    public TypewriterEffect typewriterEffect;
    public GameObject qrcode;
    private AudioSource _audioSource;
    AudioClip audioClip;

    void Awake()
    {
        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("5383");
    }
    protected override void OnTrackingFound()
    {
        
        base.OnTrackingFound();
        if (Globaldatas.num == globalnum || globalnum == 8)
        {
            
            pages.SetActive(true);
            Isfound = true;

        }
    }
    void Update()
    {
        if (Isfound)
        {
            if (typewriterEffect.Isqr)
            {
                Timer -= Time.deltaTime;
                if (Timer <= 1)
                {
                    _audioSource.clip = audioClip;
                    _audioSource.Play();
                }
                if (Timer <= 0)
                {

                    SceneManager.LoadScene(scencenum);
                }
                qrcode.SetActive(true);
            }

        }

    }

    protected override void OnTrackingLost()
    {
        qrcode.SetActive(false);
        Isfound = false;
        Timer = 2;

        pages.SetActive(false);
        base.OnTrackingLost();
    }
}
