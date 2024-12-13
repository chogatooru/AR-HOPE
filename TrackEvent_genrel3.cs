using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackEvent_genrel3 : DefaultTrackableEventHandler
{
   // public GameObject bookhand;
    public GameObject pages;
    public GameObject page2;
    public GameObject pagemark;
    public bool Ispagemark = false;
    public TrackEvent_genrel3 trackEvent_Genrel3;
    public int globalnum;
    public GameObject text;
    public TypewriterEffect typewriterEffect;
    bool Isfound = false;

    void Update()
    {
        if (Isfound)
        {
            if (typewriterEffect.Isqr)
            {
                pages.SetActive(true);
                if (page2 != null)
                {
                    page2.SetActive(true);
                }
            }
        }


        if (pagemark.activeSelf)
          {
          // bookhand.SetActive(false);
        Ispagemark = true;
          }
    }
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (trackEvent_Genrel3 != null)
        {
            if (Ispagemark && trackEvent_Genrel3.Ispagemark == false && Globaldatas.num == globalnum)
            {
                Isfound = true;
                text.SetActive(true);

            }
        }
      else
        {
            if (Ispagemark && Globaldatas.num == globalnum)
            {
                pages.SetActive(true);
                if (page2 != null)
                {
                    page2.SetActive(true);
                }

            }
        }
       

    }

    protected override void OnTrackingLost()
    {
        Isfound = false;
        text.SetActive(false);
        pages.SetActive(false);
        if (page2 != null)
        {
            page2.SetActive(false);
        }
        base.OnTrackingLost();

    }
}
