using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake_Phone : MonoBehaviour
{
    public GameObject Text;
    Vector3 accelerationDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accelerationDir = Input.acceleration;
        if (accelerationDir.sqrMagnitude >= 5f)
        {

            Text.SetActive(true);
        }
        }
}
