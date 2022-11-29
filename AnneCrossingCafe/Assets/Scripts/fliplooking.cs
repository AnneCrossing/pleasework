using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class fliplooking : MonoBehaviour {
	public AIPath lookingright;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(lookingright.desiredVelocity.x >= 0.01f){
			transform.Rotate(0, 180, 0);
		}
		else if(lookingright.desiredVelocity.x <= -0.01f) {
			transform.Rotate(0, 180, 0);
		}
		
	}
}
