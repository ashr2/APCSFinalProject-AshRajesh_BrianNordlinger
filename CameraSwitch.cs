using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera c1;
    public Camera c2;
    public Camera c3;
    public Camera c4;
    public Camera c5;
    public Camera c6;
    public Camera c7;
    public Camera c8;
    // Start is called before the first frame update
    void Start()
    {
        c1.enabled = true;
        c2.enabled = false;
        c3.enabled = false;
        c4.enabled = false;
        c5.enabled = false;
        c6.enabled = false;
        c7.enabled = false;
        c8.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            c1.enabled = true;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = false;
            c6.enabled = false;
            c7.enabled = false;
            c8.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            c1.enabled = false;
            c2.enabled = true;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = false;
            c6.enabled = false;
            c7.enabled = false;
            c8.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            c1.enabled = false;
            c2.enabled = false;
            c3.enabled = true;
            c4.enabled = false;
            c5.enabled = false;
            c6.enabled = false;
            c7.enabled = false;
            c8.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            c1.enabled = false;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = true;
            c5.enabled = false;
            c6.enabled = false;
            c7.enabled = false;
            c8.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            c1.enabled = false;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = true;
            c6.enabled = false;
            c7.enabled = false;
            c8.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            c1.enabled = false;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = false;
            c6.enabled = true;
            c7.enabled = false;
            c8.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            c1.enabled = false;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = false;
            c6.enabled = false;
            c7.enabled = true;
            c8.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            c1.enabled = false;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = false;
            c6.enabled = false;
            c7.enabled = false;
            c8.enabled = true;
        }
    }
}
