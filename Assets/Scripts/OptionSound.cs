using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionSound : MonoBehaviour
{
    public GameObject optionSound;
    public GameObject startMenu;


    public void OnClickBack()
    {
        optionSound.SetActive(false);
        startMenu.SetActive(true);
    }
}
