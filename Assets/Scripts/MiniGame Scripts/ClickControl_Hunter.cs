using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ClickControl_Hunter : MonoBehaviour
{
    public GameObject ObjectLabel;
    public Transform ObjectPos;
    public Transform SuccessClick;
    public AudioSource FoundSound1;
    public AudioSource FoundSound2;
    private int RandomNumber = 0;
    // private int HunterCount = 0;
    // Start is called before the first frame update
    void Update()
    {
        // use unityengibe.random because got conflict
        RandomNumber = UnityEngine.Random.Range(0,2);

        // if(HunterCount == 7){
        //     PauseGame.GameIsPaused = true;
        // }

    }
    private void OnMouseDown(){

        Destroy (gameObject);
        Destroy (ObjectLabel);

        if(RandomNumber==0){
            FoundSound1.Play();
        }else{
            FoundSound2.Play();
        }
        
        Instantiate(SuccessClick, ObjectPos.position, SuccessClick.rotation);
    }

}
