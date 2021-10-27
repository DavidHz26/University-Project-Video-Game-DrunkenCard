using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignCard : MonoBehaviour
{
    public Image gameIMG;
    public Text gameTXT;
    public GameObject BG;
    public Color[] myColors;

    public List<CardSample> _gameDECK;

    //Cartas descartadas
    public List<CardSample> disCards;

    //Cartas Especiales
    public List<CardSample> spcCards;

    public int id = 0;

    public void CardsReady()
    {
        _gameDECK = gameObject.GetComponent<Shuffle>()._sDeck;
    }

    void Update()
    {
        if (_gameDECK.Count > 0)
        {
            gameIMG.sprite = _gameDECK[id]._image;
            gameTXT.text = _gameDECK[id]._text;

            AssignColor(id);
        }
    }

    void AssignColor(int _id)
    {
        if (_gameDECK[_id]._type == CardType.ABSOLUTA)
        {
            BG.GetComponent<Image>().color = myColors[0];
        }

        if (_gameDECK[_id]._type == CardType.MASACRE)
        {
            BG.GetComponent<Image>().color = myColors[1];
        }

        if (_gameDECK[_id]._type == CardType.VERSUS)
        {
            BG.GetComponent<Image>().color = myColors[2];
        }

        if (_gameDECK[_id]._type == CardType.FUGAZ)
        {
            BG.GetComponent<Image>().color = myColors[3];
        }

        if (_gameDECK[_id]._type == CardType.PROTECCION)
        {
            BG.GetComponent<Image>().color = myColors[4];

            if (!spcCards.Contains(_gameDECK[id]))
            {
                spcCards.Add(_gameDECK[id]);
                gameObject.GetComponent<spCards>().AddSpecial(_gameDECK[id]);

            }
        }
    }

    public void NextCard()
    {
        if (_gameDECK.Count > 0)
        {
            disCards.Add(_gameDECK[id]);
            _gameDECK.Remove(_gameDECK[id]);

            id = 0;

        }
    }
}
