using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class Buttontest : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject Player;  //角色
    private Rigidbody PlayerRigidbody;    //角色的刚体组件
    //public Button button;
    public float speed = 4;

    public static int movenum = 0;
   
    void Start()
    {
        PlayerRigidbody = Player.GetComponent<Rigidbody>();
    }
        public void OnPointerDown(PointerEventData eventData)
    {
        if (PlaneButton.IsStarting == false && PlayButton_plane.buttonisdown)
        {



            movenum = 1;

            //PlayerRigidbody.velocity = Vector3.forward * speed;
           
        }
        
        //print("按下！！！！");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (PlaneButton.IsStarting == false && PlayButton_plane.buttonisdown)
        {
            movenum = 2;
            
            //PlayerRigidbody.velocity = Vector3.forward * -speed;

        }
            
        //print("抬起！！！！");
    }

    void Update()
    {
        if (movenum == 1)
        {
            Player.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.Self);
        }
        else if(movenum == 2)
        {
            Player.transform.Translate(Vector3.up * Time.deltaTime * -speed, Space.Self);
        }
        else if (movenum == 0)
        {
            Player.transform.Translate(Vector3.up * Time.deltaTime * 0, Space.Self);
        }
    }

}
