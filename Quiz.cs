using TMPro;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [System.Serializable]
    public class Question
    {
        public string prompt;
        public string answer;
    }

    public Question[] questions;

    public TMP_Text questionText;
    public TMP_InputField answerInput;
    public TMP_Text feedbackText;

    private int currentQuestionIndex = 0;

    void Start()
    {
        ShowQuestion();
        feedbackText.text = "";
        answerInput.onSubmit.AddListener(CheckAnswer);
    }

    void ShowQuestion()
    {
        if (currentQuestionIndex < questions.Length)
        {
            questionText.text = questions[currentQuestionIndex].prompt;
            answerInput.text = ""; // This wipes the question after you answer
            feedbackText.text = "";
            answerInput.ActivateInputField();
        }
        else
        {
            questionText.text = "YOU WIN. NOW GO AWAY AND NEVER COME BACK."; // The end text. (amazing i know)
            feedbackText.text = "";
            answerInput.gameObject.SetActive(false);
        }
    }

    public void CheckAnswer(string userAnswer)
    {
        string correctAnswer = questions[currentQuestionIndex].answer.Trim().ToLower();
        string userInput = userAnswer.Trim().ToLower();

        if (userInput == correctAnswer)
        {
            feedbackText.text = "Correct";
            currentQuestionIndex++;
            Invoke(nameof(ShowQuestion), 1f); // Delay so you can actually read the correct message lmao
        }
        else
        {
            feedbackText.text = "INCORRECT. TRY AGAIN IDIOT";
            answerInput.ActivateInputField();
        }
    }
}
