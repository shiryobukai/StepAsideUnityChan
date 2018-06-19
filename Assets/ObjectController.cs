using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {
    private GameObject unitychan;

	// Use this for initialization
	void Start () {
		
		       //Unityちゃんのオブジェクトを取得
                this.unitychan = GameObject.Find ("unitychan");
        
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z - unitychan.transform.position.z < -5){
			Destroy(this.gameObject);
		}
	}
}
