
using UnityEngine;
using System.Collections;

public class stagescript : MonoBehaviour {

	public GameObject stage1;
	public GameObject stage2;
	public GameObject stage3;

	public bool check = false;

	float time = 0f;


	private float speed =4.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		speed += 0.01f;

		if (speed >= 12.0f) {
			speed = 12.0f;
		}

		stage1.transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);
		stage2.transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);
		stage3.transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);

		if (stage1.transform.position.x < -75) {
			
			stage1.transform.position = new Vector3 (36.6f, 0, 0);

		} else if (stage2.transform.position.x < -75) {
				
			stage2.transform.position = new Vector3 (36.6f, 0, 0);
		
		} else if (stage3.transform.position.x < -75) {
			
			stage3.transform.position = new Vector3 (36.6f, 0, 0);

		}

		if (check == true) {
		
			time += Time.deltaTime;
			 
			if (time > 3f) {
				Debug.Log ("a");
				speed = 5.0f;
			
			}

		}



	}


}
		
