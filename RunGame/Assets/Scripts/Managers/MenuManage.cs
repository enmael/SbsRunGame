using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManage : MonoBehaviour
{
    public void Execute()
    {
        StartCoroutine(SceneryManager.Instance.ChangeScene("NextScene"));
    }

    public void Shop()
    {
        Debug.Log("shop");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPaused = false;
#else
    Application.Quit();
#endif

    }
}
