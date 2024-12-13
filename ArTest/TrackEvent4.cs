using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class TrackEvent4 : DefaultTrackableEventHandler
{

    protected override void OnTrackingFound()
    {
        SceneManager.LoadScene(3);
    }

    protected override void OnTrackingLost()
    {

    }
}
