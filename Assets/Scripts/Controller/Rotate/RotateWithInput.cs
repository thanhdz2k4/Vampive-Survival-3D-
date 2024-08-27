using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithInput : MonoBehaviour, iRotate
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float steer;
    [SerializeField] VariableJoystick variableJoystick;

    float inputRotate;
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
        if (isPC)
        {
            inputRotate = Input.GetAxis("Horizontal");
        }
        else if(isMobile)
        {
            inputRotate = variableJoystick.Horizontal;
        }
        
    }


    private void FixedUpdate()
    {
        Rotate();
       
    }


    public void Rotate()
    {
       
        rb.MoveRotation(Quaternion.Euler(0, steer * inputRotate * Time.fixedDeltaTime , 0) * transform.rotation);
        
    }
}
