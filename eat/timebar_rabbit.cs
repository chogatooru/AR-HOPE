using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timebar_rabbit : MonoBehaviour
{
    public Slider Timebar;
    public float maxTime = 10f;
    public float timer = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            timer -= Time.deltaTime;

        Timebar.value = timer / maxTime;

        if (timer <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
