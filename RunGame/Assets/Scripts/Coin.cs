/*
# ----------------------------------------------------------------------------------------
#파일이름 :Coin.cs
#생성일 : 2024.09.19
#내용 :코인 오브젝트를 제자리에서 회전 시키는 코드 
# ------------------------------------------------------------------------------------------
*/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour, IColliderable
{
    
    [SerializeField] float rotationSpeed = 300;
    [SerializeField] GameObject rotationObject;
    [SerializeField] ParticleSystem particleSystem;
    //[SerializeField] GameObject playe;


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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            particleSystem.Play();
        }
    }
    
    //public void Activvater () 
    //{
       
    //}

    

    public void Activatr()
    {
        particleSystem.Play();

        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;


    }
}
