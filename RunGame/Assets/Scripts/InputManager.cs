using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : Singleton<InputManager> // �̱��� ���
{
    public Action action; // ���������͸� ���� ����ϴ¹��

    private void Update()
    {
        #region ��Ǯ��

        //if (Input.anyKeyDown == true)
        //{
        //    action?.Invoke(); //��ϵ� �̺�Ʈ�� �ϳ��� ������ �̺�Ʈ�� ȣ���Ѵ�.
        //}
        //else
        //{
        //    return;
        //}

        #endregion
        #region ����� Ǯ��

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
