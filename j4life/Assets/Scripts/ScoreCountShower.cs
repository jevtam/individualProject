using UnityEngine;
using UnityEngine.UI;

public class ScoreCountShower : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private Text _scoreText;

    private void OnEnable() => _score.ScoreChanged += OnScoreChanged;
    private void OnDisable() => _score.ScoreChanged -= OnScoreChanged;
    private void OnScoreChanged(int score) => _scoreText.text = score.ToString();
}