using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class mySlots{
    public int id;

    public Image Slot1;
    public Image Slot2;
    public Image Slot3;

    public string Text1;
    public string Text2;
    public string Text3;

    public mySlots(int _id, Image _is1, Image _is2, Image _is3, string _t1, string _t2, string _t3)
    {
        id = _id;

        Slot1 = _is1;
        Slot2 = _is2;
        Slot3 = _is3;

        Text1 = _t1;
        Text2 = _t2;
        Text3 = _t3;
    }

}

public class Slots : MonoBehaviour
{
}
