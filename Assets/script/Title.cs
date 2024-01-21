using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public static bool GameStart=false;
    public GameObject OptionP;

    public void ClickStart()
    {
        Debug.Log("GameStart");
        SceneManager.LoadScene("AimTraining");
        Pause.GamePaused = false;
        GameStartOn();
        GameStart = true;
        Time.timeScale = 1;
    }

    public static void GameStartOn()
    {
        TargetSpawn.GameTimer = 30;
        Player.hitcount = 0;
        Player.Accuracycount = 0;
    }
    /*public static void GameStartOff()
    {
        TargetSpawn.GameTimer = 0;
    }*/
    public void ClickOption()
    {
        OptionP.SetActive(true);
        Debug.Log("Option");

    }
    public void ClickExit()
    {
        Application.Quit();
    }
    public void BackToMenu()
    {
        OptionP.SetActive(false);
    }

    public void DifficultyEasy()
    {
        TargetSpawn.SpawnCycle = 1f;
        Target.DestroyCycle = 4f;
    }
    public void DifficultyHard()
    {
        TargetSpawn.SpawnCycle = 0.5f;
        Target.DestroyCycle = 2f;
    }
}
