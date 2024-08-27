using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAnimation : MonoBehaviour
{

    [SerializeField]
    Animator animator;

    [SerializeField]
    string parameterOfAnimation;

    [SerializeField]
    KeyCode keyCodeToActiveAnimation;

    // Start is called before the first frame update
    void Start()
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }

    }   

    // Update is called once per frame
    void Update()
    {
        PlaySkill();
        
    }

    void PlaySkill()
    {

        //DelayPlaySkill();
        if (Input.GetKeyDown(keyCodeToActiveAnimation))
        {
            animator.SetBool(parameterOfAnimation, true);
        }
        else
        {
            animator.SetBool(parameterOfAnimation, false);
        }
    }
}
