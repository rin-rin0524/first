using UnityEngine;
using System.Collections;

public class cameraproject : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = target.transform.position + new Vector3 (4.0f, -1.5f, -8.0f);
	
	}
}
