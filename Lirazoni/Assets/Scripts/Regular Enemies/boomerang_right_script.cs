using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomerang_right_script : MonoBehaviour
{
    public int id;
    public int turn = 1;
    public SpriteRenderer spriteRenderer;
    public Sprite forward, backwards;
    public SpriteRenderer spriteRendererBoss;
    public Sprite stand, throwA, throwB;
    public GameObject Boomerang, Thrower;
    Vector3 originalPos;
    portal_master_object_script p;

    public Animator animator;
    public bool boomSpin;
    public bool boomSpin2;

    void Start()
    {
        if (GameObject.Find("Portal Master Object") != null)
        {
            p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
        }
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;

        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    void Update()
    {
        animator.SetBool("spin", boomSpin);
        animator.SetBool("spinBack", boomSpin2);
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                Debug.Log("TURN OK!");
                ResetX();
            }
        }
    }

        IEnumerator Timer()
        {
            yield return new WaitForSeconds(0.001f);
            (this.gameObject).SetActive(false);
        }

    IEnumerator SpinTimer()
    {
        boomSpin = true;
        yield return new WaitForSeconds(0.2f);
        boomSpin = false;
    }
    IEnumerator SpinTimerBack()
    {
        boomSpin2 = true;
        yield return new WaitForSeconds(0.2f);
        boomSpin2 = false;
    }

    private void OnEnemiesAdvance(int id)
    {
        if (id == this.id)
        {
            turn += 1;
            if (gameObject.activeSelf)
            {
                StartCoroutine(SpinTimer());
            }
            Vector3 left = new Vector3(-0.04f, 0, 0);
            Vector3 right = new Vector3(0.04f, 0, 0);

            if ((turn >= 0) && (turn <= 48))
            {
             //   spriteRenderer.sprite = forward;
                transform.position += right;
            }
            else if ((turn >= 49) && (turn <= 96))
            {
             //   spriteRenderer.sprite = backwards;
                transform.position += left;
            }
            if (turn == (96) - 2)
            {
                (this.gameObject).SetActive(false);
            }
            if (turn == 97)
            {
                ResetX();
            }
        }
    }
    private void OnEnemiesAdvanceReverse(int id)
    {
        if (id == this.id)
        {
            turn -= 1;
            if (gameObject.activeSelf)
            {
                StartCoroutine(SpinTimerBack());
            }
            if (turn == 1)
            {
                (this.gameObject).SetActive(false);
            }
            Vector3 left = new Vector3(-0.04f, 0, 0);
            Vector3 right = new Vector3(0.04f, 0, 0);

            if ((turn > -1) && (turn < 3 * 16))
            {
             //   spriteRenderer.sprite = forward;
                transform.position -= right;
            }
            else if ((turn > 2 * 16) && (turn < 6 * 16))
            {
             //   spriteRenderer.sprite = backwards;
                transform.position -= left;
            }
            if (turn == 0)
            {
                turn = 96;
            }
        }
    }

    private void ResetX()
    {
        turn = 1;
        gameObject.transform.position = originalPos;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("wall"))
        {
            ResetX();
        }
    }

    public void OnDestroy()
    {
        master_script.current.onEnemiesMove -= OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse -= OnEnemiesAdvanceReverse;
    }
}
