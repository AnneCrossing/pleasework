using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class topdownbasic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D other) {
		foodamountmanager.fullfoodamount -=1; 
		Destroy(gameObject); 
		if (foodamountmanager.fullfoodamount <= 0) { 
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
		}
	
	}
}
