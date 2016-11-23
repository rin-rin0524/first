using UnityEngine;
using System.Collections;

public class GameManager : SingletonMonoBehaviour<GameManager>{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	public void LoadGameOver(){
		scorescript.Instance.StopTimer ();
		Application.LoadLevel ("GAMEOVER");
	}


	//Application.LoadLevel ("GAMEOVER");

}
