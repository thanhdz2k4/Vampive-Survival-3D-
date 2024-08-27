using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SkillScriptableObject", menuName = "ScriptableObjects/Skill")]
public class SkillScriptableObject : ScriptableObject
{
    [SerializeField]
    string nameOfSkill;
    public string NameOfSkill { get => nameOfSkill; private set => nameOfSkill = value; }

    [SerializeField]
    float damge;
    public float Damage { get => damge; private set => damge = value; }

    [SerializeField]
    float coolDownDuration;
    public float CoolDownDuration { get => coolDownDuration; private set => coolDownDuration = value; }

    
}
