using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public void OnButtonClick()
    {
        Debug.Log(gameObject.name);
        if(gameObject.name == "QuitButton")
        {
            Application.Quit();
        }
    }
}
