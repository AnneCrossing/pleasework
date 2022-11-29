using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backmainmenu : MonoBehaviour {
	public void backmm() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2); //this is for the options back button
	}
	public void backmm2() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1); //this is for the back button in the level selector

	}
	public void backmm3() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-5); //this is for the back button in the level selector

	}

}
