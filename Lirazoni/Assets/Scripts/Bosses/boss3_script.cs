using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss3_script : MonoBehaviour
{
    public GameObject left, right, up, down, P1, P2, P3, P4, enemies;
    Vector3 spawnLeft;
    Vector3 spawnRight;
    Vector3 spawnUp;
    Vector3 spawnDown;
    public int moves;
    public int id;
    public int random;
    public bool hasPowerUpSpawned;
    public int hp;
    public bool inv;
    public SpriteRenderer playerSprite, bossSprite;
    public Sprite winP;

    private Material matWhite;
    private Material matDefault;
    private Object explosionRef;

    // Start is called before the first frame update
    void Start()
    {
        master_script.current.onEnemiesAttack += OnEnemiesSpawn;
        master_script.current.onEnemiesAttackReverse += OnEnemiesSpawnReverse;

        spawnLeft = new Vector3(left.transform.position.x, left.transform.position.y, left.transform.position.z);
        spawnRight = new Vector3(right.transform.position.x, right.transform.position.y, right.transform.position.z);
        spawnUp = new Vector3(up.transform.position.x, up.transform.position.y, up.transform.position.z);
        spawnDown = new Vector3(down.transform.position.x, down.transform.position.y, down.transform.position.z);

        bossSprite = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = bossSprite.material;
        explosionRef = Resources.Load("Explosion");
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
        hasPowerUpSpawned = false;
        moves = 0;
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

    IEnumerator AttackTimer()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        transform.GetChild(0).gameObject.SetActive(false);
    }
    private void OnEnemiesSpawn(int id)
    {
        if (id == this.id)
        {
            moves += 1;
            StartCoroutine(AttackTimer());
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
        if ((moves == 1) || (moves == 3) || (moves == 4) || (moves == 6) || (moves == 7) || (moves == 8) || (moves == 10) || (moves == 11) || (moves == 12) || (moves == 13)
            || (moves == 15) || (moves == 16) || (moves == 17) || (moves == 18) || (moves == 20) || (moves == 21) || (moves == 22) || (moves == 24) || (moves == 25) || (moves == 27))
        {
            GameObject leftProjectile = Instantiate(Resources.Load("projectile-B1Left")) as GameObject;
            GameObject rightProjectile = Instantiate(Resources.Load("projectile-B1Right")) as GameObject;
            GameObject upProjectile = Instantiate(Resources.Load("projectile-B1Up")) as GameObject;
            GameObject downProjectile = Instantiate(Resources.Load("projectile-B1Down")) as GameObject;
            leftProjectile.transform.position = spawnLeft;
            rightProjectile.transform.position = spawnRight;
            upProjectile.transform.position = spawnUp;
            downProjectile.transform.position = spawnDown;
        }
        if (moves == 28)
        {
            moves = 0;
            if (hasPowerUpSpawned == false)
            {
                Vector3 extra = new Vector3(0.32f, 0.32f, 0);
                GameObject spawnPowerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                if (random == 0)
                {
                    spawnPowerUp.transform.position = P1.transform.position + extra;
                }
                if (random == 1)
                {
                    spawnPowerUp.transform.position = P2.transform.position + extra;
                }
                if (random == 2)
                {
                    spawnPowerUp.transform.position = P3.transform.position + extra;
                }
                if (random == 3)
                {
                    spawnPowerUp.transform.position = P4.transform.position + extra;
                }
                hasPowerUpSpawned = true;
            }
        }
        if (moves == -1)
        {
            moves = 27;
        }
    }
    public void Update()
    {
        random = Random.Range(0, 3);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (((collision.gameObject.tag.Equals("Sword"))) && (inv == false))
        {
            StartCoroutine(DamageTimer());
        }
    }
}
