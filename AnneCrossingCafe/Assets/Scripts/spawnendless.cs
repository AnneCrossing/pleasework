using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnendless : MonoBehaviour {
	public GameObject enemyone;
	// Use this for initialization
	void Start () {
		Instantiate(enemyone, transform.position, Quaternion.identity);
	
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
