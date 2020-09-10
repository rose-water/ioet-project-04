using System.Collections;
using UnityEngine;

public class InstantiateGoatsScript : MonoBehaviour {

	public GameObject goatPrefab;
	public int numGoats = 15;


	void Start() {
		SpawnGoats();
	}


	void SpawnGoats() {

		for (int i = 0; i < numGoats; i++) {
			Vector3 pos = new Vector3(Random.Range(-5.0f, 5.0f), 0.0f, Random.Range(-5.0f, 5.0f));
    	Instantiate(goatPrefab, pos, Quaternion.Euler(0.0f, Random.Range(0.0f, 90.0f), 0.0f));
		}

	}
}
