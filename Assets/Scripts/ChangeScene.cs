using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public static ChangeScene instance; 

	// Use this for initialization
	void Start () {
        if(instance==null){
            instance = this;
        }
	}
	
    public IEnumerator goToScene(string name){
        LoadingAnimation.instance.animateIn();
        yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(name);
        yield return null;
	}

    private void OnLevelWasLoaded(int level){
        Debug.Log("Animate Out");
        LoadingAnimation.instance.animateOut();

    }

	// Update is called once per frame
	void Update () {
		
	}
}
