using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishMovment : MonoBehaviour
{
    public int MoveSpeed = 1;
    public FishingButton fishingButton;
    public GameObject buttn;
    public GameObject sldie;
    public GameObject bookhand;
    public GameObject nextpage;
    public bool isMoving = true;
    public bool isFlying = false;
    public bool isfireing = false;
    public bool iscooked = false;

    public Transform target;
    public Transform targetfire;
    Color tcolor;

    public fishcheck sfishcheck;
  //  public int times = 0;

    private SpriteRenderer spriteRenderer;
    Color scolor;
    public float color_Tran_speed = 0.5f;
    Animator animator;

    public BrushIcon1 BrushIcon1;
    public Sprite image00;
    public Sprite image0;
    public Sprite image1;
    public GameObject bookhandback;

    public int chadao = 0;
    public fishcheck fishcheck;

    private AudioSource _audioSource;
    AudioClip audioClip;
    //public Image UIpop;
    // Use this for initialization
    void Start()
    {

        scolor = transform.GetComponent<SpriteRenderer>().color;
        scolor.a = 1f;
        animator = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("gaind");
        // offset = target.position - this.transform.position;
    }

    void Update()
    {

        if (isFlying)
        {
            // buttn.SetActive(false);
            //  bookhand.SetActive(true);
            spriteRenderer.sprite = image00;
            spriteRenderer.maskInteraction = SpriteMaskInteraction.None;
            spriteRenderer.sortingOrder = 10;


            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.position, 1);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, 1);
            transform.parent = target.parent;
            if (gameObject.transform.position == target.transform.position)
            {
                
                iTween.ScaleTo(gameObject, iTween.Hash("scale", target.localScale, "time", 1));
                animator.enabled = false;
            }

        }
    }
        

    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime, Space.Self);
            if (transform.localPosition.x <= -0.6)
            {
                transform.localPosition += new Vector3(1.2f, 0, 0);
                MoveSpeed = Random.Range(3, 6);
                // transform.Translate(0.6f, transsform.position.y, transform.position.z, Space.Self);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cha")
        {
            _audioSource.clip = audioClip;
            _audioSource.Play();
            fishingButton.Isshooting = false;
            isMoving = false;
            isFlying = true;

            chadao++;
            if (chadao >= 3)
            {
               // UIpop.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
                buttn.SetActive(false);
                bookhand.SetActive(true);
            }
          ///  
         ///   buttn.SetActive(false);
        ///    bookhandback.SetActive(false);
         ///   bookhand.SetActive(true);
        }
    }
}
