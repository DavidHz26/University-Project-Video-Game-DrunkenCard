using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _Menus : MonoBehaviour
{
    //Menus
    public GameObject MainMenu;
    public GameObject PlayersReg;
    public GameObject AddMenu;
    public GameObject PlayersMenu;
    public GameObject LanguageMenu;
    public GameObject SettingsMenu;
    public GameObject GameMenu;
    public GameObject SpecialMenu;
    public GameObject TemporizerMenu;

    public void Register()
    {
        MainMenu.SetActive(false);
        PlayersReg.SetActive(true);
        PlayersMenu.SetActive(false);
        LanguageMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        GameMenu.SetActive(false);
    }

    public void Add()
    {
        AddMenu.SetActive(true);
        GameObject.Find("GameController").gameObject.GetComponent<Register>().CleanNS();
    }

    public void AddSuccesfull()
    {
        AddMenu.SetActive(false);
    }

    public void EnablePlayersMenu()
    {
        PlayersMenu.SetActive(true);
    }

    public void DisablePlayersMenu()
    {
        PlayersMenu.SetActive(false);
    }

    public void Languages()
    {
        MainMenu.SetActive(false);
        PlayersReg.SetActive(false);
        PlayersMenu.SetActive(false);
        LanguageMenu.SetActive(true);
        SettingsMenu.SetActive(false);
        GameMenu.SetActive(false);
        SpecialMenu.SetActive(false);
        TemporizerMenu.SetActive(false);
    }

    public void Settings()
    {
        MainMenu.SetActive(false);
        PlayersReg.SetActive(false);
        PlayersMenu.SetActive(false);
        LanguageMenu.SetActive(false);
        SettingsMenu.SetActive(true);
        GameMenu.SetActive(false);
        SpecialMenu.SetActive(false);
        TemporizerMenu.SetActive(false);
    }

    //Administración
    public void Players()
    {
        MainMenu.SetActive(false);
        PlayersReg.SetActive(false);
        PlayersMenu.SetActive(true);
        LanguageMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        GameMenu.SetActive(false);
        SpecialMenu.SetActive(false);
        TemporizerMenu.SetActive(false);
    }

    public void Main()
    {
        MainMenu.SetActive(true);
        PlayersReg.SetActive(false);
        PlayersMenu.SetActive(false);
        LanguageMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        GameMenu.SetActive(false);
        SpecialMenu.SetActive(false);
        TemporizerMenu.SetActive(false);
    }

    public void ToGame()
    {
        if (GameObject.Find("GameController").GetComponent<Register>().myPlayers.Count > 1)
        {
            GameMenu.SetActive(true);
            MainMenu.SetActive(false);
            PlayersReg.SetActive(false);
            PlayersMenu.SetActive(false);
            LanguageMenu.SetActive(false);
            SettingsMenu.SetActive(false);
            SpecialMenu.SetActive(false);
            TemporizerMenu.SetActive(false);

            GameObject.Find("Deck").GetComponent<Deck>().CreateCards();
        }
    }

    public void ReturnToGame()
    {
        GameMenu.SetActive(true);
        MainMenu.SetActive(false);
        PlayersReg.SetActive(false);
        PlayersMenu.SetActive(false);
        LanguageMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        SpecialMenu.SetActive(false);
        TemporizerMenu.SetActive(false);

        gameObject.GetComponent<Temporizer>().myLock = false;

    }

    public void SpCards()
    {
        GameMenu.SetActive(false);
        MainMenu.SetActive(false);
        PlayersReg.SetActive(false);
        PlayersMenu.SetActive(false);
        LanguageMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        SpecialMenu.SetActive(true);
        TemporizerMenu.SetActive(false);

    }

    public void TemporizerOn()
    {
        GameMenu.SetActive(false);
        MainMenu.SetActive(false);
        PlayersReg.SetActive(false);
        PlayersMenu.SetActive(false);
        LanguageMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        SpecialMenu.SetActive(false);
        TemporizerMenu.SetActive(true);

        gameObject.GetComponent<Temporizer>().Seconds = 1000;
        gameObject.GetComponent<Temporizer>().myLock = true;


    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
