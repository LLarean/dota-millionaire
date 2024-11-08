using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace millionaire
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private QuizView _quizView;
        [Space]
        [SerializeField] private QuestionsData _easyQuestions;
        [SerializeField] private QuestionsData _middleQuestions;
        [SerializeField] private QuestionsData _hardQuestions;
        
        private void Start()
        {
            var quizModel = new QuizModel
            {
                Questions = GetQuestionList()
            };

            var quizPresenter = new QuizPresenter(quizModel, _quizView);
            quizPresenter.Launch();
        }

        private List<QuestionData> GetQuestionList()
        {
            List<QuestionData> questions = new List<QuestionData>();
            
            var randomQuestions = GetRandomQuestions(_easyQuestions.Questions, 5);
            questions.AddRange(randomQuestions);
            
            randomQuestions = GetRandomQuestions(_middleQuestions.Questions, 5);
            questions.AddRange(randomQuestions);
            
            randomQuestions = GetRandomQuestions(_hardQuestions.Questions, 5);
            questions.AddRange(randomQuestions);
            
            return questions;
        }
        
        private List<QuestionData> GetRandomQuestions(List<QuestionData> questionList, int count)
        {
            Random rand = new Random();

            return questionList
                .OrderBy(x => rand.Next())
                .Take(count)
                .ToList();
        }
    }
}