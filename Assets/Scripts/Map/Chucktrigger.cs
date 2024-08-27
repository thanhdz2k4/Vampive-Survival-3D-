using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chucktrigger : MonoBehaviour
{
    MapController mapController;
    GameObject targetMap;

    // Start is called before the first frame update
    void Start()
    {
        mapController = FindAnyObjectByType<MapController>();
        targetMap = transform.parent.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            mapController.SetCurrentChuck(targetMap, transform.parent.name);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(mapController.GetCurrentChuck() == targetMap)
            {
                mapController.SetCurrentChuck(null, gameObject.name); 
            }
        }
    }
}
