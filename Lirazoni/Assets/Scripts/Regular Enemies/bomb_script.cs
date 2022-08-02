using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_script : MonoBehaviour
{
    public int bombTimer;
    public int id;
    public SpriteRenderer spriteRenderer;
    public Sprite one, two, nothing;
    public bool invincibile;
    portal_master_object_script p;
    public int bombTimerCheck;
    public bool versus2P_enemy;
    public bool resetBombTimer;

    public Animator animator;
    public int animations;
    public bool isReverseActive;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Portal Master Object") != null)
        {
            p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
        }
        bombTimerCheck = bombTimer;
        if (invincibile == true)
        {
            gameObject.tag = "ArmourEnemy";
            spriteRenderer.color = new Color(0.32f, 0.32f, 0.32f, 1f);
        }
        master_script.current.onEnemiesAttack += SpriteChange;
        master_script.current.onEnemiesAttackReverse += SpriteChangeReverse;
        if (bombTimer == 1)
        {
            animations = 1;
            //spriteRenderer.sprite = two;
        }
    }

    IEnumerator DamagePrevent()
    {
        animations = 2;
        //spriteRenderer.sprite = nothing;
        yield return new WaitForSeconds(0.3f);
        transform.GetChild(0).gameObject.SetActive(true);
      //  Debug.Log("ON");
    }

    public void SpriteChange(int id)
    {
        isReverseActive = false;
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                bombTimer += 1;
                if (bombTimer == 0)
                {
                    animations = 3;
                    //spriteRenderer.sprite = one;
                }
                else if (bombTimer == 1)
                {
                    animations = 1;
                    //spriteRenderer.sprite = two;
                }
                else if (bombTimer == 2)
                {
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(DamagePrevent());
                    }
                }
                else if (bombTimer == 3)
                {
                    animations = 3;
                    //spriteRenderer.sprite = one;
                 //   Debug.Log("OFF");
                    bombTimer = 0;
                }
            }
        }
    }
    public void SpriteChangeReverse(int id)
    {
        isReverseActive = true;
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                bombTimer -= 1;
                if (bombTimer == -1)
                {
                    bombTimer = 2;
                }
                if (bombTimer == 0)
                {
                    animations = 5;
                    //spriteRenderer.sprite = one;
                }
                else if (bombTimer == 1)
                {
                    animations = 4;
                    //spriteRenderer.sprite = two;
                }
                else if (bombTimer == 2)
                {
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(DamagePrevent());
                    }
                }
                else if (bombTimer == 3)
                {
                    animations = 5;
                    //spriteRenderer.sprite = one;
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("animation", animations);
        if ((isReverseActive == false) && (bombTimer == 0))
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        if ((isReverseActive == true) && ((bombTimer == 1) || (bombTimer == 3)))
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                if (bombTimerCheck == 0)
                {
                    bombTimer = 0;
                    animations = 3;
                    //spriteRenderer.sprite = one;
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                if (bombTimerCheck == 1)
                {
                    bombTimer = 1;
                    animations = 1;
                    //spriteRenderer.sprite = two;
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                if (bombTimerCheck == 2)
                {
                    bombTimer = 2;
                }
            }
        }
            //  Debug.Log(bombTimer);
    }

    public void OnDestroy()
    {
        master_script.current.onEnemiesAttack -= SpriteChange;
        master_script.current.onEnemiesAttackReverse -= SpriteChangeReverse;
    }
}
