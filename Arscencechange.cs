using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arscencechange : MonoBehaviour
{
    public int scencenum = 1;
    public float Timer = 4;

    // Start is called before the first frame update
    void Awake()
    {
        Timer = 4;
    }

    // Update is called once per frame
    void Update()
    {

        Timer -= Time.deltaTime;
       
        if (Timer <= 0)
        {
            SceneManager.LoadScene(scencenum);
        }

    }
}

