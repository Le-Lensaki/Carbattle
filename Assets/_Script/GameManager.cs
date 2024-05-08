using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    private void Awake()
    {
        GameManager.instance = this;
    }


    public virtual void GamePLay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GamePlay");
    }

    public virtual void MenuGame()
    {
        SceneManager.LoadScene("Menu");
        
    }

    public virtual void GameOver()
    {
        Time.timeScale = 0;
        UIManager.instance.gameover = true;
        UIManager.instance.GameOver();

        AudioManager.instance.StopMusic();
        AudioManager.instance.PlaySFX("GameOver");

    }

    public virtual void GameReplay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public virtual void ExitGame()
    {
        Application.Quit();
    }
    
    public virtual void GamePause()
    {
        Debug.Log("Pause");
        switch (Time.timeScale)
        {
            case 1:
                Time.timeScale = 0;
                AudioManager.instance.StopMusic();
                UIManager.instance.OpenSetting();

                break;
            case 0:
                Time.timeScale = 1;
                AudioManager.instance.PlayMusic("CarRun");
                UIManager.instance.CloseSetting();
                break;
        }

    }    
}
