/*
# ----------------------------------------------------------------------------------------
#�����̸� :Coin.cs
#������ : 2024.09.19
#���� :���� ������Ʈ�� ���ڸ����� ȸ�� ��Ű�� �ڵ� 
# ------------------------------------------------------------------------------------------
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    [SerializeField] float rotationSpeed = 300;
    [SerializeField] GameObject rotationObject;
    private void OnEnable()
    {
        rotationObject = GameObject.Find("RotationGameObject");
        rotationSpeed = rotationObject.GetComponent<RotationObject>().Speed;

        transform.localRotation = rotationObject.transform.rotation;
    }

    private void Update()
    {
        //float posY = rotate.Rotatesreturn();
        // transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
    
}
