using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorialpress : MonoBehaviour
{
    public Animator animator;
    public bool Isclicked = false;
    public int scencenum = 0;
    float timer = 1;
   public GameObject endimage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Button()
    {
        animator.SetBool("isclicked", true);
        Isclicked = true;
    }

    public void EndButton()
    {
        Globaldatas.num += 1;
        animator.SetBool("isclicked", true);
        // Isclicked = false;
        timer -= Time.deltaTime;
        endimage.SetActive(true);
           // SceneManager.LoadScene(scencenum);
        
    }

    
    // Update is called once per frames
    void Update()
    {
       
    }
}
