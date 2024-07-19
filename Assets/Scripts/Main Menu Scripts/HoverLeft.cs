using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HoverLeft : MonoBehaviour
{
    public GameObject SignLeft;
    public Animator signAnimatorLeft;

    public AudioSource PopSound;

    public static int SoundTrigger = 0;

    // SFXPlayOnce sfxPlayOnce;//DIdnt behave as intended SMH
    // private void Awake(){
    //     sfxPlayOnce = GameObject.FindGameObjectWithTag("Audio").GetComponent<SFXPlayOnce>();
    // }


    // This Script uses sprite data not UI button data
    public void Start(){
    }

    // public void Update(){
    // }

    public void OnMouseOver(){
        SignLeft.SetActive(true);
        SignLeft.SetActive(true);
        signAnimatorLeft.Play("SignAnimationInLeft");

        // sfxPlayOnce.PlaySFX(sfxPlayOnce.PopSFX); >:( behaves weirdly SMH

        // use this silly method to stop the system from playing the sfx in infinite loop until triggered
        SoundTrigger++;
        if(SoundTrigger==10000){
            SoundTrigger=0;
        }

        // let sfx audio only play once
        if(SoundTrigger==1){
            PopSound.Play();
        }
    }



    public void OnMouseExit(){
        // signAnimator.Play("SignAnimationOut");
        SignLeft.SetActive(false);
        SignLeft.SetActive(false);
        PopSound.Stop();
        SoundTrigger=0;

    }

    // Keep for reference, the Map uses the UI buttons layered over the sprites.
    // Sprites are used to use the on mouse over function for the sign animation.
    
    // public void OnMouseDown(){
    //     // EnterArea(AreaName);
    // }
    // public void EnterArea(string AreaName){
    //     SceneManager.LoadScene(AreaName);
    // }

}
