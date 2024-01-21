using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TargetSpawn : MonoBehaviour
{
    public GameObject rangeObject;
    BoxCollider rangeCollider;
    GameObject GameStart;
    public GameObject GameEnd;
    public static int GameTimer = 30;
    public static float TargetNum = 0;
    public Text text;
    public Text text2;
    public static float SpawnCycle = 1f;
    

    private void Awake()
    {
        rangeCollider = rangeObject.GetComponent<BoxCollider>();
    }

    Vector3 Return_RandomPosition()
    {
        Vector3 originPosition = rangeObject.transform.position;
        float range_X = rangeCollider.bounds.size.x;
        float range_Y = rangeCollider.bounds.size.y;

        range_X = Random.Range((range_X / 2) * -1, range_X / 2);
        range_Y = Random.Range((range_Y / 2) * -1, range_Y / 2);
        Vector3 RandomPostion = new Vector3(range_X, range_Y, 0f);


        Vector3 respawnPosition = originPosition + RandomPostion;
        return respawnPosition;
    }
    public GameObject target;
    private void Start()
    {
        if(Title.GameStart == true)
        {
            StartCoroutine(RandomRespawn_Coroutine());
            StartCoroutine(Timer_Coroutine());
            GameEnd.SetActive(false);
        }

    }

    private void Update()
    {
        /*Debug.Log(GameTimer);*/
        if (GameTimer == 0)
        {
            StopAllCoroutines();
            GameOver();
        }
    }

    public void GameOver()
    {
        GameEnd.SetActive(true);
        text2.text = "Score : " + Player.hitcount.ToString() + "  " +
            "Accuracy : " + Mathf.Round(Player.Accuracycount) + "%";
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;

    }
    public void BackToMain()
    {
        SceneManager.LoadScene("GameStart");
        Title.GameStart = false;
    }

    IEnumerator RandomRespawn_Coroutine()
    {
        
        while (true)
        {
            
            yield return new WaitForSeconds(SpawnCycle);

            GameObject instantTarget = Instantiate(target, Return_RandomPosition(), Quaternion.identity);

            Target.targetOn = true;

            TargetNum++;

        }
    }
    IEnumerator Timer_Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            GameTimer--;
        }
    }

}
