using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBehaviour : MonoBehaviour
{
    [SerializeField]
    SkillScriptableObject skillData;

    

    float currentDamage;
    float currentCoolDownDuration;
    // Start is called before the first frame update
    void Start()
    {
        currentDamage = skillData.Damage;
        currentCoolDownDuration = skillData.CoolDownDuration;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            EnemyStats enemy = other.GetComponent<EnemyStats>();
            enemy.TakeDamage(currentDamage);
        }
    }

    public void hihi()
    {
        Debug.Log("Hihi");
    }
}
