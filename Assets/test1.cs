using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    [SerializeField] VariableJoystick variableJoystick;
    [SerializeField] float speed;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir = new Vector3(variableJoystick.Horizontal, 0, variableJoystick.Vertical).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}
