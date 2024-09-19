using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 300f;
    //private void Update()
    //{
    //    //transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    //    //Rotates();
    //}

    //private void Rotates()
    //{
    //    transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    //}

    //public float Rotatesreturn()
    //{
    //    float speed = rotationSpeed * Time.deltaTime;
    //    return speed;
    //}

    public float Speed
    {
        get { return rotationSpeed;  }
    }

    private void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        
    }


}
