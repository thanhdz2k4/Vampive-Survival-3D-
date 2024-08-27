using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithInput : MonoBehaviour, iMove
{
    [SerializeField]
    Rigidbody engineRB;

    [SerializeField]
    VariableJoystick variableJoystick;

    [SerializeField]
    float acceleration, maxSpeed, maxSpeedBackWalk;

    float moveInput;

    [SerializeField]
    bool isContinueMove;

    bool isMobile;
    bool isPC;
    // Start is called before the first frame update
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        if(isContinueMove)
        {
            if(isPC)
            {
                moveInput = Input.GetAxis("Vertical");
            }
            else if(isMobile)
            {
                moveInput = variableJoystick.Vertical;
            }
               
            Move();
        }
       
    }

   

    public void Move()
    {
        Acceleration();
    }

     void Acceleration()
    {
        if(moveInput > 0)
        {
            engineRB.velocity = Vector3.Lerp(engineRB.velocity, moveInput * maxSpeed * transform.forward, Time.fixedDeltaTime * acceleration);
        } else
        {
            engineRB.velocity = Vector3.Lerp(engineRB.velocity, moveInput * maxSpeedBackWalk * transform.forward, Time.fixedDeltaTime * acceleration);
        }
       
    }

    public void ContinueMove()
    {
        this.isContinueMove = true;
    }

    public void StopMove()
    {
        this.isContinueMove = false;
    }
    
}
