using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firststar : MonoBehaviour
{
    public float timer = 0;
    public GameObject star1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        //if (timer > 2)
       // {
        //    star1.SetActive(true);
            
      //  }
    }
}
