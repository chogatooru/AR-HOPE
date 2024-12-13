using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlaneButton : MonoBehaviour
{
    public float Flyin_speed = 0.2f;

    public GameObject Startpoint;
    public GameObject Playpoint;
    public GameObject Endpoint;

    public static bool Isdie = false;
    public static bool IsStarting = false;

    public GameObject button;
    public GameObject button1;
    public GameObject button2;
    // Start is called before the first frame update

    void Start()
    {


    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            Buttontest.movenum = 0;
            TimeBar_plane.timer = 0;
            Isdie = true;
           // print("555555");
        }
    }

    void Update()
    {
        if (Isdie)
        {
            transform.position = Vector3.MoveTowards(transform.position, Startpoint.transform.position, 100);
            PlayButton_plane.buttonisdown = false;
        }

        if(transform.position== Startpoint.transform.position)
        {
            Isdie = false;
            IsStarting = true;
            
           // print("55555");
        }
        if (IsStarting)
        {

            transform.position = Vector3.MoveTowards(transform.position, Playpoint.transform.position, Flyin_speed);
            if (transform.position == Playpoint.transform.position)
            {
                button.SetActive(true);
                button1.SetActive(false);
                

                
                IsStarting = false;
            }
            }
        if (TimeBar_plane.timer >= 10)
        {
            transform.position = Vector3.MoveTowards(transform.position, Endpoint.transform.position, Flyin_speed);
            Destroy(gameObject, 1f);
            button2.SetActive(true);
            button1.SetActive(false);
            button.SetActive(false);

        }
    }
}
