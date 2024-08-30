using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimationWithInput : MoveAnimation
{

    [SerializeField]
    VariableJoystick variableJoystick;

    [SerializeField]
    string nameAnimationMoveToward;

    bool isMobile;
    bool isPC;

    float dirXMove;
    protected override void Start()
    {
        base.Start();
#if UNITY_ANDROID
        Debug.Log("Đang biên dịch cho Android");
        isMobile = true;
        isPC = false;
        // Thực hiện các thao tác đặc biệt cho Android ở đây
#elif UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX
    Debug.Log("Đang biên dịch cho PC");
    isMobile = false;
    isPC = true;
        // Thực hiện các thao tác đặc biệt cho PC ở đây
#else
    Debug.Log("Nền tảng không xác định");
#endif
    }

    protected override void Update()
    {
        if(isMobile)
        {
            dirXMove = variableJoystick.Vertical;
        }
        else if(isPC)
        {
            dirXMove = Input.GetAxis("Vertical");
        }
       
        AnimationMoveToward(nameAnimationMoveToward);
    }


    protected override void AnimationMoveToward(string nameOfMoveTowardAnimation)
    {
        animator.SetFloat(nameOfMoveTowardAnimation, rb.velocity.magnitude);
    }

}
