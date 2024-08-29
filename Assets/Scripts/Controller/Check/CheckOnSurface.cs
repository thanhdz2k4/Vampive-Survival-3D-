using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckOnSurface : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    UnityEvent ActionOn, ActionOff;

    [SerializeField]
    LayerMask derivaleSurface;

    RaycastHit hit;

    
    float rayLength;

    private void Start()
    {
        this.rayLength = rb.GetComponent<CapsuleCollider>().radius + 0.2f;
    }

    private void Update()
    {
        isRightSuface();
    }

    private void isRightSuface()
    {
        if (Physics.Raycast(rb.transform.position, Vector3.down, out hit, rayLength, derivaleSurface))
        {
            ActionOn.Invoke();
           
        }
        else
        {
            ActionOff.Invoke();
            
        }
    }

    
}
