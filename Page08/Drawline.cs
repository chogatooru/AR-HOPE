using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drawline : MonoBehaviour
{
    public LineRenderer line;
    public Vector3 MouseDown;
    public Vector3 MouseUp;

    public GameObject[] stars;
    public GameObject[] bridges;
    // public GameObject star2;
    public int i = 0;

    public GameObject cam;

    public bool mousedowni = false;

    float direct;
    public GameObject UIstart;
    public GameObject UIbook;
    public GameObject imagear4;
    public SpriteRenderer UIpop;


    private AudioSource _audioSource;
    AudioClip audioClip;

    private void Start()
    {
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        audioClip = Resources.Load<AudioClip>("star");
        // line.material.color = Color.white;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            //鼠标点击的位置
            MouseDown = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            

            if (Physics.Raycast(ray, out hitInfo) )
            {
                GameObject gameObj = hitInfo.collider.gameObject;

                if(gameObj == stars[i])
                {
                    _audioSource.clip = audioClip;
                    _audioSource.Play();
                    mousedowni = true;
                }

            }

        }
        if (Input.GetKey(KeyCode.Mouse0))
        {

            //鼠标松开时的位置
            MouseUp = Input.mousePosition;

            if (i <= 5) //中了
            {
                direct = stars[i + 1].transform.position.z - cam.transform.position.z;
            }

            if (mousedowni )
            {
                if(i <= 6) { stars[i + 1].SetActive(true); }

                if (i <= 5)
                {
                    line.positionCount = 2;//设置LineRenderer顶点数

                    line.SetPosition(0, stars[i].transform.position);//出发点，世界坐标转换成屏幕坐标，为了能看到z设为15

                    line.SetPosition(1, Camera.main.ScreenToWorldPoint(new Vector3(MouseUp.x, MouseUp.y, direct)));//结束点
                }

                                                                                                               //  }
            }
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;


            if (Physics.Raycast(ray, out hitInfo))
            {
                GameObject gameObj = hitInfo.collider.gameObject;

                if (gameObj == stars[i + 1] && mousedowni)
                {
                    

                    if (i <= 5) //中了
                    {
                        i++;
                        stars[i + 1].SetActive(true);
                        _audioSource.clip = audioClip;
                        _audioSource.Play();
                    }
                    bridges[i - 1].SetActive(true);
                }
            }

            if (i >= 6)
            {
                this.GetComponent<LineRenderer>().enabled = false;

            }

        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if(i <= 5)
            {
                stars[i + 1].SetActive(false);
            }
            if (i > 5)
            {
                UIstart.SetActive(true);
                imagear4.SetActive(true);
                UIbook.SetActive(true);
                UIpop.color = new Color32(255, 255, 225, 255);
            }

            line.positionCount = 0;
            mousedowni = false;
        }
    }
    
}
