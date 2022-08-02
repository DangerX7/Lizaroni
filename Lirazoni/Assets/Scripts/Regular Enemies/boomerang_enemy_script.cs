using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class boomerang_enemy_script : MonoBehaviour
{
    public int id;
  //  public bool throwing;
    public SpriteRenderer spriteRenderer;
    public Sprite stand, throwA, throwB;
    public bool isReverseTrue;
    public int moveCount;
    public bool invincibile;
    portal_master_object_script p;
    public bool versus2P_enemy;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Portal Master Object") != null)
        {
            p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
        }
        if (invincibile == true)
        {
            gameObject.tag = "ArmourEnemy";
            spriteRenderer.color = new Color(0.32f, 0.32f, 0.32f, 1f);
        }
        master_script.current.onEnemiesMove += SpriteChange;
        master_script.current.onEnemiesMoveReverse += SpriteChangeReverse;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.001f);
        (this.gameObject).SetActive(false);
    }

    public void SpriteChange(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                moveCount += 1;
                if (moveCount == 0)
                {
                    spriteRenderer.sprite = throwA;
                    //   transform.GetChild(0).gameObject.SetActive(false);
                }
                if (moveCount == (1 * 16) -15)
                {
                    spriteRenderer.sprite = throwB;
                    transform.GetChild(0).gameObject.SetActive(true);
                }
                if ((moveCount == (2 * 16) - 15) || (moveCount == (3 * 16) - 15) || (moveCount == (4 * 16) - 15))
                {
                    spriteRenderer.sprite = stand;
                }
                if (moveCount == (5 * 16) -15)
                {
                    spriteRenderer.sprite = throwA;
                }

                if (moveCount == 6 * 16)
                {
                    moveCount = 0;
                }
            }
        }
    }
    public void SpriteChangeReverse(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                moveCount -= 1;
                if (moveCount == 0)
                {
                    spriteRenderer.sprite = throwA;
                    //   transform.GetChild(0).gameObject.SetActive(false);
                }
                if (moveCount == -((1 * 16) - 15))
                {
                    spriteRenderer.sprite = throwB;
                    transform.GetChild(0).gameObject.SetActive(true);
                }
                if ((moveCount == -((2 * 16) - 15)) || (moveCount == -((3 * 16) - 15)) || (moveCount == -((4 * 16) - 15)))
                {
                    spriteRenderer.sprite = stand;
                }
                if (moveCount == -((5 * 16) - 15))
                {
                    spriteRenderer.sprite = throwA;
                }

                if (moveCount == -(6 * 16))
                {
                    moveCount = 0;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                isReverseTrue = false;
                moveCount = 0;
            }
        }
    }
    public void OnDestroy()
    {
        master_script.current.onEnemiesMove -= SpriteChange;
        master_script.current.onEnemiesMoveReverse -= SpriteChangeReverse;
    }
}
