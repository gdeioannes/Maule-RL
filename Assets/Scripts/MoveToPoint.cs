using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour {

    public float timeToMove=-1;
    public GameObject path;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void moveToPoint(){
        if(path==null){
            AnimateCamera.instance.startCameraMovement(gameObject,timeToMove);
        }else{
            AnimateCamera.instance.startCameraMovementPath(gameObject, timeToMove,path);
        }
	}
}
