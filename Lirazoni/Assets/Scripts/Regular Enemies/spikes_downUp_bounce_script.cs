using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes_downUp_bounce_script : MonoBehaviour
{
    public GameObject spike, downLimit, upLimit;
    public int id;
    public bool goingUp;

    public SpriteRenderer spriteRenderer;
    public Sprite downX, upX;

    public bool colReset;
    public bool isReverseTrue;
    Vector3 downLimitX;
    Vector3 upLimitX;
    public bool invincibile;
    Vector3 originalPos;
    public bool dirrectionCheck;
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
            if (goingUp == true)
            {
                transform.position = downLimitX;
            }
            else
            {
                transform.position = upLimitX;
            }
        }
        else
        {

            if (goingUp == true)
            {
                transform.position = upLimitX;
            }
            else
            {
                transform.position = downLimitX;
            }
        }
        if (animationVariable == 3)
        {
            animationVariable = 1;
        }
        if (animationVariable == 2)
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
        dirrectionCheck = goingUp;
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        if (invincibile == true)
        {
            gameObject.tag = "ArmourEnemy";
            spriteRenderer.color = new Color(0.32f, 0.32f, 0.32f, 1f);
        }
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;
        downLimitX = new Vector3(downLimit.transform.position.x, downLimit.transform.position.y, downLimit.transform.position.z);
        upLimitX = new Vector3(upLimit.transform.position.x, upLimit.transform.position.y, upLimit.transform.position.z);

        if (goingUp == false)
        {
            animationVariable = 1;
            spriteRenderer.sprite = downX;
        }
        else if (goingUp == true)
        {
            animationVariable = 0;
            spriteRenderer.sprite = upX;
        }
    }
    private void OnEnemiesAdvance(int id)
    {
        if ((id == this.id) && (colReset == false))
        {
            if (gameObject.activeSelf)
            {
                isReverseTrue = false;
                Vector3 down = new Vector3(0, -0.04f, 0);
                Vector3 up = new Vector3(0, 0.04f, 0);
                if (goingUp == false)
                {
                    if (colReset == false)
                    {
                        StartCoroutine(SpinTimerBack());
                    }
                    else
                    {
                        animationVariable = 0;
                    }
                    transform.position += down;
                }
                else if (goingUp == true)
                {
                    if (colReset == false)
                    {
                        StartCoroutine(SpinTimer());
                    }
                    else
                    {
                        animationVariable = 1;
                    }
                    transform.position += up;
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
                Vector3 down = new Vector3(0, -0.04f, 0);
                Vector3 up = new Vector3(0, 0.04f, 0);
                if (goingUp == false)
                {
                    if (colReset == false)
                    {
                        StartCoroutine(SpinTimer());
                    }
                    else
                    {
                        animationVariable = 1;
                    }
                    transform.position += up;
                }
                else if (goingUp == true)
                {
                    if (colReset == false)
                    {
                        StartCoroutine(SpinTimerBack());
                    }
                    else
                    {
                        animationVariable = 0;
                    }
                    transform.position += down;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector3 up = new Vector3(0, 0.20f, 0);
        Vector3 down = new Vector3(0, -0.20f, 0);

        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")))
        {
            if (id == 0)
            {
                colReset = true;
                if (goingUp == false)
                {
                    if (isReverseTrue == false)
                    {
                        spike.transform.position -= down;
                        spike.transform.position -= down;
                        goingUp = true;
                        if (animationLock == false)
                        {
                            animationVariable = 2;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = upX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                    if (isReverseTrue == true)
                    {
                        spike.transform.position -= up;
                        spike.transform.position -= up;
                        goingUp = true;
                        if (animationLock == false)
                        {
                            animationVariable = 2;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = upX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                }
                else if (goingUp == true)
                {
                    if (isReverseTrue == false)
                    {
                        spike.transform.position -= up;
                        spike.transform.position -= up;
                        goingUp = false;
                        if (animationLock == false)
                        {
                            animationVariable = 3;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = downX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                    if (isReverseTrue == true)
                    {
                        spike.transform.position -= down;
                        spike.transform.position -= down;
                        goingUp = false;
                        if (animationLock == false)
                        {
                            animationVariable = 3;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = downX;
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
                if (goingUp == false)
                {
                    if (isReverseTrue == false)
                    {
                        spike.transform.position -= down;
                        spike.transform.position -= down;
                        goingUp = true;
                        if (animationLock == false)
                        {
                            animationVariable = 2;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = upX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                    if (isReverseTrue == true)
                    {
                        spike.transform.position -= up;
                        spike.transform.position -= up;
                        goingUp = true;
                        if (animationLock == false)
                        {
                            animationVariable = 2;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = upX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                }
                else if (goingUp == true)
                {
                    if (isReverseTrue == false)
                    {
                        spike.transform.position -= up;
                        spike.transform.position -= up;
                        goingUp = false;
                        if (animationLock == false)
                        {
                            animationVariable = 3;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = downX;
                        if (gameObject.activeInHierarchy)
                        {
                            StartCoroutine(Timer());
                        }
                    }
                    if (isReverseTrue == true)
                    {
                        spike.transform.position -= down;
                        spike.transform.position -= down;
                        goingUp = false;
                        if (animationLock == false)
                        {
                            animationVariable = 3;
                            animationLock = true;
                        }
                        spriteRenderer.sprite = downX;
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
                    goingUp = false;
                }
                if (dirrectionCheck == true)
                {
                    goingUp = true;
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
