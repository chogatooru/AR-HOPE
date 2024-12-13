using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragShadow : MonoBehaviour
{
    public bool IsWall = false;
    Vector3 screenSpace;
    Vector3 offset;
    public int damageNum = 20;

    public GameObject target;
    public GameObject gameUI;
    public GameObject HandIcon;

    SpriteRenderer spriteR;
    public Sprite[] ShadowSprites;

    SpriteRenderer HandIcon_spriteR;
    public Sprite[] HandIconSprites;

    Tutorialpress tutorialpress;

    private AudioSource _audioSource;
    AudioClip audioClip;

    void Start()
    {
        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("Player_hurt");

        tutorialpress = Camera.main.GetComponent<Tutorialpress>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        HandIcon_spriteR = HandIcon.GetComponent<SpriteRenderer>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            IsWall = true;
           // print("aaaaa");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            IsWall = false;
            // print("aaaaa");
        }
    }

    void OnMouseDown()
    {
        screenSpace = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
    }

    void OnMouseDrag()//拽上
    {
        if (tutorialpress.Isclicked)
        {
            spriteR.sprite = ShadowSprites[1];
            HandIcon_spriteR.sprite = HandIconSprites[1];
            Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
            transform.position = curPosition;
        }

    }


    void OnMouseUp()
    {
        HandIcon_spriteR.sprite = HandIconSprites[0];
        if (IsWall)
        {
            HopeSlider hopeslider = gameUI.GetComponent<HopeSlider>();

            _audioSource.clip = audioClip;
            _audioSource.Play();
            hopeslider.Hope-= 10;
            Destroy(this.gameObject,1f);

        }
        else
        {
            spriteR.sprite = ShadowSprites[0];
            transform.position = target.transform.position;
        }
    }
 } 

