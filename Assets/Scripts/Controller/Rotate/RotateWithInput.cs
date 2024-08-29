using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithInput : RotateWithDirection
{
    Vector3 dir;
    [SerializeField]
    VariableJoystick variableJoystick;
    protected override void Start()
    {
        
       
    }
    protected override void Update()
    {
        dir = new Vector3(variableJoystick.Horizontal, 0, variableJoystick.Vertical).normalized;
        if(dir.x != 0 || dir.y!= 0)
        {
            Rotate(dir);
        }
       
    }
}
