using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void goToScene(string name){
		SceneManager.LoadScene(name);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
