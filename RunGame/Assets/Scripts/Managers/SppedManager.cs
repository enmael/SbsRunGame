/*
# ----------------------------------------------------------------------------------------
#�����̸� :SppedManager.cs
#������ : 2024.09.24
#���� : �ڷ�Ƽ �̱����� Ȱ���ؼ� �ε��� ���ǵ尪 ����?
        - Adjusting Road speed using Coruti singleton?
# ------------------------------------------------------------------------------------------
*/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class SppedManager : State
{
   

    [SerializeField] float speed = 30f;
    [SerializeField] float limitSpeed = 75f;

    [SerializeField] float incraseVaue = 5.0f;
    //[SerializeField] float increaseTime = 10.0f;

 

    public float Speed
    {
        get { return speed; } //�ٸ��� ���ǵ� ���� ����
                              //�ٸ����� ������ ���ؼ� �����͸� ������
    }

    private void Awake()
    {
        StartCoroutine(Increase());
    }

    public IEnumerator Increase()
    {
        while(stat == true && speed <limitSpeed)
        {
            yield return CoroutineCache.waitForSecond(2);

            speed += incraseVaue;   
        }
    }


    #region ���� (����)
    //private float speed = 30;
    //private float  timespeed = 0;

    //public static SppedManager Instance { get; private set; }

    //void Start()
    //{
    //    StartCoroutine(MyCoroutine());
    //}

    //IEnumerator MyCoroutine()
    //{
    //    while (speed <= 75) 
    //    { 
    //        yield return new WaitForSeconds(10);
    //        speed = speed + 5;
    //        //Debug.Log(speed);
    //    }
    //}

    //private void Update()
    //{
    //    //timespeed = Time.deltaTime;
    //    //if (timespeed > 10 && speed <= 75)
    //    //{
    //    //    speed += 5;
    //    //    timespeed = 0;
    //    //}
    //    Debug.Log(speed);
    //}

    //public float Speed()
    //{
    //    return speed;   
    //}

    #endregion




}
