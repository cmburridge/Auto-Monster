using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateParty : MonoBehaviour
{
    public BattleManager manager;

    public bool playerMon = true;
    public int value;
    void Update()
    {
        if (playerMon == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = manager.playerMonsters[value].art;
            if (value > manager.playerMonsters.Capacity)
            {
                Disable(); 
            }
        }

        if (playerMon == false)
        {
            this.GetComponent<SpriteRenderer>().sprite = manager.enemyMonsters[value].art;
            if (value > manager.enemyMonsters.Capacity)
            {
                Disable(); 
            }
        }
    }

    public void Disable()
    {
        Destroy(this.gameObject);
    }
}
