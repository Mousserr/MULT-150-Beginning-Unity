using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
	public GameObject ball;							//Get game target
    
    void Start()
    {
        ball = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
		float hVal = Input.GetAxis("Horizontal");
		float vVal = Input.GetAxis("Vertical");

		ball.transform.Translate(hVal, vVal, 0);
    }
}
