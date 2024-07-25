using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class AnimalUnlock : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        UnlockAnimals();
    }

    public void UnlockAnimals(){
        if(CheckEmptyContainer.CheckClear==true){
            if(AreaRandomiser.AreaRandomNumber==0){
                PlayerPrefs.SetInt("Player Pref Animal 0",1);
                PlayerPrefs.SetInt("Player Pref Animal 1",1);
                PlayerPrefs.SetInt("Player Pref Animal 2",1);
                PlayerPrefs.SetInt("Player Pref Animal 3",1);
                PlayerPrefs.SetInt("Player Pref Animal 4",1);
            }else if(AreaRandomiser.AreaRandomNumber==1){
                PlayerPrefs.SetInt("Player Pref Animal 5",1);
                PlayerPrefs.SetInt("Player Pref Animal 6",1);
                PlayerPrefs.SetInt("Player Pref Animal 7",1);
                PlayerPrefs.SetInt("Player Pref Animal 8",1);
                PlayerPrefs.SetInt("Player Pref Animal 9",1);
            }else if(AreaRandomiser.AreaRandomNumber==2){
                PlayerPrefs.SetInt("Player Pref Animal 10",1);
                PlayerPrefs.SetInt("Player Pref Animal 11",1);
                PlayerPrefs.SetInt("Player Pref Animal 12",1);
                PlayerPrefs.SetInt("Player Pref Animal 13",1);
                PlayerPrefs.SetInt("Player Pref Animal 14",1);
            }else if(AreaRandomiser.AreaRandomNumber==3){
                PlayerPrefs.SetInt("Player Pref Animal 15",1);
                PlayerPrefs.SetInt("Player Pref Animal 16",1);
                PlayerPrefs.SetInt("Player Pref Animal 17",1);
                PlayerPrefs.SetInt("Player Pref Animal 18",1);
                PlayerPrefs.SetInt("Player Pref Animal 19",1);
            }else if(AreaRandomiser.AreaRandomNumber==4){
                PlayerPrefs.SetInt("Player Pref Animal 20",1);
                PlayerPrefs.SetInt("Player Pref Animal 21",1);
                PlayerPrefs.SetInt("Player Pref Animal 22",1);
                PlayerPrefs.SetInt("Player Pref Animal 23",1);
                PlayerPrefs.SetInt("Player Pref Animal 24",1);
            }else if(AreaRandomiser.AreaRandomNumber==5){
                PlayerPrefs.SetInt("Player Pref Animal 1",1);
                PlayerPrefs.SetInt("Player Pref Animal 2",1);
                PlayerPrefs.SetInt("Player Pref Animal 12",1);
                PlayerPrefs.SetInt("Player Pref Animal 17",1);
                PlayerPrefs.SetInt("Player Pref Animal 19",1);
            }else if(AreaRandomiser.AreaRandomNumber==6){
                PlayerPrefs.SetInt("Player Pref Animal 3",1);
                PlayerPrefs.SetInt("Player Pref Animal 5",1);
                PlayerPrefs.SetInt("Player Pref Animal 1",1);
                PlayerPrefs.SetInt("Player Pref Animal 20",1);
                PlayerPrefs.SetInt("Player Pref Animal 21",1);
            }
        }
    }
}
