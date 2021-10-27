using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shuffle : MonoBehaviour
{
    public int _size;
    public List<Sprite> imgS;
    public List<string> textS;

    public List<CardSample> _sDeck;

    public bool _lock;

    // Update is called once per frame
    void Update()
    {
        _size = gameObject.GetComponent<Deck>().size;
            if (_lock)
            {
                for (int i = 0; i <= _size; i++)
                {
                    int randNum = Random.Range(0, _size);

                    if (!_sDeck.Contains(gameObject.GetComponent<Deck>().myDeck[randNum]))
                    {
                        _sDeck.Add(gameObject.GetComponent<Deck>().myDeck[randNum]);
                    }
                }

                if (_sDeck.Count == _size)
                {
                    gameObject.GetComponent<AssignCard>().CardsReady();
                    _lock = true;
                }
            }
    }
}
