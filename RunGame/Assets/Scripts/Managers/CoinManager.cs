/*
# ----------------------------------------------------------------------------------------
#�����̸� :CoinManager.cs
#������ : 2024.09.19
#���� :Road ���� ������ ���ڷ� �����ϴ� �ڵ� 
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
