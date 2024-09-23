using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtoExecute : MonoBehaviour
{
    public void OnButtonClick()
    {
        
            #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPaused = false;
#else
        Application.Quit();
#endif
        
    }
}
