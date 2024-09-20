/*
# ----------------------------------------------------------------------------------------
#파일이름 :MonoBehaviour.cs
#생성일 : 2024.09.19
#내용 :코인 오브젝트가 중간에 멈춰서 얻박자 뛰는걸 막기 위한 코드 
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
