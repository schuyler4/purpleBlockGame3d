using UnityEngine;
using System.Collections;

public class EnemyCreator : MonoBehaviour {

	public GameObject enemy;
	public float speed;

	private GameObject[] enemys;

	void reset() {
		for (int i = -4; i < 5; i++) {
			Instantiate (enemy, new Vector3 (i, 1, 4), Quaternion.identity);
		}
	}
	
	void Start () {
		reset ();
	}

	void Update () {
		enemys = GameObject.FindGameObjectsWithTag ("Enemy");

		for (int i = 0; i < enemys.Length; i++) {

			float x = enemys[i].transform.position.x;
			float y = enemys[i].transform.position.y;
			float z = enemys[i].transform.position.z;

			enemys [i].transform.position = new Vector3 (x, y, z - speed);

			if (z < -10) {
				Destroy (enemys [i]);
				reset ();
			}
		}
	}
}
