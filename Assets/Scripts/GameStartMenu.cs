using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Game;
using TowerDefense.Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStartMenu : MonoBehaviour
{
    [SerializeField]
    private string mainSceneName;

    /// <summary>
    /// The data concerning the level this button displays
    /// </summary>
    protected LevelItem m_Item;


    /// <summary>
    /// When the user clicks the button, change the scene
    /// </summary>
    public void ButtonClicked()
    {
        ChangeScenes();
    }

    protected void ChangeScenes()
    {
        SceneManager.LoadScene(mainSceneName);
    }
}
