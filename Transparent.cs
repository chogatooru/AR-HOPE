using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparent : MonoBehaviour
{
    Color scolor;
    Vector3 accelerationDir;

    public GameObject button; 
    //float color_Tran;
    public float color_Tran_speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        scolor = transform.GetComponent<SpriteRenderer>().color;
        scolor.a = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        accelerationDir = Input.acceleration;
        if (accelerationDir.sqrMagnitude >= 5f)
        {
            scolor.a -= Time.deltaTime * color_Tran_speed;
            transform.GetComponent<SpriteRenderer>().color = scolor;
        }
        if (scolor.a <= 0)
        {
            button.SetActive(true);
        }
    }
}
