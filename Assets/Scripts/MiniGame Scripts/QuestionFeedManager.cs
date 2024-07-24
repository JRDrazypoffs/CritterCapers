using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.PackageManager;

public class QuestionFeedManager : MonoBehaviour
{
    public AudioSource BGMPlayer;
    public AudioSource CorrectSFX;
    public AudioSource WrongSFX;
    public AudioSource LevelCompleteSound;
    public GameObject LevelCompletePanel;
    public GameObject Timer;

    public TMP_Text SuccessMessage;
    public TMP_Text AreaScoreText;
    public TMP_Text TotalScoreText;
    public QuestionsFeed[] questionsFeeds;
    private static List<QuestionsFeed> unansweredQuestionFeeds;

    private QuestionsFeed currentQuestionFeed;

    // private static int QuestionsLimit = 10;
    private int QuestionsCounter;

    private int GetRandomQuestionIndex;

    private int ErrorScore;
    private int CorrectScore;

    private string Username;

    private int TempAreaTotalScore;
    private int AreaScore;
    [SerializeField] float RemainingTime;

    private float TimeScore;
    private float TotalTime;
    private float TimePercent;
    private static float TimeBonusScore = 5;
    private static int PenaltyScore = 2;
    private static float FullPercent = 1;

    private int Counter;
    private bool isCorrect;


    [SerializeField] private GameObject AnimalPlaceholder;
    [SerializeField] private GameObject EmptySprite;
    // [SerializeField] private TMP_Text AnimalPlaceholder;
    [SerializeField] private float timeBetweenQuestions = 1f;

    // Start is called before the first frame update
    void Awake(){
        string TempUsername = PlayerPrefs.GetString("Player Pref Username");
        int TempTotalScore = PlayerPrefs.GetInt("Player Pref Total Score");
        Username = TempUsername;
        TempAreaTotalScore = TempTotalScore;
        TotalTime = RemainingTime;
        QuestionsCounter = questionsFeeds.Length;
    }

    void Start(){
        
        if (unansweredQuestionFeeds == null || unansweredQuestionFeeds.Count == 0){
            unansweredQuestionFeeds = questionsFeeds.ToList<QuestionsFeed>();
        }
        SetCurrentQuestionFeed();
    }

    void Update(){
        // Count Down
        if(RemainingTime > 0){
            RemainingTime -= Time.deltaTime;
        }else if(RemainingTime < 0){
            RemainingTime = 0;
        }

        if(CorrectScore+ErrorScore == QuestionsCounter){
            Counter++;
        }

        if (Counter == 1){
            print("Area Cleared");
            Destroy(Timer);
            BGMPlayer.Stop();
            LevelCompleteSound.Play();
            LevelCompletePanel.SetActive(true);
            AddScore();
            SuccessMessage.text = "<b>Congratulations</b> <color=#60B2D7><b>"+ Username + "</b></color>! \nYou have <color=green><b>completed</b></color> this level!";
            AreaScoreText.text = AreaScore.ToString();
            TotalScoreText.text = TempAreaTotalScore.ToString();
        }
    }

    void SetCurrentQuestionFeed(){
        GetRandomQuestionIndex = Random.Range(0, unansweredQuestionFeeds.Count);
        currentQuestionFeed = unansweredQuestionFeeds[GetRandomQuestionIndex];

        AnimalPlaceholder.GetComponent<SpriteRenderer>().sprite = currentQuestionFeed.Animal;
        // QuestionsCounter++;
    }

    IEnumerator TransitionToNextQuestion (){
        unansweredQuestionFeeds.Remove(currentQuestionFeed);

        if (isCorrect){
            TimePercent = RemainingTime/TotalTime*FullPercent;
            print("TimePercent: "+TimePercent);
            TimeScore += TimePercent*TimeBonusScore;
            print("TimeScore: "+TimeScore);
        }
        
        yield return new WaitForSeconds(timeBetweenQuestions);

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Start();
    }

    public void UserSelectMeat(){
        if(currentQuestionFeed.Meat){
            CorrectScore++;
            isCorrect=true;
            CorrectSFX.Play();
            print("CORRECT");
        }else{
            ErrorScore++;
            isCorrect=false;
            WrongSFX.Play();
            print("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
        // Start();
    }

    public void UserSelectFish(){
        if(currentQuestionFeed.Fish){
            CorrectScore++;
            isCorrect=true;
            CorrectSFX.Play();
            print("CORRECT");
        }else{
            ErrorScore++;
            isCorrect=false;
            WrongSFX.Play();
            print("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
        // Start();
    }

    public void UserSelectVegetation(){
        if(currentQuestionFeed.Vegetation){
            CorrectScore++;
            isCorrect=true;
            CorrectSFX.Play();
            print("CORRECT");
        }else{
            ErrorScore++;
            isCorrect=false;
            WrongSFX.Play();
            print("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
        // Start();
    }

    public void UserSelectInsect(){
        if(currentQuestionFeed.Insect){
            CorrectScore++;
            isCorrect=true;
            CorrectSFX.Play();
            print("CORRECT");
        }else{
            ErrorScore++;
            isCorrect=false;
            WrongSFX.Play();
            print("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
        // Start();
    }

    public void AddScore(){
        int TotalErrorScore = ErrorScore*PenaltyScore;
        AreaScore+=(int)System.Math.Floor(TimeScore);

        if(AreaScore-TotalErrorScore<0){
            AreaScore=0;
        }else{
            AreaScore-=TotalErrorScore;
        }
        
        TempAreaTotalScore+=AreaScore;
        PlayerPrefs.SetInt("Player Pref Total Score",TempAreaTotalScore);
    }

}
