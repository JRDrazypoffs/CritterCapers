using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ClickControl_Rescue : MonoBehaviour
{
    // public static string ObjectName;
    // public GameObject ObjectNameText;
    public Transform ObjectPos;
    public Transform SuccessClick;
    public AudioSource FoundSound;

    // private int AnimalCount = 0;


    // Start is called before the first frame update
    void Update()
    {
        // if(AnimalCount == 4){
        //     PauseGame.GameIsPaused=true;
        //     Debug.Log("All rescued");
        // }
    }
    private void OnMouseDown(){
        Instantiate(SuccessClick, ObjectPos.position, SuccessClick.rotation);
        Destroy (gameObject);
        // AnimalCount++;
        FoundSound.Play();
    }

}
