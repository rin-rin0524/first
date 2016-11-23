using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LastScoreScript : MonoBehaviour {
	
//	public static int Last;
//	public Text last;
	public Text scoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		scoreText.text = scorescript.timer.ToString ("f0");
//		if (last != null) {
//
//			if (Last < timer) {
//
//				//PlayerPrefs.SetFloat ("Last", timer);
//				last.text = "おめでとう!!最高記録!!";
//			} else {
//				last.text = " ";
//			}
//
//		}

	}
}
