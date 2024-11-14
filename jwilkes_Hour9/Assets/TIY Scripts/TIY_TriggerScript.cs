using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIY_TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		print(other.gameObject.name + " has entered the cube");
	}

	private void OnTriggerStay(Collider other)
	{
		print (other.gameObject.name + " is still in the cube");
	}

	private void OnTriggerExit(Collider other)
	{
		print(other.gameObject.name + " has left the cube ");
	}
}
