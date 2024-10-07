using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdstaclePositionManager : MonoBehaviour
{
    #region 내풀이
    float[] array = new float[17];
    [SerializeField] GameObject opm;
    #endregion

    #region 강사님 풀이
    [SerializeField] int index = -1;
    [SerializeField] Transform[] parentRoad;

    [SerializeField] float[] randomPositionZ = new float[16];

    [SerializeField] OdstacleManager odstacleManager;
    [SerializeField] bool state = false;

    [SerializeField] Transform[] positionX;   
    #endregion
   

    void Start()
    {
        #region 내풀이
        //ArrayPosZ();
        //StartCoroutine(ArrayTransfiem());
        #endregion

        
        

        StartCoroutine(SetPositiom());


    }
    #region 강사님 풀이
    private void Awake()
    {
        float number = 2.5f;
        for (int i = 0; i < randomPositionZ.Length; i++) 
        {
            randomPositionZ[i] = -10 + number * i;
        }
    }


    public void InitializedPosition()
    {
        state = true;   
        index = (index +1) %parentRoad.Length;

        transform.SetParent(parentRoad[index]);

        transform.localPosition += new Vector3(0, 0, 40);
        //transform.position = parentRoad[index].transform.localPosition;
    }



    private IEnumerator SetPositiom() 
    {
        while (true) 
        {
            yield return CoroutineCache.waitForSecond(2.5f);

            

            transform.localPosition = new Vector3(0, 0, randomPositionZ[Random.Range(0, randomPositionZ.Length)]);


            if(state == true)
            {
                odstacleManager.GetObstacle().SetActive(true);  

                odstacleManager.GetObstacle().transform.position = transform.localPosition;

                odstacleManager.GetObstacle().transform.localPosition = positionX[Random.Range(0, positionX.Length)].position;
            
           
                odstacleManager.GetObstacle().transform.SetParent(transform.root.GetChild((index + 1) % parentRoad.Length));
            }
        }
    }


    private void Update()
    {
        Debug.Log(opm.transform.position);
    }
    #endregion


    #region 내풀이
    //private void ArrayPosZ()
    //{
    //    float number = 2.5f;

    //    for(int i  = 0; i < array.Length; i++) 
    //    {
    //        array[i] = -10 + number*i;
    //    }   

    //}
    //private IEnumerator ArrayTransfiem()
    //{
    //    while(true) 
    //    {
    //        System.Random rand = new System.Random();
    //        int random = rand.Next(0, array.Length);

    //        yield return new WaitForSeconds(5f);

    //        opm.transform.position= new Vector3(0, 0, array[random]);

    //    }
    //}

    #endregion

    
    
}
