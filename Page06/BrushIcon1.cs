using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrushIcon1 : MonoBehaviour
{
    public Slider slider;

    Vector3 pos;//物体的屏幕position
    Vector3 mousePos;//鼠标屏幕转世界的position
    SpriteRenderer spriteR;
    public GameObject mouse;
    // Start is called before the first frame update

    //public GameObject pop1;
   public GameObject handtu;

    public Vector3 delta = Vector3.zero;
    float timer = 0.1f;
    float brushproess = 0;
    private Vector3 lastMousePosition = Vector3.zero;
    public GameObject fire;
    public Transform targetfire;


    public int tuzi = 0;
    public float brushspeed;
    public int topvalue = 2000;



    void Start()
    {

        //tutorialpress = Camera.main.GetComponent<Tutorialpress>();
        spriteR = mouse.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
          //  delta = Input.mousePosition - lastMousePosition;
            // Debug.Log("delta distance : " + delta.magnitude);
           // brushspeed = delta.magnitude;
           // if (delta.magnitude >= 10)
           // {
            //    handtu.SetActive(false);
              //  iTween.ScaleTo(fire, iTween.Hash("scale", targetfire.localScale, "time", 220- brushspeed));
            // pop1.SetActive(true);
           // }
            
          //  if (delta.magnitude >= 200)
           // {

                brushspeed = 30;
          //  }
            brushproess += brushspeed;
            if (brushproess >= topvalue)
            {
                
                brushproess = topvalue;
                //stopvalue += 1000;
                tuzi++;
            }

            lastMousePosition = Input.mousePosition;

            spriteR.color = new Color(255, 255, 255, 255);
            pos = Camera.main.WorldToScreenPoint(transform.position);
            mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pos.z);
            //新的世界position
            Vector3 newPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = new Vector3(newPos.x, newPos.y, newPos.z);
        }

        else
        {
            spriteR.color = new Color(255, 255, 255, 0);
        }
       slider.value = brushproess / topvalue;
        if (slider.value >= 1)
        {
            slider.gameObject.SetActive(false);
            brushproess = 0;
        }
        //print(slider.value);

       /* if (brushproess > 0)
        {
            brushproess -= 100;
        }
        else
        {
            brushproess = 0;
        }*/
    }
}
