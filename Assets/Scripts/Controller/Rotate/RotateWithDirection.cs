using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithDirection : MonoBehaviour, iRotate
{ 
    
    protected string tagOfTarget;
    protected Vector3 target;
    [SerializeField]
    float rotateIncrement = .09f;

    

    // Start is called before the first frame update
    protected virtual void Start()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag(tagOfTarget).transform.position;
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Rotate(target);
    }

    public void Rotate(Vector3 target)
    {
        // Calculate the direction to the target
        //Vector3 direction = (target - transform.position).normalized;

        // Create the target rotation based on the direction
        Quaternion targetRotation = Quaternion.LookRotation(target, Vector3.up);

        // Smoothly rotate towards the target rotation using Slerp
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateIncrement);
    }
}
