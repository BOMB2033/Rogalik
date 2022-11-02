using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsControl : MonoBehaviour
{
    public string _startScene;
    public GameObject _panelConfig;

    public void StartGame()
    {
        if (!_panelConfig.active)
        {
            SceneManager.LoadScene(_startScene);
        }        
    }

    public void ConfSceneIn()
    {
        _panelConfig.SetActive(true); 
    }
    public void ConfSceneOut()
    {
        _panelConfig.SetActive(false);
    }
    public void Exit()
    {
        if (!_panelConfig.active)
        {
            Application.Quit();
        }
    }
}
