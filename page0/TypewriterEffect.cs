using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{
    public float charsPerSecond = 0.2f;
    private string words;

    private bool isActive = false;
    private float timer;
    private Text myText;
    private int currentPos = 0;//当前打字位置

   // public GameObject QR;
    private AudioSource _audioSource;
    AudioClip audioClip;

    public bool Isqr = false;
    // Use this for initialization
    public Image image;
    public Color icolor;
    public Color tcolor;

    public bool Isend = false;
    float timerr = 1f;


    void Awake()
    {
        tcolor = GetComponent<Text>().color;
        //tcolor.a = 1f;
        icolor = image.GetComponent<Image>().color;
       // icolor.a = 0.5f;


        timer = 0;
  
        
        charsPerSecond = Mathf.Max(0.2f, charsPerSecond);
        myText = GetComponent<Text>();
        words = myText.text;
        myText.text = "";
    }
    void Start()
    {
        if (Isend == false)
        {
            //添加 Audio Source 组件
            _audioSource = this.gameObject.AddComponent<AudioSource>();

            //加载 Audio Clip 对象
            audioClip = Resources.Load<AudioClip>("keyboard_typing");
            _audioSource.Stop();
            isActive = true;
        }

    }
    // Update is called once per frame
    void Update()
    {

        OnStartWriter();

        if (Isend)
        {
            _audioSource.Stop();
             timerr -= Time.deltaTime;
            if (timerr <= 0)
            {

                tcolor.a -= Time.deltaTime * 0.5f;
                icolor.a -= Time.deltaTime * 0.25f;

                GetComponent<Text>().color = tcolor;
                image.GetComponent<Image>().color = icolor;
            }
        }
        //Debug.Log (isActive);
    }

   // public void StartEffect()
   // {
   //     isActive = true;
   // }

    // 执行打字任务
    void OnStartWriter()
    {

        if (isActive)
        {
            timer += Time.deltaTime;
            if (timer >= charsPerSecond)
            {
                _audioSource.loop = true;
                _audioSource.clip = audioClip;
                _audioSource.Play();
                
                timer = 0;
                currentPos++;
                myText.text = words.Substring(0, currentPos);//刷新文本显示内容

                if (currentPos >= words.Length)
                {
                    Isend = true;
                    OnFinish();
                }
            }

        }
    }
    // 结束打字，初始化数据
    void OnFinish()
    {
        
      //  Invoke("tran", 1f);
        _audioSource.Stop();
        isActive = false;
        Isqr = true;
        timer = 0;
        currentPos = 0;
        myText.text = words;
       
    }

    void tran()
    {

    }


}

