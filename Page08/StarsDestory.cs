using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsDestory : MonoBehaviour
{
    public GameObject UIstart;
    public GameObject NextGroup;
    public GameObject NextLine;
    public Drawline1 drawline1;
    public GameObject thisgroup;
    public Animator animator;
    public float timer = 1;

    public Drawline2 drawline2;
    public GameObject UIstart2;
    public GameObject NextGroup2;
    public GameObject NextLine2;
    public GameObject thisgroup2;
    public Animator animator2;
    public float timer2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (drawline1.IsEnd && drawline2.IsEnd==false)
        {

            timer -= Time.deltaTime;
            if (timer > 0)
            {
                UIstart.SetActive(true);
                animator.SetBool("IsQuit", true);
            }
            if (timer <= 0)
            {
                Destroy(thisgroup);
                NextGroup.SetActive(true);
                NextLine.SetActive(true);
            }


            
            
            //Destroy(this);
        }
        if (drawline2.IsEnd)
        {

            timer2 -= Time.deltaTime;
            if (timer2 > 0)
            {
                UIstart2.SetActive(true);
                animator2.SetBool("IsQuit", true);
            }
                if (timer2 <= 0)
            {
                Destroy(thisgroup2);
                NextGroup2.SetActive(true);
                NextLine2.SetActive(true);
            }




            //Destroy(this);
        }
    }
}
