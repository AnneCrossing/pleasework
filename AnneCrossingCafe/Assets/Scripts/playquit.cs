using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playquit : MonoBehaviour {
	public void gotolevelselector() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

	}
	public void quit(){
		Application.Quit();
		
	}
	public void optionscene() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
	}
}