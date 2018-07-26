using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRoomController : MonoBehaviour {
    public Animator doll;
    public Animator information;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PartOne()
    {
        doll.gameObject.GetComponent<CapsuleCollider>().enabled = false;
        doll.SetBool("Mov1", true);
        information.gameObject.SetActive(true);
        information.SetBool("Up", true);
    }
}
