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

    /*private void OnDrawGizmos()
    {
        // Set the color of the Gizmos line
        

        // Perform the raycast
        if (Physics.Raycast(rb.transform.position, Vector3.down, out hit, rayLength, derivaleSurface))
        {
            ActionOn.Invoke();
            Debug.Log(1);
            Gizmos.color = Color.green;

            // Calculate the end point of the ray
            Vector3 rayEndPoint = rb.transform.position + Vector3.down * rayLength;

            // Draw the line from the start position to the end position
            Gizmos.DrawLine(rb.transform.position, rayEndPoint);
        }
        else
        {
            ActionOff.Invoke();
            Debug.Log(0);
            Gizmos.color = Color.red;

            // Calculate the end point of the ray
            Vector3 rayEndPoint = rb.transform.position + Vector3.down * rayLength;

            // Draw the line from the start position to the end position
            Gizmos.DrawLine(rb.transform.position, rayEndPoint);
        }
    }
*/
}
