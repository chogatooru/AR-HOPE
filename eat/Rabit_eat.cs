﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabit_eat : MonoBehaviour
{
    public GameObject luobo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began){
                Instantiate(luobo, touchPos, Quaternion.identity);}
        }
       /* if (Input.anyKeyDown)
        {
           // Touch touch = Input.GetTouch(0);
          //  Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

          //  if (touch.phase == TouchPhase.Began)
                Instantiate(luobo);
        }
        */
    }



}
