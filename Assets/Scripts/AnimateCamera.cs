using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCamera : MonoBehaviour {

    private float timeToMove = -1f;
    public static AnimateCamera instance;
    public GameObject player;
    private GameObject point;
    private bool moveFlag = true;

	// Use this for initialization
	void Start () {
        if(instance==null){
            instance = this;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startCameraMovement(GameObject obj,float time){
        if(point!=null){
            point.SetActive(true);
        }
        point = obj;
        point.SetActive(false);
        timeToMove = time;
        //player.transform.position = obj.transform.position;
        StartCoroutine(animateMovement());
    }

    private IEnumerator animateMovement(){
        float elapseTime = 0f;
        Vector3 startPosition = player.transform.position;
        Vector3 newPosition = point.transform.position;
        float time;
        if(timeToMove==-1){
            time = Vector3.Distance(startPosition, newPosition) / 5;
        }else{
            time = timeToMove;
        }
        while(elapseTime<time){
                player.transform.position = Vector3.Lerp(startPosition,newPosition,(elapseTime/time));
                elapseTime += Time.deltaTime;
            yield return null;
        }
        yield return null;

    }

}
