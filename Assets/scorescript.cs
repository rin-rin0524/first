using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scorescript : SingletonMonoBehaviour<scorescript> {

	public Text Score;
	//public static int score = 0;
	//public Text LastScore;

	private bool timerplus = false;

	public static float timer = 0;


	// Use this for initialization
	void Start () {
		StartTimer ();
	}
	

	void Update () {
		if (Score) {
			Score.text = timer.ToString ("f0");
		}
		if (timerplus = true) {
			timer += Time.deltaTime * 6;
		}

	//	if (LastScore != null) {
	//		LastScore.text = timer.ToString() + "てん";
		
		//}


	}

	public void StartTimer()
	{
		timerplus = true;
	}
	


	public void StopTimer()
	{
		timerplus = false;
	}




}
