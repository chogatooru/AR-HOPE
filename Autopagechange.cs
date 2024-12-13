using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autopagechange : MonoBehaviour
{
    public Animator animator;
    //public bool Isclicked = false;
   // public int scencenum = 0;
    //float timer = 1;
    public GameObject endimage;
    // Start is called before the

    public float Timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            
            animator.SetBool("isclicked", true);
            // Isclicked = false;
           // timer -= Time.deltaTime;
            endimage.SetActive(true);
            // SceneManager.LoadScene(scencenum);

        }
    }
}
