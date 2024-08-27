using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveWithDirection : MoveWithDirection
{
    [SerializeField]
    EnemyScriptableObject enemyData;

    protected override void Start()
    {
        distanceToStop = enemyData.DistanceToAttack;
        moveSpeed = enemyData.MoveSpeed;
        tagOfTarget = enemyData.TagOfTarget;
        base.Start();
        
        
    }

    protected override void Update()
    {
        base.Update();
    }
}
