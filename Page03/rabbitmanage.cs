using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbitmanage : MonoBehaviour
{
    public CameraEffect cameraEffect;
    // Start is called before the first frame update
    void Start()
    {
        //cameraEffect = cameraobj.GetComponent<CameraEffect>();
    }

    void OnTriggerStay2D(Collider2D other)
    {

           // print("aaaaa");
        
    }
    // Update is called once per frame
    void Update()
    {

        //cameraEffect.grayScaleAmount = 0;
    }
}
