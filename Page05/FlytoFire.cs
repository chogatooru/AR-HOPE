using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlytoFire : MonoBehaviour
{

    public GameObject nextpage;///

    public bool isfireing = false;//
    public bool iscooked = false;//

    public Transform targetfire;//

    Color scolor;//
    public float color_Tran_speed = 0.5f;//


    public BrushIcon1 BrushIcon1;///
    public GameObject sldie;
    public fishcheck fishcheck;
    public Sprite image00;
    public Sprite image0;
    public Sprite image1;
    private SpriteRenderer spriteRenderer;

    private AudioSource _audioSource;
    AudioClip audioClip;

    public bool mhasPlayedGameOverMusic = false;
    // public Sprite image00;
    // Start is called before the first frame update
    void Start()
    {
        scolor = transform.GetComponent<SpriteRenderer>().color;
        scolor.a = 1f;

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        
    }

    // Update is called once per frame
    void Update()
    {

        if (nextpage.activeSelf)
        {
            if (gameObject.name == "yellow" && BrushIcon1.tuzi == 0 && fishcheck.isfinish)
            {

                isfireing = true;
                //isFlying = false;
            }
            if (BrushIcon1.tuzi == 1 && gameObject.name == "red")
            {

                isfireing = true;
               // isFlying = false;
                //bookhandback.SetActive(true);
            }
            if (BrushIcon1.tuzi == 2 && gameObject.name == "blue")
            {

                isfireing = true;
              //  isFlying = false;
                //bookhandback.SetActive(true);
            }

            ///   isfireing = true;
        }
        if (isfireing)
        {

            ///  buttn.SetActive(false);
            ///   bookhand.SetActive(true);


            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetfire.position, 1);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetfire.rotation, 1);


            if (gameObject.transform.position == targetfire.transform.position)
            {
                sldie.SetActive(true);
                transform.parent = targetfire.parent;
                iTween.ScaleTo(gameObject, iTween.Hash("scale", targetfire.localScale, "time", 1));

            }
            if (BrushIcon1.slider.value < 0.2)
            {
                spriteRenderer.sprite = image00;
            }

            if (BrushIcon1.slider.value >= 0.2)
            {
                spriteRenderer.sprite = image0;
            }

            if (BrushIcon1.slider.value >= 0.6)
            {
                spriteRenderer.sprite = image1;

            }
            if (BrushIcon1.slider.value >= 1)

                if (BrushIcon1.tuzi == 1 && gameObject.name == "yellow")
                {
                    BrushIcon1.slider.value = 0;
                    sldie.SetActive(false);
                    iscooked = true;
                    
                    isfireing = false;
                }
            if (BrushIcon1.tuzi == 2 && gameObject.name == "red")
            {
                BrushIcon1.slider.value = 0;
                sldie.SetActive(false);
                iscooked = true;


                isfireing = false;
            }

            if (BrushIcon1.tuzi == 3 && gameObject.name == "blue")
            {
                sldie.SetActive(false);
                iscooked = true;
                isfireing = false;
                gameObject.SetActive(false);
                //bookhandback.SetActive(true);
            }

        
            
        }
        if (iscooked)
        {

           // gameObject.SetActive(false);
            scolor.a -= Time.deltaTime * color_Tran_speed;
            transform.GetComponent<SpriteRenderer>().color = scolor;
            // bookhand.SetActive(false);
            // buttn.SetActive(true);

            if (mhasPlayedGameOverMusic == false)
            {
                playpopse();
            }

            if (scolor.a <= 0)///////////////////////////////结束///////////////////////////////////
            {
                gameObject.SetActive(false);
            }
        }
    }
    void playpopse()
    {
        if (!_audioSource.isPlaying)
        {
            audioClip = Resources.Load<AudioClip>("eat");
            mhasPlayedGameOverMusic = true;
            _audioSource.clip = audioClip;
            _audioSource.PlayOneShot(audioClip, 1.5F);

        }
    }
}
