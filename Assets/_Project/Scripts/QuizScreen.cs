using System;
using TMPro;
using UnityEngine;

namespace millionaire
{
    public class QuizScreen : MonoBehaviour
    {
        [SerializeField] private HintOption _hint1;
        [SerializeField] private HintOption _hint2;
        [SerializeField] private HintOption _hint3;
        [Space]
        [SerializeField] private TextMeshProUGUI _question;
        [Space]
        [SerializeField] private AnswerOption _answerA;
        [SerializeField] private AnswerOption _answerB;
        [SerializeField] private AnswerOption _answerC;
        [SerializeField] private AnswerOption _answerD;
        
        private AnswerType _currentAnswer;

        public event Action<HintType> OnHintSelected;
        public event Action<AnswerType> OnAnswerSelected;
        
        public void ShowQuestionData(QuestionData questionData)
        {
            _question.text = questionData.Question;

            // _answerA.SetLabel(questionData.AnswerA);
            // _answerB.SetLabel(questionData.AnswerB);
            // _answerC.SetLabel(questionData.AnswerC);
            // _answerD.SetLabel(questionData.AnswerD);
        }
        
        public void ShowCorrectAnswer()
        {
            throw new NotImplementedException();
        }

        public void ShowIncorrectAnswer()
        {
            throw new NotImplementedException();
        }
        
        public void ShowCorrect()
        {
            var result = _currentAnswer switch  
            {
                AnswerType.A => _answerA,
                AnswerType.B => _answerB,
                AnswerType.C => _answerC,
                AnswerType.D => _answerD,
            };
            
            result.ShowCorrect();
        }

        public void ShowError()
        {
            var result = _currentAnswer switch  
            {
                AnswerType.A => _answerA,
                AnswerType.B => _answerB,
                AnswerType.C => _answerC,
                AnswerType.D => _answerD,
            };
            
            result.ShowError();
        }
        
        public void ShowFiftyFifty()
        {
            // ShowHint(correctAnswer);
        }

        public void ShowHint(AnswerType correctAnswer)
        {
            var result = correctAnswer switch  
            {
                AnswerType.A => _answerA,
                AnswerType.B => _answerB,
                AnswerType.C => _answerC,
                AnswerType.D => _answerD,
            };
            
            result.ShowHint();
        }

        private void Start()
        {
            _hint1.OnClicked += OnHintClicked;
            _hint2.OnClicked += OnHintClicked;
            _hint3.OnClicked += OnHintClicked;
            
            _answerA.OnClicked += OnAnswerClicked;
            _answerB.OnClicked += OnAnswerClicked;
            _answerC.OnClicked += OnAnswerClicked;
            _answerD.OnClicked += OnAnswerClicked;
        }

        private void OnAnswerClicked(AnswerType answerType)
        {
            _currentAnswer = answerType;
            OnAnswerSelected?.Invoke(answerType);
        }

        private void OnHintClicked(HintType hintType)
        {
            OnHintSelected?.Invoke(hintType);
        }
    }
}