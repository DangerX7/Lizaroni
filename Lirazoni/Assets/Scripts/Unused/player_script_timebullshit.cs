using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class player_script_timebullshit : MonoBehaviour
{
    public GameObject player, portal1, portal2, portal3, portal4, portal5, portal6, SceneObj, music, sword;

    public bool moveleftS = false;  // spikes move
    public bool moverightS = false;
    public bool moveupS = false;
    public bool movedownS = false;

    public bool leftlock = false;  //check collision for walls, if collision is true then block movement
    public bool rightlock = false;
    public bool uplock = false;
    public bool downlock = false;
    public bool leftlock2 = false;
    public bool rightlock2 = false;
    public bool uplock2 = false;
    public bool downlock2 = false;

    public bool leftlockX2 = false;
    public bool rightlockX2 = false;
    public bool uplockX2 = false;
    public bool downlockX2 = false;
    public bool leftUplock = false;
    public bool leftDownlock = false;
    public bool rightUplock = false;
    public bool rightDownlock = false;

    public bool death = false;
    public bool inputLock = false;
    public bool inv = false;
    public bool endCheck = false;

    public bool soundSpikeCheck = false;
    public int id;
    public bool countReset = false;

    public bool isSceneObjActive = false;

    public bool p1sprite = false;
    public bool p2sprite = false;
    public bool death2 = false;

    public bool colReset = false;
    public bool portalCheck = false;

    public bool HeroAttackAvailable;
    public bool attackCheck;
    public byte heroDirCheck = 1; // 0=up, 1=down, 2=left, 3=right
    public byte bullets = 3;

    public bool HeroDashAvailable;
    public bool dashCheck;
    public bool invincibility;
    public bool normalMove;
    public bool jumpLock;
    public bool leftlockXX2 = false;
    public bool rightlockXX2 = false;
    public bool uplockXX2 = false;
    public bool downlockXX2 = false;

    public bool HeroArmor;
    public bool armorBreak;

    public bool HeroInvincibility;

    public bool HeroTimeTravel;
    List<int> timeList = new List<int>();
    public int lastMove0 = -1;
    public int lastMove1 = -1;
    public int lastMove2 = -1;
    public int lastMove3 = -1;
    public int timeNumber = 3;
    public bool travelSwitch;

    ///
    public bool animate = false;

    public float tickTime = .1f;    //Time in seconds per 'tick' (.1 = .1sec full alpha, .1sec reduced alpha, .1sec full, etc)
    public float alphaScale = .3f;  //How transparent are the 'faded' ticks?

    float timeout = 0;              //timer to keep track of current time this tick.
    float fullAlpha = 1;            //Keep track of full alpha. We will grab this info from the material on start.
    bool full = true;               //Flag to keep track of if we should use the full or reduced alpha
    ///

    public SpriteRenderer spriteRenderer;
    public Sprite up, down, left, right, win, lose, perfect_win;


    void Start()
    {
        timeList.Add(-1);
        ///
        fullAlpha = spriteRenderer.material.color.a;
        timeout = 0;
        full = true;
        ///

    }



    public void MoveUpVector()
    {
        Vector3 temp = new Vector3(0, 0.04f, 0);
        player.transform.position += temp;
    }
    public void MoveDownVector()
    {
        Vector3 temp = new Vector3(0, -0.04f, 0);
        player.transform.position += temp;
    }
    public void MoveLeftVector()
    {
        Vector3 temp = new Vector3(-0.04f, 0, 0);
        player.transform.position += temp;
    }
    public void MoveRightVector()
    {
        Vector3 temp = new Vector3(0.04f, 0, 0);
        player.transform.position += temp;
    }
    public void MoveUpVectorX2()
    {
        Vector3 temp = new Vector3(0, 0.08f, 0);
        player.transform.position += temp;
    }
    public void MoveDownVectorX2()
    {
        Vector3 temp = new Vector3(0, -0.08f, 0);
        player.transform.position += temp;
    }
    public void MoveLeftVectorX2()
    {
        Vector3 temp = new Vector3(-0.08f, 0, 0);
        player.transform.position += temp;
    }
    public void MoveRightVectorX2()
    {
        Vector3 temp = new Vector3(0.08f, 0, 0);
        player.transform.position += temp;
    }
    IEnumerator SwordTimer()
    {
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        for (int i = 0; i < 16; i++)
        {
            if ((endCheck == false) && (portalCheck == false))
            {
                if (colReset == false)
                {
                    master_script.current.EnemiesMove(id);
                }
                if (id == 0)
                {
                    switchReference.enemyTurn += 1;
                }
                else if (id == 1)
                {
                    switchReference.enemyTurn2 += 1;
                }
                master_script.current.BoomerangTurn(id);
                yield return new WaitForSeconds(0.0001f);
            }
        }
        transform.GetChild(4).gameObject.SetActive(false);
        attackCheck = false;
    }
    IEnumerator CoroutineUp()
    {
        Debug.Log("Player-Up");
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        for (int i = 0; i < 16; i++)
        {
            if ((endCheck == false) && (portalCheck == false))
            {
                if (dashCheck == true)
                {
                    MoveUpVectorX2();
                }
                else
                {
                    MoveUpVector();
                }
                //switchReference.SpikesMove();
                if (colReset == false)
                {
                    master_script.current.EnemiesMove(id);
                }
                if (id == 0)
                {
                    switchReference.enemyTurn += 1;
                }
                else if (id == 1)
                {
                    switchReference.enemyTurn2 += 1;
                }
                master_script.current.BoomerangTurn(id);
                yield return new WaitForSeconds(0.0001f);
            }
        }
        if (armorBreak == true)
        {
            soundSpikeCheck = false;
            HeroArmor = false;
            armorBreak = false;
            HeroInvincibility = false;
        }
        yield return new WaitForSeconds(0.001f);
        inv = true;
        yield return new WaitForSeconds(0.001f);
        moveupS = true;
    }
    IEnumerator CoroutineDown()
    {
        Debug.Log("Player-Down");
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        for (int i = 0; i < 16; i++)
        {
            if ((endCheck == false) && (portalCheck == false))
            {
                if (dashCheck == true)
                {
                    MoveDownVectorX2();
                }
                else
                {
                    MoveDownVector();
                }
                //switchReference.SpikesMove();
                if (colReset == false)
                {
                    master_script.current.EnemiesMove(id);
                }
                if (id == 0)
                {
                    switchReference.enemyTurn += 1;
                }
                else if (id == 1)
                {
                    switchReference.enemyTurn2 += 1;
                }
                master_script.current.BoomerangTurn(id);
                yield return new WaitForSeconds(0.0001f);
            }
        }
        if (armorBreak == true)
        {
            soundSpikeCheck = false;
            HeroArmor = false;
            armorBreak = false;
            HeroInvincibility = false;
        }
        yield return new WaitForSeconds(0.001f);
        inv = true;
        yield return new WaitForSeconds(0.001f);
        movedownS = true;
    }
    IEnumerator CoroutineLeft()
    {
        Debug.Log("Player-Left");
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        for (int i = 0; i < 16; i++)
        {
            if ((endCheck == false) && (portalCheck == false))
            {
                if (dashCheck == true)
                {
                    MoveLeftVectorX2();
                }
                else
                {
                    MoveLeftVector();
                }
                //switchReference.SpikesMove();
                if (colReset == false)
                {
                    master_script.current.EnemiesMove(id);
                }
                if (id == 0)
                {
                    switchReference.enemyTurn += 1;
                }
                else if (id == 1)
                {
                    switchReference.enemyTurn2 += 1;
                }
                master_script.current.BoomerangTurn(id);
                yield return new WaitForSeconds(0.0001f);
            }
        }
        if (armorBreak == true)
        {
            soundSpikeCheck = false;
            HeroArmor = false;
            armorBreak = false;
            HeroInvincibility = false;
        }
        yield return new WaitForSeconds(0.001f);
        inv = true;
        yield return new WaitForSeconds(0.001f);
        moveleftS = true;
    }
    IEnumerator CoroutineRight()
    {
        Debug.Log("Player-Right");
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        for (int i = 0; i < 16; i++)
        {
            if ((endCheck == false) && (portalCheck == false))
            {
                if (dashCheck == true)
                {
                    MoveRightVectorX2();
                }
                else
                {
                    MoveRightVector();
                }
                //switchReference.SpikesMove();
                if (colReset == false)
                {
                    master_script.current.EnemiesMove(id);
                }
                if (id == 0)
                {
                    switchReference.enemyTurn += 1;
                }
                else if (id == 1)
                {
                    switchReference.enemyTurn2 += 1;
                }
                master_script.current.BoomerangTurn(id);
                yield return new WaitForSeconds(0.0001f);
            }
        }
        if (armorBreak == true)
        {
            soundSpikeCheck = false;
            HeroArmor = false;
            armorBreak = false;
            HeroInvincibility = false;
        }
        yield return new WaitForSeconds(0.001f);
        inv = true;
        yield return new WaitForSeconds(0.001f);
        moverightS = true;
    }


    IEnumerator CoroutineDeath()
    {
        //   predeath = true;
        Debug.Log("Die");
        yield return new WaitForSeconds(5.5f);
        if (id == 0)
        {
            death = true;
        }
    }

    IEnumerator CoroutineDamage()
    {
        Debug.Log("Armor break");
        inputLock = true;
        HeroInvincibility = true;
        yield return new WaitForSeconds(1);
        inputLock = false;
        armorBreak = true;
    }


    // Update is called once per frame
    void Update()
    {
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();

        if (endCheck == true)
        {
            inputLock = true;
        }

        if (switchReference.levelType == 2) // move for versus
        {
            if (id == 0)
            {
                if (Input.GetKeyDown(KeyCode.W) && (uplock == false))
                {
                    MoveUp();
                }
                if (Input.GetKeyDown(KeyCode.S) && (downlock == false))
                {
                    MoveDown();
                }
                if (Input.GetKeyDown(KeyCode.A) && (leftlock == false))
                {
                    MoveLeft();
                }
                if (Input.GetKeyDown(KeyCode.D) && (rightlock == false))
                {
                    MoveRight();
                }
            }
            else if (id == 1)
            {
                if (Input.GetKeyDown("up") && (uplock2 == false))
                {
                    MoveUp();
                }
                if (Input.GetKeyDown("down") && (downlock2 == false))
                {
                    MoveDown();
                }
                if (Input.GetKeyDown("left") && (leftlock2 == false))
                {
                    MoveLeft();
                }
                if (Input.GetKeyDown("right") && (rightlock2 == false))
                {
                    MoveRight();
                }
            }
        }
        else //(Regular level, not versus)
        {
            if ((Input.GetKeyDown(KeyCode.W) && (uplock == false) && (leftUplock == false) && (rightUplock == false) && (uplock2 == false) && (uplockX2 == false) || (Input.GetKeyDown("up"))) && (uplock == false) && (leftUplock == false) && (rightUplock == false) && (uplock2 == false) && (uplockX2 == false))
            {
                heroDirCheck = 0;
                normalMove = true;
                if (HeroAttackAvailable == true)
                {
                    transform.GetChild(4).gameObject.SetActive(false);
                }
                MoveUp();
            }
            if ((Input.GetKeyDown(KeyCode.S) && (downlock == false) && (leftDownlock == false) && (rightDownlock == false) && (downlock2 == false) && (downlockX2 == false) || (Input.GetKeyDown("down"))) && (downlock == false) && (leftDownlock == false) && (rightDownlock == false) && (downlock2 == false) && (downlockX2 == false))
            {
                heroDirCheck = 1;
                normalMove = true;
                if (HeroAttackAvailable == true)
                {
                    transform.GetChild(4).gameObject.SetActive(false);
                }
                MoveDown();
            }
            if (Input.GetKeyDown(KeyCode.A) && (leftlock == false) && (leftUplock == false) && (leftDownlock == false) && (leftlock2 == false) && (leftlockX2 == false) || (Input.GetKeyDown("left")) && (leftlock == false) && (leftUplock == false) && (leftDownlock == false) && (leftlock2 == false) && (leftlockX2 == false))
            {
                heroDirCheck = 2;
                normalMove = true;
                if (HeroAttackAvailable == true)
                {
                    transform.GetChild(4).gameObject.SetActive(false);
                }
                MoveLeft();
            }
            if ((Input.GetKeyDown(KeyCode.D) && (rightlock == false) && (rightUplock == false) && (rightDownlock == false) && (rightlock2 == false) && (rightlockX2 == false) || (Input.GetKeyDown("right"))) && (rightlock == false) && (rightUplock == false) && (rightDownlock == false) && (rightlock2 == false) && (rightlockX2 == false))
            {
                heroDirCheck = 3;
                normalMove = true;
                if (HeroAttackAvailable == true)
                {
                    transform.GetChild(4).gameObject.SetActive(false);
                }
                MoveRight();
            }
            if ((Input.GetKeyDown(KeyCode.Space)) && (HeroAttackAvailable == true) && (attackCheck == false) && (inputLock == false) && (bullets > 0)) //ATTACK
            {
                if (heroDirCheck == 0) // up
                {
                    transform.GetChild(4).gameObject.SetActive(true);
                    sword.transform.position = transform.position + new Vector3(0, 0.64f, 0);
                    attackCheck = true;
                    bullets -= 1;
                    StartCoroutine(SwordTimer());
                }
                if (heroDirCheck == 1) // down
                {
                    transform.GetChild(4).gameObject.SetActive(true);
                    sword.transform.position = transform.position + new Vector3(0, -0.64f, 0);
                    attackCheck = true;
                    bullets -= 1;
                    StartCoroutine(SwordTimer());
                }
                if (heroDirCheck == 2) // left
                {
                    transform.GetChild(4).gameObject.SetActive(true);
                    sword.transform.position = transform.position + new Vector3(-0.64f, 0, 0);
                    attackCheck = true;
                    bullets -= 1;
                    StartCoroutine(SwordTimer());
                }
                if (heroDirCheck == 3) // right
                {
                    transform.GetChild(4).gameObject.SetActive(true);
                    sword.transform.position = transform.position + new Vector3(0.64f, 0, 0);
                    attackCheck = true;
                    bullets -= 1;
                    StartCoroutine(SwordTimer());
                }
            }
            if (((Input.GetKeyDown(KeyCode.LeftShift)) || (Input.GetKeyDown(KeyCode.RightShift))) && (HeroDashAvailable == true) && (normalMove == false)) //JUMP
            {
                if ((heroDirCheck == 0) && (uplock == false) && (uplockXX2 == false))  // up
                {
                    invincibility = true;
                    dashCheck = true;
                    MoveUp();
                }
                if ((heroDirCheck == 1) && (downlock == false) && (downlockXX2 == false)) // down
                {
                    invincibility = true;
                    dashCheck = true;
                    MoveDown();
                }
                if ((heroDirCheck == 2) && (leftlock == false) && (leftlockXX2 == false)) // left
                {
                    invincibility = true;
                    dashCheck = true;
                    MoveLeft();
                }
                if ((heroDirCheck == 3) && (rightlock == false) && (rightlockXX2 == false)) // right
                {
                    invincibility = true;
                    dashCheck = true;
                    MoveRight();
                }
            }
            if ((Input.GetKeyDown(KeyCode.T)) && (HeroTimeTravel == true) && (travelSwitch == false))
            {
                Debug.Log("Time Travel Enter");
                inputLock = true;
                travelSwitch = true;
                if (Input.GetKeyDown(KeyCode.Minus))
                {
                    timeNumber -= 1;
                }
                if (Input.GetKeyDown(KeyCode.Equals))
                {
                    timeNumber += 1;
                }

                if (timeNumber == 3)
                {
                    ///2 in reverse
                }
                if (timeNumber == 2)
                {

                }
                if (timeNumber == 1)
                {

                }
                if (timeNumber == 0)
                {

                }

                if (Input.GetKeyDown(KeyCode.T))
                {
                    Debug.Log("Time Travel Exit");
                    inputLock = false;
                    travelSwitch = false;
                }
            }
        }


        if ((moveupS == true) || (movedownS == true) || (moveleftS == true)  || (moverightS == true)) // END MOVE VARIABLES
        {
            EndMove();
        }

        if ((death == true) && (switchReference.levelType != 2))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (switchReference.levelType == 2)
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script1 deathReference = Player2.GetComponent<player_script1>();

            if ((death == true) && (deathReference.death2 == true))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }




        if (endCheck == true)
        {
            music.SetActive(false);
        }

        if (HeroInvincibility == true)
        {
            animate = true;
            invincibility = true;
        }
        else
        {
            animate = false;
            invincibility = false;
        }


        ///
        Color c = spriteRenderer.material.color;
        c.a = fullAlpha;

        //Is the effect animating?
        if (animate)
        {
            //Accumulate time into the timer
            timeout += Time.deltaTime;

            //Process all ticks that would have happened over the deltaTime 
            //(incase of a delay, we don't want it to instantly flip for a few frames)
            while (timeout > tickTime)
            {
                timeout -= tickTime;
                full = !full;
                //Subtract the time for that tick, and flip the fade flag.
            }

            //If we are not full this frame, set the reduced alpha value.
            if (!full)
            {
                c.a *= alphaScale;
            }

        }

        //This will apply the full alpha if we are not animating,
        //And then partial alpha half the time if we are.
        spriteRenderer.material.color = c;
        ///

        ////Time Travel List values
         lastMove1 = timeList.Last();
        if (timeList.Count >= 2)
        {
             lastMove2 = timeList[timeList.Count - 2];
        }
        if (timeList.Count >= 3)
        {
             lastMove3 = timeList[timeList.Count - 3];
        }
        if (lastMove1 == 0)
        {
            lastMove0 = 1;
        }
        if (lastMove1 == 1)
        {
            lastMove0 = 0;
        }
        if (lastMove1 == 2)
        {
            lastMove0 = 3;
        }
        if (lastMove1 == 3)
        {
            lastMove0 = 2;
        }

        Debug.Log("third last is "+ lastMove3 + " second last is " + lastMove2 + " last one is " + lastMove1);
        /*
        foreach (var x in timeList)
        {
            Debug.Log(x.ToString());
        }
        */
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public void EndMove()
    {
        inv = false;
        if (endCheck == false)
        {
            if (GameObject.Find("enemyRandom") != null)
            {
                GameObject Random = GameObject.Find("enemyRandom");
                spikes_random_script randomRef = Random.GetComponent<spikes_random_script>();
                randomRef.updateSwitch = true;
            }
            inputLock = false;
        }
        attackCheck = false;
        dashCheck = false;
        invincibility = false;
        normalMove = false;
        moveupS = false;
        movedownS = false;
        moveleftS = false;
        moverightS = false;
    }

    /// <summary>
    /// /////////////////////////////////////////////
    /// </summary>
    public void MoveUp()
    {
        timeList.Add(0);
        portalCheck = false;
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        if (inputLock == false)
        {
            inputLock = true;
            master_script.current.ThrowerTurn(id);
            master_script.current.SpriteChange(id);
            master_script.current.EnemiesAttack(id);
            StartCoroutine(CoroutineUp());
            switchReference.moves += 1;
            if (endCheck == false)
            {
                spriteRenderer.sprite = up;
            }
        }
    }
    public void MoveDown()
    {
        timeList.Add(1);
        portalCheck = false;
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        if (inputLock == false)
        {
            inputLock = true;
            master_script.current.ThrowerTurn(id);
            master_script.current.SpriteChange(id);
            master_script.current.EnemiesAttack(id);
            StartCoroutine(CoroutineDown());
            switchReference.moves += 1;
            if (endCheck == false)
            {
                spriteRenderer.sprite = down;
            }
        }
    }
    public void MoveLeft()
    {
        timeList.Add(2);
        portalCheck = false;
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        if (inputLock == false)
        {
            inputLock = true;
            master_script.current.ThrowerTurn(id);
            master_script.current.SpriteChange(id);
            master_script.current.EnemiesAttack(id);
            StartCoroutine(CoroutineLeft());
            switchReference.moves += 1;
            if (endCheck == false)
            {
                spriteRenderer.sprite = left;
            }
        }
    }
    public void MoveRight()
    {
        timeList.Add(3);
        portalCheck = false;
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        if (inputLock == false)
        {
            inputLock = true;
            master_script.current.ThrowerTurn(id);
            master_script.current.SpriteChange(id);
            master_script.current.EnemiesAttack(id);
            StartCoroutine(CoroutineRight());
            switchReference.moves += 1;
            if (endCheck == false)
            {
                spriteRenderer.sprite = right;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (invincibility == false)
        {
            if ((collider.gameObject.tag.Equals("RegularEnemy")) || ((collider.gameObject.tag.Equals("JumpEnemy")) && (inv == true)) || ((collider.gameObject.tag.Equals("spikeRandom"))))
            {
                if (soundSpikeCheck == false)
                {
                    sound_manager_script.PlaySound("SpikeHit");
                    soundSpikeCheck = true;
                }
                if (HeroArmor == false)
                {
                    endCheck = true;
                    Debug.Log("Game Over");
                    spriteRenderer.sprite = lose;
                    StartCoroutine(CoroutineDeath());
                    inv = false;
                }
                else if (HeroArmor == true)
                {
                    StartCoroutine(CoroutineDamage());
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (portalCheck == false)
        {
            if (collision.gameObject.tag.Equals("Portal"))
            {
                if (collision.gameObject.name == "Portal 1")
                {
                    player.transform.position = portal2.transform.position;
                    portalCheck = true;
                }
                if (collision.gameObject.name == "Portal 2")
                {
                    player.transform.position = portal1.transform.position;
                    portalCheck = true;
                }
            }
        }
    }
}