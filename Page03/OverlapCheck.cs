using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapCheck : MonoBehaviour
{
    //判定覆盖范围
    Collider2D col2D;
    Collider2D[] result;

    //游戏后期
    public float timer = 2;
    public GameObject theend;

    public Animator m_Animator;

    public bool IsClickable = false;

    //游戏灰度变量
    public float count;
    public float awakecount;

    public float graynum;
    public CameraEffect cameraEffect;

    //图标
    public DamegeImage damegeImage;
    public GameObject HandIcon;
    SpriteRenderer HandIcon_spriteR;
    public Sprite[] HandIconSprites;

    private AudioSource _audioSource;
    AudioClip audioClip;

    void Awake()
    {
        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("Positive_response");

        col2D = GetComponent<Collider2D>();
        result = new Collider2D[10];
        awakecount = col2D.OverlapCollider(new ContactFilter2D(), result);

    }


    void Start()
    {
        //  spriteR = gameObject.GetComponent<SpriteRenderer>();
        HandIcon_spriteR = HandIcon.GetComponent<SpriteRenderer>();
    }





    void Update()
    {
        graynum = count / awakecount;
        count = col2D.OverlapCollider(new ContactFilter2D(), result);
        if (count == 0)
        {
            //print("sdfds");
            m_Animator.SetBool("Iszero", false);
        }

        if (graynum > 1)
        {
            graynum = 1;
        }
        if (graynum == 0)///////进入可以点击的状态///////////
        {
            Theend();
        }
        else
        {
            m_Animator.SetBool("Iszero", false); 

            cameraEffect.grayScaleAmount = graynum;
        }

    }

    /// <summary>
    /// 判定垃圾清除范围内执行
    /// </summary>
    void Theend()
    {
        
        

        timer -= Time.deltaTime;
        if (timer <= 3)
        {
            m_Animator.SetBool("Iszero", true);///////////闪耀点击//////////////
            IsClickable = true;
        }
            if (timer <= 0)
        {
            
          //  theend.SetActive(true);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // print("fdssssssssssssssssssssssf");
        }
    }

    /// <summary>
    /// 图标变化，判定执行
    /// </summary>

    void OnMouseDrag()//拽上
    {
        if (IsClickable)
        {
            if (damegeImage.damagebiggerthan3)
            {
                HandIcon_spriteR.sprite = HandIconSprites[3];
            }
            else
            {
                HandIcon_spriteR.sprite = HandIconSprites[1];
            }
        }

    }


    void OnMouseUp()
    {
        if (IsClickable)
        {
            if (damegeImage.damagebiggerthan3)
            {
                HandIcon_spriteR.sprite = HandIconSprites[2];
            }
            else
            {
                HandIcon_spriteR.sprite = HandIconSprites[0];
            }
            _audioSource.clip = audioClip;
            _audioSource.Play();
            theend.SetActive(true);
            Destroy(gameObject,1f);
        }
    }
    
}