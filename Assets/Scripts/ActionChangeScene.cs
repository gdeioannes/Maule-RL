using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionChangeScene : MonoBehaviour {

    public void changeScene(string name){
        StartCoroutine( ChangeScene.instance.goToScene(name));
    }

}
