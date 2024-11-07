using UnityEngine;

namespace millionaire
{
    [CreateAssetMenu(fileName = "Question", menuName = "Scriptable Objects/Question")]
    public class QuestionData : ScriptableObject
    {
        public string Question;
        [Space]
        public string AnswerA;
        public string AnswerB;
        public string AnswerC;
        public string AnswerD;
        [Space]
        public AnswerType RightAnswer;
    }
}