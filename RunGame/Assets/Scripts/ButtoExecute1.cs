using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtoExecute1 : MonoBehaviour
{
   public void OnButtonClick()
    {
        // Unity 에디터에서 실행 중일 때는 에디터 실행을 멈추지 않고, 빌드된 게임에서는 게임 종료
#if UNITY_EDITOR
        Debug.Log("Application is running in the editor. Cannot quit the application.");
        UnityEditor.EditorApplication.isPaused = false;
#else
        Debug.Log("Quitting application...");
        Application.Quit();
#endif
    }
}
