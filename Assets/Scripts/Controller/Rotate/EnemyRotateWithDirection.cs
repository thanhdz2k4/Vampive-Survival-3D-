using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateWithDirection : RotateWithDirection
{
    [SerializeField]
    EnemyScriptableObject enemyData;

    protected override void Start()
    {
        tagOfTarget = enemyData.TagOfTarget;
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
}
