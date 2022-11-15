using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class foodamountmanager : MonoBehaviour {
	public static int fullfoodamount;
	public TextMeshProUGUI text;

	// Use this for initialization
	void Start () {
		fullfoodamount = 5; // to reset it
		text = GameObject.FindGameObjectWithTag("fa").GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = fullfoodamount.ToString(); //since it updates every second it can check for collisions
	}
}
