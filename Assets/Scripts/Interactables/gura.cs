using Ink.Parsed;
using TMPro;
using UnityEngine;

public class Gura : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] private TMP_InputField Answer;

    [Header("Feedback")]
    [SerializeField] private TextMeshProUGUI feedbackText;

    [Header("Correct Answer")]
    [SerializeField] private int correctNumber = 7;

    private void Awake()
    {
        if (Answer == null) Debug.LogError("Answer (TMP_InputField) is NOT assigned!", this);
        if (feedbackText == null) Debug.LogError("feedbackText (TextMeshProUGUI) is NOT assigned!", this);

        // Hook event in code so it always fires correctly
        if (Answer != null)
            Answer.onEndEdit.AddListener(grabInputField);

        // Make sure feedback starts hidden (optional)
        if (feedbackText != null)
            feedbackText.gameObject.SetActive(false);
    }

    public void grabInputField(string input)
    {
        Debug.Log($"OnEndEdit fired. Raw input: '{input}'", this);

        if (feedbackText == null) return;

        if (string.IsNullOrWhiteSpace(input))
        {
            // If you want, show a message instead of doing nothing
            ShowFeedback("Type a number first.", Color.yellow);
            return;
        }

        if (int.TryParse(input.Trim(), out int playerNumber))
        {
            if (playerNumber == correctNumber)
                ShowFeedback("Gura is Proud", Color.green);
            else
                ShowFeedback("Gura is dissapointed", Color.red);
        }
        else
        {
            ShowFeedback("Please enter a number.", Color.yellow);
        }
    }

    private void ShowFeedback(string message, Color color)
    {
        feedbackText.text = message;
        feedbackText.color = color;
        feedbackText.gameObject.SetActive(true);
    }
}
