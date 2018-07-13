using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePath : MonoBehaviour {
    
    public List<Transform> nodes= new List<Transform>();

	// Use this for initialization
	void Start () {
        foreach (Transform child in gameObject.transform)
        {
            nodes.Add(child);
        }
    }

    // Update is called once per frame
	void Update () {
		
	}
}
