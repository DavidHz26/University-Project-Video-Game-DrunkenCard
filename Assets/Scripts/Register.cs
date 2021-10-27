using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    //Listas de jugadores
    public List<string> PNames;
    public List<string> PGenres;

    public List<PlayerC> myPlayers;

    //Campos de datos
    public InputField Name_field;
    public GameObject RegSV_Cont;
    public GameObject PlysSV_Cont;

    //Sprites Genero
    public Sprite[] Genres;
    Sprite MainS;

    //Prefabs
    public GameObject RegCenter;
    public GameObject PlysCenter;
    public GameObject NamePrefab;
    public GameObject PlayersCards;

    public List<mySlots> _PlayerSlots;

    public List<int> Avaliable;

    //Variables
    string act_genre;

    public int cont;

    int slot_id;
    public string BtnName;
    public Button Male;
    public Button Female;
    Color cmale, cfemale;

    private void Start()
    {
        cmale = Male.GetComponent<Image>().color;
        cfemale = Female.GetComponent<Image>().color;
    }

    public void CleanNS()
    {
        Name_field.text = "";
        act_genre = null;
        Male.GetComponent<Image>().color = cmale;
        Female.GetComponent<Image>().color = cfemale;
    }

    public void RemovePlayer()
    {
        if (cont >= 0)
        {
            cont -= 1;
            PNames.RemoveAt(cont);
            PGenres.RemoveAt(cont);
            Avaliable.RemoveAt(cont);
            myPlayers.RemoveAt(cont);
            _PlayerSlots.RemoveAt(cont);
            slot_id--;

            RegCenter.transform.position = new Vector3(RegCenter.transform.position.x, RegCenter.transform.position.y + 180, RegCenter.transform.position.z);
            PlysCenter.transform.position = new Vector3(PlysCenter.transform.position.x, PlysCenter.transform.position.y + 200, PlysCenter.transform.position.z);

            GameObject.Find("GameController").GetComponent<_Menus>().EnablePlayersMenu();

            GameObject _GO = GameObject.Find("Registro" + cont.ToString());
            GameObject _PL = GameObject.Find("Jugador" + cont.ToString());

            Destroy(_GO);
            Destroy(_PL);

            GameObject.Find("GameController").gameObject.GetComponent<_Menus>().DisablePlayersMenu();
        }
    }

    public void RegSuccesfull()
    {
        if (Name_field.text != null && act_genre != null)
        {
            PNames.Add(Name_field.text);
            PGenres.Add(act_genre);
            Avaliable.Add(-1);

            PlayerC tempP = new PlayerC(PNames[cont], PGenres[cont]);

            if (!myPlayers.Contains(tempP))
            {
                myPlayers.Add(tempP);
                gameObject.GetComponent<Game>().SetNumPlayers();
            }

            GameObject Reg = Instantiate(NamePrefab);
            Reg.name = "Registro" + cont.ToString();
            Reg.transform.position = RegCenter.transform.position;
            Reg.transform.SetParent(RegSV_Cont.transform);
            Reg.transform.localScale = new Vector2(5f, 5f);
            Reg.transform.GetChild(0).gameObject.GetComponent<Text>().text = PNames[cont];
            Reg.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = MainS;

            GameObject Plys = Instantiate(PlayersCards);
            Plys.name = "Jugador" + cont.ToString();
            Plys.transform.position = PlysCenter.transform.position;
            Plys.transform.SetParent(PlysSV_Cont.transform);
            Plys.transform.localScale = new Vector2(3.5f, 3.5f);
            Plys.transform.GetChild(0).gameObject.GetComponent<Text>().text = PNames[cont];

            Plys.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() => BtnClicked(1));
            Plys.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(() => BtnClicked(2));
            Plys.transform.GetChild(3).GetComponent<Button>().onClick.AddListener(() => BtnClicked(3));

            _PlayerSlots.Add(new mySlots(slot_id, Plys.transform.GetChild(1).transform.GetComponent<Image>(), Plys.transform.GetChild(2).transform.GetComponent<Image>(), Plys.transform.GetChild(3).transform.GetComponent<Image>(), " ", " ", " "));
            slot_id++;

            cont += 1;
            RegCenter.transform.position = new Vector3(RegCenter.transform.position.x, RegCenter.transform.position.y - 180, RegCenter.transform.position.z);
            PlysCenter.transform.position = new Vector3(PlysCenter.transform.position.x, PlysCenter.transform.position.y - 200, PlysCenter.transform.position.z);

            gameObject.GetComponent<_Menus>().AddSuccesfull();
        }
    }

    void BtnClicked(int id)
    {
        if(BtnName != null)
        {
            BtnName = "";
        }

        if(id == 1)
        {
            BtnName = "Slot1";
            gameObject.GetComponent<_Menus>().SpCards();
        }

        if (id == 2)
        {
            BtnName = "Slot2";
            gameObject.GetComponent<_Menus>().SpCards();
        }

        if (id == 3)
        {
            BtnName = "Slot3";
            gameObject.GetComponent<_Menus>().SpCards();
        }
    }

    public void Genre_W()
    {
        Female.GetComponent<Image>().color = Color.gray;
        Male.GetComponent<Image>().color = cmale;
        MainS = Genres[0];
        act_genre = "Mujer";
    }

    public void Genre_M()
    {
        Male.GetComponent<Image>().color = Color.gray;
        Female.GetComponent<Image>().color = cfemale;
        MainS = Genres[1];
        act_genre = "Hombre";
    }
}
