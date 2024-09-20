/*
# ----------------------------------------------------------------------------------------
#�����̸� :MonoBehaviour.cs
#������ : 2024.09.19
#���� :���� ������Ʈ�� �߰��� ���缭 ����� �ٴ°� ���� ���� �ڵ� 
# ------------------------------------------------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 300f;


    public float Speed
    {
        get { return rotationSpeed;  }
    }

    private void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        
    }


}
