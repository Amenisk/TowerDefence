using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject _firstMap;
    [SerializeField] private GameObject _canvas;

    public void StartGameAction()
    {
        _firstMap.SetActive(true);
        _canvas.SetActive(false);
    }
}
