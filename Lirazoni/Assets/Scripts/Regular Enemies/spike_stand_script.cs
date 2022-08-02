using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike_stand_script : MonoBehaviour
{
    public GameObject spike;

    public SpriteRenderer spriteRenderer;
    public Sprite defend, attack;

    public int id;
    public bool standBy;
    public bool invincibile;
    portal_master_object_script p;
    public bool turnCheck;
    public bool versus2P_enemy;

    public Animator animator;
    public bool isOpened;

    // Start is called before the first frame update
    void Start()
    {
        turnCheck = standBy;
        if (GameObject.Find("Portal Master Object") != null)
        {
            p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
        }
        if (invincibile == true)
        {
            gameObject.tag = "ArmourEnemy";
            spriteRenderer.color = new Color(0.32f, 0.32f, 0.32f, 1f);
        }
        if (standBy == true)
        {
            //   spriteRenderer.sprite = defend;
            isOpened = false;
        }
        else
        {
            //   spriteRenderer.sprite = attack;
            isOpened = true;
        }
        master_script.current.onEnemiesAttack += SpriteChange;
        master_script.current.onEnemiesAttackReverse += SpriteChange;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isOpen", isOpened);
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                if (turnCheck == false)
                {
                    standBy = false;
                }
                if (turnCheck == true)
                {
                    standBy = true;
                }
            }
        }
    }

    IEnumerator DamagePrevent()
    {
        yield return new WaitForSeconds(0.2f);
        transform.GetChild(0).gameObject.SetActive(true);
        //   spriteRenderer.sprite = attack;
        isOpened = true;
        standBy = false;
    }

    public void SpriteChange(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                if (standBy == false)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                    //   spriteRenderer.sprite = defend;
                    isOpened = false;
                    standBy = true;
                }
                else if (standBy == true)
                {
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(DamagePrevent());
                    }
                }
            }
        }
    }
    /*
    private void OnEnemiesAdvance(int id)
    {
        if (id == this.id)
        {
            Vector3 up = new Vector3(0, 0.00f, 0);
            transform.position += up;
        }
    }
    */
    public void OnDestroy()
    {
        master_script.current.onEnemiesAttack -= SpriteChange;
        master_script.current.onEnemiesAttackReverse -= SpriteChange;
    }
}
