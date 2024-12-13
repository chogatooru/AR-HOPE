using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bajifly : MonoBehaviour
{
    public Transform targetfire;
    public GameObject pagetrack;
    public GameObject puzzle;
    public bool isReady = false;
    public bool isAni = false;
    public bajifly ba;
    public GameObject gruop;
    public float color_Tran_speed = 0.5f;
    public GameObject ui4;
    Color scolor;//

    public Animator anipuzzle;
    // Start is called before the first frame update
    void Start()
    {
        scolor = transform.GetComponent<SpriteRenderer>().color;
        scolor.a = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (pagetrack.activeSelf == true&& puzzle.transform.localScale.z>=0.8)
        {
            gruop.SetActive(true);
        }
        if (isReady && targetfire.gameObject.activeSelf)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetfire.position, 1);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetfire.rotation, 1);
            if(pagetrack.activeSelf == false)
            {
                gruop.SetActive(false);
            }

            if (gameObject.transform.position == targetfire.transform.position)
            {
                GetComponent<SpriteRenderer>().maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
                //sldie.SetActive(true);
                transform.parent = targetfire.parent;
                iTween.ScaleTo(gameObject, iTween.Hash("scale", targetfire.localScale, "time", 1));
                if (ba != null)
                {
                    ba.isReady=true;
                }
                if(ui4.transform.localScale== targetfire.localScale)
                {
                    //anipuzzle.SetBool("Isanim", true);
                    //Invoke("tran", 2f);
                    scolor.a -= Time.deltaTime * color_Tran_speed;
                    transform.GetComponent<SpriteRenderer>().color = scolor;

                    if (scolor.a <= 0)///////////////////////////////结束///////////////////////////////////
                    {
                        anipuzzle.SetBool("Isanim", true);
                        isAni = true;
                        //Invoke("di", 1);
                        //gameObject.SetActive(false);
                        gameObject.SetActive(false);
                    }
                }

            }
        }
    }

}
