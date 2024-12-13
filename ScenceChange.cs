using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceChange : MonoBehaviour
{
    public int scencenum = 1;
    public float Timer = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Globaldatas.num += 1;
            SceneManager.LoadScene(scencenum);
        }
        
    }
}
