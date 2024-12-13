using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handtu : MonoBehaviour
{
    public Animator animator;
    public GameObject line1;
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (line1.active)
        {
            Destroy(hand);
            Destroy(this);
        }
            if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool("Isclicked", true);

        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            animator.SetBool("Isclicked", false);

        }
    }
}
