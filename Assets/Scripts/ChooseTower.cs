using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseTower : MonoBehaviour
{
    [SerializeField] GameObject _fireTowerPrefab;
    [SerializeField] GameObject _windTowerPrefab;
    [SerializeField] GameObject _waterTowerPrefab;
    [SerializeField] GameObject _electroTowerPrefab;

    public void PutUptower(int numberTower)
    {
        if(TowerPointPlace._point.childCount == 0)
        {
            switch (numberTower)
            {
                case 1:
                    Instantiate(_fireTowerPrefab, TowerPointPlace._point);
                    _fireTowerPrefab.transform.position = new Vector3(-2.1f, 15.6f, 0);
                    break;

                case 2:
                    Instantiate(_windTowerPrefab, TowerPointPlace._point);
                    _windTowerPrefab.transform.position = new Vector3(-2.1f, 15.6f, 0);
                    break;

                case 3:
                    Instantiate(_waterTowerPrefab, TowerPointPlace._point);
                    _waterTowerPrefab.transform.position = new Vector3(-2.1f, 15.6f, 0);
                    break;

                case 4:
                    Instantiate(_electroTowerPrefab, TowerPointPlace._point);
                    _electroTowerPrefab.transform.position = new Vector3(-2.1f, 15.6f, 0);
                    break;

                default:
                    break;

            }
        }      
    }
}
