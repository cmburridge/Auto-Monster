using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    // list of player's monsters
    public List<MonsterData> playerMonsters = new List<MonsterData>();

    // list of enemy's monsters
    public List<MonsterData> enemyMonsters = new List<MonsterData>();

    // current player's monster
    public MonsterData currentPlayerMonster;

    public GameObject playerMonsterArt;

    // current enemy's monster
    public MonsterData currentEnemyMonster;
    
    public GameObject enemyMonsterArt;

    // turn counter
    public int turnCounter = 0;

    void Start()
    {
        // select the first monster from each list as the current monster
        currentPlayerMonster = playerMonsters[0];
        playerMonsterArt.GetComponent<SpriteRenderer>().sprite = currentPlayerMonster.art;
        currentEnemyMonster = enemyMonsters[0];
        enemyMonsterArt.GetComponent<SpriteRenderer>().sprite = currentEnemyMonster.art;
    }

    void Update()
    {
        // check if it's the player's turn
        if (turnCounter % 2 == 0)
        {
            // get player's input for attack
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (currentPlayerMonster.Speed >= currentEnemyMonster.Speed)
                {
                    if (currentPlayerMonster.Attack >= currentPlayerMonster.SpecialAttack)
                    {
                        // calculate attack power of current player's monster
                        var playerAttackPower = currentPlayerMonster.Attack;

                        // calculate defense power of current enemy's monster
                        var enemyDefensePower = currentEnemyMonster.Defense;

                        // subtract attack power from enemy's monsters health
                        currentEnemyMonster.CurrentHP -=
                            playerAttackPower % enemyDefensePower * 2;
                    }
                    else if (currentPlayerMonster.Attack < currentPlayerMonster.SpecialAttack)
                    {
                        // calculate attack power of current player's monster
                        var playerSPAttackPower = currentPlayerMonster.SpecialAttack;

                        // calculate defense power of current enemy's monster
                        var enemySPDefensePower = currentEnemyMonster.SpecialDefense;

                        // subtract attack power from enemy's monsters health
                        currentEnemyMonster.CurrentHP -=
                            playerSPAttackPower % enemySPDefensePower * 2;
                    }

                    // check if enemy's monster is defeated
                    if (currentEnemyMonster.CurrentHP <= 0)
                    {
                        // remove defeated monster from enemy's list
                        enemyMonsters.Remove(currentEnemyMonster);

                        // if there are more monsters in the enemy's list, select the next one as the current enemy's monster
                        if (enemyMonsters.Capacity > 0)
                        {
                            currentEnemyMonster = enemyMonsters[0];
                            enemyMonsterArt.GetComponent<SpriteRenderer>().sprite = currentEnemyMonster.art;
                        }
                    }
                }
                else if (currentPlayerMonster.Speed < currentEnemyMonster.Speed)
                {
                    if (currentEnemyMonster.Attack >= currentEnemyMonster.SpecialAttack)
                    {
                        // calculate attack power of current player's monster
                        var enemyAttackPower = currentEnemyMonster.Attack;

                        // calculate defense power of current enemy's monster
                        var playerDefensePower = currentPlayerMonster.Defense;

                        // subtract attack power from enemy's monsters health
                        currentPlayerMonster.CurrentHP -=
                            enemyAttackPower % playerDefensePower * 2;
                    }
                    else if (currentEnemyMonster.Attack < currentEnemyMonster.SpecialAttack)
                    {
                        // calculate attack power of current player's monster
                        var enemySPAttackPower = currentEnemyMonster.SpecialAttack;

                        // calculate defense power of current enemy's monster
                        var playerSPDefensePower = currentPlayerMonster.SpecialDefense;

                        // subtract attack power from enemy's monsters health
                        currentPlayerMonster.CurrentHP -=
                            enemySPAttackPower % playerSPDefensePower * 2;
                    }

                    // check if player's monster is defeated
                    if (currentPlayerMonster.CurrentHP <= 0)
                    {
                        // remove defeated monster from player's list
                        playerMonsters.Remove(currentPlayerMonster);

                        // if there are more monsters in the player's list, select the next one as the current player's monster
                        if (playerMonsters.Capacity > 0)
                        {
                            currentPlayerMonster = playerMonsters[0];
                            playerMonsterArt.GetComponent<SpriteRenderer>().sprite = currentPlayerMonster.art;
                        }
                    }
                }
            }
        }
    }
}


