using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class PlayButton_plane : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject button;
    public GameObject button1;

    public static bool buttonisdown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {


    }

    public void OnPointerUp(PointerEventData eventData)
    {
        button.SetActive(false);
        button1.SetActive(true);
        buttonisdown = true;
        Buttontest.movenum = 2;
        
        //print("抬起！！！！");
    }
}
