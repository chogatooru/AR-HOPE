using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HopeSlider : MonoBehaviour
{
    public float Hope = 60;
    public float HopeMax = 100;
    public Image Timebar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timebar.fillAmount = Hope / HopeMax;
    }
}
