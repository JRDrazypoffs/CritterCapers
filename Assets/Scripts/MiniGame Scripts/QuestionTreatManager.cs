using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class QuestionTreatManager : MonoBehaviour
{
    public QuestionsTreat[] questionsTreats;
    private static List<QuestionsTreat> unansweredQuestionTreats;

    private QuestionsTreat currentQuestionTreat;

    [SerializeField]
    private GameObject AnimalPlaceholder;

    // Start is called before the first frame update
    void Start()
    {
        if (unansweredQuestionTreats == null|| unansweredQuestionTreats.Count == 0){
            unansweredQuestionTreats = questionsTreats.ToList<QuestionsTreat>();

        }

        currentQuestionTreat.Animal = AnimalPlaceholder;

        SetCurrentQuestionTreat();
    }

    void SetCurrentQuestionTreat(){
        int GetRandomQuestionIndex = Random.Range(0, unansweredQuestionTreats.Count);
        currentQuestionTreat = unansweredQuestionTreats[GetRandomQuestionIndex];

        unansweredQuestionTreats.RemoveAt(GetRandomQuestionIndex);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
