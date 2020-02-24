using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {

	private float timer = 180f;
	private Text timerSeconds;

	public bool timesUp;
	[SerializeField] string levelToLoad;

	// Use this for initialization
	void Start () {
		timerSeconds = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		timerSeconds.text = timer.ToString ("f2");
		if (timer <= 0) {
			DoSceneChange ();
		}

	}
		

	public void DoSceneChange()
	{
		SceneManager.LoadScene (levelToLoad);
	}

}
