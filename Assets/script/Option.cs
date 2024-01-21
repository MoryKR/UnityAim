using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public GameObject OptionP;
    public Slider Xsens;
    public Slider Ysens;
    
    // Start is called before the first frame update
    void Start()
    {
        OptionP.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Sens();
    }

    void OptionOn()
    {
        OptionP.SetActive(true);
    }

    void Sens()
    {
        PlayerCamera.camXspeed = Xsens.value;
        PlayerCamera.camYspeed = Ysens.value;

    }

}
