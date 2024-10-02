using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class OdstacleManager : MonoBehaviour
{
    List<GameObject> odstacles = new List<GameObject>();

    [SerializeField] private GameObject prefad;
    [SerializeField] private int createCount = 5;
    [SerializeField] int random;

    [SerializeField] private GameObject opm;

    private void Start()
    {
        odstacles.Capacity = 10;
        Create();
        StartCoroutine(ActiveObstacle());
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

    private IEnumerator ActiveObstacle()
    {
        //int count = 0;
        //for(int i = 0; i < createCount;i++) 
        //{
        //   odstacles[i].SetActive(true);
        //   yield return new WaitForSeconds(2.5f);
        //   count++;    
        //}


        // int count = 0;
        //.activeSelf ������Ʈ�� Ȱ��ȭ ��Ȱ��ȭ ���� Ȯ�� 
        while (true)
        {
            #region �����Ǯ��
            yield return new WaitForSeconds(2.5f);

            System.Random rand = new System.Random();
            int random = rand.Next(0, odstacles.Count);

            while (odstacles[random].activeSelf == true )
            {
                // ���� ����Ʈ�� �ִ� ��� ���� ������Ʈ�� Ȱ��ȭ�� �� �ִ��� Ȯ�� �մϴ�.
                if(ExamineActive())
                {
                    // ��� ���� ������Ʈ�� Ȱ��ȭ�Ǿ� �ִٸ� ���� ������Ʈ�� ���� ������ ����
                    //odstacles����Ʈ�� �־��ش�.
                    GameObject colone = ResourcesManager.Instance.Instantiate("cone", gameObject.transform);
                    colone.SetActive(false);
                    odstacles.Add(colone);
                }
                //Debug.Log(odstacles[random].activeSelf);
                random = (random + 1) % odstacles.Count;
            }
            odstacles[random].SetActive(true);

            //Vector3 opmVector = opm.transform.position;
            //odstacles[random].transform.position = opmVector;



            #endregion

            #region ��Ǯ��
            //yield return new WaitForSeconds(2.5f);

            //System.Random rand = new System.Random();
            //int random = rand.Next(0, odstacles.Count);
            //if(odstacles.Count != random + 1)
            //{

            //    if (odstacles[random + 1].activeSelf == true )
            //    {
            //        random++;
            //    }
            //    else
            //    {
            //        odstacles[random + 1].SetActive(true);
            //    }
            //}
            //else
            //{
            //    if(odstacles[0].activeSelf == true)
            //    {
            //        random++;
            //    }
            //    else
            //    {
            //        odstacles[0].SetActive(true);
            //    }
            #endregion

        }



    }


    private bool ExamineActive()
    {
        for(int i = 0; i < odstacles.Count; i++) 
        {
            if(odstacles[i].activeSelf == false)
            {
                return false;
            }
        }
        return true;
    }

}

       
    
