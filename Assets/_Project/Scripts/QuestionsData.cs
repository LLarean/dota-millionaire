using System.Collections.Generic;
using UnityEngine;

namespace millionaire
{
    [CreateAssetMenu(fileName = "Questions", menuName = "Scriptable Objects/Questions")]
    public class QuestionsData : ScriptableObject
    {
        public List<QuestionData> Questions;
    }
}