using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishcheck : MonoBehaviour
{
    public GameObject pagetrack;
    public GameObject fish1;
    public GameObject fish2;
    public GameObject fish3;
    public GameObject fish4;
    public GameObject fish5;
    public Animator animator;
    public bool fish1onfire = false;
    public bool fish2onfire = false;
    public bool fish3onfire = false;
    public bool fish4onfire = false;
    public bool fish5onfire = false;

    public GameObject Imagear2;
    public GameObject Imagear3;

    public BrushIcon1 BrushIcon1;
    public GameObject bookhand;

    public GameObject buttn;
    public GameObject bookhand0;

    public GameObject trarget1;
    public GameObject trarget2;
    public GameObject trarget3;
    public bool isfinish = false;

    // Color acolor;
    public SpriteRenderer UIfire;
    public SpriteRenderer UIpop;
    //public Animator ami;
    // public bool isfinish = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (fish1.transform.parent == pagetrack.transform)
        {
            fish1onfire = true;
        }
        if (fish2.transform.parent == pagetrack.transform)
        {
            fish2onfire = true;
        }
        if (fish3.transform.parent == pagetrack.transform)
        {
            fish3onfire = true;
        }
        if (fish4.transform.parent == pagetrack.transform)
        {
            fish4onfire = true;
        }
        if (fish5.transform.parent == pagetrack.transform)
        {
            fish5onfire = true;
        }
        if(fish2onfire && fish3onfire && fish5onfire)
        {
            //trarget1.SetActive(false);
           // trarget2.SetActive(false);
          //  trarget3.SetActive(false);

            buttn.SetActive(false);
            UIfire.color = new Color32(255, 255, 225, 255);
            bookhand0.SetActive(true);
            Imagear2.SetActive(true);
            isfinish = true;
        }
        if(BrushIcon1.tuzi >=3)
        {
            // isfinish = true;
            if (animator.gameObject != null)
            {
                animator.SetBool("isfin", true);
            }

            UIpop.color = new Color32(255, 255, 225, 255);
            bookhand.SetActive(true);
            Imagear3.SetActive(true);
        }
    }
}
