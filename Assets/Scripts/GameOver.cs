using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public LevelSO levelSO;
    public void Setup() 
    { 
        gameObject.SetActive(true);
    }
    public void NextButton() 
    {
        levelSO.Value += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartButton() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MenuButton() 
    {
        SceneManager.LoadScene("Menu");
    }
    public void FirstLevel()
    {
        levelSO.Value += 1;
        SceneManager.LoadScene("Level 1");
    }
}
