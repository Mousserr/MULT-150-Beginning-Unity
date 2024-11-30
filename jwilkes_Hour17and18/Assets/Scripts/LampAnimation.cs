using UnityEngine;

public class LampAnimation : MonoBehaviour
{
	//Declare anim variable
	Animator anim;

    void Start()
    {
		//Get reference for animator
		anim = GetComponent<Animator> ();
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.S))
			anim.SetTrigger ("Spinning");

		if (Input.GetKey(KeyCode.A))
			anim.SetTrigger ("Color");

		if (Input.GetKey(KeyCode.D))
			anim.SetTrigger ("Scaling");

		if (Input.GetKey(KeyCode.W))
			anim.SetTrigger ("Hover");
	}
}
