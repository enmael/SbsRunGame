/*
# ----------------------------------------------------------------------------------------
#파일이름 :Coin.cs
#생성일 : 2024.09.19
#내용 :코인 오브젝트를 제자리에서 회전 시키는 코드 
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
