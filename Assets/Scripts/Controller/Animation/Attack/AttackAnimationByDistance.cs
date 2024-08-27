using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimationByDistance : MonoBehaviour
{
    [SerializeField]
    string nameOfParameter;

    [SerializeField]
    Animator animator;

    [SerializeField]
    Transform target;

    protected string tagOfTarget;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        if(target == null)
        {
            target = GameObject.FindWithTag(tagOfTarget).transform;
        }
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        AttackAnimation();
    }


    protected virtual void AttackAnimation()
    {
        animator.SetFloat(nameOfParameter, Vector3.Distance(target.transform.position, transform.position));

    }
}
