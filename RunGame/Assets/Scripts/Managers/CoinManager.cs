/*
# ----------------------------------------------------------------------------------------
#파일이름 :CoinManager.cs
#생성일 : 2024.09.19
#내용 :Road 위에 코인을 일자로 생성하는 코드 
# ------------------------------------------------------------------------------------------
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    [SerializeField] GameObject prefab;

    [SerializeField] float offset = 2.5f;
    [SerializeField] int creatreCount = 16;

    private void Awake()
    {
        Create();
    }
  

    public void Create()
    {
        System.Random rand = new System.Random();

        int pos  = rand.Next(-1,2);

        for (int i = 0; i < creatreCount; i++) 
        {


            GameObject clone = Instantiate(prefab);

            clone.transform.SetParent(gameObject.transform);

            clone.transform.localPosition = new Vector3(pos*3.5f, 0, offset * i);

        }

    }

}
