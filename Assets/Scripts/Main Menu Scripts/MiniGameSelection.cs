using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniGameSelection : MonoBehaviour
{
    public Button[] buttons;

    public void EnterArea(string Minigame){
        SceneManager.LoadScene(Minigame);
    }
}
