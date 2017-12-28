using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    WebCamDevice webCamDevice;
    WebCamTexture webCamTexture;

    int width = 800;
    int height = 600;


    // Use this for initialization
    void Start()
    {
        webCamDevice = WebCamTexture.devices[0];
        webCamTexture = new WebCamTexture(webCamDevice.name, width, height);
        webCamTexture.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
