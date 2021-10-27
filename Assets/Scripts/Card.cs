using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum CardType
{
    //ROJO,
    //VERDE,
    //AZUL

    ABSOLUTA,
    PROTECCION,
    MASACRE,
    VERSUS,
    FUGAZ
}
[System.Serializable]
public class CardSample
{
    public Sprite _image;
    public string _text;
    public CardType _type;

    public CardSample(Sprite _img, string _txt, CardType _typ)
    {
        _image = _img;
        _text = _txt;
        _type = _typ;
    }
}


public class Card : MonoBehaviour
{   

}
