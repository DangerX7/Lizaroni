using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss4b_script : MonoBehaviour
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

    public void Start()
    {
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (((collision.gameObject.tag.Equals("Sword"))) && (inv == false))
        {
            StartCoroutine(DamageTimer());
        }
    }
}