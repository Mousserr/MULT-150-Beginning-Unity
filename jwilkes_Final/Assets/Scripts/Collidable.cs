using UnityEngine;

public class Collidable : MonoBehaviour
{
	public GameManager manager;
	public float moveSpeed = 20f;
	public float timeAmount = 1.5f;

	private void Update()
	{
		transform.Translate (0, 0, -moveSpeed * Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			manager.AdjustTime (timeAmount);
			Destroy(gameObject);
		}
	}
}
