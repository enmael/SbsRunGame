using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManage : MonoBehaviour
{
 public void Execute()
    {
        EvenetManager.Publish(EventType.START);

        // //StartCoroutine(SceneryManager.Instance.);
        StartCoroutine(SceneryManager.Instance.AsyncLoad(1));
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
