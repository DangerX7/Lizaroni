using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes_upRight_script : MonoBehaviour
{
    public GameObject spike;
    public int id;

    public int exitMovesMultiplier = 0;
    public bool isReverseTrue;
    Vector3 originalPos;
    public int moves;
    public bool invincibile;
    public SpriteRenderer spriteRenderer;
    portal_master_object_script p;
    public bool versus2P_enemy;

    public Animator animator;
    public bool move;


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
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;

        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
    private void OnEnemiesAdvance(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                moves += 1;
                move = true;
                isReverseTrue = false;
                Vector3 upRight = new Vector3(0.04f, 0.04f, 0);
                transform.position += upRight;
            }
        }
    }
    private void OnEnemiesAdvanceReverse(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                moves -= 1;
                move = true;
                isReverseTrue = true;
                Vector3 downLeft = new Vector3(-0.04f, -0.04f, 0);
                transform.position += downLeft;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector3 upRight = new Vector3(0.64f, 0.64f, 0);

        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")))
        {
            if (isReverseTrue == false)
            {
                spike.transform.position -= upRight * exitMovesMultiplier;
            }
            if (isReverseTrue == true)
            {
                spike.transform.position += upRight * exitMovesMultiplier;
            }
        }
    }
    public void OnDestroy()
    {
        master_script.current.onEnemiesMove -= OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse -= OnEnemiesAdvanceReverse;
    }
    public void Update()
    {
        animator.SetBool("isMoving", move);
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                isReverseTrue = false;
                moves = 0;
            }
        }
        if (gameObject.activeSelf == false)
        {
            transform.position = originalPos;
        }
        if ((moves == -(exitMovesMultiplier) * 16) || (moves == (exitMovesMultiplier) * 16))
        {
            transform.position = originalPos;
            moves = 0;
        }
    }
}
