using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMode : MonoBehaviour
{
    public int gameMode;

    public void Mode_1()
    {
        gameMode = 1;
        GameObject Mode1 = GameObject.Find("Mode1");
        Slider tmp_slider = Mode1.transform.GetChild(2).gameObject.GetComponent<Slider>();
        float _value = tmp_slider.value;
        if (_value == 1)
            GameObject.Find("GameController").gameObject.GetComponent<_Menus>().Register();
    }
}
