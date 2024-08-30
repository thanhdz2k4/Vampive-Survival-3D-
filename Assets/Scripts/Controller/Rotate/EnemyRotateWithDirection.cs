using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateWithDirection : RotateWithDirection
{
    [SerializeField]
    EnemyScriptableObject enemyData;

    [SerializeField]
    Transform player;

    protected override void Start()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        base.Start();
        
    }

    protected override void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        Rotate(direction);
    }
}
