using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    public TypeDictionary types;
    public int effectiveness = 10;

    public ListData playerTeam;
    public ListData enemyTeam;

    void Start()
    {
        //Player
        int value = 0;
        playerMonsters[value].art = playerTeam.monsterList[value].art;
        playerMonsters[value].AttackPower = playerTeam.monsterList[value].AttackPower;
        playerMonsters[value].Attack = playerTeam.monsterList[value].Attack;
        playerMonsters[value].Defense = playerTeam.monsterList[value].Defense;
        playerMonsters[value].SpecialAttack = playerTeam.monsterList[value].SpecialAttack;
        playerMonsters[value].SpecialDefense = playerTeam.monsterList[value].SpecialDefense;
        playerMonsters[value].Speed = playerTeam.monsterList[value].Speed;
        playerMonsters[value].Type = playerTeam.monsterList[value].Type;
        playerMonsters[value].MonsterName = playerTeam.monsterList[value].MonsterName;
        playerMonsters[value].CurrentHP = playerTeam.monsterList[value].CurrentHP;
        playerMonsters[value].MaxHP = playerTeam.monsterList[value].MaxHP;
        playerMonsters[value].Level = playerTeam.monsterList[value].Level;
        
        value = 1;
        playerMonsters[value].art = playerTeam.monsterList[value].art;
        playerMonsters[value].AttackPower = playerTeam.monsterList[value].AttackPower;
        playerMonsters[value].Attack = playerTeam.monsterList[value].Attack;
        playerMonsters[value].Defense = playerTeam.monsterList[value].Defense;
        playerMonsters[value].SpecialAttack = playerTeam.monsterList[value].SpecialAttack;
        playerMonsters[value].SpecialDefense = playerTeam.monsterList[value].SpecialDefense;
        playerMonsters[value].Speed = playerTeam.monsterList[value].Speed;
        playerMonsters[value].Type = playerTeam.monsterList[value].Type;
        playerMonsters[value].MonsterName = playerTeam.monsterList[value].MonsterName;
        playerMonsters[value].CurrentHP = playerTeam.monsterList[value].CurrentHP;
        playerMonsters[value].MaxHP = playerTeam.monsterList[value].MaxHP;
        playerMonsters[value].Level = playerTeam.monsterList[value].Level;
        
        value = 2;
        playerMonsters[value].art = playerTeam.monsterList[value].art;
        playerMonsters[value].AttackPower = playerTeam.monsterList[value].AttackPower;
        playerMonsters[value].Attack = playerTeam.monsterList[value].Attack;
        playerMonsters[value].Defense = playerTeam.monsterList[value].Defense;
        playerMonsters[value].SpecialAttack = playerTeam.monsterList[value].SpecialAttack;
        playerMonsters[value].SpecialDefense = playerTeam.monsterList[value].SpecialDefense;
        playerMonsters[value].Speed = playerTeam.monsterList[value].Speed;
        playerMonsters[value].Type = playerTeam.monsterList[value].Type;
        playerMonsters[value].MonsterName = playerTeam.monsterList[value].MonsterName;
        playerMonsters[value].CurrentHP = playerTeam.monsterList[value].CurrentHP;
        playerMonsters[value].MaxHP = playerTeam.monsterList[value].MaxHP;
        playerMonsters[value].Level = playerTeam.monsterList[value].Level;
        
        value = 3;
        playerMonsters[value].art = playerTeam.monsterList[value].art;
        playerMonsters[value].AttackPower = playerTeam.monsterList[value].AttackPower;
        playerMonsters[value].Attack = playerTeam.monsterList[value].Attack;
        playerMonsters[value].Defense = playerTeam.monsterList[value].Defense;
        playerMonsters[value].SpecialAttack = playerTeam.monsterList[value].SpecialAttack;
        playerMonsters[value].SpecialDefense = playerTeam.monsterList[value].SpecialDefense;
        playerMonsters[value].Speed = playerTeam.monsterList[value].Speed;
        playerMonsters[value].Type = playerTeam.monsterList[value].Type;
        playerMonsters[value].MonsterName = playerTeam.monsterList[value].MonsterName;
        playerMonsters[value].CurrentHP = playerTeam.monsterList[value].CurrentHP;
        playerMonsters[value].MaxHP = playerTeam.monsterList[value].MaxHP;
        playerMonsters[value].Level = playerTeam.monsterList[value].Level;
        
        value = 4;
        playerMonsters[value].art = playerTeam.monsterList[value].art;
        playerMonsters[value].AttackPower = playerTeam.monsterList[value].AttackPower;
        playerMonsters[value].Attack = playerTeam.monsterList[value].Attack;
        playerMonsters[value].Defense = playerTeam.monsterList[value].Defense;
        playerMonsters[value].SpecialAttack = playerTeam.monsterList[value].SpecialAttack;
        playerMonsters[value].SpecialDefense = playerTeam.monsterList[value].SpecialDefense;
        playerMonsters[value].Speed = playerTeam.monsterList[value].Speed;
        playerMonsters[value].Type = playerTeam.monsterList[value].Type;
        playerMonsters[value].MonsterName = playerTeam.monsterList[value].MonsterName;
        playerMonsters[value].CurrentHP = playerTeam.monsterList[value].CurrentHP;
        playerMonsters[value].MaxHP = playerTeam.monsterList[value].MaxHP;
        playerMonsters[value].Level = playerTeam.monsterList[value].Level;
        
        value = 5;
        playerMonsters[value].art = playerTeam.monsterList[value].art;
        playerMonsters[value].AttackPower = playerTeam.monsterList[value].AttackPower;
        playerMonsters[value].Attack = playerTeam.monsterList[value].Attack;
        playerMonsters[value].Defense = playerTeam.monsterList[value].Defense;
        playerMonsters[value].SpecialAttack = playerTeam.monsterList[value].SpecialAttack;
        playerMonsters[value].SpecialDefense = playerTeam.monsterList[value].SpecialDefense;
        playerMonsters[value].Speed = playerTeam.monsterList[value].Speed;
        playerMonsters[value].Type = playerTeam.monsterList[value].Type;
        playerMonsters[value].MonsterName = playerTeam.monsterList[value].MonsterName;
        playerMonsters[value].CurrentHP = playerTeam.monsterList[value].CurrentHP;
        playerMonsters[value].MaxHP = playerTeam.monsterList[value].MaxHP;
        playerMonsters[value].Level = playerTeam.monsterList[value].Level;
        
        //Enemy
        value = 0;
        enemyMonsters[value].art = enemyTeam.monsterList[value].art;
        enemyMonsters[value].AttackPower = enemyTeam.monsterList[value].AttackPower;
        enemyMonsters[value].Attack = enemyTeam.monsterList[value].Attack;
        enemyMonsters[value].Defense = enemyTeam.monsterList[value].Defense;
        enemyMonsters[value].SpecialAttack = enemyTeam.monsterList[value].SpecialAttack;
        enemyMonsters[value].SpecialDefense = enemyTeam.monsterList[value].SpecialDefense;
        enemyMonsters[value].Speed = enemyTeam.monsterList[value].Speed;
        enemyMonsters[value].Type = enemyTeam.monsterList[value].Type;
        enemyMonsters[value].MonsterName = enemyTeam.monsterList[value].MonsterName;
        enemyMonsters[value].CurrentHP = enemyTeam.monsterList[value].CurrentHP;
        enemyMonsters[value].MaxHP = enemyTeam.monsterList[value].MaxHP;
        enemyMonsters[value].Level = enemyTeam.monsterList[value].Level;
        
        value = 1;
        enemyMonsters[value].art = enemyTeam.monsterList[value].art;
        enemyMonsters[value].AttackPower = enemyTeam.monsterList[value].AttackPower;
        enemyMonsters[value].Attack = enemyTeam.monsterList[value].Attack;
        enemyMonsters[value].Defense = enemyTeam.monsterList[value].Defense;
        enemyMonsters[value].SpecialAttack = enemyTeam.monsterList[value].SpecialAttack;
        enemyMonsters[value].SpecialDefense = enemyTeam.monsterList[value].SpecialDefense;
        enemyMonsters[value].Speed = enemyTeam.monsterList[value].Speed;
        enemyMonsters[value].Type = enemyTeam.monsterList[value].Type;
        enemyMonsters[value].MonsterName = enemyTeam.monsterList[value].MonsterName;
        enemyMonsters[value].CurrentHP = enemyTeam.monsterList[value].CurrentHP;
        enemyMonsters[value].MaxHP = enemyTeam.monsterList[value].MaxHP;
        enemyMonsters[value].Level = enemyTeam.monsterList[value].Level;
        
        value = 2;
        enemyMonsters[value].art = enemyTeam.monsterList[value].art;
        enemyMonsters[value].AttackPower = enemyTeam.monsterList[value].AttackPower;
        enemyMonsters[value].Attack = enemyTeam.monsterList[value].Attack;
        enemyMonsters[value].Defense = enemyTeam.monsterList[value].Defense;
        enemyMonsters[value].SpecialAttack = enemyTeam.monsterList[value].SpecialAttack;
        enemyMonsters[value].SpecialDefense = enemyTeam.monsterList[value].SpecialDefense;
        enemyMonsters[value].Speed = enemyTeam.monsterList[value].Speed;
        enemyMonsters[value].Type = enemyTeam.monsterList[value].Type;
        enemyMonsters[value].MonsterName = enemyTeam.monsterList[value].MonsterName;
        enemyMonsters[value].CurrentHP = enemyTeam.monsterList[value].CurrentHP;
        enemyMonsters[value].MaxHP = enemyTeam.monsterList[value].MaxHP;
        enemyMonsters[value].Level = enemyTeam.monsterList[value].Level;
        
        value = 3;
        enemyMonsters[value].art = enemyTeam.monsterList[value].art;
        enemyMonsters[value].AttackPower = enemyTeam.monsterList[value].AttackPower;
        enemyMonsters[value].Attack = enemyTeam.monsterList[value].Attack;
        enemyMonsters[value].Defense = enemyTeam.monsterList[value].Defense;
        enemyMonsters[value].SpecialAttack = enemyTeam.monsterList[value].SpecialAttack;
        enemyMonsters[value].SpecialDefense = enemyTeam.monsterList[value].SpecialDefense;
        enemyMonsters[value].Speed = enemyTeam.monsterList[value].Speed;
        enemyMonsters[value].Type = enemyTeam.monsterList[value].Type;
        enemyMonsters[value].MonsterName = enemyTeam.monsterList[value].MonsterName;
        enemyMonsters[value].CurrentHP = enemyTeam.monsterList[value].CurrentHP;
        enemyMonsters[value].MaxHP = enemyTeam.monsterList[value].MaxHP;
        enemyMonsters[value].Level = enemyTeam.monsterList[value].Level;
        
        value = 4;
        enemyMonsters[value].art = enemyTeam.monsterList[value].art;
        enemyMonsters[value].AttackPower = enemyTeam.monsterList[value].AttackPower;
        enemyMonsters[value].Attack = enemyTeam.monsterList[value].Attack;
        enemyMonsters[value].Defense = enemyTeam.monsterList[value].Defense;
        enemyMonsters[value].SpecialAttack = enemyTeam.monsterList[value].SpecialAttack;
        enemyMonsters[value].SpecialDefense = enemyTeam.monsterList[value].SpecialDefense;
        enemyMonsters[value].Speed = enemyTeam.monsterList[value].Speed;
        enemyMonsters[value].Type = enemyTeam.monsterList[value].Type;
        enemyMonsters[value].MonsterName = enemyTeam.monsterList[value].MonsterName;
        enemyMonsters[value].CurrentHP = enemyTeam.monsterList[value].CurrentHP;
        enemyMonsters[value].MaxHP = enemyTeam.monsterList[value].MaxHP;
        enemyMonsters[value].Level = enemyTeam.monsterList[value].Level;
        
        value = 5;
        enemyMonsters[value].art = enemyTeam.monsterList[value].art;
        enemyMonsters[value].AttackPower = enemyTeam.monsterList[value].AttackPower;
        enemyMonsters[value].Attack = enemyTeam.monsterList[value].Attack;
        enemyMonsters[value].Defense = enemyTeam.monsterList[value].Defense;
        enemyMonsters[value].SpecialAttack = enemyTeam.monsterList[value].SpecialAttack;
        enemyMonsters[value].SpecialDefense = enemyTeam.monsterList[value].SpecialDefense;
        enemyMonsters[value].Speed = enemyTeam.monsterList[value].Speed;
        enemyMonsters[value].Type = enemyTeam.monsterList[value].Type;
        enemyMonsters[value].MonsterName = enemyTeam.monsterList[value].MonsterName;
        enemyMonsters[value].CurrentHP = enemyTeam.monsterList[value].CurrentHP;
        enemyMonsters[value].MaxHP = enemyTeam.monsterList[value].MaxHP;
        enemyMonsters[value].Level = enemyTeam.monsterList[value].Level;
        

        // select the first monster from each list as the current monster
        currentPlayerMonster = playerMonsters[0];
        playerMonsterArt.GetComponent<SpriteRenderer>().sprite = currentPlayerMonster.art;
        currentEnemyMonster = enemyMonsters[0];
        enemyMonsterArt.GetComponent<SpriteRenderer>().sprite = currentEnemyMonster.art;
    }

    void Update()
    {
        int playerAttackValue = 0;
        int enemyDefenseValue = 0;
        int superEffectiveStatis = 0;
        int randomValue = Random.Range(216, 255);
        
        if (currentPlayerMonster.Attack >= currentPlayerMonster.SpecialAttack)
        {
            playerAttackValue = currentPlayerMonster.Attack;
            enemyDefenseValue = currentEnemyMonster.Defense;

        }
        else if (currentPlayerMonster.Attack <= currentPlayerMonster.SpecialAttack)
        {
            playerAttackValue = currentPlayerMonster.SpecialAttack;
            enemyDefenseValue = currentEnemyMonster.SpecialDefense;
        }
        
        // get player's input for attack
        if (Input.GetKeyDown(KeyCode.Space))
        {
            effectiveness = types.typeEffectiveness[currentPlayerMonster.Type + "-" + currentEnemyMonster.Type];
            Debug.Log(currentPlayerMonster.Type + "-" + currentEnemyMonster.Type);
            
            if (effectiveness == 5)
            {
                Debug.Log("Not very effective");
            }
            else if (effectiveness == 20)
            {
                Debug.Log("Super Effective!");
            }

            int damagevalue = (((((2*currentPlayerMonster.Level/5+2)*(playerAttackValue*currentPlayerMonster.AttackPower/enemyDefenseValue)/50)+2)*effectiveness/10)*randomValue)/255;
            Debug.Log(damagevalue);
        }

        if (currentEnemyMonster.CurrentHP <= 0)
        {
            enemyMonsters.Remove(currentEnemyMonster);
            
            currentEnemyMonster = enemyMonsters[0];
            enemyMonsterArt.GetComponent<SpriteRenderer>().sprite = currentEnemyMonster.art;
        }
    }
}


