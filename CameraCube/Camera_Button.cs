using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Camera_Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool Isbuttondown = false;
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
        Isbuttondown = true;

        //print("抬起！！！！");
    }
}
