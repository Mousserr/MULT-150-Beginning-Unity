using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
	public GameObject powerupPrefab;
	public GameObject obstaclePrefab;
	public GameObject donutPrefab;
	public float spawnCycle = .5f;
	public float donutSpawn = 1.0f;
	public int sCount = 20;
	public int spawnCount = 0;

	GameManager manager;
	float elapsedTime;
	float totalTime;
	bool spawnPowerup = true;

	private void Start()
	{
		manager = GetComponent<GameManager>();
	}

	private void Update()
	{
		GameObject temp;


		elapsedTime += Time.deltaTime;
		totalTime += Time.deltaTime;

		if (elapsedTime > spawnCycle) 
		{
			if (spawnCount != sCount)
			{
				if (spawnPowerup)
				{
					temp = Instantiate(powerupPrefab) as GameObject;
					++spawnCount;
				}
				else
				{
					temp = Instantiate(obstaclePrefab) as GameObject;
					++spawnCount;
				}
			}
			else
			{
				temp = Instantiate(donutPrefab) as GameObject;
				spawnCount = 0;
			}

			Vector3 position = temp.transform.position;
			position.x = Random.Range(-3f, 3f);
			temp.transform.position = position;

			Collidable col = temp.GetComponent<Collidable>();
			col.manager = manager;

			elapsedTime = 0;
			spawnPowerup = !spawnPowerup;
		}
	}
}