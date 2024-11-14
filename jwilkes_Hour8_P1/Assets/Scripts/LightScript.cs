using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightScript : MonoBehaviour
{
	Light lightComponent;										//Sets up a light component


    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light> ();
		lightComponent.type = LightType.Directional;			//Sets light to directional
		lightComponent.enabled = false;							//Turns light off
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.L))
		{
			lightComponent.enabled = !lightComponent.enabled;
			/*
			if (lightComponent.enabled != true)
				lightComponent.enabled = true;
			else
				lightComponent.enabled = false;
			*/
		}
	}
}
