using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour {
	public float timing; //the time between each spawn, 
	public GameObject[] obstaclespawner; //the spawner
	public float starttiming; //the first timing interval

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timing <= 0){
			int rand = Random.Range(0, obstaclespawner.Length); //integer since theres only 3 options, random for it randomly picking
			Instantiate(obstaclespawner[rand], transform.position, Quaternion.identity); //this brings it into existence, rand for random
			timing = starttiming;} //has to wait to spawn
		else {
			timing -= Time.deltaTime; //this means if the time is zero on the betweenspawning variable then it will spawn an object, thus i can time it to music

		}
		}
		
	}
