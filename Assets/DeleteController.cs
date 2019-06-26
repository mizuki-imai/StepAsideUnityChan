using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteController : MonoBehaviour {
	//Unityちゃんのオブジェクト
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {
		//Unityちゃんよりz座標が小さいとき
		if (unitychan.transform.position.z > this.transform.position.z){
			//アイテムを削除する
			Destroy(this.gameObject);
	}
}
}
