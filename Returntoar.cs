using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Returntoar : MonoBehaviour
{
    public GameObject nextpage;
    public float timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            nextpage.SetActive(true);
           
        }
    }
}
