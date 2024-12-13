using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brushingtuzi : MonoBehaviour
{
    private SpriteRenderer spriteR;
    public Sprite[] sprites;
    public BrushIcon brushIcon;

    // public GameObject slider;
    public Animator animator;
    public GameObject texiao;
    public GameObject trunpage;
    public GameObject imagear1;
    public GameObject brusch;
    public GameObject pop2;
    public GameObject pop3;
    public GameObject pop4;
    public GameObject pop5;
    public Transform target;


    public SpriteRenderer UIpop;

    private AudioSource _audioSource;
    AudioClip audioClip;
    public bool mhasPlayedGameOverMusic0 = false;
    public bool mhasPlayedGameOverMusic = false;
    public bool mhasPlayedGameOverMusic1 = false;
    public bool mhasPlayedGameOverMusic2 = false;
    public bool mhasPlayedGameOverMusic3 = false;
    // Start is called before the first frame update
    void Start()
    {
        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("pops");
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (brushIcon.tuzi == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];


        }
        if (brushIcon.tuzi == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
            pop3.SetActive(true);
            if (mhasPlayedGameOverMusic == false)
            {
                playpopse();
            }
            
        }
        if (brushIcon.tuzi == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
            pop4.SetActive(true);
            if (mhasPlayedGameOverMusic1 == false)
            {
                playpopse1();
            }
        }
        if (brushIcon.tuzi == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];
            pop5.SetActive(true);
            pop2.SetActive(true);
            if (mhasPlayedGameOverMusic2 == false)
            {
                playpopse2();
            }
        }
        if (brushIcon.tuzi == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[4];

            //brushIcon.enabled = false;
            if (mhasPlayedGameOverMusic3 == false)
            {
                Invoke("playpopse3", 1f);
               
            }

            animator.SetBool("IsEnd", true);
            // Destroy(animator.gameObject, 2f);
            Destroy(brusch);
            Invoke("Next0", 1f);
           
        }
        if (Input.GetMouseButton(0))
        {

          //  print("fdsfdsafdsa");

        }
        }
    void Next0()
    {
        iTween.ScaleTo(gameObject, iTween.Hash("scale", target.localScale, "time", 1));
        Invoke("Next", 1f);

    }
    void Next()
    {
      //  iTween.ScaleTo(gameObject, iTween.Hash("scale", target.localScale, "time", 1));
        animator.gameObject.SetActive(false);
        UIpop.color = new Color32(255, 255, 225, 255);
        imagear1.SetActive(true);
        trunpage.SetActive(true);

    }

    void playpopse0()
    {
        if (!_audioSource.isPlaying)
        {
            audioClip = Resources.Load<AudioClip>("pops");
            mhasPlayedGameOverMusic0 = true;
            _audioSource.clip = audioClip;
            _audioSource.PlayOneShot(audioClip, 0.7F);

        }
    }

    void playpopse()
    {
        if (!_audioSource.isPlaying)
        {
            audioClip = Resources.Load<AudioClip>("pops");
            mhasPlayedGameOverMusic = true;
            _audioSource.clip = audioClip;
            _audioSource.PlayOneShot(audioClip, 0.7F);

        }
    }
    void playpopse1()
    {
        if (!_audioSource.isPlaying)
        {
            audioClip = Resources.Load<AudioClip>("pops");
            mhasPlayedGameOverMusic1 = true;
            _audioSource.clip = audioClip;
            _audioSource.PlayOneShot(audioClip, 0.7F);

        }
    }
    void playpopse2()
    {
        if (!_audioSource.isPlaying)
        {
            audioClip = Resources.Load<AudioClip>("pops");
            mhasPlayedGameOverMusic2 = true;
            _audioSource.clip = audioClip;
            _audioSource.PlayOneShot(audioClip, 0.7F);

        }
    }
    void playpopse3()
    {
        if (!_audioSource.isPlaying)
        {
            audioClip = Resources.Load<AudioClip>("gaind");
            mhasPlayedGameOverMusic3 = true;
            _audioSource.clip = audioClip;
            _audioSource.PlayOneShot(audioClip);

        }
    }
}
