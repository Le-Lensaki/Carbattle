using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static public UIManager instance;

    public GameObject btnGameOver;

    public GameObject btnGamePause;

    public GameObject btnGamePlay;

    public GameObject btnMenuGame;

    public GameObject btnExitGame;

    public Text txtScore;

    int score;

    public bool gameover;

    private void Awake()
    {
        UIManager.instance = this;

        this.btnGamePlay = GameObject.Find("BtnGamePlay");
        this.btnGameOver = GameObject.Find("BtnReplay");
        this.btnGamePause = GameObject.Find("BtnPauseGame");
        this.btnMenuGame = GameObject.Find("BtnMenuGame");
        this.btnExitGame = GameObject.Find("BtnExitGame");

        GameObject txt = GameObject.Find("TxtScore");
        if(txt != null) this.txtScore = txt.GetComponent<Text>();

        score = 0;
        gameover = false;

        //this.btnGamePause.SetActive(false);
        if(this.btnGameOver != null) this.btnGameOver.SetActive(false);
        if (this.btnMenuGame != null) this.btnMenuGame.SetActive(false);
        if (this.btnExitGame != null) this.btnExitGame.SetActive(false);
    }

    public void OpenSetting()
    {
        if (this.btnMenuGame != null) this.btnMenuGame.SetActive(true);
        if (this.btnExitGame != null) this.btnExitGame.SetActive(true);
    }

    public void CloseSetting()
    {
        if (this.btnMenuGame != null) this.btnMenuGame.SetActive(false);
        if (this.btnExitGame != null) this.btnExitGame.SetActive(false);
    }

    public void Update()
    {
        if(txtScore != null) this.txtScore.text = "Score: " + score;

    }

    public void GameOver()
    {
        if(gameover)
        {
            this.btnGameOver.SetActive(true);
            this.btnMenuGame.SetActive(true);
            this.btnExitGame.SetActive(true);
            this.btnGamePause.SetActive(false);
        }    
    }    

    public virtual void scoreUpdate()
    {
        if(!gameover)  score += 1;
    }

    


}
