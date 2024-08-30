using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAnimation : MonoBehaviour
{

    [SerializeField]
    Animator animator;

    [SerializeField]
    string parameterOfAnimation;

    InputSystem control;

    private void Awake()
    {
        control = new InputSystem();
        control.Enable();
        control.Land._1H_Melee_Attack_Slice.performed += ctx => PlaySkill();

        // Listen for the attack action being canceled (button released)
        control.Land._1H_Melee_Attack_Slice.canceled += ctx => ResetSkill();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }

    }   

    private void PlaySkill()
    {
        animator.SetBool(parameterOfAnimation, true);
    }

    private void ResetSkill()
    {
        animator.SetBool(parameterOfAnimation, false);
    }
}
