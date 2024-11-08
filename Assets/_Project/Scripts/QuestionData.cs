using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace millionaire
{
    [CreateAssetMenu(fileName = "Question", menuName = "Scriptable Objects/Question")]
    public class QuestionData : ScriptableObject
    {
        public string Question;
        public AnswerType CorrectAnswer;
        public List<AnswerData> Answers = new List<AnswerData>()
        {
            new()
            {
                Type = AnswerType.A,
                Text = "Ответ А",
            },
            new()
            {
                Type = AnswerType.B,
                Text = "Ответ B",
            },
            new()
            {
                Type = AnswerType.C,
                Text = "Ответ C",
            },
            new()
            {
                Type = AnswerType.D,
                Text = "Ответ D",
            }
        };

        [Button]
        public void SetCorrectAnswer()
        {
            foreach (var answerData in Answers)
            {
                if (answerData.Type == CorrectAnswer)
                {
                    answerData.Text = answerData.Text + " (правильный)";
                }
            }
        }
    }
}