using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starttotular : MonoBehaviour
{
    public Animator animator;
    public GameObject book4;
    public GameObject book3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void isclick()
    {
      if(Globaldatas.num == 0)
        {
            
            animator.SetBool("IsEnd", true);
           
            Destroy(book3);
            Destroy(book4);
            Invoke("plusone", 1f);
    }

    }
    void plusone()
    {
        Globaldatas.num += 1;
        Destroy(gameObject);
    }
}
