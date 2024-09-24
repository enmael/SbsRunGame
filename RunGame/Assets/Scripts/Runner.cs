using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum RoadLine
{
    LEET = -1,
    MIDDLE = 0,
    RLGHT = 1
            
 }
public class Runner : MonoBehaviour
{
    RoadManager roadManager;
    SppedManager sppedManager; 

    [SerializeField] RoadLine roadLine;
    [SerializeField] float positionX = 2.0f;
    [SerializeField] float speed = 30;

    public Rigidbody rigidbody;

    //public SppedManager sppedManager;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();  
    }

    private void OnEnable()
    {
        InputManager.Instance.action += OnKeyUpdate;
    }

    private void Start()
    {
        roadLine = RoadLine.MIDDLE;
    }

    private void FixedUpdate()
    {
        //speed = sppedManager.Speed();
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
        rigidbody.position = Vector3.Lerp //러프 사용법(시작 지점, 가려는지점, 속도)
            (
            rigidbody.position,
            new Vector3(positionX * (int)roadLine, 0, 0), 
            speed* Time.fixedDeltaTime
            ) ;
        //rigidbody.position = new Vector3(positionX  * (int)roadLine , 0, 0);
        #endregion
    }


    private void OnDisable()
    {
        InputManager.Instance.action -= OnKeyUpdate;
    }

    private void OnTriggerEnter(Collider other)
    {
        IColliderable colliderable = other.GetComponent<IColliderable>();

        if (colliderable != null) 
        {
            colliderable.Activatr();
        }
    }

    //private void Update()
    //{
    //    #region 강사님 풀이
    //    OnKeyUpdate();
    //    #endregion

    //    #region 내풀이

    //    //if (Input.GetKeyDown(KeyCode.A) && roadLine == RoadLine.MIDDLE)
    //    //{
    //    //    roadLine = RoadLine.LEET;
    //    //}
    //    //else if (Input.GetKeyDown(KeyCode.D) && roadLine == RoadLine.MIDDLE)
    //    //{
    //    //    roadLine = RoadLine.RLGHT; 
    //    //}
    //    //else if(Input.GetKeyDown(KeyCode.D) && roadLine == RoadLine.LEET)
    //    //{
    //    //    roadLine = RoadLine.MIDDLE;
    //    //}
    //    //else if( Input.GetKeyDown(KeyCode.A) && roadLine == RoadLine.RLGHT)
    //    //{
    //    //    roadLine = RoadLine.MIDDLE;
    //    //}
    //    #endregion



    //}
}
