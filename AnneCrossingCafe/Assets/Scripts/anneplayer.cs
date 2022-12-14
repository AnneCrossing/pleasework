using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anneplayer : MonoBehaviour {
	public int foodamount; // the health of the player, due to ingame the player losing a food eachtime they're hit, it's called food amount
	public float topboarder; // so the player cant go infinite up
	public float bottomboarder; //so the player cant go infinite down
	public float leftboarder;
	public float rightboarder;
    public float changeiny; // the amount player will go up and down
    public float changeinx; // the amount player will go left to right, if I have time to code endless runner
    private Vector2 newpos; // this will be the new position the player will go to
	bool lookright = false;

	private void Update()
	{
		if(Input.GetKey(KeyCode.W) && transform.position.y < topboarder) { //this says that if they want to move and it's lower than the top boarder they will be allowed
			newpos = new Vector2(transform.position.x, transform.position.y + changeiny); //this is basically the calculation of current position + changeiny
			transform.position = newpos; //this is basically making the new position equal to the original + changeiny 
		}
		
		else if (Input.GetKey(KeyCode.S) && transform.position.y > bottomboarder){
			newpos = new Vector2(transform.position.x, transform.position.y - changeiny); //this is basically the calculation of current position - changeiny
			transform.position = newpos; //this is basically making the new position equal to the original - changeiny 
		}
		
		else if (Input.GetKey(KeyCode.A) && transform.position.x > leftboarder){
			newpos = new Vector2(transform.position.x - changeinx, transform.position.y); 
			transform.position = newpos;
			if(lookright == true){
				transform.Rotate(0, 180, 0);
				lookright = false;
			}
		}

		else if (Input.GetKey(KeyCode.D) && transform.position.x > leftboarder){
			newpos = new Vector2(transform.position.x + changeinx, transform.position.y); 
			transform.position = newpos;
			if(lookright == false){
				transform.Rotate(0, 180, 0);
				lookright = true;
			}
		}
		if(Input.GetKey(KeyCode.Escape)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
		}

		}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("currency")) {
			Destroy(other.gameObject);
		}
	}
}