using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum RoadLine
{
    LEET = -1,
    MIDDLE = 0,
    RLGHT = 1

 }
public class Runner : MonoBehaviour
{
    [SerializeField] RoadLine roadLine;
    [SerializeField] float positionX = 2.0f;

    public Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();  
    }

    private void Start()
    {
        roadLine = RoadLine.MIDDLE;
    }


    private void Update()
    {
        #region 강사님 풀이
        OnKeyUpdate();
        #endregion

        #region 내풀이

        //if (Input.GetKeyDown(KeyCode.A) && roadLine == RoadLine.MIDDLE)
        //{
        //    roadLine = RoadLine.LEET;
        //}
        //else if (Input.GetKeyDown(KeyCode.D) && roadLine == RoadLine.MIDDLE)
        //{
        //    roadLine = RoadLine.RLGHT; 
        //}
        //else if(Input.GetKeyDown(KeyCode.D) && roadLine == RoadLine.LEET)
        //{
        //    roadLine = RoadLine.MIDDLE;
        //}
        //else if( Input.GetKeyDown(KeyCode.A) && roadLine == RoadLine.RLGHT)
        //{
        //    roadLine = RoadLine.MIDDLE;
        //}
        #endregion



    }

    private void FixedUpdate()
    {
        Move();
    }
    void OnKeyUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(roadLine != RoadLine.LEET) 
            {
                roadLine--;
            }   
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (roadLine != RoadLine.RLGHT)
            {
                roadLine++;
            }
        }
    }
    private void Move()
    {
        #region 내풀이
        //if (roadLine == RoadLine.MIDDLE)
        //{
        //    positionX = 0;
        //}
        //else if(roadLine == RoadLine.LEET)
        //{
        //    positionX = -2;
        //}
        //else if(roadLine == RoadLine.RLGHT)
        //{
        //    positionX = 2;
        //}

        //rigidbody.MovePosition(new Vector3(positionX, 0, 0));

        #endregion

        #region 강사님 풀이
        rigidbody.position = new Vector3(positionX  * (int)roadLine , 0, 0);
        #endregion
    }




}
