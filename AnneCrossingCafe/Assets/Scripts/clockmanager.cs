using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class clockmanager : MonoBehaviour {
	public float totaltime;
	public float sec = 1;
	public TextMeshProUGUI text;
	// Use this for initialization
	void Start () {
		text = GameObject.FindGameObjectWithTag("time").GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = totaltime.ToString();
		if (totaltime > 0){
			totaltime = totaltime - sec*Time.deltaTime;
			totaltime = Mathf.Round(totaltime*100.0f)/100.0f;
		}
		else {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);//GAMEROVER SCREEN
		}
	}
}
