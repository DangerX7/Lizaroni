using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_boss_script : MonoBehaviour
{
    public GameObject pos1, pos2, pos3, pos4, pos5, posX, Help, music, MusicX2;
    Vector3 spawn1;
    Vector3 spawn2;
    Vector3 spawn3;
    Vector3 spawn4;
    Vector3 spawn5;
    Vector3 spawnX;
    public int moves;
    public int movesType;
    public int id;
    public bool hasPowerUpSpawned;
    public int hp;
    public bool inv;
    public SpriteRenderer playerSprite, bossSprite;
    public Sprite winP, firstForm, secondForm, switchSprite;

    private Material matWhite;
    private Material matDefault;
    private Object explosionRef;

    public bool set0;
    public bool set1;
    public bool set2;
    public bool set3;
    public int extraShit;
    public bool finalMoves;

    // Start is called before the first frame update
    void Start()
    {
        master_script.current.onEnemiesAttack += OnEnemiesSpawn;
        master_script.current.onEnemiesAttackReverse += OnEnemiesSpawnReverse;

        spawn1 = new Vector3(pos1.transform.position.x, pos1.transform.position.y, pos1.transform.position.z);
        spawn2 = new Vector3(pos2.transform.position.x, pos2.transform.position.y, pos2.transform.position.z);
        spawn3 = new Vector3(pos3.transform.position.x, pos3.transform.position.y, pos3.transform.position.z);
        spawn4 = new Vector3(pos4.transform.position.x, pos4.transform.position.y, pos4.transform.position.z);
        spawn5 = new Vector3(pos5.transform.position.x, pos5.transform.position.y, pos5.transform.position.z);
        spawnX = new Vector3(posX.transform.position.x, posX.transform.position.y, posX.transform.position.z);

        bossSprite = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = bossSprite.material;
        explosionRef = Resources.Load("Explosion");
    }

    IEnumerator CoroutineWait()
    {
        GameObject Keyboard = GameObject.Find("Change");
        keyboard_script keyboardReference = Keyboard.GetComponent<keyboard_script>();
        keyboardReference.WASD = true;
        transform.GetChild(16).gameObject.SetActive(false);
        transform.GetChild(17).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        transform.GetChild(17).gameObject.SetActive(false);
        transform.GetChild(18).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        transform.GetChild(18).gameObject.SetActive(false);
        transform.GetChild(16).gameObject.SetActive(true);
        //   bossSprite.sprite = switchSprite;
        RandomReset();
        yield return new WaitForSeconds(0.5f);
        keyboardReference.WASD = false;
        if (hp > 2)
        {
        //    bossSprite.sprite = firstForm;
        }
        else
        {
         //   bossSprite.sprite = secondForm;
        }
    }

    IEnumerator DamageTimer()
    {
        hp -= 1;
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        if (switchReference.movesEven == false)
        {
            moves = -1;
        }
        if (switchReference.movesEven == true)
        {
            moves = 0;
        }
        RandomReset();
        inv = true;
        bossSprite.material = matWhite;
        yield return new WaitForSeconds(0.1f);
        if (hp == 5)
        {
            transform.GetChild(10).gameObject.SetActive(false);
        }
        if (hp == 4)
        {
            transform.GetChild(11).gameObject.SetActive(false);
        }
        if (hp == 3)
        {
            transform.GetChild(12).gameObject.SetActive(false);
        }
        if (hp == 2)
        {
            transform.GetChild(13).gameObject.SetActive(false);
        }
        if (hp == 1)
        {
            transform.GetChild(14).gameObject.SetActive(false);
        }
        if (hp == 0)
        {
            transform.GetChild(15).gameObject.SetActive(false);
        }
        bossSprite.material = matDefault;
        yield return new WaitForSeconds(0.9f);
        inv = false;
        hasPowerUpSpawned = false;
        if (hp == 2)
        {
            transform.GetChild(8).gameObject.SetActive(false);
            transform.GetChild(9).gameObject.SetActive(true);
            music.SetActive(false);
            MusicX2 = Instantiate(Resources.Load("MusicFinalBossX2")) as GameObject;
            bossSprite.sprite = secondForm;
            set0 = false;
            set1 = false;
            set2 = false;
            set3 = false;
            finalMoves = true;
            movesType = 0;
            GameObject Armour = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
            Armour.transform.position = spawnX;
        }
        if (hp == 0)
        {
            MusicX2.SetActive(false);
            playerSprite.sprite = winP;
            GameObject Player = GameObject.Find("Player");
            player_script finishRef = Player.GetComponent<player_script>();
            finishRef.worldPass = true;
            GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("projectile");
            foreach (GameObject enemy in enemies2)
                GameObject.Destroy(enemy);
            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(this.gameObject);
        }
    }
    private void OnEnemiesSpawn(int id)
    {
        if (id == this.id)
        {
            moves += 1;
            SpawnProjectiles();
        }
    }
    private void OnEnemiesSpawnReverse(int id)
    {
        if (id == this.id)
        {
            moves -= 1;
        }
    }

    public void OnDestroy()
    {
        master_script.current.onEnemiesAttack -= OnEnemiesSpawn;
        master_script.current.onEnemiesAttackReverse -= OnEnemiesSpawnReverse;
    }

    public void SpawnProjectiles()
    {
        if (finalMoves == false)
        {
            if (movesType == 0)
            {
                if (moves == 4)
                {
                    Spawn3();
                }
                if (moves == 5)
                {
                    Spawn2();
                    Spawn4();
                }
                if (moves == 6)
                {
                    Spawn1();
                    Spawn3();
                    Spawn5();
                }
                if (moves == 7)
                {
                    Spawn2();
                    Spawn4();
                }
                if (moves == 8)
                {
                    Spawn1();
                    Spawn3();
                    Spawn5();
                }
                if (moves == 9)
                {
                    Spawn2();
                    Spawn4();
                }
                if (moves == 10)
                {
                    Spawn1();
                    Spawn5();
                }
                if (moves == 12)
                {
                    Spawn1();
                    Spawn3();
                    Spawn5();
                }
                if (moves == 13)
                {
                    Spawn2();
                    Spawn4();
                }
                if (moves == 14)
                {
                    set0 = true;
                    ResetMoves();
                }
            }
            if (movesType == 1)
            {
                if (moves == 5)
                {
                    Spawn1();
                    Spawn2();
                    Spawn3();
                    Spawn4();
                }
                if (moves == 7)
                {
                    Spawn5();
                }
                if (moves == 8)
                {
                    Spawn4();
                }
                if (moves == 9)
                {
                    Spawn3();
                }
                if (moves == 10)
                {
                    Spawn2();
                }
                if (moves == 13)
                {
                    Spawn1();
                }
                if (moves == 14)
                {
                    Spawn2();
                }
                if (moves == 15)
                {
                    Spawn3();
                }
                if (moves == 16)
                {
                    Spawn4();
                }
                if (moves == 19)
                {
                    Spawn1();
                    Spawn2();
                    Spawn4();
                    Spawn5();
                }
                if (moves == 20)
                {
                    set1 = true;
                    ResetMoves();
                }
            }
            if (movesType == 2)
            {
                if (moves == 4)
                {
                    Spawn1();
                    Spawn2();
                    Spawn3();
                    Spawn5();
                }
                if (moves == 6)
                {
                    Spawn1();
                    Spawn3();
                    Spawn4();
                    Spawn5();
                }
                if (moves == 9)
                {
                    Spawn2();
                    Spawn3();
                    Spawn4();
                }
                if (moves == 11)
                {
                    Spawn1();
                    Spawn3();
                    Spawn5();
                }
                if (moves == 12)
                {
                    Spawn2();
                }
                if (moves == 14)
                {
                    Spawn3();
                    Spawn4();
                }
                if (moves == 15)
                {
                    Spawn1();
                    Spawn2();
                    Spawn5();
                }
                if (moves == 18)
                {
                    set2 = true;
                    ResetMoves();
                }
            }
            if (movesType == 3)
            {
                if (moves == 5)
                {
                    Spawn1();
                    Spawn2();
                    Spawn4();
                    Spawn5();
                }
                if (moves == 7)
                {
                    Spawn1();
                    Spawn2();
                    Spawn3();
                    Spawn4();
                }
                if (moves == 10)
                {
                    Spawn3();
                    Spawn4();
                    Spawn5();
                }
                if (moves == 11)
                {
                    Spawn1();
                }
                if (moves == 13)
                {
                    Spawn2();
                    Spawn3();
                    Spawn4();
                }
                if (moves == 15)
                {
                    Spawn3();
                }
                if (moves == 16)
                {
                    Spawn4();
                }
                if (moves == 17)
                {
                    Spawn5();
                }
                if (moves == 19)
                {
                    Spawn1();
                    Spawn2();
                    Spawn3();
                    Spawn4();
                }
                if (moves == 20)
                {
                    set3 = true;
                    ResetMoves();
                }
            }
        }
        if (finalMoves == true)
        {
            if (movesType == 0)
            {
                if (moves == 1)
                {
                    Spawn1();
                    Spawn2();
                    Spawn4();
                    Spawn5();
                }
                if (moves == 2)
                {
                    Spawn3X();
                }
                if (moves == 3)
                {
                    Spawn1();
                    Spawn3();
                    Spawn5();
                }
                if (moves == 6)
                {
                    Spawn4X();
                }
                if (moves == 9)
                {
                    Spawn1();
                }
                if (moves == 10)
                {
                    Spawn1X();
                }
                if (moves == 11)
                {
                    Spawn2X();
                    Spawn3();
                }
                if (moves == 12)
                {
                    Spawn3X();
                }
                if (moves == 13)
                {
                    Spawn4X();
                    Spawn1();
                    Spawn3();
                }
                if (moves == 14)
                {
                    Spawn5X();
                    Spawn2();
                }
                if (moves == 15)
                {
                    Spawn4X();
                }
                if (moves == 16)
                {
                    Spawn3X();
                }
                if (moves == 17)
                {
                    Spawn2X();
                    Spawn3();
                    Spawn4();
                    Spawn5();
                }
                if (moves == 18)
                {
                    Spawn1X();
                }
                if (moves == 19)
                {
                    Spawn2X();
                    Spawn1();
                }
                if (moves == 20)
                {
                    Spawn3X();
                    Spawn2();
                }
                if (moves == 21)
                {
                    Spawn4X();
                    Spawn3();
                }
                if (moves == 22)
                {
                    Spawn5X();
                    Spawn4();
                }
                if (moves == 23)
                {
                    Spawn4X();
                }
                if (moves == 24)
                {
                    Spawn3X();
                }
                if (moves == 25)
                {
                    Spawn2X();
                }
                if (moves == 26)
                {
                    set0 = true;
                    ResetMoves();
                }
            }
            if (movesType == 1)
            {
                if (moves == 3)
                {
                    Spawn2();
                    Spawn4();
                }
                if (moves == 4)
                {
                    Spawn1X();
                    Spawn3X();
                    Spawn5X();
                }
                if (moves == 6)
                {
                    Spawn1();
                }
                if (moves == 9)
                {
                    Spawn2();
                    Spawn4();
                }
                if (moves == 11)
                {
                    Spawn3X();
                    Spawn5X();
                }
                if (moves == 14)
                {
                    Spawn1X();
                    Spawn3X();
                }
                if (moves == 15)
                {
                    Spawn2X();
                }
                if (moves == 19)
                {
                    Spawn1();
                    Spawn3();
                    Spawn5();
                }
                if (moves == 21)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 22)
                {
                    set1 = true;
                    ResetMoves();
                }
            }
            if (movesType == 2)
            {
                if (moves == 3)
                {
                    Spawn1X();
                    Spawn5X();
                }
                if (moves == 4)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 5)
                {
                    Spawn3X();
                }
                if (moves == 6)
                {
                    Spawn2X();
                    Spawn4X();
                    Spawn2();
                    Spawn4();
                }
                if (moves == 7)
                {
                    Spawn1X();
                    Spawn5X();
                }
                if (moves == 8)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 9)
                {
                    Spawn3X();
                }
                if (moves == 10)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 11)
                {
                    Spawn1X();
                    Spawn5X();
                }
                if (moves == 12)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 13)
                {
                    Spawn3X();
                    Spawn3();
                    Spawn5();
                }
                if (moves == 14)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 15)
                {
                    Spawn1X();
                    Spawn5X();
                }
                if (moves == 16)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 17)
                {
                    Spawn3X();
                    Spawn1();
                    Spawn5();
                }
                if (moves == 18)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 19)
                {
                    Spawn1X();
                    Spawn5X();
                    Spawn3();
                }
                if (moves == 20)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 21)
                {
                    Spawn3X();
                }
                if (moves == 22)
                {
                    Spawn2X();
                    Spawn4X();
                }
                if (moves == 23)
                {
                    Spawn1X();
                    Spawn5X();
                }
                if (moves == 26)
                {
                    set2 = true;
                    ResetMoves();
                }
            }
            if (movesType == 3)
            {
                if (moves == 2)
                {
                    Spawn1();
                }
                if (moves == 3)
                {
                    Spawn2();
                }
                if (moves == 4)
                {
                    Spawn3();
                    Spawn5X();
                }
                if (moves == 5)
                {
                    Spawn4();
                    Spawn4X();
                }
                if (moves == 6)
                {
                    Spawn5();
                    Spawn3X();
                }
                if (moves == 7)
                {
                    Spawn4();
                    Spawn2X();
                }
                if (moves == 8)
                {
                    Spawn3();
                    Spawn1X();
                }
                if (moves == 9)
                {
                    Spawn2();
                    Spawn2X();
                }
                if (moves == 10)
                {
                    Spawn1();
                    Spawn3X();
                }
                if (moves == 11)
                {
                    Spawn2();
                    Spawn4X();
                }
                if (moves == 12)
                {
                    Spawn3();
                    Spawn5X();
                }
                if (moves == 13)
                {
                    Spawn4();
                    Spawn4X();
                }
                if (moves == 14)
                {
                    Spawn5();
                    Spawn3X();
                }
                if (moves == 15)
                {
                    Spawn4();
                    Spawn2X();
                }
                if (moves == 16)
                {
                    Spawn3();
                    Spawn1X();
                }
                if (moves == 17)
                {
                    Spawn2();
                    Spawn2X();
                }
                if (moves == 18)
                {
                    Spawn1();
                    Spawn3X();
                }
                if (moves == 19)
                {
                    Spawn2();
                    Spawn4X();
                }
                if (moves == 20)
                {
                    Spawn3();
                    Spawn5X();
                }
                if (moves == 21)
                {
                    Spawn4();
                    Spawn4X();
                }
                if (moves == 22)
                {
                    Spawn5();
                    Spawn3X();
                }
                if (moves == 23)
                {
                    Spawn4();
                    Spawn2X();
                }
                if (moves == 24)
                {
                    Spawn3();
                    Spawn1X();
                }
                if (moves == 25)
                {
                    Spawn2();
                    Spawn2X();
                }
                if (moves == 26)
                {
                    Spawn1();
                    Spawn3X();
                }
                if (moves == 27)
                {
                    Spawn2();
                    Spawn4X();
                }
                if (moves == 28)
                {
                    Spawn3();
                    Spawn5X();
                }
                if (moves == 29)
                {
                    Spawn4();
                }
                if (moves == 30)
                {
                    Spawn5();
                }
                if (moves == 32)
                {
                    set3 = true;
                    ResetMoves();
                }
            }
        }
    }
    public void Update()
    {
        extraShit = Random.Range(0, 2);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (((collision.gameObject.tag.Equals("Sword"))) && (inv == false))
        {
            StartCoroutine(DamageTimer());
        }
    }

    public void Spawn1()
    {
        GameObject Projectile1 = Instantiate(Resources.Load("projectile-B1DownF")) as GameObject;
        Projectile1.transform.position = spawn1;
    }
    public void Spawn2()
    {
        GameObject Projectile2 = Instantiate(Resources.Load("projectile-B1DownF")) as GameObject;
        Projectile2.transform.position = spawn2;
    }
    public void Spawn3()
    {
        GameObject Projectile3 = Instantiate(Resources.Load("projectile-B1DownF")) as GameObject;
        Projectile3.transform.position = spawn3;
    }
    public void Spawn4()
    {
        GameObject Projectile4 = Instantiate(Resources.Load("projectile-B1DownF")) as GameObject;
        Projectile4.transform.position = spawn4;
    }
    public void Spawn5()
    {
        GameObject Projectile5 = Instantiate(Resources.Load("projectile-B1DownF")) as GameObject;
        Projectile5.transform.position = spawn5;
    }
    public void Spawn1X()
    {
        GameObject Projectile1X = Instantiate(Resources.Load("projectile-B1DownX2F")) as GameObject;
        Projectile1X.transform.position = spawn1;
    }
    public void Spawn2X()
    {
        GameObject Projectile2X = Instantiate(Resources.Load("projectile-B1DownX2F")) as GameObject;
        Projectile2X.transform.position = spawn2;
    }
    public void Spawn3X()
    {
        GameObject Projectile3X = Instantiate(Resources.Load("projectile-B1DownX2F")) as GameObject;
        Projectile3X.transform.position = spawn3;
    }
    public void Spawn4X()
    {
        GameObject Projectile4X = Instantiate(Resources.Load("projectile-B1DownX2F")) as GameObject;
        Projectile4X.transform.position = spawn4;
    }
    public void Spawn5X()
    {
        GameObject Projectile5X = Instantiate(Resources.Load("projectile-B1DownX2F")) as GameObject;
        Projectile5X.transform.position = spawn5;
    }
    public void ResetMoves()
    {
        moves = 0;
        if (hasPowerUpSpawned == false)
        {
            GameObject spawnPowerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
            spawnPowerUp.transform.position = Help.transform.position;
            hasPowerUpSpawned = true;
        }
        StartCoroutine(CoroutineWait());
    }

    public void RandomReset()
    {
        // +1 for each random.range to set the limit (limit cannot be reached)
        if ((set0 == false) && (set1 == false) && (set2 == false) && (set3 == false))
        {
            movesType = Random.Range(0, 4);
        }
        if ((set0 == false) && (set1 == false) && (set2 == false) && (set3 == true))
        {
            movesType = Random.Range(0, 3);
        }
        if ((set0 == false) && (set1 == false) && (set2 == true) && (set3 == false))
        {
            if (extraShit == 0)
            {
                movesType = Random.Range(0, 2);
            }
            if (extraShit == 1)
            {
                movesType = 3;
            }
        }
        if ((set0 == false) && (set1 == false) && (set2 == true) && (set3 == true))
        {
            movesType = Random.Range(0, 2);
        }



        if ((set0 == false) && (set1 == true) && (set2 == false) && (set3 == false))
        {
            if (extraShit == 0)
            {
                movesType = 0;
            }
            if (extraShit == 1)
            {
                movesType = Random.Range(2, 4);
            }
        }
        if ((set0 == false) && (set1 == true) && (set2 == false) && (set3 == true))
        {
            if (extraShit == 0)
            {
                movesType = 0;
            }
            if (extraShit == 1)
            {
                movesType = 2;
            }
        }
        if ((set0 == false) && (set1 == true) && (set2 == true) && (set3 == false))
        {
            if (extraShit == 0)
            {
                movesType = 0;
            }
            if (extraShit == 1)
            {
                movesType = 3;
            }
        }
        if ((set0 == false) && (set1 == true) && (set2 == true) && (set3 == true))
        {
            movesType = 0;
        }



        if ((set0 == true) && (set1 == false) && (set2 == false) && (set3 == false))
        {
            movesType = Random.Range(1, 4);
        }
        if ((set0 == true) && (set1 == false) && (set2 == false) && (set3 == true))
        {
            movesType = Random.Range(1, 3);
        }
        if ((set0 == true) && (set1 == false) && (set2 == true) && (set3 == false))
        {
            if (extraShit == 0)
            {
                movesType = 1;
            }
            if (extraShit == 1)
            {
                movesType = 3;
            }
        }
        if ((set0 == true) && (set1 == false) && (set2 == true) && (set3 == true))
        {
            movesType = 1;
        }




        if ((set0 == true) && (set1 == true) && (set2 == false) && (set3 == false))
        {
            movesType = Random.Range(2, 4);
        }
        if ((set0 == true) && (set1 == true) && (set2 == false) && (set3 == true))
        {
            movesType = 2;
        }
        if ((set0 == true) && (set1 == true) && (set2 == true) && (set3 == false))
        {
            movesType = 3;
        }
        if ((set0 == true) && (set1 == true) && (set2 == true) && (set3 == true))
        {
            set0 = false;
            set1 = false;
            set2 = false;
            set3 = false;
            movesType = Random.Range(0, 4);
        }
    }
}
