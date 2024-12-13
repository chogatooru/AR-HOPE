using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchRotation : MonoBehaviour
{

    private AudioSource _audioSource;
    AudioClip audioClip;

    private void Start()
    {
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        audioClip = Resources.Load<AudioClip>("button32");
        // line.material.color = Color.white;
    }

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        //if (transform.rotation.z / 360 == 0)
        //{
            //print(transform.localRotation.z);
        //}
        if (!GameControl.youWin)
        {
            transform.Rotate(0f, 0f, 90f);
            _audioSource.clip = audioClip;
            _audioSource.Play();
        }

    }

    public void rotation()
    {
        //if (transform.rotation.z / 360 == 0)
        //{
        //print(transform.localRotation.z);
        //}
        if (!GameControl.youWin)
        {
            transform.Rotate(0f, 0f, 90f);
            _audioSource.clip = audioClip;
            _audioSource.Play();
        }

    }
}
