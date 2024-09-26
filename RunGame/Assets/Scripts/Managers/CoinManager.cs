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
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class CoinManager : MonoBehaviour
{

    [SerializeField] GameObject prefab;
 
    [SerializeField] float offset = 2.5f;
    [SerializeField] int creatreCount = 16;

    [SerializeField] List<GameObject> coins;

    [SerializeField] float positionX = 3.5f;

    //[SerializeField] MeshRenderer meshRenderer;

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

            //GameObject clone = Instantiate(prefab);

            //ResourcesManager �̱��������ؼ� �ڵ� ����ȭ��
            GameObject clone = ResourcesManager.Instance.Instantiate("Coin",gameObject.transform); 

            //clone.transform.SetParent(gameObject.transform);

            clone.transform.localPosition = new Vector3(0, 0, offset * i);

            //clone.transform.localPosition = new Vector3(pos * 3.5f, 0, offset * i);

            #region ���� ������Ʈ���� Clone ����� 
            
            //int index = clone.name.IndexOf("(Clone)");
            //if (index > -1) 
            //{
            //    clone.name = clone.name.Substring(0, index);
            //    //clone.name = clone.name + i;
            //}
            
            //Debug.Log(clone.name.Substring(0,5));


            #endregion
            //clone.SetActive(false);
            clone.GetComponent<MeshRenderer>().enabled = false;
            clone.GetComponent<BoxCollider>().enabled = false;
            
            coins.Add(clone);

        }
        

    }

    public void InitializePosition()
    {
        System.Random rand = new System.Random();

        int pos = rand.Next(-1, 2);

        transform.localPosition = new Vector3(positionX * pos, 0, 0);


        // Mesh Renderer�� ��Ȱ���Ѱ� Ȱ��ȭ �ؼ� 
        for (int i = 0; i < coins.Count; i++) 
        {
            if (coins[i].GetComponent<MeshRenderer>().enabled == false) 
            {
                coins[i].GetComponent<BoxCollider>().enabled = true;
                coins[i].GetComponent<MeshRenderer>().enabled = true;
            }
        }

    }
   
}
