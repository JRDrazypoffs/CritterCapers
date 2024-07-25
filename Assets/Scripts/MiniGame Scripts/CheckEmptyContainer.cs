using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class CheckEmptyContainer : MonoBehaviour
{
    public List<GameObject> ObjectList = new List<GameObject>();
    public AudioSource LevelCompleteSound;
    public AudioSource BGMPlayer;

    public GameObject Timer;
    public GameObject LevelCompletePanel;

    public TMP_Text SuccessMessage;
    public TMP_Text AreaScoreText;
    public TMP_Text TotalScoreText;
    private string Username;

    private int TempAreaTotalScore;
    private int AreaScore;
    [SerializeField] float RemainingTime;

    private float TimeScore;
    private float TotalTime;
    private float TimePercent;
    private static float TimeBonusScore = 5;
    private static float FullPercent = 1;

    public static bool CheckClear = false;

    public static int ObjectCounter;

    // Start is called before the first frame update
    void Start(){
        ObjectCounter=0;
        string TempUsername = PlayerPrefs.GetString("Player Pref Username");
        int TempTotalScore = PlayerPrefs.GetInt("Player Pref Total Score");
        Username = TempUsername;
        TempAreaTotalScore = TempTotalScore;
        TotalTime = RemainingTime;
    }

    // Update is called once per frame
    void Update(){
        // Count Down
        if(RemainingTime > 0){
            RemainingTime -= Time.deltaTime;
        }else if(RemainingTime < 0){
            RemainingTime = 0;
        }

        for (int i = ObjectList.Count - 1; i >= 0; i--)
        {
            if (ObjectList[i] == null){
                ObjectList.RemoveAt(i);
                ObjectCounter++;
                TimePercent = RemainingTime/TotalTime*FullPercent;
                print("TimePercent: "+TimePercent);
                TimeScore += TimePercent*TimeBonusScore;
                print("TimeScore: "+TimeScore);
            }

            if (ObjectList.Count == 0){
                print("Area Cleared");
                Destroy(Timer);
                CheckClear = true;
                BGMPlayer.Stop();
                LevelCompleteSound.Play();
                LevelCompletePanel.SetActive(true);
                AddScore();
                SuccessMessage.text = "<b>Congratulations</b> <color=#60B2D7><b>"+ Username + "</b></color>! \nYou have <color=green><b>completed</b></color> this level!";
                AreaScoreText.text = AreaScore.ToString();
                TotalScoreText.text = TempAreaTotalScore.ToString();
            }
        }
    }

    public void AddScore(){
        AreaScore+=(int)System.Math.Floor(TimeScore);
        TempAreaTotalScore+=AreaScore;
        PlayerPrefs.SetInt("Player Pref Total Score",TempAreaTotalScore);
    }
}
