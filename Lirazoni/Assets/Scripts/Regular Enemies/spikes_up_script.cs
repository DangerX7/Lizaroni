using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes_up_script : MonoBehaviour
{
    public GameObject spike;
    public int id;
    public bool isReverseTrue;
    Vector3 originalPos;
    public int moves;
    public int mapDifference;
    public bool invincibile;
    public SpriteRenderer spriteRenderer;
    portal_master_object_script p;
    public bool versus2P_enemy;

    public Animator animator;
    public float miniMoves;

    public bool classicSpike; // dissable animation for classic mode spikes

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
                AnimationActivation();
                moves += 1;
                isReverseTrue = false;
                Vector3 up = new Vector3(0, 0.04f, 0);
                transform.position += up;
            }
        }
    }
    private void OnEnemiesAdvanceReverse(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                AnimationActivation();
                moves -= 1;
                isReverseTrue = true;
                Vector3 down = new Vector3(0, -0.04f, 0);
                transform.position += down;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector3 up = new Vector3(0, 0.64f, 0);
        Vector3 down = new Vector3(0, -0.64f, 0);
        Vector3 left = new Vector3(-0.64f, 0, 0);
        Vector3 right = new Vector3(0.64f, 0, 0);

        GameObject Master = GameObject.Find("MasterObject");
        master_script levelReference = Master.GetComponent<master_script>();

        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")))
        {
            if (id == 0)
            {
                if (isReverseTrue == false)
                {
                    spike.transform.position -= up * (levelReference.levelRows + mapDifference);
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += up * (levelReference.levelRows + mapDifference);
                }
            }
            if (id == 1)
            {
                if (isReverseTrue == false)
                {
                    spike.transform.position -= up * (levelReference.levelRowsV + mapDifference);
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += up * (levelReference.levelRowsV + mapDifference);
                }
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
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                moves = 0;
                miniMoves = 0;
                isReverseTrue = false;
            }
        }
        if (gameObject.activeInHierarchy == false)
        {
            transform.position = originalPos;
        }
        GameObject Master = GameObject.Find("MasterObject");
        master_script levelReference = Master.GetComponent<master_script>();
        if (id == 0)
        {
            if ((moves == -(mapDifference + levelReference.levelRows) * 16) || (moves == (mapDifference + levelReference.levelRows) * 16))
            {
                transform.position = originalPos;
                moves = 0;
            }
        }
        if (id == 1)
        {
            if ((moves == -(mapDifference + levelReference.levelRowsV) * 16) || (moves == (mapDifference + levelReference.levelRowsV) * 16))
            {
                transform.position = originalPos;
                moves = 0;
            }
        }

        if (classicSpike == false)
        {
            animator.SetFloat("Move", miniMoves);
        }

        if ((miniMoves >= 16) || (miniMoves <= -16))
        {
            miniMoves = 0;
        }

        if ((GameObject.Find("Player") != null) && (id == 0))
        {
            GameObject Player = GameObject.Find("Player");
            player_script aniStop = Player.GetComponent<player_script>();
            if (aniStop.animationStop == true)
            {
                miniMoves = 0;
            }
        }
        if ((GameObject.Find("Player2") != null) && (id == 1))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script aniStop2 = Player2.GetComponent<player_script>();
            if (aniStop2.animationStop == true)
            {
                miniMoves = 0;
            }
        }
    }

    public void AnimationActivation()
    {
        if ((GameObject.Find("Player") != null) && (id == 0))
        {
            GameObject Player = GameObject.Find("Player");
            player_script aniStop = Player.GetComponent<player_script>();
            if (aniStop.animationStop == false)
            {
                miniMoves += 1;
            }
        }
        if ((GameObject.Find("Player2") != null) && (id == 1))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script aniStop2 = Player2.GetComponent<player_script>();
            if (aniStop2.animationStop == false)
            {
                miniMoves += 1;
            }
        }
    }
}
