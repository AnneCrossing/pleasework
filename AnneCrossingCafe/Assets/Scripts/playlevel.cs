using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playlevel : MonoBehaviour {
		public void playlevelzero() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);

	}
		public void playlevelone() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);

		}
		public void playleveltwo() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);

		}
}
