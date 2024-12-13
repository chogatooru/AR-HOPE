using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAndGo : MonoBehaviour
{

    public Vector3 fristPos; 
    public Vector3 twoPos;
    public float speed = 3.0f;        
    void Update()
    {
        float moveY = 0;      
        float moveX = 0;
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            
            fristPos = Input.GetTouch(0).position;
        }
        //判断移动                 
        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
           
            twoPos = Input.GetTouch(0).position;
        
            if (fristPos.y < twoPos.y && Camera.main.WorldToScreenPoint(transform.localPosition).y < Screen.height)
            {
                moveY += speed * Time.deltaTime;
            }            
            if (fristPos.y > twoPos.y && Camera.main.WorldToScreenPoint(transform.localPosition).y > 0)
            {
                moveY -= speed * Time.deltaTime;
            }            
            if (fristPos.x > twoPos.x && Camera.main.WorldToScreenPoint(transform.localPosition).x > 0)
            {
                moveX -= speed * Time.deltaTime;
            }            
            if (fristPos.x < twoPos.x && Camera.main.WorldToScreenPoint(transform.localPosition).x < Screen.width)
            {
                moveX += speed * 2.0f * Time.deltaTime;
            }          
            transform.Translate(moveX, moveY, 0);
        }
    }
}