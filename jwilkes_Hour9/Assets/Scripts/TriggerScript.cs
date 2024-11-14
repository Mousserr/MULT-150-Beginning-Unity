using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
	public GameObject rightCollider;
	public GameObject leftCollider;
	public GameObject ball;

	// Start is called before the first frame update
	void Start()
    {
		rightCollider = GameObject.Find("RTrigger");
		leftCollider = GameObject.Find("LTrigger");
		ball = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider ball)
	{
		print(ball + " has entered the " + gameObject.name);
	}

	void OnTriggerStay(Collider ball)
	{
		print(ball + " is still in the " + gameObject.name);
	}

	void OnTriggerExit(Collider ball)
	{
		print (ball + " has exited the " + gameObject.name);
	}
}
