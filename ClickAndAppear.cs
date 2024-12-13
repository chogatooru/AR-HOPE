using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndAppear : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        gameObject.SetActive(true);
    }
}
