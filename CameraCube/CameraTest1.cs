using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraTest1 : MonoBehaviour
{
    public GameObject button;
    public GameObject Cube;
    public GameObject imphoto;

    public GameObject photo;
    // Start is called before the first frame update
    WebCamTexture webcamTexture;
    // Use this for initialization
    void Start()
    {

        webcamTexture = new WebCamTexture();

        //调用前置
       for (int i = 0; i < WebCamTexture.devices.Length; i++)
      {
          if (!WebCamTexture.devices[i].isFrontFacing)
           {
                webcamTexture.deviceName = WebCamTexture.devices[i].name;
              break;
          }
       }


        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();


        }
    
    void Update()
{
    if (Camera_Button.Isbuttondown)
    {
        //
        imphoto.SetActive(true);
        button.SetActive(false);
        Cube.SetActive(false);


        //拍照
        Texture2D t = new Texture2D(webcamTexture.width, webcamTexture.height);
        t.SetPixels(webcamTexture.GetPixels());
        t.Apply();
        Renderer rendererphoto = photo.GetComponent<Renderer>();
        rendererphoto.material.mainTexture = t;
        webcamTexture.Pause();

    }
}

}

