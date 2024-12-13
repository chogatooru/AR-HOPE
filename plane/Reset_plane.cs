using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_plane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Buttontest.movenum = 0;
        PlaneButton.Isdie = false;
        PlaneButton.IsStarting = false;
        PlayButton_plane.buttonisdown = false;
        TimeBar_plane.timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
