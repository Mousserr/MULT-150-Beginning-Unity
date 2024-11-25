using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
   public GameObject prefab;

	void Start()
	{
		for (int x = 0; x < 10; x++)
		{
			transform.position = transform.position + new Vector3(0, 0, -5);
			Instantiate(prefab, transform.position, transform.rotation);
		}
	}

    // Update is called once per frame
    void Update()
    {
		/*  Whenever we hit the B key we will generate a prefab at the
		 *  position of the original prefab.
		 *  Whenever we hit the space key, we will generate a prefab at the
		 *  position of the spawn object that this script is attached to
		 */

		if(Input.GetKeyDown(KeyCode.B))
		{
			Instantiate(prefab);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(prefab, transform.position, transform.rotation);
		}
    }
}
