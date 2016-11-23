using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ball;

	private float timer = 1.0f;
	public bool isPlay = true;

	public float posx;
	public float posy_min;
	public float posy_max;

	void start(){

	

	}


	void Update () {

		if (transform.position.x < -20f) {

			Destroy (ball);
			//isPlay = true;

		}

		if (isPlay) {
			timer -= Time.deltaTime;
		}

	

		if (timer < 0) {

		

			Instantiate (
				ball, 
				new Vector3(
					posx,
					Random.Range(posy_min, posy_max), 
					0),
				Quaternion.identity);
			timer = Random.Range(3.0f, 7.0f);// 次に出す時間
		}
	}

}