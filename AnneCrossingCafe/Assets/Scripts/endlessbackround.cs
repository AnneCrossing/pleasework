using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessbackround : MonoBehaviour {
	public float bgspeed; //speed of the background
	public float leftboarder; //taken from player script
	public float based; //the base distance, its origins
	private Vector2 newpos; //taken from player script


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {

		transform.Translate(Vector2.left * bgspeed); //it moving
		if(transform.position.x < leftboarder) {
			newpos = new Vector2(based, transform.position.y); //if it hits the boarder it is sent back to the base
			transform.position = newpos; // new position
		}
	}
}