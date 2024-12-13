using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndAnimate : MonoBehaviour
{
    public GameObject shadow1;
    public GameObject shadow2;
    public GameObject shadow3;
    public GameObject shadow4;
    public GameObject shadow5;

    public GameObject Dad;
    public GameObject nextpage;
    public GameObject light;
    float timer = 2;

    public GameObject endtu;
    Tutorialpress tutorialpress;

    private AudioSource _audioSource;
    AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("spotlight");
        tutorialpress = Camera.main.GetComponent<Tutorialpress>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shadow1 == null && shadow2 == null && shadow3 == null && shadow4 == null && shadow5 == null)
        {

            Dad.SetActive(true);

            timer -= Time.deltaTime;
            if (timer <= 1)
            {
                _audioSource.clip = audioClip;
             //   _audioSource.Play();
            }
                if (timer <= 0)
            {
                light.SetActive(true);
                //nextpage.SetActive(true);
         
                endtu.SetActive(true);
                tutorialpress.Isclicked = false;
                //  SceneManager.LoadScene(scencenum);
            }
        }
    }
}
