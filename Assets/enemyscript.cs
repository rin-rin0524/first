using UnityEngine;
using System.Collections;

public class enemyscript : MonoBehaviour {

	private float speed = 13f;

	public GameObject item2;
	public GameObject player;


	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);





	


	//	if (transform.position.x < -20f) {

	//		float x = Random.Range (30.0f, 60.0f);
	//		float y = Random.Range (0.0f, 7.0f);

	//		Instantiate (item2, new Vector2 (x, y), Quaternion.identity);
	//	}

	
		
		}

	void OnCollisionEnter(Collision player){

		GameManager.Instance.LoadGameOver ();

	//	scorescript ss = GetComponent<scorescript> ();
	//	Debug.Log (ss);
	//	ss.SetDeadFlg ();
	}
}
