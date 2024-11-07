using System;
using TMPro;
using UnityEngine;

namespace millionaire
{
    public class QuizScreen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _question;
        [Space]
        [SerializeField] private AnswerOption _answerA;
        [SerializeField] private AnswerOption _answerB;
        [SerializeField] private AnswerOption _answerC;
        [SerializeField] private AnswerOption _answerD;

        public event Action<AnswerType> OnAnswerSelected;
        
        public void ShowQuestionData(QuestionData questionData)
        {
            _question.text = questionData.Question;
            
            _answerA.SetLabel(questionData.AnswerA);
            _answerB.SetLabel(questionData.AnswerB);
            _answerC.SetLabel(questionData.AnswerC);
            _answerD.SetLabel(questionData.AnswerD);
        }

        private void Start()
        {
            _answerA.OnClicked += OnAnswerClicked;
            _answerB.OnClicked += OnAnswerClicked;
            _answerC.OnClicked += OnAnswerClicked;
            _answerD.OnClicked += OnAnswerClicked;
        }

        private void OnAnswerClicked(AnswerType answerType) => OnAnswerSelected?.Invoke(answerType);
    }
}