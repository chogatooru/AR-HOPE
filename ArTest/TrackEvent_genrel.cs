using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackEvent_genrel : DefaultTrackableEventHandler
{

    public GameObject pages;
  // public GameObject pagemark;
    public bool Ispagemark = false;
    
     void Update()
    {

            // if (pagemark.activeSelf)
            //  {
            Ispagemark = true;
     //   }
    }
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

            pages.SetActive(true);
        
        

    }

    protected override void OnTrackingLost()
    {
        pages.SetActive(false);
        base.OnTrackingLost();

    }
}
