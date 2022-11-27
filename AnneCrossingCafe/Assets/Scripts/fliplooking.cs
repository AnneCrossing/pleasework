using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pathfinding;

public class fliplooking : MonoBehaviour {
	public AIpath lookingright;
	bool lookright = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(lookingright.desiredvelocity.x >= 0.01f){
			lookright==true;
			transform.Rotate(0, 180, 0);
			lookright==false;
		}
		elseif(lookingright.desiredvelocity.x <= -0.01f) {
			transform.Rotate(0, 180, 0);
			lookright==true;
			transform.Rotate(0, 180, 0);
			lookright==false;
		}
		
	}
}
