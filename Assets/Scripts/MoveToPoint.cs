﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour {

    public float timeToMove=-1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void moveToPoint(){
        AnimateCamera.instance.startCameraMovement(gameObject,timeToMove);
	}
}
