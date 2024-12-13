using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseIcon : MonoBehaviour
{

    Vector3 pos;//物体的屏幕position
    Vector3 mousePos;//鼠标屏幕转世界的position
    SpriteRenderer spriteR;
    public GameObject mouse;

    Tutorialpress tutorialpress;

    void Start()
    {
        tutorialpress = Camera.main.GetComponent<Tutorialpress>();
        spriteR = mouse.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0)&& tutorialpress.Isclicked)
        {
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

    }
}
