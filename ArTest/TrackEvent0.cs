using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackEvent0 : DefaultTrackableEventHandler
{
    public Animator m_Animator;
    public GameObject page0;
    public bool isccc = false;
    public TypewriterEffect typewriterEffect;
    bool Isfound = false;
    protected override void OnTrackingFound()
    {
        Isfound = true;
        isccc = true;
        base.OnTrackingFound();
        if (typewriterEffect != null)
        {
            if (typewriterEffect.Isqr)
            {
                page0.SetActive(true);
            }
        }
        else
        {
            page0.SetActive(true);
        }

       
        //TypewriterEffect.
        if (m_Animator != null)
        {
            m_Animator.SetBool("targetin", true);
        }
        
    }
    void Update()
    {
        if (Isfound)
        {
            if (typewriterEffect.Isqr)
            {
                page0.SetActive(true);
            }
        }

    }
    protected override void OnTrackingLost()
    {
        isccc = false;
        Isfound = false;
        page0.SetActive(false);
        base.OnTrackingLost();
        if (m_Animator != null)
        {
            m_Animator.SetBool("targetin", false);
        }
    }
}
