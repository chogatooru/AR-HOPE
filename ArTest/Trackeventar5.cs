using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Trackeventar5 : DefaultTrackableEventHandler
{
    public GameObject pages;
    public GameObject page2;
    public GameObject pagemark;
    public bool Ispagemark = false;

    public int globalnum;
    // public TrackEvent_genrel3 trackEvent_Genrel3;

    void Update()
    {
        if (pagemark.activeSelf)
        {
            // bookhand.SetActive(false);
            Ispagemark = true;
        }
    }
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (Ispagemark && Globaldatas.num == globalnum)
        {
            pages.SetActive(true);
            if (page2 != null)
            {
                page2.SetActive(true);
            }

        }

    }

    protected override void OnTrackingLost()
    {
        pages.SetActive(false);
        if (page2 != null)
        {
            page2.SetActive(false);
        }
        base.OnTrackingLost();

    }
}

