using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;
using TMPro;

public class SaveInitSettings : MonoBehaviour
{

    Resolution[] resolutionsStart;

    [SerializeField] TMP_InputField UsernameInput;
    // public TMP_Dropdown difficultyDropdown;
    private int TempResolutionIndex;

    // Set warning text variable
    public Button SaveBtn;
    public TMP_Text WarningTextField;
    private string UsernameName;
    private string WarningText;
    
    void Start(){
        resolutionsStart = Screen.resolutions;
        for(int i = 0; i < resolutionsStart.Length; i++){
            if(resolutionsStart[i].width == Screen.currentResolution.width && 
            resolutionsStart[i].height == Screen.currentResolution.height){
                TempResolutionIndex = i;
            }
        }
    }

    void Update(){
        WarningTextField.text = WarningText;
        UsernameName = UsernameInput.text;
        ValidateUsername();
    }

    public void SaveInitData(){
        
        // preset settings if no settings was initially set
        PlayerPrefs.SetString("Player Pref Username",UsernameInput.text);
        PlayerPrefs.SetInt("Player Pref Resolution Index",TempResolutionIndex);
        PlayerPrefs.SetInt("Player Pref IsFullscreen",1);
        PlayerPrefs.SetInt("Settings Has Set",1);
        PlayerPrefs.SetInt("Settings Init Was Set",1);
        PlayerPrefs.Save();
    }

    void ValidateUsername(){
       WarningText="";

        // Define the regex pattern
        string pattern = @"^[a-zA-Z0-9@\-_\. ]+$";                  // check if alphanumerals, with @ . - _ characters
        string pattern2 = @"^[0-9@\-_\. ]+$";                       // check if no alphabets and is only 1 character
        string pattern3 = @"^[^a-zA-Z]*([a-zA-Z][^a-zA-Z]*){0,1}$"; // Username must contain one alphabetic characters or fewer


        // Use the Matches method to find matches in the input string
        bool isMatch = Regex.IsMatch(UsernameName, pattern);
        bool isMatch2 = Regex.IsMatch(UsernameName, pattern2);
        bool isMatch3 = Regex.IsMatch(UsernameName, pattern3);
        

        if(UsernameName == ""){
            WarningText="Username is empty!";
            SaveBtn.interactable = false;
        }else if( !isMatch ){
            WarningText = "Username contains illegal characters!";
            SaveBtn.interactable = false;
        }else if(isMatch2||isMatch3){
            WarningText="Enter a valid name!";
            SaveBtn.interactable = false;
        }else{
            WarningText = "";
            SaveBtn.interactable = true;
        }
    }
}
