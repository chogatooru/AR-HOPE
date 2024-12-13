using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheakscreenpos : MonoBehaviour
{
    public Vector3 screenPos;
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    void Update()
    {
        screenPos = Camera.main.WorldToScreenPoint(transform.position);
       // print(screenPos);
    }
}
