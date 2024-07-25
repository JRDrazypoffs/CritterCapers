using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidePanelManager : MonoBehaviour
{
    public GameObject[] Slides;

    public GameObject NextBtn;
    public GameObject BackBtn;
    // public GameObject PlayBtn;

    public GameObject HelpPanel;

    public GameObject MiniGameUIPanel;

    private int SlideIndex;

    
    // Start is called before the first frame update
    void Start()
    {
        int CurrentScore = PlayerPrefs.GetInt("Player Pref Total Score");

        if(CurrentScore == 0 || MiniGameUIPanel.activeSelf==true){
            PauseTheGame();
            HelpPanel.SetActive(true);
        }else {
            HelpPanel.SetActive(false);
        }

        for (int i = 0; i < Slides.Length; i++){
            Slides[i].SetActive(false);
            if(i==0){
                Slides[i].SetActive(true);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Slides.Length; i++){
            Slides[i].SetActive(false);
            if(i==SlideIndex){
                Slides[i].SetActive(true);
            }
        }

        if(SlideIndex==0){
            NextBtn.SetActive(true);
            BackBtn.SetActive(false);
            // PlayBtn.SetActive(false);
        }else if(SlideIndex==Slides.Length-1){
            NextBtn.SetActive(false);
            BackBtn.SetActive(true);
            // PlayBtn.SetActive(true);
        }else{
            NextBtn.SetActive(true);
            BackBtn.SetActive(true);
            // PlayBtn.SetActive(false);
        }

        if(HelpPanel.activeSelf==false){
            ResumeTheGame();
        }
    }

    public void NextSlide(){
        SlideIndex++;
    }
    public void PrevSlide(){
        SlideIndex--;
    }
    public void PauseTheGame(){
        // PauseMenu.SetActive(true);
        Time.timeScale = 0;
        // GameIsPaused = true;
    }
    public void ResumeTheGame(){
        // PauseMenu.SetActive(false);
        Time.timeScale = 1;
        // GameIsPaused = false;
    }

}
