using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetText();
    }

    public void SetText()
    {
        text.text = "Score :" + Player.hitcount.ToString();
    }
}