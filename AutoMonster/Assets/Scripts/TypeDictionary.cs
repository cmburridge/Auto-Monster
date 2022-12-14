using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TypeDictionary : MonoBehaviour
{
    // Create a dictionary to store type effectiveness
    Dictionary<string, int> typeEffectiveness = new Dictionary<string, int>();

    public int effectiveness = 10;

    // Use the dictionary to look up the effectiveness of a move
    public MonsterData playerMonster;
    public MonsterData enemyMonster;

    private BattleManager manager;
    private void Start()
    {
        playerMonster = manager.currentPlayerMonster;
        enemyMonster = manager.currentEnemyMonster;
        
        //Normal
        typeEffectiveness.Add("Normal-Rock", 5);
        typeEffectiveness.Add("Normal-Ghost", 0);
        typeEffectiveness.Add("Normal-Steel", 0);
        //Fire
        typeEffectiveness.Add("Fire-Grass", 20);
        typeEffectiveness.Add("Fire-Water", 5);
        typeEffectiveness.Add("Fire-Fire", 5);
        typeEffectiveness.Add("Fire-Ice", 20);
        typeEffectiveness.Add("Fire-Bug", 20);
        typeEffectiveness.Add("Fire-Steel", 20);
        typeEffectiveness.Add("Fire-Rock", 5);
        typeEffectiveness.Add("Fire-Dragon", 5);
        //Water
        typeEffectiveness.Add("Water-Fire", 20);
        typeEffectiveness.Add("Water-Water", 5);
        typeEffectiveness.Add("Water-Grass", 5);
        typeEffectiveness.Add("Water-Ground", 20);
        typeEffectiveness.Add("Water-Rock", 20);
        typeEffectiveness.Add("Water-Dragon", 5);
        //Grass
        typeEffectiveness.Add("Grass-Fire", 5);
        typeEffectiveness.Add("Grass-Water", 20);
        typeEffectiveness.Add("Grass-Grass", 5);
        typeEffectiveness.Add("Grass-Poison", 5);
        typeEffectiveness.Add("Grass-Ground", 20);
        typeEffectiveness.Add("Grass-Flying", 5);
        typeEffectiveness.Add("Grass-Bug", 5);
        typeEffectiveness.Add("Grass-Rock", 20);
        typeEffectiveness.Add("Grass-Dragon", 5);
        typeEffectiveness.Add("Grass-Steel", 5);
        //Electric
        typeEffectiveness.Add("Electric-Water", 20);
        typeEffectiveness.Add("Electric-Grass", 5);
        typeEffectiveness.Add("Electric-Electric", 5);
        typeEffectiveness.Add("Electric-Ground", 0);
        typeEffectiveness.Add("Electric-Flying", 20);
        typeEffectiveness.Add("Electric-Dragon", 5);
        //Ice
        typeEffectiveness.Add("Ice-Fire", 5);
        typeEffectiveness.Add("Ice-Water", 5);
        typeEffectiveness.Add("Ice-Grass", 20);
        typeEffectiveness.Add("Ice-Ice", 5);
        typeEffectiveness.Add("Ice-Ground", 20);
        typeEffectiveness.Add("Ice-Flying", 20);
        typeEffectiveness.Add("Ice-Dragon", 20);
        typeEffectiveness.Add("Ice-Steel", 5);
        //Fighting
        typeEffectiveness.Add("Fighting-Normal", 20);
        typeEffectiveness.Add("Fighting-Ice", 20);
        typeEffectiveness.Add("Fighting-Poison", 5);
        typeEffectiveness.Add("Fighting-Flying", 5);
        typeEffectiveness.Add("Fighting-Psychic", 5);
        typeEffectiveness.Add("Fighting-Bug", 5);
        typeEffectiveness.Add("Fighting-Rock", 20);
        typeEffectiveness.Add("Fighting-Ghost", 0);
        typeEffectiveness.Add("Fighting-Dark", 20);
        typeEffectiveness.Add("Fighting-Steel", 20);
        typeEffectiveness.Add("Fighting-Fairy", 5);
        //Poison
        typeEffectiveness.Add("Poison-Grass", 20);
        typeEffectiveness.Add("Poison-Poison", 5);
        typeEffectiveness.Add("Poison-Ground", 5);
        typeEffectiveness.Add("Poison-Rock", 5);
        typeEffectiveness.Add("Poison-Ghost", 5);
        typeEffectiveness.Add("Poison-Steel", 0);
        typeEffectiveness.Add("Poison-Fairy", 20);
        //Ground
        typeEffectiveness.Add("Ground-Fire", 20);
        typeEffectiveness.Add("Ground-Grass", 5);
        typeEffectiveness.Add("Ground-Electric", 20);
        typeEffectiveness.Add("Ground-Poison", 20);
        typeEffectiveness.Add("Ground-Flying", 0);
        typeEffectiveness.Add("Ground-Bug", 5);
        typeEffectiveness.Add("Ground-Rock", 20);
        typeEffectiveness.Add("Ground-Steel", 20);
        //Flying
        typeEffectiveness.Add("Flying-Grass", 20);
        typeEffectiveness.Add("Flying-Electric", 5);
        typeEffectiveness.Add("Flying-Fighting", 20);
        typeEffectiveness.Add("Flying-Bug", 20);
        typeEffectiveness.Add("Flying-Rock", 5);
        typeEffectiveness.Add("Flying-Steel", 5);
        //Psychic
        typeEffectiveness.Add("Psychic-G", 5);
    }

    private void Update()
    {
        playerMonster = manager.currentPlayerMonster;
        enemyMonster = manager.currentEnemyMonster;
    }

    public void CheckEffectiveOnPlayer()
    {
        effectiveness = typeEffectiveness[enemyMonster.Type + "-" + playerMonster.Type];
    }
    
    public void CheckEffectiveOnEnemy()
    {
        effectiveness = typeEffectiveness[playerMonster.Type + "-" + enemyMonster.Type];
    }
}
