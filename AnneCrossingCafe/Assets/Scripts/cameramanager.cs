using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramanager : MonoBehaviour {
	public float ypos;
	public float xpos;
	public float cameraspeed;
	public Transform target;
    void LateUpdate()
    {
        Vector3 pos = new Vector3(Mathf.Clamp(target.position.x, -xpos, xpos), Mathf.Clamp(target.position.y, -ypos, ypos), transform.position.z); // creates a 3d vector //mathf.clamp limits the movement to the ypos
        transform.position = Vector3.Lerp(transform.position, pos, cameraspeed * Time.deltaTime); //lerping is the transformation of an object over a decided time frame hehe 
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
