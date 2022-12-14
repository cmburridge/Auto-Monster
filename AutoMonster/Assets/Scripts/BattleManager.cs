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

    public TypeDictionary types;
    public int effectiveness = 10;

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
    }
}


