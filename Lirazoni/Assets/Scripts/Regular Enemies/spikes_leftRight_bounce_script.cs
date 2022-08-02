using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes_leftRight_bounce_script : MonoBehaviour
{
    public GameObject spike, leftLimit, rightLimit;
    public int id;
    public bool goingRight;

    public SpriteRenderer spriteRenderer;
    public Sprite leftX, rightX;

    public bool colReset;
    public bool isReverseTrue;
    Vector3 leftLimitX;
    Vector3 rightLimitX;
    public bool invincibile;
    Vector3 originalPos;
    public bool dirrectionCheck = false;
    portal_master_object_script p;
    public bool versus2P_enemy;

    public Animator animator;
    public int animationVariable;
    public bool animationLock;

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.1f);
        colReset = false;
        if (isReverseTrue == false)
        {
            if (goingRight == true)
            {
                transform.position = leftLimitX;
            }
            else
            {
                transform.position = rightLimitX;
            }
        }
        else
        {

            if (goingRight == true)
            {
                transform.position = rightLimitX;
            }
            else
            {
                transform.position = leftLimitX;
            }
        }
        if (animationVariable == 2)
        {
            animationVariable = 1;
        }
        if (animationVariable == 3)
        {
            animationVariable = 0;
        }
        yield return new WaitForSeconds(0.1f);
        animationLock = false;
    }

    IEnumerator SpinTimer()
    {
        if(animationLock == false)
        {
            animationVariable = 3;
        }
        yield return new WaitForSeconds(0.15f);
        if (animationLock == false)
        {
            animationVariable = 0;
        }
    }
    IEnumerator SpinTimerBack()
    {
        if (animationLock == false)
        {
            animationVariable = 2;
        }
        yield return new WaitForSeconds(0.15f);
        if (animationLock == false)
        {
            animationVariable = 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Portal Master Object") != null)
        {
            p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
        }
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        if (invincibile == true)
        {
            gameObject.tag = "ArmourEnemy";
            spriteRenderer.color = new Color(0.32f, 0.32f, 0.32f, 1f);
        }
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;
        leftLimitX = new Vector3(leftLimit.transform.position.x, leftLimit.transform.position.y, leftLimit.transform.position.z);
        rightLimitX = new Vector3(rightLimit.transform.position.x, rightLimit.transform.position.y, rightLimit.transform.position.z);

        if (goingRight == false)
        {
            animationVariable = 0;
            spriteRenderer.sprite = leftX;
        }
        else if (goingRight == true)
        {
            animationVariable = 1;
            spriteRenderer.sprite = rightX;
        }
    }
    private void OnEnemiesAdvance(int id)
    {
        if ((id == this.id) && (colReset == false))
        {
            if (gameObject.activeSelf)
            {
                isReverseTrue = false;
                Vector3 left = new Vector3(-0.04f, 0, 0);
                Vector3 right = new Vector3(0.04f, 0, 0);
                if (goingRight == false)
                {
                    StartCoroutine(SpinTimer());
                    transform.position += left;
                }
                else if (goingRight == true)
                {
                    StartCoroutine(SpinTimerBack());
                    transform.position += right;
                }
            }
        }
    }
    private void OnEnemiesAdvanceReverse(int id)
    {
        if ((id == this.id) && (colReset == false))
        {
            if (gameObject.activeSelf)
            {
                isReverseTrue = true;
                Vector3 left = new Vector3(-0.04f, 0, 0);
                Vector3 right = new Vector3(0.04f, 0, 0);
                if (goingRight == false)
                {
                    StartCoroutine(SpinTimerBack());
                    transform.position += right;
                }
                else if (goingRight == true)
                {
                    StartCoroutine(SpinTimer());
                    transform.position += left;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector3 left = new Vector3(-0.24f, 0, 0);
        Vector3 right = new Vector3(0.24f, 0, 0);

        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")))
        {
            GameObject Player = GameObject.Find("Player");
            player_script colRef = Player.GetComponent<player_script>();
            if (id == 0)
            {
                colReset = true;
                if (goingRight == false)
                {
                    if (isReverseTrue == false)
                    {
                        spike.transform.position -= left;
                        spike.transform.position -= left;
                        goingRight = true;
                        if (animationLock == false)
                        {
                            animationVariable = 2;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = rightX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                    if (isReverseTrue == true)
                    {
                        spike.transform.position -= right;
                        spike.transform.position -= right;
                        goingRight = true;
                        if (animationLock == false)
                        {
                            animationVariable = 2;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = rightX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                }
                else if (goingRight == true)
                {
                    if (isReverseTrue == false)
                    {
                        spike.transform.position -= right;
                        spike.transform.position -= right;
                        goingRight = false;
                        if (animationLock == false)
                        {
                            animationVariable = 3;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = leftX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                    if (isReverseTrue == true)
                    {
                        spike.transform.position -= left;
                        spike.transform.position -= left;
                        goingRight = false;
                        if (animationLock == false)
                        {
                            animationVariable = 3;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = leftX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                }
            }
            if (id == 1)
            {
                colReset = true;
                if (goingRight == false)
                {
                    if (isReverseTrue == false)
                    {
                        spike.transform.position -= left;
                        spike.transform.position -= left;
                        goingRight = true;
                        if (animationLock == false)
                        {
                            animationVariable = 2;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = rightX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                    if (isReverseTrue == true)
                    {
                        spike.transform.position -= right;
                        spike.transform.position -= right;
                        goingRight = true;
                        if (animationLock == false)
                        {
                            animationVariable = 2;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = rightX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                }
                else if (goingRight == true)
                {
                    if (isReverseTrue == false)
                    {
                        spike.transform.position -= right;
                        spike.transform.position -= right;
                        goingRight = false;
                        if (animationLock == false)
                        {
                            animationVariable = 3;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = leftX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                    if (isReverseTrue == true)
                    {
                        spike.transform.position -= left;
                        spike.transform.position -= left;
                        goingRight = false;
                        if (animationLock == false)
                        {
                            animationVariable = 3;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = leftX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                }
            }
        }
    }
    public void Update()
    {
        animator.SetInteger("animationVariable", animationVariable);
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                if (dirrectionCheck == false)
                {
                    goingRight = false;
                }
                if (dirrectionCheck == true)
                {
                    goingRight = true;
                }
                colReset = false;
                isReverseTrue = false;
            }
        }
        if (gameObject.activeSelf == false)
        {
            transform.position = originalPos;
        }
    }
    public void OnDestroy()
    {
        master_script.current.onEnemiesMove -= OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse -= OnEnemiesAdvanceReverse;
    }
}
