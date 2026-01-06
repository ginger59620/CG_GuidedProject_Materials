using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraShots : MonoBehaviour
{
    public Camera mainCam;
    public Camera wideCam;
    public Camera midCam;
    public Camera closeCam;
    public Camera otoCam;

    private void Awake()
    {
        mainCam.enabled = true;
        wideCam.enabled = false;
        midCam.enabled = false;
        closeCam.enabled = false;
        otoCam.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("1") || Input.GetButtonDown("WideCam"))
        {
            WideCam();
        }
        if (Input.GetKeyUp("2") || Input.GetButtonDown("MidCam"))
        {
            MidCam();
        }
        if (Input.GetKeyUp("3") || Input.GetButtonDown("CloseCam"))
        {
            CloseCam();
        }
        if (Input.GetKeyUp("4") || Input.GetButtonDown("OtoCam"))
        {
            OtoCam();
        }
        if (Input.GetKeyUp("0") || Input.GetButtonDown("MainCam"))
        {
            MainCam();
        }
    }
    public void MainCam()
    {
        mainCam.enabled = true;
        wideCam.enabled = false;
        midCam.enabled = false;
        closeCam.enabled = false;
        otoCam.enabled = false;
    }
    public void WideCam()
    {
        mainCam.enabled = false;
        wideCam.enabled = true;
        midCam.enabled = false;
        closeCam.enabled = false;
        otoCam.enabled = false;
    }
    public void CloseCam()
    {
        mainCam.enabled = false;
        wideCam.enabled = false;
        midCam.enabled = false;
        closeCam.enabled = true;
        otoCam.enabled = false;
    }
    public void MidCam()
    {
        mainCam.enabled = false;
        wideCam.enabled = false;
        midCam.enabled = true;
        closeCam.enabled = false;
        otoCam.enabled = false;
    }
    public void OtoCam()
    {
        mainCam.enabled = false;
        wideCam.enabled = false;
        midCam.enabled = false;
        closeCam.enabled = false;
        otoCam.enabled = true;
    }
}
