using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorret = false;
    public QuizManager quizManager;

    public void Answer()
    {
        if(isCorret)
        {
            Debug.Log("Resposta Correta");
            quizManager.corret();
        }
        else
        {
            Debug.Log("Resposta Incorreta");
            quizManager.corret();
        }
    }
}
