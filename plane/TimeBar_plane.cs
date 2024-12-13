using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar_plane : MonoBehaviour
{
    public Slider Timebar;
    public float maxTime = 10f;
    public static float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayButton_plane.buttonisdown)
        {
            timer += Time.deltaTime;
        }

        Timebar.value  = timer / maxTime;
    }
}
