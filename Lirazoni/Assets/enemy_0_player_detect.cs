using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_0_player_detect : MonoBehaviour
{
    public bool collisionCheck;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameObject Enemy = transform.parent.gameObject;
            basic_enemy_script attackReference = Enemy.GetComponent<basic_enemy_script>();
            collisionCheck = true;
            attackReference.isEnemyAttacking = true;
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        GameObject Enemy = transform.parent.gameObject;
        basic_enemy_script attackReference = Enemy.GetComponent<basic_enemy_script>();
        if (collision.gameObject.tag.Equals("Player"))
        {
            collisionCheck = false;
            attackReference.isEnemyAttacking = false;
        }
    }
}
