using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float lookVertical = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(-lookVertical, 0f, 0f));
    }
}
