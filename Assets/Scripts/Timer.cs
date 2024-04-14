using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    
    public bool loadNextQuestion;
    public bool isAnsweringQuestion = false;
    public float fillFraction;
    float timerValue;

    void Update() {
        UpdateTimer();
    }
    public void CancelTimer(){
        timerValue=0;
    }
    void UpdateTimer() {
        timerValue-=Time.deltaTime;
        if (timerValue<=0&&isAnsweringQuestion)
        {
            timerValue=timeToShowCorrectAnswer;
            isAnsweringQuestion = false;
            Debug.Log("I'm showing answer");
        }else if (timerValue>0&&isAnsweringQuestion)
        {
            fillFraction = timerValue/timeToCompleteQuestion;
        }else if (timerValue<=0&&!isAnsweringQuestion)
        {
            timerValue=timeToCompleteQuestion;
            isAnsweringQuestion = true;
            loadNextQuestion = true;
        }else if (timerValue>0&&!isAnsweringQuestion)
        {
            fillFraction = timerValue/timeToShowCorrectAnswer;
        }
        Debug.Log(isAnsweringQuestion + ": " + timerValue + " = " + fillFraction);
    }
}
