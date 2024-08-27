
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    [SerializeField]
    protected Animator animator;

    [SerializeField]
    protected Rigidbody rb;

   
    // Start is called before the first frame update
    protected virtual void Start()
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }
        if(rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
        
    }

    protected virtual void AnimationMoveToward(string nameOfMoveTowardAnimation)
    {       
       
    }

    protected virtual void AnimationMoveBackward(string nameOfMoveBackwardAnimation)
    {
       
    }
}
