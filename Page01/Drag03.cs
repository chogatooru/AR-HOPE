using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag03 : MonoBehaviour
{
    public bool IsWall = false;
    Vector3 screenSpace;
    Vector3 offset;

    public OverlapCheck overlapCheck;
   // public int damageNum = 20;

   // public GameObject target;
   //  public GameObject gameUI;
   public GameObject HandIcon;

    public DamegeImage damegeImage;

    SpriteRenderer spriteR;

    Tutorialpress tutorialpress;
    //   public Sprite[] ShadowSprites;

    SpriteRenderer HandIcon_spriteR;
   public Sprite[] HandIconSprites;

    private AudioSource _audioSource;
    AudioClip audioClip;

    void Start()
    {

        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("suliao");

        tutorialpress = Camera.main.GetComponent<Tutorialpress>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
     HandIcon_spriteR = HandIcon.GetComponent<SpriteRenderer>();
        overlapCheck = GameObject.FindGameObjectWithTag("tuzi").GetComponent<OverlapCheck>();
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
        //HandIcon_spriteR.sprite = HandIconSprites[1];
        screenSpace = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
    }

    void OnMouseDrag()//拽上
    {
        if (tutorialpress.Isclicked)
        {
            if (damegeImage.damagebiggerthan3)
            {
                HandIcon_spriteR.sprite = HandIconSprites[3];
            }
            else
            {
                HandIcon_spriteR.sprite = HandIconSprites[1];
            }
            _audioSource.clip = audioClip;
            _audioSource.Play();
            //spriteR.sprite = ShadowSprites[1];

            Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
            transform.position = curPosition;
        }

    }


    void OnMouseUp()
    {
        if (damegeImage.damagebiggerthan3)
        {
            HandIcon_spriteR.sprite = HandIconSprites[2];
        }
        else
        {
            HandIcon_spriteR.sprite = HandIconSprites[0];
        }
            if (IsWall)
        {
         //   HopeSlider hopeslider = gameUI.GetComponent<HopeSlider>();


           // hopeslider.Hope -= 10;
           // Destroy(this.gameObject);

        }
        else
        {
         //   spriteR.sprite = ShadowSprites[0];
       //     transform.position = target.transform.position;
        }
    }

     void Update()
    {
        if (IsWall)
        {
            if (damegeImage.damagebiggerthan3)
            {
                HandIcon_spriteR.sprite = HandIconSprites[2];
            }
            else
            {
                HandIcon_spriteR.sprite = HandIconSprites[0];
            }
            //   HopeSlider hopeslider = gameUI.GetComponent<HopeSlider>();


            // hopeslider.Hope -= 10;
            Destroy(this.gameObject);

        }

        if (overlapCheck.IsClickable)
        {
            spriteR.color = Color.Lerp(spriteR.color, Color.clear, 3 * Time.deltaTime);
            Destroy(gameObject,3f);
        }
    }
}
