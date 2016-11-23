using UnityEngine;
using System.Collections;

public class itemscript : MonoBehaviour {

	public GameObject itemObj;





	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnCollisionEnter(Collision collision){
		if (collision.collider.tag == "Player") {
	
			Destroy (this.gameObject);

			scorescript.timer += 20;
	
		}
			

	}

}
