using UnityEngine;

namespace Quiz.ScriptableObjects
{
    [CreateAssetMenu(fileName = "QuestionScriptableObject", menuName = "ScriptableObjects/Question")]
    public class QuestionScriptableObject : ScriptableObject
    {
        // Definições das variavéis das questões
        #region VARIABLES

        [TextArea]
        public string question; // Texto da questões
        [TextArea]
        public string[] answers; // Resposta
        public int answerRightIndex; // Index da Resposta Certa
        [TextArea(1, 100)]
        public string questionRightDescription; // Descricão da resposta certa

        #endregion
    }
}