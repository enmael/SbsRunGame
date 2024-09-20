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
using static UnityEditor.PlayerSettings;

public class CoinManager : MonoBehaviour
{

    [SerializeField] GameObject prefab;
 
    [SerializeField] float offset = 2.5f;
    [SerializeField] int creatreCount = 16;

    [SerializeField] List<GameObject> coins;

    [SerializeField] float positionX = 3.5f;
    private void Awake()
    {
        Create();
        coins.Capacity = 20; 
    }

 

    public void Create()
    {
        //System.Random rand = new System.Random();

        //int pos  = rand.Next(-1,2);


        for (int i = 0; i < creatreCount; i++) 
        {

            GameObject clone = Instantiate(prefab);
            clone.transform.SetParent(gameObject.transform);

            clone.transform.localPosition = new Vector3(0, 0, offset * i);

            //clone.transform.localPosition = new Vector3(pos * 3.5f, 0, offset * i);

            #region 코인 오브젝트에서 Clone 지우기 
            
            int index = clone.name.IndexOf("(Clone)");
            if (index > -1) 
            {
                clone.name = clone.name.Substring(0, index);
                //clone.name = clone.name + i;
            }
            
            //Debug.Log(clone.name.Substring(0,5));


            #endregion
            clone.SetActive(false);

            coins.Add(clone);
        }
        

    }

    public void InitializePosition()
    {
        System.Random rand = new System.Random();

        int pos = rand.Next(-1, 2);

        transform.localPosition = new Vector3(positionX * pos, 0, 0);
    }
   
}
