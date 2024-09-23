using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SeletButtom : MonoBehaviour
{
    
    [SerializeField] Text Text;

    private void Awake()
    {
        Text = GetComponentInChildren<Text>(); // 자식을 자동으로 찾음 
    }
    public void OnEnter()
    {
        Text.fontSize = 85;
    }

    public void OnLeave()
    {
        Text.fontSize = 75;
    }

    public void OnSelect ()
    {
        Text.fontSize = 50;
    }

  

    // public void OnPointerEnter(PointerEventData eventData)
    // {
    //     Text.GetComponent<Text>().fontSize = 85;
    // }

    //public void OnPointerExit(PointerEventData eventData) 
    //{
    //     Text.GetComponent<Text>().fontSize = 75;
    //}

    // public void OnButtonClick()
    // {
    //     Text.GetComponent<Text>().fontSize = 50;
    // }

}
