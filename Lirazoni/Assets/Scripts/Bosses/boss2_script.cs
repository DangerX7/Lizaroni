using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2_script : MonoBehaviour
{
    public GameObject enemies;
    public bool attack;
    public int detectPlayer = -1; // 0-left, 1-right, 2-up, 3-down
    public int hp;
    public bool inv;
    public SpriteRenderer playerSprite, bossSprite;
    public Sprite winP;
    //  public int detectWall = -1;
    public bool wallLeft = false;
    public bool wallRight = false;
    public bool wallUp = false;
    public bool wallDown = false;

    public int moveLock;

    private Material matWhite;
    private Material matDefault;
    private Object explosionRef;

    public Animator animator;
    public int animations;
    public bool animate;
    public int animationState;

    public void Start()
    {
        master_script.current.onEnemiesAttack += OnEnemiesChange;
        master_script.current.onEnemiesAttackReverse += OnEnemiesChangeReverse;
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;

        bossSprite = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = bossSprite.material;
        explosionRef = Resources.Load("Explosion");
        animations = 1;
    }

    IEnumerator DamageTimer()
    {
        hp -= 1;
        inv = true;
        bossSprite.material = matWhite;
        yield return new WaitForSeconds(0.1f);
        bossSprite.material = matDefault;
        yield return new WaitForSeconds(0.9f);
        inv = false;
        if (hp == 0)
        {
            playerSprite.sprite = winP;
            GameObject Player = GameObject.Find("Player");
            player_script finishRef = Player.GetComponent<player_script>();
            finishRef.worldPass = true;
            Destroy(enemies);
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(this.gameObject);
        }
    }
    IEnumerator CoroutineWait()
    {
        yield return null;

        Vector3 up = new Vector3(0, 0.04f, 0);
        Vector3 down = new Vector3(0, -0.04f, 0);
        Vector3 left = new Vector3(-0.04f, 0, 0);
        Vector3 right = new Vector3(0.04f, 0, 0);
        if ((detectPlayer == 0) && (wallLeft == false))
        {
            if (attack == true)
            {
                animations = 1;
            }
            transform.position += left;
        }
        if ((detectPlayer == 1) && (wallRight == false))
        {
            if (attack == true)
            {
                animations = 2;
            }
            transform.position += right;
        }
        if ((detectPlayer == 2) && (wallUp == false))
        {
            if (attack == true)
            {
                animations = 3;
            }
            transform.position += up;
        }
        if ((detectPlayer == 3) && (wallDown == false))
        {
            if (attack == true)
            {
                animations = 4;
            }
            transform.position += down;
        }
        moveLock += 1;

        yield return new WaitForSeconds(1);
        if (animations == 1)
        {
            animations = 5;
        }
        if (animations == 2)
        {
            animations = 6;
        }
        if (animations == 3)
        {
            animations = 7;
        }
        if (animations == 4)
        {
            animations = 8;
        }
    }
    IEnumerator CoroutineWaitReverse()
    {
        yield return new WaitForSeconds(0.1f);

        Vector3 up = new Vector3(0, 0.04f, 0);
        Vector3 down = new Vector3(0, -0.04f, 0);
        Vector3 left = new Vector3(-0.04f, 0, 0);
        Vector3 right = new Vector3(0.04f, 0, 0);
        if ((detectPlayer == 0) && (wallRight == false))
        {
            if (attack == true)
            {
                animations = 1;
            }
            transform.position -= left;
        }
        if ((detectPlayer == 1) && (wallLeft == false))
        {
            if (attack == true)
            {
                animations = 2;
            }
            transform.position -= right;
        }
        if ((detectPlayer == 2) && (wallDown == false))
        {
            if (attack == true)
            {
                animations = 3;
            }
            transform.position -= up;
        }
        if ((detectPlayer == 3) && (wallUp == false))
        {
            if (attack == true)
            {
                animations = 4;
            }
            transform.position -= down;
        }
        moveLock += 1;

        yield return new WaitForSeconds(1);
        if (animations == 1)
        {
            animations = 5;
        }
        if (animations == 2)
        {
            animations = 6;
        }
        if (animations == 3)
        {
            animations = 7;
        }
        if (animations == 4)
        {
            animations = 8;
        }
    }

    private void OnEnemiesChange(int id)
    {
            if (attack == false)
            {
                attack = true;
                return;
            }
            if (attack == true)
            {
                attack = false;
                return;
            }
    }
    private void OnEnemiesChangeReverse(int id)
    {
            if (attack == false)
            {
                attack = true;
                return;
            }
            if (attack == true)
            {
                attack = false;
                return;
            }
    }

    public void OnEnemiesAdvance(int id)
    {
        if (attack == true)
        {
            StartCoroutine(CoroutineWait());
            if (moveLock >= 16)
            {
                moveLock = 0;
            }
        }
    }


    public void OnEnemiesAdvanceReverse(int id)
    {
        if (attack == true)
        {
            StartCoroutine(CoroutineWaitReverse());
            if (moveLock >= 16)
            {
                moveLock = 0;
            }
        }
    }

    public void Update()
    {
        Debug.Log("animation " + animations + " attack " + attack + " moveCheck " + moveLock);
        animator.SetInteger("animation", animations);

        GameObject LeftLimit = GameObject.Find("left player detect");
        b2_player_detect_script leftRef = LeftLimit.GetComponent<b2_player_detect_script>();
        GameObject RightLimit = GameObject.Find("right player detect");
        b2_player_detect_script rightRef = RightLimit.GetComponent<b2_player_detect_script>();
        GameObject UpLimit = GameObject.Find("up player detect");
        b2_player_detect_script upRef = UpLimit.GetComponent<b2_player_detect_script>();
        GameObject DownLimit = GameObject.Find("down player detect");
        b2_player_detect_script downRef = DownLimit.GetComponent<b2_player_detect_script>();
        /*
        GameObject x1 = GameObject.Find("1");
        b2_player_detect_script x1Ref = x1.GetComponent<b2_player_detect_script>();
        GameObject x2 = GameObject.Find("2");
        b2_player_detect_script x2Ref = x2.GetComponent<b2_player_detect_script>();
        GameObject x3 = GameObject.Find("3");
        b2_player_detect_script x3Ref = x3.GetComponent<b2_player_detect_script>();
        GameObject x4 = GameObject.Find("4");
        b2_player_detect_script x4Ref = x4.GetComponent<b2_player_detect_script>();
        */
        if ((leftRef.collisionCheckLeft == true) && (moveLock == 16))
        {
         //   Debug.Log("Left Colided!");
            detectPlayer = 0;
         //   ready = true;
        }
        if ((rightRef.collisionCheckRight == true) && (moveLock == 16))
        {
         //   Debug.Log("Right Colided!");
            detectPlayer = 1;
         //   ready = true;
        }
        if ((upRef.collisionCheckUp == true) && (moveLock == 16))
        {
         //   Debug.Log("Up Colided!");
            detectPlayer = 2;
         //   ready = true;
        }
        if ((downRef.collisionCheckDown == true) && (moveLock == 16))
        {
         //   Debug.Log("Down Colided!");
            detectPlayer = 3;
         //   ready = true;
        }
        /*
        if ((x1Ref.collisionCheck == true) || (x2Ref.collisionCheck == true) || (x3Ref.collisionCheck == true) || (x4Ref.collisionCheck == true))
        {
            ready = false;
        }
        */

        GameObject LeftWall = GameObject.Find("left wall detect");
        b2_wall_detect_script leftCol = LeftWall.GetComponent<b2_wall_detect_script>();
        GameObject RightWall = GameObject.Find("right wall detect");
        b2_wall_detect_script rightCol = RightWall.GetComponent<b2_wall_detect_script>();
        GameObject UpWall = GameObject.Find("up wall detect");
        b2_wall_detect_script upCol = UpWall.GetComponent<b2_wall_detect_script>();
        GameObject DownWall = GameObject.Find("down wall detect");
        b2_wall_detect_script downCol = DownWall.GetComponent<b2_wall_detect_script>();
        if (leftCol.wallCheck == true)
        {
            //   Debug.Log("Left Colided!");
            wallLeft = true;
        }
        if (rightCol.wallCheck == true)
        {
            //   Debug.Log("Right Colided!");
            wallRight = true;
        }
        if (upCol.wallCheck == true)
        {
            //   Debug.Log("Up Colided!");
            wallUp = true;
        }
        if (downCol.wallCheck == true)
        {
            //   Debug.Log("Down Colided!");
            wallDown = true;
        }
        if (leftCol.wallCheck == false)
        {
            wallLeft = false;
        }
        if (rightCol.wallCheck == false)
        {
            wallRight = false;
        }
        if (upCol.wallCheck == false)
        {
            wallUp = false;
        }
        if (downCol.wallCheck == false)
        {
            wallDown = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (((collision.gameObject.tag.Equals("Sword"))) && (inv == false))
        {
            StartCoroutine(DamageTimer());
        }
    }

    public void OnDestroy()
    {
        master_script.current.onEnemiesAttack += OnEnemiesChange;
        master_script.current.onEnemiesAttackReverse += OnEnemiesChangeReverse;
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;
    }
}