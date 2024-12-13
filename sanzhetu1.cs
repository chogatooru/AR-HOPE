using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanzhetu1 : MonoBehaviour
{
    public GameObject textobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textobj.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}
