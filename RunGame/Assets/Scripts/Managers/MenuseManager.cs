using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuseManager :Singleton<MenuseManager>
{
    [SerializeField] Texture2D texture2D;



    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }


    private void State(int state)
    {
        switch (state) 
        {
            case 0:
                //Cursor.visible = true;
                //Cursor.lockState = CursorLockMode.None;
                texture2D = ResourcesManager.Instance.Load<Texture2D>("Defauit");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.SetCursor(texture2D, Vector2.zero, CursorMode.Auto);
                break; 
            case 1:
                texture2D = ResourcesManager.Instance.Load<Texture2D>("Defauit");
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.SetCursor(texture2D, Vector2.zero, CursorMode.Auto);
                break;
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        State(scene.buildIndex);
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
