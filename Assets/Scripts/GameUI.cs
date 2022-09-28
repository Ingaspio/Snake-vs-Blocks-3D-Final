using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TMP_Text levelText;
    public LevelSO levelSO;
    void Update()
    {
        levelText.text = "Level: " + levelSO.Value.ToString();
        

        if (Input.GetKeyDown(KeyCode.R)) 
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
