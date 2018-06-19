using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnviromentManager : MonoBehaviour {

	public static EnviromentManager _instance;
	public GameObject currentEnviroment;
	public GameObject enviromentContainer;
	public GameObject cameraContainer;
	public GameObject fadePanelSamsung;
	public GameObject fadePanelGoogle;
	private GameObject currentFadePanel;
	public bool thunderTriggerFlag=false;


	// Use this for initialization
	void Start () {
		if(_instance==null){
			_instance=this;
		}
	}

	// Update is called once per frame


	IEnumerator tunderEffect(GameObject newCurrectEnviroment){
		thunderTriggerFlag=true;
		float thunderChance=35;
		if(Random.Range(0,100)<thunderChance ){
			int counter=0;
			int counterMax=20;
			float waitMin=0.1f;
			float waitMax=0.3f;
			float wait=0.3f;
			float exposureMin=1f;
			float exposureMax=1.5f;
			float exposure=0.3f;
			yield return new WaitForSeconds(2);
			gameObject.GetComponents<AudioSource>()[1].Play();
			while(counter<counterMax){
				wait=Random.Range(waitMin,waitMax);
				exposure=Random.Range(exposureMin,exposureMax);
				newCurrectEnviroment.GetComponent<Renderer>().material.SetFloat("_Exposure",exposure);
				yield return new WaitForSeconds(wait);
				counter++;
			}

			newCurrectEnviroment.GetComponent<Renderer>().material.SetFloat("_Exposure",1);
		}
		yield return new WaitForSeconds(5);
		thunderTriggerFlag=false;
		yield return null;
	}
}
