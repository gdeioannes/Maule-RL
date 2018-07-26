using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleWorkshopController : MonoBehaviour {

    public GameObject info1;
    public GameObject infoFinal;
    public GameObject moveContainer;
    public GameObject badGear;
    public GameObject goodGear;
    public ParticleSystem badGearParticle;
    public GameObject replaceGear;
    public GameObject lever;
    private bool part5Flag = false;

	// Use this for initialization
	void Start () {
        info1.SetActive(true);
        moveContainer.SetActive(false);
        badGear.GetComponent<MeshCollider>().enabled = false;
        infoFinal.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void part1(){
        info1.SetActive(false);
        moveContainer.SetActive(true);
    }

    public void part2(){
        if (badGear.activeSelf){
            badGearParticle.Play();
            badGear.GetComponent<Animator>().SetBool("badGear", true);
            goodGear.GetComponent<Animator>().SetBool("badSpin", true);
            lever.GetComponent<Animator>().SetBool("on", true);
            StartCoroutine(stopBadGear());
            SoundManager.instance.playClipSfx(11);
        }

        if(part5Flag){
            if(!replaceGear.GetComponent<Animator>().GetBool("spin")){
                replaceGear.GetComponent<Animator>().SetBool("spin", true);
                goodGear.GetComponent<Animator>().SetBool("spin", true); 
                lever.GetComponent<Animator>().SetBool("on", true);
                SoundManager.instance.playClipSfx(17);

                infoFinal.SetActive(true);
            }else{
                replaceGear.GetComponent<Animator>().SetBool("spin", false);
                goodGear.GetComponent<Animator>().SetBool("spin", false);    
                lever.GetComponent<Animator>().SetBool("on", false);
                SoundManager.instance.playClipSfx(12);
            }

        }


    }

    IEnumerator stopBadGear(){
        yield return new WaitForSeconds(6f);
        badGear.GetComponent<MeshCollider>().enabled = true;
        badGear.GetComponent<Animator>().SetBool("badGear", false);
        goodGear.GetComponent<Animator>().SetBool("badSpin", false);
        lever.GetComponent<Animator>().SetBool("on", false);
    }

    public void part3(){
        badGear.SetActive(false);
        SoundManager.instance.playClipSfx(2);
    }

    public void part4()
    {
        if (!badGear.activeSelf)
        {
            replaceGear.GetComponent<Animator>().SetBool("replace", true);
            replaceGear.GetComponent<MeshCollider>().enabled = true;
            SoundManager.instance.playClipSfx(3);
            part5Flag = true;
        }
    }





}
