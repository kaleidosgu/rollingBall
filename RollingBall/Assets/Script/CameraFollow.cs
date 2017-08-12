using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform leftTrans;
    public Transform rightTrans;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float newX = (leftTrans.position.x + rightTrans.position.x) / 2;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
	}
}
