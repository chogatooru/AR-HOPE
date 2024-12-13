using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bajic : MonoBehaviour
{
    Animator animator;
    public GameObject pagepuzzle;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pagepuzzle.activeSelf)
        {
            animator.SetBool("Isflying", true);

            Invoke("ddd", 2.5f);
        }
        
    }
    void ddd()
    {
        Destroy(gameObject);
    }
}
