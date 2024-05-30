using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public event UnityAction<int> ScoreChanged;
    private int score;

    public void ResetScore() => score = 0;

    public void AddScore()
    {
        score++;
        ScoreChanged?.Invoke(score);
    }
}