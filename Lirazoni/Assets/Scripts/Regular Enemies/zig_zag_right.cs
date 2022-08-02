using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zig_zag_right : MonoBehaviour
{
    public GameObject spike;

    public SpriteRenderer spriteRenderer;
    public Sprite stay, moveA, moveB;

    public bool sprite;
    public byte spriteCheck;
    public int id;
    public bool goingDownFirst = false;
    public bool isReverseTrue;
    Vector3 originalPos;
    public int moves;
    public int mapDifference;
    public bool invincibile;
    portal_master_object_script p;
    public bool firstDirrectionCheck;
    public byte oddNumberMap; // 0 (if the map lenght or width is 2,4,6,8,10) 1 (if the map lenght or width is 1,3,5,7,9,11)
    private bool differenceCheck;
    public bool versus2P_enemy;

    public Animator animator;
    public int rocketDirrection; // down = 1, up = 2
    public int animationMoves;

    // Start is called before the first frame update
    void Start()
    {
        firstDirrectionCheck = goingDownFirst;
        if (GameObject.Find("Portal Master Object") != null)
        {
            p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
        }
        if (invincibile == true)
        {
            gameObject.tag = "ArmourEnemy";
            spriteRenderer.color = new Color(0.32f, 0.32f, 0.32f, 1f);
        }
        sprite = true;
        master_script.current.onEnemiesAttack += SpriteChange;
        master_script.current.onEnemiesAttackReverse += SpriteChange;
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;

        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

        if (goingDownFirst == true)
        {
            spriteRenderer.sprite = moveB;
            rocketDirrection = -1;
        }
        else if (goingDownFirst == false)
        {
            spriteRenderer.sprite = moveA;
            rocketDirrection = -2;
        }
    }

    IEnumerator AnimationTimer()
    {
        sprite = false;
        yield return new WaitForSeconds(0.25f);
        sprite = true;
    }


    public void SpriteChange(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                StartCoroutine(AnimationTimer());
            }
        }
    }

    private void OnEnemiesAdvance(int id)
    {
        if (gameObject.activeSelf)
        {
            if ((id == this.id) && (id == 0))
            {
                moves += 1;
                animationMoves += 1;
                isReverseTrue = false;
                GameObject Master = GameObject.Find("MasterObject");
                master_script turnReference = Master.GetComponent<master_script>();
                Vector3 rightUp = new Vector3(0.04f, 0.04f);
                Vector3 rightDown = new Vector3(0.04f, -0.04f);
                if ((turnReference.enemyTurn > -1) && (turnReference.enemyTurn < 16))
                {
                    if (goingDownFirst == true)
                    {
                        spriteCheck = 1;
                        if (animationMoves == 10)
                        {
                            rocketDirrection = 2;
                        }
                        transform.position += rightDown;
                    }
                    else if (goingDownFirst == false)
                    {
                        spriteCheck = 1;
                        if (animationMoves == 10)
                        {
                            rocketDirrection = 1;
                        }
                        transform.position += rightUp;
                    }
                }
                else if ((turnReference.enemyTurn > 15) && (turnReference.enemyTurn < 33))
                {
                    if (goingDownFirst == true)
                    {
                        spriteCheck = 2;
                        if (animationMoves == 12)
                        {
                            rocketDirrection = 1;
                        }
                        transform.position += rightUp;
                    }
                    else if (goingDownFirst == false)
                    {
                        spriteCheck = 2;
                        if (animationMoves == 12)
                        {
                            rocketDirrection = 2;
                        }
                        transform.position += rightDown;
                    }
                }
            }
            else if ((id == this.id) && (id == 1))
            {
                moves += 1;
                animationMoves += 1;
                isReverseTrue = false;
                GameObject Master = GameObject.Find("MasterObject");
                master_script turnReference2 = Master.GetComponent<master_script>();
                Vector3 rightUp = new Vector3(0.04f, 0.04f);
                Vector3 rightDown = new Vector3(0.04f, -0.04f);
                if ((turnReference2.enemyTurn2 > -1) && (turnReference2.enemyTurn2 < 16))
                {
                    if (goingDownFirst == true)
                    {
                        Debug.Log("move = 1A");
                        spriteCheck = 1;
                        if (animationMoves == 10)
                        {
                            rocketDirrection = 2;
                        }
                        transform.position += rightDown;
                    }
                    else if (goingDownFirst == false)
                    {
                        Debug.Log("move = 1B");
                        spriteCheck = 1;
                        if (animationMoves == 10)
                        {
                            rocketDirrection = 1;
                        }
                        transform.position += rightUp;
                    }
                }
                else if ((turnReference2.enemyTurn2 > 15) && (turnReference2.enemyTurn2 < 33))
                {
                    if (goingDownFirst == true)
                    {
                        Debug.Log("move = 2A");
                        spriteCheck = 2;
                        if (animationMoves == 12)
                        {
                            rocketDirrection = 1;
                        }
                        transform.position += rightUp;
                    }
                    else if (goingDownFirst == false)
                    {
                        Debug.Log("move = 2B");
                        spriteCheck = 2;
                        if (animationMoves == 12)
                        {
                            rocketDirrection = 2;
                        }
                        transform.position += rightDown;
                    }
                }
            }
        }
    }
    private void OnEnemiesAdvanceReverse(int id)
    {
        if (gameObject.activeSelf)
        {
            if ((id == this.id) && (id == 0))
            {
                moves -= 1;
                animationMoves -= 1;
                isReverseTrue = true;
                GameObject Master = GameObject.Find("MasterObject");
                master_script turnReference = Master.GetComponent<master_script>();
                Vector3 leftDown = new Vector3(-0.04f, -0.04f);
                Vector3 leftUp = new Vector3(-0.04f, 0.04f);
                if ((turnReference.enemyTurn > -1) && (turnReference.enemyTurn < 16))
                {
                    if (goingDownFirst == true)
                    {
                        spriteCheck = 1;
                        if (animationMoves == -10)
                        {
                            rocketDirrection = 1;
                        }
                        transform.position += leftDown;
                    }
                    else if (goingDownFirst == false)
                    {
                        spriteCheck = 1;
                        if (animationMoves == -10)
                        {
                            rocketDirrection = 1;
                        }
                        transform.position += leftUp;
                    }
                }
                else if ((turnReference.enemyTurn > 15) && (turnReference.enemyTurn < 33))
                {
                    if (goingDownFirst == true)
                    {
                        spriteCheck = 2;
                        if (animationMoves == -12)
                        {
                            rocketDirrection = 2;
                        }
                        transform.position += leftUp;
                    }
                    else if (goingDownFirst == false)
                    {
                        spriteCheck = 2;
                        if (animationMoves == -12)
                        {
                            rocketDirrection = 2;
                        }
                        transform.position += leftDown;
                    }
                }
            }
            else if ((id == this.id) && (id == 1))
            {
                moves -= 1;
                animationMoves -= 1;
                isReverseTrue = true;
                GameObject Master = GameObject.Find("MasterObject");
                master_script turnReference2 = Master.GetComponent<master_script>();
                Vector3 leftDown = new Vector3(-0.04f, -0.04f);
                Vector3 leftUp = new Vector3(-0.04f, 0.04f);
                if ((turnReference2.enemyTurn2 > -1) && (turnReference2.enemyTurn2 < 16))
                {
                    if (goingDownFirst == true)
                    {
                        Debug.Log("move = 1A");
                        spriteCheck = 1;
                        if (animationMoves == -10)
                        {
                            rocketDirrection = 1;
                        }
                        transform.position += leftDown;
                    }
                    else if (goingDownFirst == false)
                    {
                        Debug.Log("move = 1B");
                        spriteCheck = 1;
                        if (animationMoves == -10)
                        {
                            rocketDirrection = 1;
                        }
                        transform.position += leftUp;
                    }
                }
                else if ((turnReference2.enemyTurn2 > 15) && (turnReference2.enemyTurn2 < 33))
                {
                    if (goingDownFirst == true)
                    {
                        Debug.Log("move = 2A");
                        spriteCheck = 2;
                        if (animationMoves == -12)
                        {
                            rocketDirrection = 2;
                        }
                        transform.position += leftUp;
                    }
                    else if (goingDownFirst == false)
                    {
                        Debug.Log("move = 2B");
                        spriteCheck = 2;
                        if (animationMoves == -12)
                        {
                            rocketDirrection = 2;
                        }
                        transform.position += leftDown;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector3 right = new Vector3(0.64f, 0, 0);

        GameObject Master = GameObject.Find("MasterObject");
        master_script levelReference = Master.GetComponent<master_script>();

        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")))
        {
            if (id == 0)
            {
                if (isReverseTrue == false)
                {
                    spike.transform.position -= right * (levelReference.levelColumns + mapDifference);
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += right * (levelReference.levelColumns + mapDifference);
                }
            }
            if (id == 1)
            {
                if (isReverseTrue == false)
                {
                    spike.transform.position -= right * (levelReference.levelColumnsV + mapDifference);
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += right * (levelReference.levelColumnsV + mapDifference);
                }
            }
        }
    }

    public void OnDestroy()
    {
        master_script.current.onEnemiesAttack -= SpriteChange;
        master_script.current.onEnemiesAttackReverse -= SpriteChange;
        master_script.current.onEnemiesMove -= OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse -= OnEnemiesAdvanceReverse;
    }
    void Update()
    {
     //   Debug.Log("AnimationMoves: " + animationMoves + " RocketDirrection: " + rocketDirrection);
        if ((animationMoves == 16) || (animationMoves == -16))
        {
            animationMoves = 0;
        }
        animator.SetInteger("dirrection", rocketDirrection);
        GameObject Master = GameObject.Find("MasterObject");
        master_script turnReference = Master.GetComponent<master_script>();
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                sprite = true;
                spriteCheck = 0;
                moves = 0;
                if (firstDirrectionCheck == false)
                {
                    goingDownFirst = false;
                }
                if (firstDirrectionCheck == true)
                {
                    goingDownFirst = true;
                }
                turnReference.enemyTurn = 0;
            }
        }
        if (gameObject.activeSelf == false)
        {
            transform.position = originalPos;
        }
        if (sprite == false)
        {
            if (spriteCheck == 1)
            {
                if (goingDownFirst == true)
                {
                    spriteRenderer.sprite = moveB;
                    rocketDirrection = -1;
                }
                else
                {
                    spriteRenderer.sprite = moveA;
                    rocketDirrection = -2;
                }
            }
            else if (spriteCheck == 2)
            {
                if (goingDownFirst == true)
                {
                    spriteRenderer.sprite = moveA;
                    rocketDirrection = -2;
                }
                else
                {
                    spriteRenderer.sprite = moveB;
                    rocketDirrection = -1;
                }
            }
        }
        else if (sprite == true)
        {
            //   spriteRenderer.sprite = stay;
            if (spriteCheck == 1)
            {
                if (goingDownFirst == true)
                {
                    spriteRenderer.sprite = moveA;
                    rocketDirrection = -2;
                }
                else
                {
                    spriteRenderer.sprite = moveB;
                    rocketDirrection = -1;
                }
            }
            else if (spriteCheck == 2)
            {
                if (goingDownFirst == true)
                {
                    spriteRenderer.sprite = moveB;
                    rocketDirrection = -1;
                }
                else
                {
                    spriteRenderer.sprite = moveA;
                    rocketDirrection = -2;
                }
            }
        }

        GameObject Master2 = GameObject.Find("MasterObject");
        master_script levelReference = Master2.GetComponent<master_script>();
        if (id == 0)
        {
            if ((moves == -(mapDifference + levelReference.levelColumns) * 16) || (moves == (mapDifference + levelReference.levelColumns) * 16))
            {
                differenceCheck = false;
                if (oddNumberMap == 0)
                {
                    transform.position = originalPos;
                }
                if (oddNumberMap == 1)
                {
                    Vector3 temp = new Vector3(0, 0.64f, 0);
                    if (goingDownFirst == false)
                    {
                        transform.position = originalPos + temp;
                    }
                    if (goingDownFirst == true)
                    {
                        transform.position = originalPos - temp;
                    }
                    oddNumberMap = 2;
                    differenceCheck = true;
                }
                if ((oddNumberMap == 2) && (differenceCheck == false))
                {
                    transform.position = originalPos;
                    oddNumberMap = 1;
                }
                moves = 0;
            }
        }
        if (id == 1)
        {
            if ((moves == -(mapDifference + levelReference.levelColumnsV) * 16) || (moves == (mapDifference + levelReference.levelColumnsV) * 16))
            {
                differenceCheck = false;
                if (oddNumberMap == 0)
                {
                    transform.position = originalPos;
                }
                if (oddNumberMap == 1)
                {
                    Vector3 temp = new Vector3(0, 0.64f, 0);
                    if (goingDownFirst == false)
                    {
                        transform.position = originalPos + temp;
                    }
                    if (goingDownFirst == true)
                    {
                        transform.position = originalPos - temp;
                    }
                    oddNumberMap = 2;
                    differenceCheck = true;
                }
                if ((oddNumberMap == 2) && (differenceCheck == false))
                {
                    transform.position = originalPos;
                    oddNumberMap = 1;
                }
                moves = 0;
            }
        }
    }
}
