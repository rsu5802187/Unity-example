using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButton : MonoBehaviour
{
    public enum WindowState {
        none =0,
        menu =1,
        language =2,
        account =3
    }
    public WindowState windowState = WindowState.none;
    public GameObject menu;

    public void _MenuOptionButton_Enter()
    {
        if(windowState == (WindowState)0)
        {
            windowState = WindowState.menu;
            menu.SetActive(true);
            menu.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void _MenuOption_Quit()
    {
        windowState = WindowState.none;
        menu.SetActive(false);
    }

    public void _Menu_LanguageButtonClick()
    {
        windowState = WindowState.language;
    }

    public void _Menu_AccountButtonClick()
    {
        windowState = WindowState.account;
    }


}
