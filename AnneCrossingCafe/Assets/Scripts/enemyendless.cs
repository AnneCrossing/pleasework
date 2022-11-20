using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyendless : MonoBehaviour {
	public float ememyspeed;
	
	void Update () {
		transform.Translate(Vector2.left * ememyspeed); //due to it being in the update funciton it will constantly move forwards,
	}
	private void OnTriggerEnter2D(Collider2D other) {
		foodamountmanager.fullfoodamount -=1; //adds it to the other script for the ui
		Destroy(gameObject); //to not clutter space
		if (foodamountmanager.fullfoodamount <= 0) { //if lives are zero then 
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
		}
	
	}
}