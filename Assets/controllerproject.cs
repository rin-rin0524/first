using UnityEngine;
using System.Collections;

public class controllerproject : MonoBehaviour {

	float speed = 4.0f;
	RaycastHit hit;
	public ParticleSystem _particle;
//	public ParticleSystem particle;
	private float timer = 3.0f;
	public bool isPlay = true;


//	private scorescript Scorescript;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (isPlay) {
			timer -= Time.deltaTime;
		}

		if(Input.GetKeyDown(KeyCode.RightShift)){

			transform.position += new Vector3 (0, 0, -2.0f);

			if (timer < 0) {
				transform.position += new Vector3 (0, 0, 2.0f);
			}

		}




		/*speed += 0.2f;

		if (speed >= 6.0f) {
			speed = 6.0f;
		}*/


		if (Input.GetKeyDown (KeyCode.DownArrow)) {

			GetComponent<Rigidbody> ().velocity = new Vector3 (0, -40, 0);


		}




		Ray ray = new Ray (transform.position, Vector3.down);




		//transform.position += new Vector3 (speed*Time.deltaTime, 0, 0);

		if(Physics.Raycast(ray, out hit,1)){
			
			if (Input.GetKeyDown (KeyCode.Space)) {

				GetComponent<Rigidbody> ().velocity = new Vector3 (0, 7, 0);

				_particle.Play();

			}
		
		}

	

		if (transform.position.y < -9) {
		
			GameManager.Instance.LoadGameOver();

		}

	
	
	}

//	 void OnCollisionEnter(Collision item){
//
//		particle.Play ();
//
//	}

	/*void OnCollisionEnter(Collision other){

		if (other.collider.tag == "item") {

			stagescript stage = GetComponent<stagescript> ();
			stage.SpeedChange ();

		}

	}*/

	/*public void GameOver (){
		scorescript pp = GetComponent<scorescript> ();
		pp.SetDeadFlg ();

	}*/
}
