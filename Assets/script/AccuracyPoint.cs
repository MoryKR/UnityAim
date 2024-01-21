using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccuracyPoint : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetAccuracy();
    }
    public void SetAccuracy()
    {
        text.text = "Accuracy :" + Mathf.Round(Player.Accuracycount) + "%";
    }
}
