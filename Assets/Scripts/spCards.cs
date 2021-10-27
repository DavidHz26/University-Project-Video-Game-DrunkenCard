using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spCards : MonoBehaviour
{
    public List<GameObject> PlayersSlots;

    public List<CardSample> SpecialCards;

    // Start is called before the first frame update

    public void AddSpecial(CardSample _card)
    {
        SpecialCards.Add(_card);
    }
}
