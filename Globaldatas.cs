using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globaldatas : MonoBehaviour
{
    public static int num = 0;
    public GameObject gameobject0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (num == 1)
        {
            gameobject0.SetActive(false);
        }
        if (num == 2)
        {
            gameobject0.SetActive(false);
        }
        if (num == 3)
        {
            gameobject0.SetActive(false);
        }
        if (num == 4)
        {
            gameobject0.SetActive(false);
        }
        // print(num);
    }
}
