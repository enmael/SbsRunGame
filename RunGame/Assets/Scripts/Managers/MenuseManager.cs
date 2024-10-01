using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuseManager :Singleton<MenuseManager>
{
    [SerializeField] Texture2D texture2D;

    private void Start()
    {
        texture2D = ResourcesManager.Instance.Load<Texture2D>("Defauit");

        Cursor.SetCursor(texture2D, Vector2.zero,CursorMode.Auto);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //scene.buildIndex = 0;]
    }

    private void State(int state)
    {
        switch (state) 
        {
            case 0:
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                break; 
            case 1:
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                break;
        }
    }
}
