using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float mxVal = Input.GetAxis("Mouse X");				//Access Mouse X axis values
		float myVal = Input.GetAxis("Mouse Y");				//Access Mouse Y axis values

		transform.Translate(mxVal, myVal, 0);
    }
}