using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviour3DtwstScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			Debug.Log("Space");
		}
	}
}
