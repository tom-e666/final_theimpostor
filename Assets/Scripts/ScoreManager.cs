using UnityEngine;
using UnityEngine.UI; // Import the UnityEngine.UI namespace

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    private int temporaryScore = 0;

    [SerializeField] private Text cherryText; // Reference to the UI Text component

    private void Awake()
    {
        // Get the initial temporary score from the ScoreData
        temporaryScore = scoreData.score;
        UpdateCherryText();
    }

    public void AddToTemporaryScore(int pointsToAdd)
    {
        temporaryScore += pointsToAdd;
        UpdateCherryText();
    }

    public int GetTemporaryScore()
    {
        return temporaryScore;
    }
    public void UpdatePermanentScore()
    {
        scoreData.score = temporaryScore;
        temporaryScore = 0;
        UpdateCherryText();
    }

    private void UpdateCherryText()
    {
        if (cherryText != null)
        {
            cherryText.text = string.Format("Cherries: {0}", temporaryScore);
        }
    }
}
