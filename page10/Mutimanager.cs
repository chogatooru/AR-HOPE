using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Mutimanager : MonoBehaviour
{
    public DrawMask drawMask1;
    public DrawMask drawMask2;
    public DrawMask drawMask3;

    public TrackEvent0 event0;
    public GameObject typeww;
    public GameObject rain;
    public GameObject bookhand;
    public GameObject nextpage;
    public int scencenum = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (event0.isccc)
        {
            typeww.SetActive(true);
        }
        if (event0.isccc==false)
        {
            typeww.SetActive(false);
        }

        if (drawMask1.isPressed&& drawMask2.isPressed && drawMask3.isPressed)
        {
            drawMask1.gameObject.GetComponent<Animator>().SetBool("Isend", true);
            drawMask2.gameObject.GetComponent<Animator>().SetBool("Isend", true);
            drawMask3.gameObject.GetComponent<Animator>().SetBool("Isend", true);
            bookhand.SetActive(true);
            Invoke("qend", 3f);
        }
        if (nextpage.activeSelf)
        {
            bookhand.SetActive(false);
        }
    }
    void qend()
    {
        SceneManager.LoadScene(scencenum);

        // SceneManager.LoadScene(scencenum);
    }
}
