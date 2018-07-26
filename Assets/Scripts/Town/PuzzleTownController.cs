using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTownController : MonoBehaviour {

    public GameObject firstInfo;
    public GameObject secondInfo;
    public GameObject pathMovCollider;
    public GameObject workshopCollider;

	// Use this for initialization
	void Start () {
        secondInfo.SetActive(false);
        pathMovCollider.SetActive(false);
        workshopCollider.SetActive(false);
	}

    public void firtPart(){
        firstInfo.SetActive(false);
        pathMovCollider.SetActive(true);
    }

    public void secondPart()
    {
        pathMovCollider.SetActive(false);
        secondInfo.SetActive(true);
    }

    public void thirdPart()
    {
        secondInfo.SetActive(false);
        workshopCollider.SetActive(true);
    }

}
