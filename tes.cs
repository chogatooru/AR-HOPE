using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tes : MonoBehaviour
{

    public string deviceName1;
    WebCamTexture tex1;//接收返回的图片数据 
    public string deviceName2;
    WebCamTexture tex2;//接收返回的图片数据 
    public GameObject plane1;
    public GameObject plane2;
    bool turn = true;
    public GUISkin guiSkin;
    void Start()
    {
        StartCoroutine(test1());
        StartCoroutine(test2());
    }

    // Update is called once per frame
    void Update()
    {
        plane1.GetComponent<Renderer>().material.mainTexture = turn ? tex1 : tex2;
        plane2.GetComponent<Renderer>().material.mainTexture = turn ? tex2 : tex1;
    }
    void OnGUI()
    {
        GUI.skin = guiSkin;
        if (GUI.Button(new Rect(20, 20, 300, 100), "翻转"))
        {
            turn = !turn;
        }
    }
    IEnumerator test1()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);//授权 
        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            deviceName1 = devices[0].name;
            //设置摄像机摄像的区域 
            tex1 = new WebCamTexture(deviceName1, 1280, 720, 30);
            tex1.Play();//开始摄像 
        }
    }
    IEnumerator test2()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);//授权 
        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            deviceName2 = devices[1].name;
            //设置摄像机摄像的区域 
            tex2 = new WebCamTexture(deviceName2, 640, 480, 30);
            tex2.Play();//开始摄像 
        }

    }
}
