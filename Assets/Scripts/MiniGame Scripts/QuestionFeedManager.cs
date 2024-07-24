using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestionFeedManager : MonoBehaviour
{
    public AudioSource CorrectSFX;
    public AudioSource WrongSFX;
    public QuestionsFeed[] questionsFeeds;
    private static List<QuestionsFeed> unansweredQuestionFeeds;

    private QuestionsFeed currentQuestionFeed;

    private static int QuestionsLimit = 10;
    private static int QuestionsCounter = 0;

    private int GetRandomQuestionIndex;

    [SerializeField] private GameObject AnimalPlaceholder;
    [SerializeField] private GameObject EmptySprite;
    // [SerializeField] private TMP_Text AnimalPlaceholder;
    [SerializeField] private float timeBetweenQuestions = 1f;

    // Start is called before the first frame update

    void Start(){
        
        if (unansweredQuestionFeeds == null || unansweredQuestionFeeds.Count == 0){
            unansweredQuestionFeeds = questionsFeeds.ToList<QuestionsFeed>();
        }

        for (int i = 0; i<QuestionsLimit;i++){
            SetCurrentQuestionFeed();
        }

        if(QuestionsLimit == 0){
            SetCurrentQuestionFeed();
        }
    }

    void Update(){
        if(QuestionsCounter==QuestionsLimit){
            // EndGame
        }
    }

    void SetCurrentQuestionFeed(){
        GetRandomQuestionIndex = Random.Range(0, unansweredQuestionFeeds.Count);
        currentQuestionFeed = unansweredQuestionFeeds[GetRandomQuestionIndex];

        AnimalPlaceholder.GetComponent<SpriteRenderer>().sprite = currentQuestionFeed.Animal;
        QuestionsCounter++;
    }

    IEnumerator TransitionToNextQuestion (){
        unansweredQuestionFeeds.Remove(currentQuestionFeed);

        yield return new WaitForSeconds(timeBetweenQuestions);

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectMeat(){
        if(currentQuestionFeed.Meat){
            CorrectSFX.Play();
            print("CORRECT");
        }else{
            WrongSFX.Play();
            print("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
        Start();
    }

    public void UserSelectFish(){
        if(currentQuestionFeed.Fish){
            CorrectSFX.Play();
            print("CORRECT");
        }else{
            WrongSFX.Play();
            print("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
        Start();
    }

    public void UserSelectVegetation(){
        if(currentQuestionFeed.Vegetation){
            CorrectSFX.Play();
            print("CORRECT");
        }else{
            WrongSFX.Play();
            print("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
        Start();
    }

    public void UserSelectInsect(){
        if(currentQuestionFeed.Insect){
            CorrectSFX.Play();
            print("CORRECT");
        }else{
            WrongSFX.Play();
            print("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
        Start();
    }

    public void ResetQuestionsLimit(){
        if(QuestionsLimit ==10){
            QuestionsLimit = 0;
        }
    }
}
