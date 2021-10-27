using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    //Mobile
    Vector2 touchPos;
    Vector2 endTouch;

    //Desktop
    Vector3 mousePos;
    Vector3 endPos;

    float maxRange = 15;
    

    // Update is called once per frame
    void Update()
    {
        DesktopSwipe();
    }

    void DesktopSwipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;

            if (endPos.x < mousePos.x - maxRange)
            {
                if (GameObject.Find("Game") != null)
                {
                    GameObject.Find("Deck").GetComponent<AssignCard>().NextCard();
                    GameObject.Find("GameController").GetComponent<Game>().NextTurn();
                }
            }
        }
    }

    
}
