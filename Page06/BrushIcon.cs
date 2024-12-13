using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrushIcon : MonoBehaviour
{
    public Slider slider;

    Vector3 pos;//物体的屏幕position
    Vector3 mousePos;//鼠标屏幕转世界的position
    SpriteRenderer spriteR;
    public GameObject mouse;
    // Start is called before the first frame update

    public GameObject pop1;
    public GameObject handtu;

    public Vector3 delta = Vector3.zero;
    float timer = 0.1f;
    float brushproess = 0;
    float brushvalue = 0;
    private Vector3 lastMousePosition = Vector3.zero;

    public int tuzi = 0;

    public float brushspeed;

    public int topvalue = 2000;

    private AudioSource _audioSource;
    AudioClip audioClip;
    void Start()
    {
        //tutorialpress = Camera.main.GetComponent<Tutorialpress>();
        spriteR = mouse.GetComponent<SpriteRenderer>();
        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("brushing");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            delta = Input.mousePosition - lastMousePosition;
            // Debug.Log("delta distance : " + delta.magnitude);
            brushspeed = delta.magnitude;
            if(delta.magnitude < 10)
            {
                _audioSource.Stop();
            }
            if (delta.magnitude >= 10)
            {
                _audioSource.loop = true;
                _audioSource.clip = audioClip;
                _audioSource.Play();

                handtu.SetActive(false);
                pop1.SetActive(true);
            }
                if (delta.magnitude >= 200)
            {
               
                brushspeed = 200;
            }
            brushproess += brushspeed;
            brushvalue += brushspeed;
            if (brushproess >= topvalue)
            {
                _audioSource.Stop();
                brushproess = 0;
                //topvalue += 1000;
                tuzi++;
            }
            
            lastMousePosition = Input.mousePosition;

            spriteR.color = new Color(255, 255, 255, 255);
            pos = Camera.main.WorldToScreenPoint(transform.position);
            mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pos.z);
            //新的世界position
            Vector3 newPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = new Vector3(newPos.x, newPos.y, newPos.z);
        }
        else
        {
            spriteR.color = new Color(255, 255, 255, 0);
        }
        slider.value = brushvalue / 8000;
        if (slider.value >= 1)
        {
            slider.gameObject.SetActive(false);
        }
    }

}
