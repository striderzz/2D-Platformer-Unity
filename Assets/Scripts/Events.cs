using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene("Level");
    }
    public void Level()
    {
        SceneManager.LoadScene("Level");
    }
}
