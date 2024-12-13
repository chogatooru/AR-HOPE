using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tonect : MonoBehaviour
{
    public GameObject linerender;
    public GameObject starUI;
    // Start is called before the first frame update
    void Start()
    {
        linerender.SetActive(false);
        starUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
