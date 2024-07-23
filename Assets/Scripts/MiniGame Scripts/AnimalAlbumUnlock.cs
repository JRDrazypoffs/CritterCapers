using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalAlbumUnlock : MonoBehaviour
{
    public Button[] AnimalButtons;
    private string KeyName = "Player Pref Animal ";

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0;i<AnimalButtons.Length;i++){
            if(PlayerPrefs.HasKey(KeyName+i)){
                AnimalButtons[i].interactable = true;
            }else{
                AnimalButtons[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
