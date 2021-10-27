using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public List<PlayerC> _myPlayers;

    public int turn;
    public int numPlayers;

    public Text turnName;

    public void SetNumPlayers()
    {
        _myPlayers = gameObject.GetComponent<Register>().myPlayers;

        numPlayers = _myPlayers.Count;
    }

    void Update()
    {
        if (_myPlayers.Count > 0 && GameObject.Find("Deck").GetComponent<AssignCard>()._gameDECK.Count > 0)
        {
            turnName.text = _myPlayers[turn].mName;
        }
    }

    // Update is called once per frame
    public void NextTurn()
    {
        if (turn < numPlayers - 1)
            turn += 1;
        else
            turn = 0;
    }
}
