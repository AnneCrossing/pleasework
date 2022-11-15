using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currency : MonoBehaviour {
	public float currencyspeed; //so it can move

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.left * currencyspeed); //due to it being in the update funciton it will constantly move forwards,
	}
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			currencymanager.totalcurrency +=1; //adds it to the other script for the ui
			Destroy(gameObject); //to not clutter space
		}
	}
}