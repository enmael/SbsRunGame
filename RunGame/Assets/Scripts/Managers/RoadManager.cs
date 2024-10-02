using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Windows.Speech;

public class RoadManager : State
{
    //[SerializeField] List <GameObject>list;
    //[SerializeField] float speed = 2;
    //float pos;

    [SerializeField] List<GameObject> roads;
    //[SerializeField] float speed = 5.0f;
    [SerializeField] int createCount = 4;
    [SerializeField] float offset = 40.0f;

    [SerializeField] SppedManager speedManager;


   // [SerializeField] GameObject odstacle;

    private void Awake()
    {
        //list = new List<GameObject>();
    }
    private void Start()
    {
        roads.Capacity = 10;
        AddRod();

       // StartCoroutine(SppedManager.Instance.Increase()); //코루틴 호출
    }

    private void Update() //���� �����δ�.
    {
        if (stat == false) return;

        for (int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.Translate(Vector3.back * speedManager.Speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Debug.Log("1");
            newPosition();
        }
    }

    void AddRod() //�ڵ����� ����Ʈ�� �ִ� ��� 
    {
        for (int i = 0; i < createCount; i++)
        {
            roads.Add(transform.GetChild(i).gameObject);
        }
    }
    public void newPosition()
    {
        //GameObject game = roads[0];
        //roads.RemoveAt(0);

        //Vector3 vector = roads[3].transform.position;
        //Vector3 vector1 = new Vector3(0, 0, 40);


        //game.transform.position = vector + vector1;

        //roads.Add(game);

        #region ����� Ǯ�� 

        GameObject newRoad = roads[0];
        roads.Remove(newRoad);

        float newZ = roads[roads.Count-1].transform.position.z + offset;

        newRoad.transform.position = new Vector3(0, 0, newZ);

        roads.Add(newRoad);

       

        //odstacle.transform.SetParent(newRoad);

        // 필요 시 상대적 위치 초기화
        //odstacle.transform.localPosition = Vector3.zero;
    }
        #endregion
}
