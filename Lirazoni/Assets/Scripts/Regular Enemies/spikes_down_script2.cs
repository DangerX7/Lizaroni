using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes_down_script2 : MonoBehaviour
{
    public GameObject spike;

    public SpriteRenderer spriteRenderer;
    public Sprite defend, attack;

    public bool sprite;
    public int id;
    public bool isReverseTrue;
    Vector3 originalPos;
    public int moves;
    public int mapDifference;
    public bool invincibile;
    portal_master_object_script p;
    public bool versus2P_enemy;
    public Animator animator;
    public bool enemyDig; // false = exit hole, true = enter hole
    public bool secondaryWallCheck;
    public bool targetReset;

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
        sprite = true;
        master_script.current.onEnemiesAttack += SpriteChange;
        master_script.current.onEnemiesAttackReverse += SpriteChange;
        master_script.current.OnEnemiesActionEnd += EnemiesActionEnd;
        master_script.current.OnEnemiesActionEndReverse += EnemiesActionEndReverse;

        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    IEnumerator AnimationTimer()
    {
        sprite = true;
        yield return new WaitForSeconds(0.25f);
        sprite = true;
    }
    IEnumerator AnimationTimer2()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        enemyDig = true;
        yield return new WaitForSeconds(0.33f);
        if (isReverseTrue == false)
        {
            Vector3 down = new Vector3(0, -1.28f, 0);
            transform.position += down;
        }
        if (isReverseTrue == true)
        {
            Vector3 up = new Vector3(0, 1.28f, 0);
            transform.position += up;
        }
        enemyDig = false;
        secondaryWallCheck = true;
        GetComponent<BoxCollider2D>().enabled = true;
    }


    IEnumerator Digging()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        //   yield return new WaitForSeconds(0.001f);
        transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        transform.GetChild(2).gameObject.SetActive(true);
        //    yield return new WaitForSeconds(0.001f);
        transform.GetChild(3).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        transform.GetChild(4).gameObject.SetActive(true);
        //   yield return new WaitForSeconds(0.001f);
        transform.GetChild(5).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        transform.GetChild(6).gameObject.SetActive(true);
        //  yield return new WaitForSeconds(0.001f);
        transform.GetChild(7).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        transform.GetChild(8).gameObject.SetActive(true);
        //   yield return new WaitForSeconds(0.001f);
        transform.GetChild(9).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        transform.GetChild(10).gameObject.SetActive(true);
        //   yield return new WaitForSeconds(0.001f);
        transform.GetChild(11).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        transform.GetChild(12).gameObject.SetActive(true);
        //   yield return new WaitForSeconds(0.001f);
        transform.GetChild(13).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        transform.GetChild(14).gameObject.SetActive(true);
        //   yield return new WaitForSeconds(0.001f);
        transform.GetChild(15).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(4).gameObject.SetActive(false);
        transform.GetChild(5).gameObject.SetActive(false);
        transform.GetChild(6).gameObject.SetActive(false);
        transform.GetChild(7).gameObject.SetActive(false);
        transform.GetChild(8).gameObject.SetActive(false);
        transform.GetChild(9).gameObject.SetActive(false);
        transform.GetChild(10).gameObject.SetActive(false);
        transform.GetChild(11).gameObject.SetActive(false);
        transform.GetChild(12).gameObject.SetActive(false);
        transform.GetChild(13).gameObject.SetActive(false);
        transform.GetChild(14).gameObject.SetActive(false);
        transform.GetChild(15).gameObject.SetActive(false);
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
    private void EnemiesActionEnd(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                moves += 1;
                isReverseTrue = false;
                StartCoroutine(AnimationTimer2());
            }
        }
    }

    private void EnemiesActionEndReverse(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                moves -= 1;
                isReverseTrue = true;
                StartCoroutine(AnimationTimer2());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector3 down = new Vector3(0, -0.64f, 0);

        GameObject Master = GameObject.Find("MasterObject");
        master_script levelReference = Master.GetComponent<master_script>();

        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")) || (((col.gameObject.tag.Equals("wallDown"))) && (secondaryWallCheck == true) && (isReverseTrue == false)) || (((col.gameObject.tag.Equals("wallUp"))) && (secondaryWallCheck == true) && (isReverseTrue == true)))
        {
            targetReset = true;
            secondaryWallCheck = false;
            if (id == 0)
            {
                if (isReverseTrue == false)
                {
                    spike.transform.position -= down * (levelReference.levelRows + mapDifference);
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += down * (levelReference.levelRows + mapDifference);
                }
            }
            if (id == 1)
            {
                if (isReverseTrue == false)
                {
                    spike.transform.position -= down * (levelReference.levelRowsV + mapDifference);
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += down * (levelReference.levelRowsV + mapDifference);
                }
            }
        }
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        targetReset = false;
    }
        public void OnDestroy()
    {
        master_script.current.onEnemiesAttack -= SpriteChange;
        master_script.current.onEnemiesAttackReverse -= SpriteChange;
        master_script.current.OnEnemiesActionEnd -= EnemiesActionEnd;
        master_script.current.OnEnemiesActionEndReverse -= EnemiesActionEndReverse;
    }
    public void Update()
    {
    //    Debug.Log("muieFAAAAAA" + targetReset);
        animator.SetBool("dig", enemyDig);
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                sprite = false;
                moves = 0;
                isReverseTrue = false;
            }
        }
        if (gameObject.activeSelf == false)
        {
            transform.position = originalPos;
        }
        if (sprite == false)
        {
            spriteRenderer.sprite = defend;
        }
        else if (sprite == true)
        {
            spriteRenderer.sprite = attack;
        }

        GameObject Master = GameObject.Find("MasterObject");
        master_script levelReference = Master.GetComponent<master_script>();
        if (id == 0)
        {
            if ((moves == -(mapDifference + levelReference.levelRows) * 8) || (moves == (mapDifference + levelReference.levelRows) * 8))
            {
                transform.position = originalPos;
                moves = 0;
            }
        }
        if (id == 1)
        {
            if ((moves == -(mapDifference + levelReference.levelRowsV) * 8) || (moves == (mapDifference + levelReference.levelRowsV) * 8))
            {
                transform.position = originalPos;
                moves = 0;
            }
        }

        if (id == 0)
        {
            GameObject Player = GameObject.Find("Player");
            player_script digReference = Player.GetComponent<player_script>();
            if (digReference.armorCounter == 8)
            {
                StartCoroutine(Digging());
            }
        }

        if (id == 1)
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script digReference2 = Player2.GetComponent<player_script>();
            if (digReference2.armorCounter == 8)
            {
                StartCoroutine(Digging());
            }
        }
    }
}
