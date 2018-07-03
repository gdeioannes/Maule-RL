using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingAnimation : MonoBehaviour {

    public static LoadingAnimation instance;
    public Animator rigth;
    public Animator left;

	// Use this for initialization
	void Start () {
        if(instance==null){
            instance = this;
        }
       
	}
	
	// Update is called once per frame

    public void animateIn(){
        rigth.SetBool("In", true);
        rigth.SetBool("Out", false);
        left.SetBool("In", true);
        left.SetBool("Out", false);
    }

    public void animateOut()
    {
        rigth.SetBool("In", false);
        rigth.SetBool("Out", true);
        left.SetBool("In", false);
        left.SetBool("Out", true);
    }

}
