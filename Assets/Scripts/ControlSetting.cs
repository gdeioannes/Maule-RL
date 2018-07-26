using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using System;

public class ControlSetting : MonoBehaviour {

    public GameObject Gvr;
    public GameObject GvrNoCardBoard;
    public GameObject PlayerTouch;
    public GameObject control;

    // Use this for initialization
    void Awake()
    {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeScene(string controlName){
        StartCoroutine( ChangeScene.instance.goToScene("PiezaPedro"));
        SoundManager.instance.playClipMusic(2);
        switch(controlName){
            case "VR":
            control = Gvr;
                StartCoroutine(SwitchToVR());
                break;

            case "G":
                control = Gvr;
                StartCoroutine(SwitchToVR());
                break;

            case "T":
                control = PlayerTouch;
                break;
        }

    }

    public void goToVideo()
    {
        Application.OpenURL("https://vimeo.com/281734759");
    }

    private void OnLevelWasLoaded(int level)
    {
        Debug.Log("Change Level");
        GameObject spawn= GameObject.Find("SpawnPlayer");
        GameObject player = Instantiate(control);
        player.transform.position = spawn.transform.position;
        player.transform.rotation= spawn.transform.rotation;
    }

    // Call via `StartCoroutine(SwitchToVR())` from your code. Or, use
    // `yield SwitchToVR()` if calling from inside another coroutine.
    IEnumerator SwitchToVR()
    {
        // Device names are lowercase, as returned by `XRSettings.supportedDevices`.
        string desiredDevice = "cardboard"; // Or "cardboard".

        // Some VR Devices do not support reloading when already active, see
        // https://docs.unity3d.com/ScriptReference/XR.XRSettings.LoadDeviceByName.html
        if (String.Compare(XRSettings.loadedDeviceName, desiredDevice, true) != 0)
        {
            XRSettings.LoadDeviceByName(desiredDevice);

            // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
            yield return null;
        }

        // Now it's ok to enable VR mode.
        XRSettings.enabled = true;
    }

}
