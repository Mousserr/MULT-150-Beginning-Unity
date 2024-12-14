using UnityEngine;

public class FlyingDonut : MonoBehaviour
{
	private void Update()
	{
		transform.Translate(0, 0, -20f * Time.unscaledDeltaTime, Space.World);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Doughnut collected! ");
			Destroy(gameObject);
		}
	}
}
