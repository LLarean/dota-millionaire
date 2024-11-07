using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace millionaire
{
    public class QuizScreen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _question;
        [SerializeField] private List<Answer> _answers;

        public event Action<AnswerType> OnAnswerSelected;
        
        public void ShowQuestions(QuestionData questionData)
        {
            _question.text = questionData.Question;

            foreach (var answer in _answers)
            {
                switch (answer.Type)
                {
                    case AnswerType.A:
                        _answers[0].SetLabel(questionData.AnswerA);
                        break;
                    case AnswerType.B:
                        _answers[1].SetLabel(questionData.AnswerB);
                        break;
                    case AnswerType.C:
                        _answers[2].SetLabel(questionData.AnswerC);
                        break;
                    case AnswerType.D:
                        _answers[3].SetLabel(questionData.AnswerD);
                        break;
                }
            }
        }

        private void Start()
        {
            foreach (var answer in _answers)
            {
                answer.OnClicked += OnAnswerClicked;
            }
        }

        private void OnAnswerClicked(AnswerType answerType) => OnAnswerSelected?.Invoke(answerType);
    }
}