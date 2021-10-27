using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsSlot : MonoBehaviour
{
    public List<mySlots> _mySlots;
    public List<CardSample> _SpecialCards;

    public int size;
    public int _turn;

    public List<int> _avaliable;

    public Image mainImage;
    public Text mainText;
    public GameObject BG;

    public string _BtnName;
    public Sprite defaultImg;

    // Update is called once per frame
    void Update()
    {
        _avaliable = GetComponent<Register>().Avaliable;
        _mySlots = GetComponent<Register>()._PlayerSlots;
        _SpecialCards = GameObject.Find("Deck").GetComponent<spCards>().SpecialCards;

        _turn = GameObject.Find("GameController").GetComponent<Game>().turn;
        _BtnName = GameObject.Find("GameController").GetComponent<Register>().BtnName;

        AssignCT();
        SetInfoSlots();
    }

    //When button clicked
    void AssignCT()
    {
        //Change image from player´s specific turn
        if (_BtnName == "Slot1" && _mySlots[_turn].id == _turn)
        {
            mainImage.sprite = _mySlots[_turn].Slot1.GetComponent<Image>().sprite;
            mainText.text = _mySlots[_turn].Text1;
        }

        else if (_BtnName == "Slot2" && _mySlots[_turn].id == _turn)
        {
            mainImage.sprite = _mySlots[_turn].Slot2.GetComponent<Image>().sprite;
            mainText.text = _mySlots[_turn].Text2;
        }

        else if (_BtnName == "Slot3" && _mySlots[_turn].id == _turn)
        {
            mainImage.sprite = _mySlots[_turn].Slot3.GetComponent<Image>().sprite;
            mainText.text = _mySlots[_turn].Text3;
        }
        else
        {
            //Empty image
            mainImage.sprite = defaultImg;
            mainText.text = "";
        }
    }

    //Set image and text from slots
    void SetInfoSlots()
    {
        if (_mySlots.Count > 0 && _avaliable.Count > 0 && _SpecialCards.Count > 0)
        {
            isSlotAv();

            if (_avaliable[_turn] == 1)
            {
                _mySlots[_turn].Slot1.GetComponent<Image>().sprite = _SpecialCards[0]._image;
                _mySlots[_turn].Text1 = _SpecialCards[0]._text;
                _SpecialCards.RemoveAt(0);
            }

            else if (_avaliable[_turn] == 2)
            {
                _mySlots[_turn].Slot2.GetComponent<Image>().sprite = _SpecialCards[0]._image;
                _mySlots[_turn].Text2 = _SpecialCards[0]._text;
                _SpecialCards.RemoveAt(0);
            }

            else if (_avaliable[_turn] == 3)
            {
                _mySlots[_turn].Slot3.GetComponent<Image>().sprite = _SpecialCards[0]._image;
                _mySlots[_turn].Text3 = _SpecialCards[0]._text;
                _SpecialCards.RemoveAt(0);
            }
        }
    }

    //Check if slots are avaliable
    void isSlotAv()
    {
        if (_mySlots[_turn].Slot1.GetComponent<Image>().sprite == defaultImg)
        {
            _avaliable[_turn] = 1;
            return;
        }

        else if (_mySlots[_turn].Slot2.GetComponent<Image>().sprite == defaultImg)
        {
            _avaliable[_turn] = 2;
            return;
        }

        else if (_mySlots[_turn].Slot3.GetComponent<Image>().sprite == defaultImg)
        {
            _avaliable[_turn] = 3;
            return;
        }
    }

    //Delete used cards from slots
    public void FreeSlot()
    {
        if (_BtnName == "Slot1" && _mySlots[_turn].Slot1.GetComponent<Image>().name != null)
        {
            mainImage.sprite = defaultImg;
            mainText.text = "";

            _mySlots[_turn].Slot1.GetComponent<Image>().sprite = defaultImg;
            _mySlots[_turn].Text1 = "";
        }

        if (_BtnName == "Slot2" && _mySlots[_turn].id == _turn && _mySlots[_turn].Slot2.GetComponent<Image>().name != null)
        {
            mainImage.sprite = defaultImg;
            mainText.text = "";

            _mySlots[_turn].Slot2.GetComponent<Image>().sprite = defaultImg;
            _mySlots[_turn].Text2 = "";
        }

        if (_BtnName == "Slot3" && _mySlots[_turn].id == _turn && _mySlots[_turn].Slot3.GetComponent<Image>().name != null)
        {
            mainImage.sprite = defaultImg;
            mainText.text = "";

            _mySlots[_turn].Slot3.GetComponent<Image>().sprite = defaultImg;
            _mySlots[_turn].Text3 = "";
        }
    }
}
