using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class OdstacleManager : MonoBehaviour
{
    List<GameObject> odstacles = new List<GameObject>();

    [SerializeField] private GameObject prefad;
    [SerializeField] private int createCount  = 5;

    private void Start()
    {
        odstacles.Capacity = 10;
        Create();
    }
    public void Create()
    {
        for (int i = 0; i < createCount; i++) 
        {
            prefad = ResourcesManager.Instance.Instantiate("cone", gameObject.transform);
            
            prefad.SetActive(false);

            odstacles.Add(prefad);

        }
    }


    //private void Start()
    //{
    //    list.Capacity = 10;

    //}

    //private void Cone()
    //{
    //    for (int i = 0; i < list.Capacity; i++) 
    //    {
    //        GameObject cone = Instantiate(gameObject);
    //        cone.transform.SetParent(gameObject.transform);
    //        cone.transform.localPosition = new Vector3(0, 0, PosX * i);

    //        list.Add(cone); 

    //        cone.GetComponent<Collider>().enabled = false;   
    //    }

    //}
}
