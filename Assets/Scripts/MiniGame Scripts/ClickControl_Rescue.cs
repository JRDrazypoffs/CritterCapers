using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class ClickControl_Rescue : MonoBehaviour
{
    // public static string ObjectName;
    // public GameObject ObjectNameText;
    public Transform ObjectPos;
    public Transform SuccessClick;
    public AudioSource FoundSound;

    public TMP_Text CounterText;

    void Start(){

    }
    // Start is called before the first frame update
    void Update()
    {
        CounterText.text = CheckEmptyContainer.ObjectCounter.ToString()+"/5";
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
