using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableObject", menuName ="ScriptableObjects/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField]
    string enemyName;
    public string EnemyName { get => enemyName; private set => enemyName = value;}

    [SerializeField]
    float moveSpeed;
    public float MoveSpeed { get => moveSpeed; private set => moveSpeed = value; }

    [SerializeField]
    float maxHealth;
    public float MaxHealth { get => maxHealth; private set => maxHealth = value; }

    [SerializeField]
    float damge;
    public float Damage { get => damge; private set => damge = value; }

    [SerializeField]
    float distanceToAttack;
    public float DistanceToAttack { get => distanceToAttack; private set => distanceToAttack = value; }

    [SerializeField]
    string tagOfTarget;
    public string TagOfTarget { get => tagOfTarget; private set => tagOfTarget = value; }

    
}
