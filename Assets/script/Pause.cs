using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject MenuPanel;
    public static bool GamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        if (Title.GameStart)
        {
            MenuPanel.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused == true)
            {
                Continue();
            }
            else
            {
                PauseOn();
            }
        }
        
    }

    public void PauseOn()
    {
        Time.timeScale = 0f; //시간 정지
        MenuPanel.SetActive(true);
        GamePaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Continue()
    {
        Time.timeScale = 1f; //시간 정지 해제
        MenuPanel.SetActive(false);
        GamePaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("Continue");
    }
    public void GameExit()
    {
        SceneManager.LoadScene("GameStart");
        Debug.Log("Exit");

    }
}
