using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TowerFactory : MonoBehaviour
{
    [SerializeField] private int _count;
    [SerializeField] private Tower _tower;
    [SerializeField] private SpawnContainer _towerContainer;

    private List<Tower> _createdTowerPool = new List<Tower>();

    public bool TryGetTower(out Tower createdTower)
    {
        createdTower = _createdTowerPool.First(x => x.gameObject.activeSelf == false);
        return createdTower != null;
    }


    private void CreateTowers()
    {
        for (int i = 0; i < _count; i++)
        {
            Tower createdTower = Instantiate(_tower, _towerContainer.transform);
            createdTower.gameObject.SetActive(false);

            _createdTowerPool.Add(createdTower);
        }
    }

    private void Start() => CreateTowers();
}