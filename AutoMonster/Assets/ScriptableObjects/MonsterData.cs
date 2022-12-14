using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MonsterData : ScriptableObject
{
    public string MonsterName;
    public int Level;
    public int CurrentHP;
    public int MaxHP;
    public int Attack;
    public int Defense;
    public int SpecialAttack;
    public int SpecialDefense;
    public int Speed;
    public int AttackPower;
    public string Type;
    public Sprite art;

    public void ResetHp()
    {
        
    }
}
