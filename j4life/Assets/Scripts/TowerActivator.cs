using System.Collections.Generic;
using UnityEngine;

public class TowerActivator : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private TowerFactory _towerFactory;
    [SerializeField] private ActivatePoint[] _activatePoints;

    private List<Tower> _activatedTowerPool = new List<Tower>();

    private float _passedTime;

    public void DeactivateTowers()
    {
        for (int i = 0; i < _activatedTowerPool.Count; i++)
        {
            _activatedTowerPool[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        _passedTime += Time.deltaTime;

        if (_passedTime >= _delay) 
        {
            if (_towerFactory.TryGetTower(out Tower createdTower))
            {
                createdTower.transform.position = _activatePoints[Random.Range(0, _activatePoints.Length)].transform.position;
                createdTower.gameObject.SetActive(true);
                _activatedTowerPool.Add(createdTower);

                _passedTime = 0;
            }
        }
    }
}