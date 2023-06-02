using UnityEngine;

namespace Quiz.ScriptableObjects
{
    [CreateAssetMenu(fileName = "QuestionScriptableObject", menuName = "ScriptableObjects/Question")]
    public class QuestionScriptableObject : ScriptableObject
    {
        // Defini��es das variav�is das quest�es
        #region VARIABLES

        [TextArea]
        public string question; // Texto da quest�es
        [TextArea]
        public string[] answers; // Resposta
        public int answerRightIndex; // Index da Resposta Certa
        [TextArea(1, 100)]
        public string questionRightDescription; // Descric�o da resposta certa

        #endregion
    }
}