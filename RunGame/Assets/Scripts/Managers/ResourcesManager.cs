/*
# ----------------------------------------------------------------------------------------
#�����̸� :
#������ : 
#���� : 
     
# ------------------------------------------------------------------------------------------
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : Singleton<ResourcesManager> 
{
    public T Load<T>(string path) where T : Object // Object Ÿ�Ը� �ް� �������
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent =null)
    {
       GameObject prefad = Load<GameObject>(path);

        if(prefad == null) 
        {
            Debug.Log("Failed to Load Prefab : " + path);
            return null;    
        }
        
        GameObject clone = Object.Instantiate(prefad, parent);  


        int index = clone.name.IndexOf("(Clone)");
        if (index > 0)
        {
            clone.name = clone.name.Substring(0, index);
            
        }

        return clone;
    }

    public void Destroy(GameObject prefad) 
    {
        if (prefad == null)
        {
            return;
        }

        Object.Destroy(prefad.gameObject);
    }

}
