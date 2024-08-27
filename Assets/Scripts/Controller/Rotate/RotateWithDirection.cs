using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithDirection : MonoBehaviour, iRotate
{ 
    
    protected string tagOfTarget;
    Transform target;
    [SerializeField]
    float rotateIncrement = .09f;

    

    // Start is called before the first frame update
    protected virtual void Start()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag(tagOfTarget).transform;
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        // Calculate the direction to the target
        Vector3 direction = (target.position - transform.position).normalized;

        // Create the target rotation based on the direction
        Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);

        // Smoothly rotate towards the target rotation using Slerp
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateIncrement);
    }
}
