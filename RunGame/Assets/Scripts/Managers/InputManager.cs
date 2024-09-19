using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : Singleton<InputManager> // 싱글톤 상속
{
    public Action action; // 델리게이터를 쉽게 사용하는방법

    private void Update()
    {
        #region 내풀이

        //if (Input.anyKeyDown == true)
        //{
        //    action?.Invoke(); //등록된 이벤트가 하나라도 있으면 이벤트를 호출한다.
        //}
        //else
        //{
        //    return;
        //}

        #endregion
        #region 강사님 풀이

        if (Input.anyKeyDown == false) return;
        {
            if (action != null)
            {
                action.Invoke();
            }
            
        }
      
        #endregion
    }
}
