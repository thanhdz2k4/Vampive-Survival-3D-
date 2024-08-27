using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsRandomizer : MonoBehaviour
{
    [SerializeField] List<GameObject> listOfLocationSpawn;
    [SerializeField] GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < listOfLocationSpawn.Count; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.position = listOfLocationSpawn[i].transform.position;
            obj.transform.parent = gameObject.transform;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
