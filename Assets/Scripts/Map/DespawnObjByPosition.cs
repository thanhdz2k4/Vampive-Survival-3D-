using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnObjByPosition : MonoBehaviour
{
    [SerializeField]
    string nameOfObjectToDespawn;
    Transform player;
    PoolingObject poolingObject;

    [SerializeField]
    float positionDespawn;


    private void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag(nameOfObjectToDespawn).transform;
        }
        if(poolingObject == null)
        {
            poolingObject = GameObject.Find("PoolingObjectMap").GetComponent<PoolingObject>();
        }
    }

    private void Update()
    {
        
        if (Vector3.Distance(transform.position, player.position) >= positionDespawn)
        {
            poolingObject.ReturnToPool(gameObject);
        }
    }
}
