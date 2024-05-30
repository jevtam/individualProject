using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private TowerActivator _towerActivator;
    [SerializeField] private PlayButton _playButton;

    public void StartGameLoop() => SetGameLoop(1, true, false);

    public void EndGameLoop()
    {
        SetGameLoop(0, false, true);
        _towerActivator.DeactivateTowers();
    }

    private void SetGameLoop(float timeScale, bool activateBird, bool activateButton )
    {
        Time.timeScale = timeScale;
        _bird.gameObject.SetActive(activateBird);
        _playButton.gameObject.SetActive(activateButton);
    }
}