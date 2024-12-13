using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanzhetu : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void isclick()
    {


            animator.SetBool("IsEnd", true);
            Invoke("plusone", 1f);
        
    }


void plusone()
{
    Globaldatas.num += 1;
    Destroy(gameObject);
}
    }
