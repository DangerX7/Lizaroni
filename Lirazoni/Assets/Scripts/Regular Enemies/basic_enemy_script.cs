using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_enemy_script : MonoBehaviour
{
    public byte spawnCheck;
    public bool invincibile;
    public SpriteRenderer spriteRenderer;
    public bool versus2P_enemy;
    public bool isEnemyAttacking;
    public Animator animator;

    public void Start()
    {
        if (invincibile == true)
        {
            gameObject.tag = "ArmourEnemy";
            spriteRenderer.color = new Color(0.32f,0.32f,0.32f, 1f);
        }
    }

    public void Update()
    {
        animator.SetBool("attack", isEnemyAttacking);
    }

    public void OnDestroy()
    {
        if (spawnCheck == 1)
        {
            GameObject keyCard = Instantiate(Resources.Load("Key")) as GameObject;
            keyCard.transform.position = transform.position;
        }
        if (spawnCheck == 2)
        {
            GameObject keyCard = Instantiate(Resources.Load("Special Key")) as GameObject;
            keyCard.transform.position = transform.position;
        }
        if (spawnCheck == 3)
        {
            GameObject armour = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
            armour.transform.position = transform.position;
        }
        if (spawnCheck == 4)
        {
            GameObject keyCard = Instantiate(Resources.Load("Special Key 6")) as GameObject;
            keyCard.transform.position = transform.position;
        }
    }
}
