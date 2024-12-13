using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawline1 : MonoBehaviour
{
    public LineRenderer line;
    public Vector3 MouseDown;
    public Vector3 MouseUp;

    public GameObject[] stars;
    public GameObject[] bridges;
    public Animator animator;
    // public GameObject star2;
    public int i = 0;

    public GameObject cam;

    public bool mousedowni = false;

    float direct;

    public bool IsEnd = false;

    private AudioSource _audioSource;
    AudioClip audioClip;

    private void Start()
    {
        animator.SetBool("IsQuit", false);
        // line.material.color = Color.white;

        _audioSource = this.gameObject.AddComponent<AudioSource>();

        audioClip = Resources.Load<AudioClip>("star");
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

            if (i <= 2) //中了
            {
                direct = stars[i + 1].transform.position.z - cam.transform.position.z;


            }

            if (mousedowni )
            {
                if(i <= 3) { stars[i + 1].SetActive(true); }

                if (i <= 2)
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
                    

                    if (i <= 2) //中了
                    {
                        i++;
                        stars[i + 1].SetActive(true);

                        _audioSource.clip = audioClip;
                        _audioSource.Play();
                        // print("ddddddddd");

                    }
                    bridges[i - 1].SetActive(true);
                }
            }

            if (i >= 3)
            {
                this.GetComponent<LineRenderer>().enabled = false;

            }


        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if(i <= 1)
            {
                stars[i + 1].SetActive(false);
                
            }

            if (i >= 3)
            {
                IsEnd = true;
               // Destroy(this);
            }

            line.positionCount = 0;
            mousedowni = false;
        }
    }
    
}
