using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss4a_script : MonoBehaviour
{
    public GameObject enemies, LeftLimit, RightLimit, UpLimit, DownLimit, LeftWall, RightWall, UpWall, DownWall;
    public bool attack;
    public int cooldownTimer = 10;
    public int detectPlayer; // 0-left, 1-right, 2-up, 3-down
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
    public byte firstMoves; // 1-left, 2-right, 3-up, 4-down
    public bool moveLOCK;

    private Material matWhite;
    private Material matDefault;
    private Object explosionRef;

    public int type; // 0 = real, 1 = fake1, 2 = fake2 ///Don't use
    public int id;

    public Animator animator;
    public int animations;

    public void Start()
    {
        detectPlayer = -1;
        master_script.current.onEnemiesAttack += OnEnemiesChange;
        master_script.current.onEnemiesAttackReverse += OnEnemiesChangeReverse;
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;

        bossSprite = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = bossSprite.material;
        explosionRef = Resources.Load("Explosion");


    wallLeft = false;
    wallRight = false;
    wallUp = false;
    wallDown = false;
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
        if ((firstMoves == 1) && (wallLeft == false))
        {
            //   Debug.Log("left");
            animations = 1;
            transform.position += left;
        }
        if ((firstMoves == 2) && (wallRight == false))
        {
            //   Debug.Log("right");
            animations = 2;
            transform.position += right;
        }
        if ((firstMoves == 3) && (wallUp == false))
        {
            //   Debug.Log("up");
            animations = 3;
            transform.position += up;
        }
        if ((firstMoves == 4) && (wallDown == false))
        {
            //   Debug.Log("down");
            animations = 4;
            transform.position += down;
        }

        if ((detectPlayer == 0) && (wallLeft == false))
        {
         ///   Debug.Log("LEFT");
            firstMoves = 0;
            animations = 1;
            yield return new WaitForSeconds(0.1f);
            transform.position += left;
        }
        if ((detectPlayer == 1) && (wallRight == false))
        {
         //   Debug.Log("RIGHT");
            firstMoves = 0;
            animations = 2;
            yield return new WaitForSeconds(0.1f);
            transform.position += right;
        }
        if ((detectPlayer == 2) && (wallUp == false))
        {
         //   Debug.Log("UP");
            firstMoves = 0;
            animations = 3;
            yield return new WaitForSeconds(0.1f);
            transform.position += up;
        }
        if ((detectPlayer == 3) && (wallDown == false))
        {
         //   Debug.Log("DOWN");
            firstMoves = 0;
            animations = 4;
            yield return new WaitForSeconds(0.1f);
            transform.position += down;
        }
        moveLock += 1;
        if (moveLock == 16)
        {
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
    }
    IEnumerator CoroutineWaitReverse()
    {
        yield return null;

        Vector3 up = new Vector3(0, 0.04f, 0);
        Vector3 down = new Vector3(0, -0.04f, 0);
        Vector3 left = new Vector3(-0.04f, 0, 0);
        Vector3 right = new Vector3(0.04f, 0, 0);
        if ((firstMoves == 1) && (wallLeft == false))
        {
            animations = 1;
            transform.position -= left;
        }
        if ((firstMoves == 2) && (wallRight == false))
        {
            animations = 2;
            transform.position -= right;
        }
        if ((firstMoves == 3) && (wallUp == false))
        {
            animations = 3;
            transform.position -= up;
        }
        if ((firstMoves == 4) && (wallDown == false))
        {
            animations = 4;
            transform.position -= down;
        }

        if ((detectPlayer == 0) && (wallRight == false))
        {
            animations = 1;
            transform.position -= left;
        }
        if ((detectPlayer == 1) && (wallLeft == false))
        {
            animations = 2;
            transform.position -= right;
        }
        if ((detectPlayer == 2) && (wallDown == false))
        {
            animations = 3;
            transform.position -= up;
        }
        if ((detectPlayer == 3) && (wallUp == false))
        {
            animations = 4;
            transform.position -= down;
        }
        moveLock += 1;
        if (moveLock == 16)
        {
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
    }

    IEnumerator CoroutineWait2()
    {
        moveLock += 160;
        yield return new WaitForSeconds(0.3f);
        cooldownTimer = 10;
    }

        private void OnEnemiesChange(int id)
    {
        cooldownTimer -= 1;
    }
    private void OnEnemiesChangeReverse(int id)
    {
        cooldownTimer -= 1;
    }

    public void OnEnemiesAdvance(int id)
    {
      //      if (cooldownTimer > 0)
            {
                if (moveLock >= 16)
                {
                    moveLock = 0;
                }
                StartCoroutine(CoroutineWait());
            }
    }


    public void OnEnemiesAdvanceReverse(int id)
    {
     //       if (cooldownTimer > 0)
            {
                if (moveLock == 16)
                {
                    moveLock = 0;
                }
                StartCoroutine(CoroutineWaitReverse());
            }
    }

    public void Update()
    {
        animator.SetInteger("animation", animations);
        //    Debug.Log("playerSensor " + detectPlayer);
        if (cooldownTimer == -2)
        {
        //    StartCoroutine(CoroutineWait2());
        }

        if (moveLOCK == true)
        {
            moveLock = 0;
        }

            b4_player_left_detect_script leftRef0 = LeftLimit.GetComponent<b4_player_left_detect_script>();
            b4_player_right_detect_script rightRef0 = RightLimit.GetComponent<b4_player_right_detect_script>();
            b4_player_up_detect_script upRef0 = UpLimit.GetComponent<b4_player_up_detect_script>();
            b4_player_down_detect_script downRef0 = DownLimit.GetComponent<b4_player_down_detect_script>();

            if ((leftRef0.collisionCheck == true) && (moveLock == 16))
            {
             //   Debug.Log("Left Colided!");
                detectPlayer = 0;
                //   ready = true;
            }
            if ((rightRef0.collisionCheck == true) && (moveLock == 16))
            {
            //    Debug.Log("Right Colided!");
                detectPlayer = 1;
                //   ready = true;
            }
            if ((upRef0.collisionCheck == true) && (moveLock == 16))
            {
             //   Debug.Log("Up Colided!");
                detectPlayer = 2;
                //   ready = true;
            }
            if ((downRef0.collisionCheck == true) && (moveLock == 16))
            {
             //   Debug.Log("Down Colided!");
                detectPlayer = 3;
                //   ready = true;
            }
            /*
            b2_wall_detect_script leftCol0 = LeftWall.GetComponent<b2_wall_detect_script>();
            b2_wall_detect_script rightCol0 = RightWall.GetComponent<b2_wall_detect_script>();
            b2_wall_detect_script upCol0 = UpWall.GetComponent<b2_wall_detect_script>();
            b2_wall_detect_script downCol0 = DownWall.GetComponent<b2_wall_detect_script>();

            if (leftCol0.wallCheck == true)
            {
                //   Debug.Log("Left Colided!");
                wallLeft = true;
            }
            if (rightCol0.wallCheck == true)
            {
                //   Debug.Log("Right Colided!");
                wallRight = true;
            }
            if (upCol0.wallCheck == true)
            {
                //   Debug.Log("Up Colided!");
                wallUp = true;
            }
            if (downCol0.wallCheck == true)
            {
                //   Debug.Log("Down Colided!");
                wallDown = true;
            }
            if (leftCol0.wallCheck == false)
            {
                wallLeft = false;
            }
            if (rightCol0.wallCheck == false)
            {
                wallRight = false;
            }
            if (upCol0.wallCheck == false)
            {
                wallUp = false;
            }
            if (downCol0.wallCheck == false)
            {
                wallDown = false;
            }
            */
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