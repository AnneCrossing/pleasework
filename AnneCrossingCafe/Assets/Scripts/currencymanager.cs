using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class currencymanager : MonoBehaviour {
	public static int totalcurrency;
	public TextMeshProUGUI text;

	// Use this for initialization
	void Start () {
		totalcurrency = 0; // to reset it
		text = GameObject.FindGameObjectWithTag("cc").GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = totalcurrency.ToString();
	}
}
