using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}


	//オブジェクトが画面外に出た時(ここでこまってます。)
	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}


}
