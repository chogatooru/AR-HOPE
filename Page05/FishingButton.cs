using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingButton : MonoBehaviour
{
    public bool Isshooting = false;
    public Transform transformf;
    public Transform trager;
    public GameObject img1;
    public GameObject cha;
    public GameObject img0;
    public int MoveSpeed = 6;
    // Start is called before the first frame update
    private AudioSource _audioSource;
    AudioClip audioClip;

    public bool mhasPlayedGameOverMusic = false;

    void Start()
    {
        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象

    }

    public void sth()
    {
        Isshooting = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Isshooting)
        {

            img0.SetActive(false);
            img1.SetActive(true);

            transformf.Translate(Vector3.down * MoveSpeed * Time.deltaTime, Space.Self);

            if (mhasPlayedGameOverMusic == false)
            {
                playpopse();
            }

            if (transformf.localPosition.y <= -3.6)
            {
                img0.SetActive(true);
                img1.SetActive(false);
                transformf.localPosition = trager.localPosition;
                mhasPlayedGameOverMusic = false;
                Isshooting = false;
            }
        }
        else
        {
            img0.SetActive(true);
            img1.SetActive(false);
            transformf.localPosition = trager.localPosition;
        }
    }

    void playpopse()
    {
        if (!_audioSource.isPlaying)
        {
            audioClip = Resources.Load<AudioClip>("dropwater");
            mhasPlayedGameOverMusic = true;
            _audioSource.clip = audioClip;
            _audioSource.PlayOneShot(audioClip, 1F);

        }
    }
}
