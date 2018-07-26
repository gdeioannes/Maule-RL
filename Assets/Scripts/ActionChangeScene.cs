using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionChangeScene : MonoBehaviour {

    public void changeScene(string name){
        StartCoroutine(ChangeScene.instance.goToScene(name));

    }

    public void resetGame(){
        Destroy(GameObject.Find("DontDestroy"));
        StartCoroutine(ChangeScene.instance.goToScene("MainUI"));
    }

}
