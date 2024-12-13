using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackEvent_genrel_ar1 : DefaultTrackableEventHandler
{

    public GameObject fishmark;
    public GameObject pages;
    public GameObject pagemark;
    public GameObject qrcode;
    public bool Ispagemark = false;
    public int globalnum;
    public TypewriterEffect typewriterEffect;
    public TrackEvent_genrel3 trackEvent_Genrel3;
    bool Isfound = false;

    void Update()
    {
        if (Isfound)
        {
            if (typewriterEffect.Isqr)
            {
                qrcode.SetActive(true);                
            }
            }
            if (pages.activeSelf)
          {
        Ispagemark = true;
          }
        if (Ispagemark)
        {
            fishmark.SetActive(true);
        }
    }
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (Globaldatas.num == globalnum && trackEvent_Genrel3.Ispagemark == false)
        {
            pages.SetActive(true);
            Isfound = true;
        }


    }

    protected override void OnTrackingLost()
    {

        qrcode.SetActive(false);
        Isfound = false;
        pages.SetActive(false);
        base.OnTrackingLost();

    }
}
