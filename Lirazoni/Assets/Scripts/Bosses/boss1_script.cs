using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1_script : MonoBehaviour
{
    public GameObject enemies, P1, P2, P3, P4, P5, P6, P7, P8;
    public int detectPlayer = -1; // 0-left1, 1-right2, 2-left1, 3-right2, 4-up, 5-down
    public byte phase;
    public bool isAttackingOn;
    public int hp;
    public bool inv;
    public SpriteRenderer playerSprite, bossSprite;
    public Sprite winP, boss1Up, boss1Down, boss1Left, boss1Right, Boss1TurnUp, Boss1TurnDown, Boss1TurnLeft,  Boss1TurnRight, B1attack;
    
    public int moveLock;
    Vector3 spawnBasePoint;
    public int weaponSpawn;
    public int spawnPos;
    public int armorSpawn;
    public int spawnPos2;

    /// code for boss flash
    private Material matWhite;
    private Material matDefault;
    private Object explosionRef;

    public Animator animator;
    public int animations;
    public bool animationPlay;
    public bool actionStop;
    public bool exitPLayer;

    public void Start()
    {
        spawnBasePoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        master_script.current.onEnemiesAttack += OnEnemiesChange;
        master_script.current.onEnemiesAttackReverse += OnEnemiesChangeReverse;

        /// code for boss flash
        bossSprite = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = bossSprite.material;
        explosionRef = Resources.Load("Explosion");
    }

    IEnumerator DamageTimer()
    {
        hp -= 1;
        inv = true;
        /// code for boss flash
        bossSprite.material = matWhite;
        yield return new WaitForSeconds(0.1f);
        bossSprite.material = matDefault;
        yield return new WaitForSeconds(0.9f);
        //   weaponSpawn += 1;
        inv = false;
        if (hp == 0)
        {
            playerSprite.sprite = winP;
            GameObject Player = GameObject.Find("Player");
            player_script finishRef = Player.GetComponent<player_script>();
            finishRef.worldPass = true;
            Destroy(enemies);
            GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("projectile");
            foreach (GameObject enemy in enemies2)
            GameObject.Destroy(enemy);
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(this.gameObject);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.12f);
        Vector3 left1 = new Vector3(-1.5f, 0.33f, 0);
        Vector3 left2 = new Vector3(-1.5f, -0.33f, 0);
        Vector3 right1 = new Vector3(1.5f, 0.33f, 0);
        Vector3 right2 = new Vector3(1.5f, -0.33f, 0);
        Vector3 up = new Vector3(0, 1.8f, 0);
        Vector3 down = new Vector3(0, -1.8f, 0);
        if (animations == 11)
        {
            GameObject projectile = Instantiate(Resources.Load("projectile-B2L")) as GameObject;
            projectile.transform.position = spawnBasePoint + left1;
        }
        if (animations == 12)
        {
            GameObject projectile = Instantiate(Resources.Load("projectile-B2L")) as GameObject;
            projectile.transform.position = spawnBasePoint + left2;
        }
        if (animations == 13)
        {
            GameObject projectile = Instantiate(Resources.Load("projectile-B2R")) as GameObject;
            projectile.transform.position = spawnBasePoint + right1;
        }
        if (animations == 14)
        {
            GameObject projectile = Instantiate(Resources.Load("projectile-B2R")) as GameObject;
            projectile.transform.position = spawnBasePoint + right2;
        }
        if (animations == 15)
        {
            GameObject projectile = Instantiate(Resources.Load("projectile-B2U")) as GameObject;
            projectile.transform.position = spawnBasePoint + up;
        }
        if (animations == 16)
        {
            GameObject projectile = Instantiate(Resources.Load("projectile-B2D")) as GameObject;
            projectile.transform.position = spawnBasePoint + down;
        }
        yield return new WaitForSeconds(0.6f);
        if ((animations == 11) || (animations == 12))
        {
            animations = 21;
        }
        if ((animations == 13) || (animations == 14))
        {
            animations = 22;
        }
        if (animations == 15)
        {
            Debug.Log("STOP!");
            animations = 23;
        }
        if (animations == 16)
        {
            animations = 24;
        }
    }

    private void OnEnemiesChange(int id)
    {
        if (weaponSpawn >=0)
        {
            weaponSpawn += 1;
        }
        if (armorSpawn >= 0)
        {
            armorSpawn += 1;
        }
        /*
        if (phase == 1)
        {
            if ((detectPlayer == 0) || (detectPlayer == 2))
            {
            //    bossSprite.sprite = boss1Left;
                phase = 2;
                return;
            }
            if ((detectPlayer == 1) || (detectPlayer == 3))
            {
            //    bossSprite.sprite = boss1Right;
                phase = 2;
                return;
            }
            if (detectPlayer == 4)
            {
            //    bossSprite.sprite = boss1Up;
                phase = 2;
                return;
            }
            if (detectPlayer == 5)
            {
            //    bossSprite.sprite = boss1Down;
                phase = 2;
                return;
            }
        }
        */
        if (phase == 1)
        {
            if (isAttackingOn == false)
            {
                if (detectPlayer == 0)
                {
                    animations = 11;
                    StartCoroutine(Timer());
                }
                if (detectPlayer == 2)
                {
                    animations = 12;
                    StartCoroutine(Timer());
                }
                if (detectPlayer == 1)
                {
                    animations = 13;
                    StartCoroutine(Timer());
                }
                if (detectPlayer == 3)
                {
                    animations = 14;
                    StartCoroutine(Timer());
                }
                if (detectPlayer == 4)
                {
                    animations = 15;
                    StartCoroutine(Timer());
                }
                if (detectPlayer == 5)
                {
                    animations = 16;
                    StartCoroutine(Timer());
                }
                isAttackingOn = true;
            }
        }

        if (weaponSpawn >= 5)
        {
            Vector3 extra = new Vector3(0.179f, 0.169f, 0);
            GameObject spawnPowerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
            if (spawnPos == 0)
            {
                spawnPowerUp.transform.position = P1.transform.position + extra;
            }
            if (spawnPos == 1)
            {
                spawnPowerUp.transform.position = P2.transform.position + extra;
            }
            if (spawnPos == 2)
            {
                spawnPowerUp.transform.position = P3.transform.position + extra;
            }
            if (spawnPos == 3)
            {
                spawnPowerUp.transform.position = P4.transform.position + extra;
            }
            weaponSpawn = -1;
        }

        if (armorSpawn >= 1)
        {
            Vector3 extra2 = new Vector3(0.14f, 0.12f, 0);
            GameObject spawnPowerUp = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
            if (spawnPos2 == 0)
            {
                spawnPowerUp.transform.position = P5.transform.position + extra2;
            }
            if (spawnPos2 == 1)
            {
                spawnPowerUp.transform.position = P6.transform.position + extra2;
            }
            if (spawnPos2 == 2)
            {
                spawnPowerUp.transform.position = P7.transform.position + extra2;
            }
            if (spawnPos2 == 3)
            {
                spawnPowerUp.transform.position = P8.transform.position + extra2;
            }
            armorSpawn = -1;
        }
        GameObject Player = GameObject.Find("Player");
        player_script armourReference = Player.GetComponent<player_script>();
        if (armourReference.HeroArmor == true)
        {
            armorSpawn = 0;
        }
    }
    private void OnEnemiesChangeReverse(int id)
    {
        /// TO BE MADE
    }
    public void Update()
    {
     //   Debug.Log("detect: " + detectPlayer + "animation: " + animations);
        animator.SetInteger("animation", animations);
        //   Debug.Log("armor: " + armorSpawn + " weapon: " + weaponSpawn);

        spawnPos = Random.Range(0, 4);
        spawnPos2 = Random.Range(0, 4);


        if ((animations == 11) || (animations == 12) || (animations == 13) || (animations == 14) || (animations == 15)  || (animations == 16))
        {
            actionStop = true;
        }
        else
        {
            actionStop = false;
        }


        if (phase == 0)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("projectile");
            foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);
        }

        GameObject LeftLimit1 = GameObject.Find("left player detect 1");
        b1_player_detect_script leftRef1 = LeftLimit1.GetComponent<b1_player_detect_script>();
        GameObject LeftLimit2 = GameObject.Find("left player detect 2");
        b1_player_detect_script leftRef2 = LeftLimit2.GetComponent<b1_player_detect_script>();
        GameObject RightLimit1 = GameObject.Find("right player detect 1");
        b1_player_detect_script rightRef1 = RightLimit1.GetComponent<b1_player_detect_script>();
        GameObject RightLimit2 = GameObject.Find("right player detect 2");
        b1_player_detect_script rightRef2 = RightLimit2.GetComponent<b1_player_detect_script>();
        GameObject UpLimit = GameObject.Find("up player detect");
        b1_player_detect_script upRef = UpLimit.GetComponent<b1_player_detect_script>();
        GameObject DownLimit = GameObject.Find("down player detect");
        b1_player_detect_script downRef = DownLimit.GetComponent<b1_player_detect_script>();
        if ((leftRef1.collisionCheck == true) && (moveLock == 0))
        {
                if ((detectPlayer == 4) || (detectPlayer == -1))
                {
                    animations = 1;
                }
            detectPlayer = 0;
        }
        if ((rightRef1.collisionCheck == true) && (moveLock == 0))
        {
                if ((detectPlayer == 4) || (detectPlayer == -1))
                {
                    animations = 5;
                }
            detectPlayer = 1;
        }
        if ((leftRef2.collisionCheck == true) && (moveLock == 0))
        {
                if ((detectPlayer == 5) || (detectPlayer == -1))
                {
                    animations = 2;
                }
            detectPlayer = 2;
        }
        if ((rightRef2.collisionCheck == true) && (moveLock == 0))
        {
                if ((detectPlayer == 5) || (detectPlayer == -1))
                {
                    animations = 6;
                }
            detectPlayer = 3;
        }
        if ((upRef.collisionCheck == true) && (moveLock == 0))
        {
                if ((detectPlayer == 0) || (detectPlayer == -1))
                {
                    animations = 3;
                }
                if ((detectPlayer == 1) || (detectPlayer == -1))
                {
                    animations = 4;
                }
            detectPlayer = 4;
        }
        if ((downRef.collisionCheck == true) && (moveLock == 0))
        {
                if ((detectPlayer == 2) || (detectPlayer == -1))
                {
                    animations = 7;
                }
                if ((detectPlayer == 3) || (detectPlayer == -1))
                {
                    animations = 8;
                }
            detectPlayer = 5;
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
    }
}