using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerC
{

    public string mName;
    public string mGenre;

    public PlayerC(string _name, string _genre)
    {
        mName = _name;
        mGenre = _genre;
    }
}

public class Player : MonoBehaviour
{
  
}
