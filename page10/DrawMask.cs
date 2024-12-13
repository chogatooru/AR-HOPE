using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawMask : MonoBehaviour
{
    public GameObject maskPrefab;
    public GameObject hand;
    public bool isPressed = false;

    public Vector3 MouseDown;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MouseDown = Input.mousePosition;
        // mousePos.z = 100;

      //  mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (Input.GetMouseButton(0))
        {
            if (hand != null) { Destroy(hand); }
            
            MouseDown = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;


            if (Physics.Raycast(ray, out hitInfo))
            {
                GameObject gameObj = hitInfo.collider.gameObject;

                if (gameObj == gameObject)
                {
                    //print("aaaaaaaa");
                   // GameObject maskSprite = Instantiate(maskPrefab, MouseDown, Quaternion.identity);
                    GameObject maskSprite = GameObject.Instantiate(maskPrefab, hitInfo.point, transform.rotation) as GameObject;
                    maskSprite.transform.parent = gameObject.transform;
                }

            }
            
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;


            if (Physics.Raycast(ray, out hitInfo))
            {
                GameObject gameObj = hitInfo.collider.gameObject;

                if (gameObj == gameObject)
                {
                    isPressed = true;
                    //print("aaaaaaaa");
                    // GameObject maskSprite = Instantiate(maskPrefab, MouseDown, Quaternion.identity);
                    //GameObject maskSprite = GameObject.Instantiate(maskPrefab, hitInfo.point, transform.rotation) as GameObject;
                    //maskSprite.transform.parent = gameObject.transform;
                }

            }
            //GetComponent<Animator>().SetBool("Isend", true);
            
        }
    }
}
