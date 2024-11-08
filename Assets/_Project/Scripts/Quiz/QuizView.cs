using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace millionaire
{
    public class QuizView : MonoBehaviour
    {
        [SerializeField] private List<HintOption> _hintOptions;
        [SerializeField] private TextMeshProUGUI _question;
        [SerializeField] private List<AnswerOption> _answerOptions;

        public event Action<HintType> OnHintSelected;
        public event Action<AnswerType> OnAnswerSelected;
        
        public void ShowQuestion(in QuestionData questionData)
        {
            _question.text = questionData.Question;

            foreach (var answerOption in _answerOptions)
            {
                foreach (var answerData in questionData.Answers)
                {
                    if (answerOption.Type == answerData.Type)
                    {
                        answerOption.SetLabel(answerData.Text);
                    }
                }
            }
        }

        public void DisableSelectedHint(HintType hintType)
        {
            foreach (var hintOption in _hintOptions)
            {
                if (hintOption.Type == hintType)
                {
                    hintOption.Disable();
                }
            }
        }

        public void ShowHint(AnswerType answerType)
        {
            foreach (var answerOption in _answerOptions)
            {
                if (answerOption.Type == answerType)
                {
                    answerOption.ShowHint();
                }
            }
        }

        private void Start()
        {
            foreach (var hintOption in _hintOptions)
            {
                hintOption.OnClicked += SelectHint;
            }

            foreach (var answerOption in _answerOptions)
            {
                answerOption.OnClicked += SelectAnswer;
            }
        }

        private void SelectHint(HintType hintType) => OnHintSelected?.Invoke(hintType);
        
        private void SelectAnswer(AnswerType answerType) => OnAnswerSelected?.Invoke(answerType);
        
    }
}