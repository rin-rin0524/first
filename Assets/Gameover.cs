using UnityEngine;
using System.Collections;

public class Gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.T)) {

			scorescript.timer = 0;
			Application.LoadLevel ("MAIN");

		}
	
	}
}
