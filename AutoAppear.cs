using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAppear : MonoBehaviour
{
    public GameObject tgameObject;
    public float Timer = 5;
    Tutorialpress tutorialpress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0 && tgameObject!=null)
        {
            tgameObject.SetActive(true);
        }
        }
}
