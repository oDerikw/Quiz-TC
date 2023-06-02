using Quiz.ScriptableObjects;
using Quiz.Prefab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Quiz.Manager
{
    public class GameManager : MonoBehaviour
    {
        [Header("Parameters")]
        //[SerializeField] private int limitMaxQuestions = 5;
        //[SerializeField] private int timeMaxQuestionInSeconds = 60;

        [Header("Questions")]
        [SerializeField] private QuestionScriptableObject[] questionScriptableObjects;

        [Header("UserInterfaceGeneral")]
        [SerializeField] private GameObject[] screens;
        [SerializeField] private AnswerPrefab answerPrefab;
        [SerializeField] private Button startGameButton;

        [Header("QuestionScreen")]
        [SerializeField] private TMP_Text questionIdText;
        [SerializeField] private TMP_Text questionDescription;
        [SerializeField] private TMP_Text questionCounterText;
        [SerializeField] private Transform rootAnswers;
        //[SerializeField] private Slider timerSlider;
        [SerializeField] private Button restartGameQuestionButton;
        [SerializeField] private Button nextQuestionQuestionButton;


        #region MONOBEHAVIOUR_METHODS

        private void OnEnable()
        {
            AnswerPrefab.OnAnswerClick += OnAnswerClick_Handler;
            //timerSlider.onValueChanged.AddListener(TimerSliderOnValueChanged_Handler);
            //startGameButton.onClick.AddListener(StartGameButton_Handler);
            //homeButton.onClick.AddListener(HomeButton_Handler);
            //nextQuestionFeedbackButton.onClick.AddListener(() => NextQuestionButton_Handler(false));
            //nextQuestionQuestionButton.onClick.AddListener(() => NextQuestionButton_Handler(false));
            //restartGameFeedbackButton.onClick.AddListener(OnRestartClick_Handler);
            //restartGameQuestionButton.onClick.AddListener(OnRestartClick_Handler);
        }

        private void OnDisable()
        {
            AnswerPrefab.OnAnswerClick -= OnAnswerClick_Handler;
        }

        #endregion

        #region PRIVATE_METHODS
        private void OnAnswerClick_Handler(bool isRigth)
        {
            Debug.Log($"User right question = {isRigth}");
            //SetupFeedbackScreen(isRigth);
        }
        #endregion
    }
}
