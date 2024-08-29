using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    // The terrain prefab to spawn

    [SerializeField]
    private GameObject terrainPrefab;

    [SerializeField]
    private GameObject currentChuck;

    [SerializeField]
    LayerMask layerMask;

    [SerializeField]
    PoolingObject poolingObject;


    public GameObject GetCurrentChuck()
    {
        return currentChuck;
    }

    public void SetCurrentChuck(GameObject currentChuck, string name)
    {
       
        this.currentChuck = currentChuck;
       
        // to do
            
        // Check Forward is empty, if is null, it will spawn a terrain
        if(Physics.OverlapBox(currentChuck.transform.Find("Forward").position, new Vector3(1, 1, 1), Quaternion.identity, layerMask).Length == 0)
        {
            SpawnMap("Forward");
        }
        if (Physics.OverlapBox(currentChuck.transform.Find("Forward_Right").position, new Vector3(1, 1, 1), Quaternion.identity, layerMask).Length == 0)
        {
            SpawnMap("Forward_Right");
        }
        if (Physics.OverlapBox(currentChuck.transform.Find("Forward_Left").position, new Vector3(1, 1, 1), Quaternion.identity, layerMask).Length == 0)
        {
            SpawnMap("Forward_Left");
        }
        if (Physics.OverlapBox(currentChuck.transform.Find("Behind").position, new Vector3(1, 1, 1), Quaternion.identity, layerMask).Length == 0)
        {
            SpawnMap("Behind");
        }
        if (Physics.OverlapBox(currentChuck.transform.Find("Behind_Left").position, new Vector3(1, 1, 1), Quaternion.identity, layerMask).Length == 0)
        {
            SpawnMap("Behind_Left");
        }
        if (Physics.OverlapBox(currentChuck.transform.Find("Behind_Right").position, new Vector3(1, 1, 1), Quaternion.identity, layerMask).Length == 0)
        {
            SpawnMap("Behind_Right");
        }
        if (Physics.OverlapBox(currentChuck.transform.Find("Left").position, new Vector3(1, 1, 1), Quaternion.identity, layerMask).Length == 0)
        {
            SpawnMap("Left");
        }
        if (Physics.OverlapBox(currentChuck.transform.Find("Right").position, new Vector3(1, 1, 1), Quaternion.identity, layerMask).Length == 0)
        {
            SpawnMap("Right");
        }

    }

    private void SpawnMap(string direction)
    {
        GameObject obj = poolingObject.GetPoolObject();
        obj.transform.position = currentChuck.transform.Find(direction).position;
        
    }

}
