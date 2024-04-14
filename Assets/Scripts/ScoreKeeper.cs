using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    int correctAnswer = 0;
    int questionsSeen = 0;

    public int GetCorrectAnswer(){
        return correctAnswer;
    } 
    public void IncrementCorrectAnswers(){
        correctAnswer++;
    }
    public int GetQuestionsSeen(){
        return questionsSeen;
    } 
    public void IncrementQuestionsSeen(){
        questionsSeen++;
    }
    public int CalculateScore(){
        return Mathf.RoundToInt(correctAnswer / (float)questionsSeen * 100);
    }
}
