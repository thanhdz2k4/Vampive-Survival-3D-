using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingObject : MonoBehaviour
{
    [SerializeField]
    GameObject objectPrefab;

    [SerializeField]
    int poolSize;

    [SerializeField]
    List<GameObject> pool;
    // Start is called before the first frame update
    void Start()
    {
        InitializeObjectPooling(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeObjectPooling()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetPoolObject()
    {
        foreach(var obj in pool)
        {
            if(!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }
        GameObject newObj = Instantiate(objectPrefab);
        newObj.SetActive(false);
        pool.Add(newObj);
        return newObj;
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
    }
   
}
