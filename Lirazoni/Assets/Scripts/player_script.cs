using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_script : MonoBehaviour
{
    public GameObject player, SceneObj, music, sword, door;

    private float waitTimer = 0.008f;

    public bool HeroAttackAvailable;
    public bool HeroDashAvailable;
    public bool HeroArmor;
    public bool HeroInvincibility;
    public bool HeroTimeTravel;

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

    // HERO ATTACK
    public bool attackCheck;
    public byte heroDirCheck = 1; // 0=up, 1=down, 2=left, 3=right
    public byte bullets = 255;

    // HERO DASH
    public bool dashCheck;
    public float dashAvailable = 0;
    public bool dashInput;
    public bool dashInput2;
    public bool invincibility;
    public bool normalMove;
    public bool jumpLock;
    public bool leftlockXX2 = false;
    public bool rightlockXX2 = false;
    public bool uplockXX2 = false;
    public bool downlockXX2 = false;

    // HERO ARMOR
    public bool armorBreak;

    // HERO INVINCIBILITY
    public int HeroInvTimer = 5;

    // HERO TIME TRAVEL
    List<int> timeList = new List<int>();
    public int lastMove0 = -1;
    public int lastMove1 = -1;
    public int lastMove2 = -1;
    public int lastMove3 = -1;
    public int timeNumber = 3;
    public bool travelSwitch;
    public bool travelSwitch2;

    public bool worldPass;

    ///
    public bool animate = false;
    public byte startingPoss;

    public float tickTime = .1f;    //Time in seconds per 'tick' (.1 = .1sec full alpha, .1sec reduced alpha, .1sec full, etc)
    public float alphaScale = .3f;  //How transparent are the 'faded' ticks?

    float timeout = 0;              //timer to keep track of current time this tick.
    float fullAlpha = 1;            //Keep track of full alpha. We will grab this info from the material on start.
    bool full = true;               //Flag to keep track of if we should use the full or reduced alpha
    ///

    public SpriteRenderer spriteRenderer;
    public Sprite up, down, left, right, win, lose, perfect_win;

    public bool specialVariable;
    public GameObject portal1_1a, portal1_1b, portal1_1c, portal1_1d, portal1_2, portal1_3, portal1_4, portal1_5,
                      portal2_1, portal2_2a, portal2_2b, portal2_2c, portal2_2d, portal2_3, portal2_4, portal2_5,
                      portal3_1, portal3_2, portal3_3a, portal3_3b, portal3_3c, portal3_3d, portal3_4, portal3_5,
                      portal4_1, portal4_2, portal4_3, portal4_4a, portal4_4b, portal4_4c, portal4_4d, portal4_5,
                      portal5_1, portal5_2, portal5_3, portal5_4, portal5_5a, portal5_5b, portal5_5c, portal5_5d,
                      portal1_A, portal1_B, portal1_C, portal1_D,
                      portal2_A, portal2_B, portal2_C, portal2_D,
                      portal3_A, portal3_B, portal3_C, portal3_D,
                      portal4_A, portal4_B, portal4_C, portal4_D,
                      portal5_A, portal5_B, portal5_C, portal5_D;

    List<GameObject> children = new List<GameObject>();
    public int roomSet;
    public int roomOfMap = 1;
    public bool portalEnterCheck;

    public byte upCount;
    public bool unlimitedAttacksCheck;
    public int specialSpawnPossition;
    public bool specialTeleport;
    public GameObject light1, light2;
    public bool lastStage;

    public Renderer rend;
    public bool isPLayerOnPlatform;
    public bool holeCheck;
    public bool animationStop;

    public bool endOfMove;
    public Animator animator;
    public int animations;
    public byte doorWinSprite; // 1 = regular win, 2 = perfect win
    public bool armorSpriteDissable;
    private byte boss1Counter;
    public bool deathPrevent;
    public byte armorBreakXXX; // 1 - armor was break while walking, 2 - armor was break when standing
    public byte armorCounter;
    public bool extraTutorialInputLock;
    void Start()
    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;

        StartCoroutine(EnterGame());
        timeList.Add(-1);
        ///
        fullAlpha = spriteRenderer.material.color.a;
        timeout = 0;
        full = true;
        ///
        GameObject Camera = GameObject.Find("Main Camera");
        camera_script cameraChange = Camera.GetComponent<camera_script>();


        if (GameObject.Find("SceneUnlocker") != null)
        {
            GameObject Scene = GameObject.Find("SceneUnlocker");
            scene_unlocker_script difRef = Scene.GetComponent<scene_unlocker_script>();
            if ((difRef.difficulty == 1) && (startingPoss == 1))
            {
                player.transform.position += new Vector3(0.64f, 0, 0);
            }
        }

        if (GameObject.Find("Spawn Master 1") != null)
        {
            specialSpawnPossition = Random.Range(1, 4);
            if (specialSpawnPossition == 1)
            {
                Debug.Log("1");
                player.transform.position += new Vector3(-1.28f, 1.92f, 0);
            }
            if (specialSpawnPossition == 2)
            {
                Debug.Log("2");
                player.transform.position += new Vector3(1.92f, 1.92f, 0);
            }
            if (specialSpawnPossition == 3)
            {
                Debug.Log("3");
                player.transform.position += new Vector3(0, -1.28f, 0);
            }
            if (specialSpawnPossition == 4)
            {
                Debug.Log("4");
                player.transform.position += new Vector3(2.56f, -0.64f, 0);
            }
        }
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
        master_script.current.HitboxActivate(id);
        master_script.current.EnemiesActionEnd(id);
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        for (int i = 0; i < 16; i++)
        {
            if (endCheck == false)
            {
                if (lastStage == false)
                {
                    EnemiesActions();
                }
                yield return new WaitForSeconds(waitTimer);
            }
            if (i == 2)
            {
                inputLock = true;
                /*
                GameObject Sword = GameObject.Find("attack");
                sword_script wallRef = Sword.GetComponent<sword_script>();
                if (wallRef.youDestroyedAWall == true)
                {
                    if (heroDirCheck == 4)
                    {
                        uplock = false;
                    }
                    if (heroDirCheck == 5)
                    {
                        downlock = false;
                    }
                    if (heroDirCheck == 6)
                    {
                        leftlock = false;
                    }
                    if (heroDirCheck == 7)
                    {
                        rightlock = false;
                    }
                }
            */
                yield return new WaitForSeconds(0.1f);
                transform.GetChild(8).gameObject.SetActive(false);
                transform.GetChild(9).gameObject.SetActive(true);
                yield return new WaitForSeconds(0.1f);
                transform.GetChild(9).gameObject.SetActive(false);
                transform.GetChild(10).gameObject.SetActive(true);
                yield return new WaitForSeconds(0.1f);
                transform.GetChild(10).gameObject.SetActive(false);
                attackCheck = false;
                if (unlimitedAttacksCheck == false)
                {
                    HeroAttackAvailable = false;
                }
                if (GameObject.Find("Power-Up Icon") != null)
                {
                    GameObject Icon = GameObject.Find("Power-Up Icon");
                    power_up_icon_script iconReference = Icon.GetComponent<power_up_icon_script>();

                    iconReference.iconAttack = false;
                }
                if (GameObject.Find("Boss 1") != null)
                {
                    GameObject Boss1 = GameObject.Find("Boss 1");
                    boss1_script respawnReference = Boss1.GetComponent<boss1_script>();
                    respawnReference.weaponSpawn += 1;
                }
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (colReset == false)
            {
                master_script.current.EnemiesMoveHalf(id);
                yield return new WaitForSeconds(waitTimer);
            }
        }
        yield return new WaitForSeconds(0.1f);
        inputLock = false;

    }

    IEnumerator EnterGame()
    {
        inputLock = true;
        yield return new WaitForSeconds(0.2f);

        inputLock = false;
        if (GameObject.Find("Tutorial Object") != null)
        {
            GameObject Tutorial = GameObject.Find("Tutorial Object");
            tutorial_object_script moveReference = Tutorial.GetComponent<tutorial_object_script>();
            if (moveReference.activeCheck == true)
            {
                inputLock = true;
            }
            else
            {
                inputLock = false;
            }
        }
    }

    IEnumerator NewWorld()
    {
        inputLock = true;
        //   Destroy(music);
        yield return new WaitForSeconds(0.01f);
        //   SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
        door.SetActive(true);
    }
    IEnumerator CoroutineUp()
    {
        master_script.current.HitboxActivate(id);
        dashInput = true;
    //    Debug.Log("Player-Up");
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        switchReference.movesChange = true;
        master_script.current.EnemiesActionEnd(id);
        if ((deathPrevent == true) && (armorBreakXXX == 2))
        {
            HeroInvincibility = false;
            deathPrevent = false;
        }
        for (int i = 0; i < 16; i++)
        {
            boss1Counter += 1;
            armorCounter += 1;
            if ((endCheck == false) && (portalCheck == false))
            {
                if (dashCheck == true)
                {
                    MoveUpVectorX2();
                    dashAvailable -= 0.0625f;
                }
                else
                {
                    MoveUpVector();
                }
                //switchReference.SpikesMove();
                EnemiesActions();
                yield return new WaitForSeconds(waitTimer);
            }
        }
        armorCounter = 0;
        for (int i = 0; i < 8; i++)
        {
            if (colReset == false)
            {
                master_script.current.EnemiesMoveHalf(id);
                yield return new WaitForSeconds(waitTimer);
            }
        }
        if (dashCheck == true)
        {
            MoveUpVector();
            dashAvailable -= 0.0625f;
        }
        if ((deathPrevent == true) && (armorBreakXXX == 1))
        {
            HeroInvincibility = false;
            deathPrevent = false;
        }
        ArmorBreak();
        yield return new WaitForSeconds(waitTimer);
        switchReference.movesChange = false;
        inv = true;
        yield return new WaitForSeconds(0.05f);
        moveupS = true;
    }
    IEnumerator CoroutineDown()
    {
        master_script.current.HitboxActivate(id);
        dashInput = true;
    //    Debug.Log("Player-Down");
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        switchReference.movesChange = true;
        master_script.current.EnemiesActionEnd(id);
        if ((deathPrevent == true) && (armorBreakXXX == 2))
        {
            HeroInvincibility = false;
            deathPrevent = false;
        }
        for (int i = 0; i < 16; i++)
        {
            boss1Counter += 1;
            armorCounter += 1;
            if ((endCheck == false) && (portalCheck == false))
            {
                if (dashCheck == true)
                {
                    MoveDownVectorX2();
                    dashAvailable -= 0.0625f;
                }
                else
                {
                    MoveDownVector();
                }
                //switchReference.SpikesMove();
                EnemiesActions();
                yield return new WaitForSeconds(waitTimer);
            }
        }
        armorCounter = 0;
        for (int i = 0; i < 8; i++)
        {
            if (colReset == false)
            {
                master_script.current.EnemiesMoveHalf(id);
                yield return new WaitForSeconds(waitTimer);
            }
        }
        if (dashCheck == true)
        {
            MoveDownVector();
            dashAvailable -= 0.0625f;
        }
        if ((deathPrevent == true) && (armorBreakXXX == 1))
        {
            HeroInvincibility = false;
            deathPrevent = false;
        }
        ArmorBreak();
        yield return new WaitForSeconds(waitTimer);
        switchReference.movesChange = false;
        inv = true;
        yield return new WaitForSeconds(0.05f);
        movedownS = true;
    }
    IEnumerator CoroutineLeft()
    {
        master_script.current.HitboxActivate(id);
        dashInput = true;
    //    Debug.Log("Player-Left");
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        switchReference.movesChange = true;
        master_script.current.EnemiesActionEnd(id);
        if ((deathPrevent == true) && (armorBreakXXX == 2))
        {
            HeroInvincibility = false;
            deathPrevent = false;
        }
        for (int i = 0; i < 16; i++)
        {
            boss1Counter += 1;
            armorCounter += 1;
            if ((endCheck == false) && (portalCheck == false))
            {
                if (dashCheck == true)
                {
                    MoveLeftVectorX2();
                    dashAvailable -= 0.0625f;
                }
                else
                {
                    MoveLeftVector();
                }
                //switchReference.SpikesMove();
                EnemiesActions();
                yield return new WaitForSeconds(waitTimer);
            }
        }
        armorCounter = 0;
        for (int i = 0; i < 8; i++)
        {
            if (colReset == false)
            {
                master_script.current.EnemiesMoveHalf(id);
                yield return new WaitForSeconds(waitTimer);
            }
        }
        if (dashCheck == true)
        {
            MoveLeftVector();
            dashAvailable -= 0.0625f;
        }
        if ((deathPrevent == true) && (armorBreakXXX == 1))
        {
            HeroInvincibility = false;
            deathPrevent = false;
        }
        ArmorBreak();
        yield return new WaitForSeconds(waitTimer);
        switchReference.movesChange = false;
        inv = true;
        yield return new WaitForSeconds(0.05f);
        moveleftS = true;
    }
    IEnumerator CoroutineRight()
    {
        master_script.current.HitboxActivate(id);
        dashInput = true;
    //    Debug.Log("Player-Right");
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        switchReference.movesChange = true;
        master_script.current.EnemiesActionEnd(id);
        if ((deathPrevent == true) && (armorBreakXXX == 2))
        {
            HeroInvincibility = false;
            deathPrevent = false;
        }
        for (int i = 0; i < 16; i++)
        {
            boss1Counter += 1;
            armorCounter += 1;
            if ((endCheck == false) && (portalCheck == false))
            {
                if (dashCheck == true)
                {
                    MoveRightVectorX2();
                    dashAvailable -= 0.0625f;
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
                yield return new WaitForSeconds(waitTimer);
            }
        }
        armorCounter = 0;
        for (int i = 0; i < 8; i++)
        {
            if (colReset == false)
            {
                master_script.current.EnemiesMoveHalf(id);
                yield return new WaitForSeconds(waitTimer);
            }
        }
        if (dashCheck == true)
        {
            MoveRightVector();
            dashAvailable -= 0.0625f;
        }
        if ((deathPrevent == true) && (armorBreakXXX == 1))
        {
            HeroInvincibility = false;
            deathPrevent = false;
        }
        ArmorBreak();
        yield return new WaitForSeconds(waitTimer);
        switchReference.movesChange = false;
        inv = true;
        yield return new WaitForSeconds(0.05f);
        moverightS = true;
    }


    IEnumerator CoroutineTimeTravel()
    {
        yield return null;
        inputLock = true;
        yield return new WaitForSeconds(0.1f);
        travelSwitch = true;
    }

    IEnumerator CoroutineTimeTravelBackward()
    {
        travelSwitch2 = true;
        master_script.current.EnemiesAttackReverse(id);
        master_script.current.SpriteChange(id);
        master_script.current.EnemiesActionEndReverse(id);
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        for (int i = 0; i < 16; i++)
        {
            if ((endCheck == false) && (portalCheck == false))
            {
                if (colReset == false)
                {
                    master_script.current.EnemiesMoveReverse(id);
                }
                if (id == 0)
                {
                    switchReference.enemyTurn += 1;
                }
                else if (id == 1)
                {
                    switchReference.enemyTurn2 += 1;
                }
                master_script.current.BoomerangTurnReverse(id);
                yield return new WaitForSeconds(waitTimer);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (colReset == false)
            {
                master_script.current.EnemiesMoveReverseHalf(id);
                yield return new WaitForSeconds(waitTimer);
            }
        }
        yield return new WaitForSeconds(0.2f);
        travelSwitch2 = false;
    }
    IEnumerator CoroutineTimeTravelForward()
    {
        travelSwitch2 = true;
        master_script.current.EnemiesAttack(id);
        master_script.current.SpriteChange(id);
        master_script.current.EnemiesActionEnd(id);
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
                yield return new WaitForSeconds(waitTimer);
            }
        }
        yield return new WaitForSeconds(0.2f);
        travelSwitch2 = false;
    }

    IEnumerator CoroutineDeath()
    {
        //   predeath = true;
        animationStop = true;
        Debug.Log("Die");
        spriteRenderer.sprite = lose;
        yield return new WaitForSeconds(5);
        if (id == 0)
        {
            death = true;
        }
        if (id == 1)
        {
            death2 = true;
        }
    }

    IEnumerator CoroutineDamage()
    {
        armorSpriteDissable = true;
        if (animations == 9)
        {
            animations = 1;
        }
        if (animations == 10)
        {
            animations = 2;
        }
        if (animations == 11)
        {
            animations = 3;
        }
        if (animations == 12)
        {
            animations = 4;
        }
        if (animations == 13)
        {
            animations = 5;
        }
        if (animations == 14)
        {
            animations = 6;
        }
        if (animations == 15)
        {
            animations = 7;
        }
        if (animations == 16)
        {
            animations = 8;
        }
        Debug.Log("Armor break");
        inputLock = true;
        HeroInvincibility = true;
        if ((armorCounter == 0) || (armorCounter > 14))
        {
            armorBreakXXX = 1;
        }
        else if ((armorCounter != 0) && (armorCounter <= 14))
        {
            armorBreakXXX = 2;
        }
        yield return new WaitForSeconds(0.1f);
        armorBreak = true;//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        inputLock = false;
        if (GameObject.Find("Power-Up Icon") != null)
        {
            GameObject Icon = GameObject.Find("Power-Up Icon");
            power_up_icon_script iconReference = Icon.GetComponent<power_up_icon_script>();

            iconReference.iconArmour = false;
        }
    }

    IEnumerator CoroutineRoomChange()
    {
        Debug.Log("lock");
        portalEnterCheck = true;
        inputLock = true;
        /*
        if (GameObject.Find("Player Light") != null)
        {
            light1 = (GameObject.Find("Player Light"));
            Destroy(light1);
        }
        if (GameObject.Find("Player Light2") != null)
        {
            GameObject light = (GameObject.Find("Player Light2"));
            Destroy(light2);
        }*/
        yield return new WaitForSeconds(0.5f);
     //   light2 = Instantiate(Resources.Load("Player Light2")) as GameObject;
        if (roomSet == 1)
        {
            roomOfMap = 1;
        }
        if (roomSet == 2)
        {
            roomOfMap = 2;
        }
        if (roomSet == 3)
        {
            roomOfMap = 3;
        }
        if (roomSet == 4)
        {
            roomOfMap = 4;
        }
        if (roomSet == 5)
        {
            roomOfMap = 5;
        }
        portalEnterCheck = false;
        yield return new WaitForSeconds(0.2f);
        inputLock = false;
    }
    IEnumerator CoroutineHoleCheck()
    {
        yield return new WaitForSeconds(0.1f);
        if ((inputLock == true) && (isPLayerOnPlatform == false) && (holeCheck == true) && (endCheck == false))
        {
            endCheck = true;
            Debug.Log("Game Over X");
            Vector3 scale1 = new Vector3(0.9f, 0.9f, 1f);
            transform.localScale = scale1;
            yield return new WaitForSeconds(0.05f);
            Vector3 scale2 = new Vector3(0.8f, 0.8f, 1f);
            transform.localScale = scale2;
            yield return new WaitForSeconds(0.05f);
            Vector3 scale3 = new Vector3(0.7f, 0.7f, 1f);
            transform.localScale = scale3;
            yield return new WaitForSeconds(0.05f);
            Vector3 scale4 = new Vector3(0.6f, 0.6f, 1f);
            transform.localScale = scale4;
            yield return new WaitForSeconds(0.05f);
            Vector3 scale5 = new Vector3(0.5f, 0.5f, 1f);
            transform.localScale = scale5;
            yield return new WaitForSeconds(0.05f);
            Vector3 scale6 = new Vector3(0.4f, 0.4f, 1f);
            transform.localScale = scale6;
            yield return new WaitForSeconds(0.05f);
            Vector3 scale7 = new Vector3(0.3f, 0.3f, 1f);
            transform.localScale = scale7;
            yield return new WaitForSeconds(0.05f);
            rend = GetComponent<Renderer>();
            rend.enabled = false;
            StartCoroutine(CoroutineDeath());
            inv = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    //    Debug.Log(inputLock);
        animator.SetInteger("animation", animations);
        if (animationStop == true)
        {
            animator.gameObject.GetComponent<Animator>().enabled = false;
        }
        if (doorWinSprite == 1)
        {
            animator.gameObject.GetComponent<Animator>().enabled = false;
            spriteRenderer.sprite = win;
        }
        if (doorWinSprite == 2)
        {
            animator.gameObject.GetComponent<Animator>().enabled = false;
            spriteRenderer.sprite = perfect_win;
        }
        if ((isPLayerOnPlatform == false) && (holeCheck == true))
        {
            StartCoroutine(CoroutineHoleCheck());
        }
       // Debug.Log("ROOM OF MAP " + roomOfMap);
        if (specialVariable == true)
        {
            MoveUp();
        }

        if (dashAvailable == 0)
        {
            dashInput2 = false;
        }

        if (dashAvailable < 0.8f)
        {
            HeroDashAvailable = false;
        }


        if (GameObject.Find("Boss 1") != null)
        {
            GameObject Boss1 = GameObject.Find("Boss 1");
            boss1_script bossReference = Boss1.GetComponent<boss1_script>();
            if ((boss1Counter > 11) && (bossReference.exitPLayer == false))
            {
              //  Debug.Log("STOOOOP!");
              //  Boss1ActionStop();
              //  boss1Counter = 0;
            }
        }

        //  Debug.Log("timer " + HeroInvTimer);
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();

        if (endCheck == true)
        {
            inputLock = true;
        }

     //   Debug.Log("counter " + armorCounter);

        #region Inputs
        if (switchReference.levelType == 2) // move for versus
        {
            if (id == 0)
            {
                if (Input.GetKeyDown(KeyCode.W) && (uplock == false))
                {
                    animations = 3;
                    MoveUp();
                }
                if (Input.GetKeyDown(KeyCode.S) && (downlock == false))
                {
                    animations = 4;
                    MoveDown();
                }
                if (Input.GetKeyDown(KeyCode.A) && (leftlock == false))
                {
                    animations = 1;
                    MoveLeft();
                }
                if (Input.GetKeyDown(KeyCode.D) && (rightlock == false))
                {
                    animations = 2;
                    MoveRight();
                }
            }
            else if (id == 1)
            {
                if (Input.GetKeyDown("up") && (uplock2 == false))
                {
                    animations = 3;
                    MoveUp();
                }
                if (Input.GetKeyDown("down") && (downlock2 == false))
                {
                    animations = 4;
                    MoveDown();
                }
                if (Input.GetKeyDown("left") && (leftlock2 == false))
                {
                    animations = 1;
                    MoveLeft();
                }
                if (Input.GetKeyDown("right") && (rightlock2 == false))
                {
                    animations = 2;
                    MoveRight();
                }
            }
        }
        else //(Regular level, not versus)
        {
            if (inputLock == false)
            {
                if ((Input.GetKeyDown(KeyCode.W) && (uplock == false) && (leftUplock == false) && (rightUplock == false) && (uplock2 == false) && (uplockX2 == false) || (Input.GetKeyDown("up"))) && (uplock == false) && (leftUplock == false) && (rightUplock == false) && (uplock2 == false) && (uplockX2 == false))
                {
                    if ((HeroArmor == false) || ((HeroArmor == true) && (armorSpriteDissable == true)))
                    {
                        animations = 3;
                    }
                    else if ((HeroArmor == true) && (armorSpriteDissable == false))
                    {
                        animations = 11;
                    }
                    if ((dashCheck == true) && (uplockXX2 == false))
                    {
                        invincibility = true;
                    }
                    heroDirCheck = 0;
                    normalMove = true;
                    if (HeroAttackAvailable == true)
                    {
                        transform.GetChild(8).gameObject.SetActive(false);
                        transform.GetChild(9).gameObject.SetActive(false);
                        transform.GetChild(10).gameObject.SetActive(false);
                    }
                    MoveUp();
                }
                if ((Input.GetKeyDown(KeyCode.S) && (downlock == false) && (leftDownlock == false) && (rightDownlock == false) && (downlock2 == false) && (downlockX2 == false) || (Input.GetKeyDown("down"))) && (downlock == false) && (leftDownlock == false) && (rightDownlock == false) && (downlock2 == false) && (downlockX2 == false))
                {
                    if ((HeroArmor == false) || ((HeroArmor == true) && (armorSpriteDissable == true)))
                    {
                        animations = 4;
                    }
                    else if ((HeroArmor == true) && (armorSpriteDissable == false))
                    {
                        animations = 12;
                    }
                    if ((dashCheck == true) && (downlockXX2 == false))
                    {
                        invincibility = true;
                    }
                    heroDirCheck = 1;
                    normalMove = true;
                    if (HeroAttackAvailable == true)
                    {
                        transform.GetChild(8).gameObject.SetActive(false);
                        transform.GetChild(9).gameObject.SetActive(false);
                        transform.GetChild(10).gameObject.SetActive(false);
                    }
                    MoveDown();
                }
                if (Input.GetKeyDown(KeyCode.A) && (leftlock == false) && (leftUplock == false) && (leftDownlock == false) && (leftlock2 == false) && (leftlockX2 == false) || (Input.GetKeyDown("left")) && (leftlock == false) && (leftUplock == false) && (leftDownlock == false) && (leftlock2 == false) && (leftlockX2 == false))
                {
                    if ((HeroArmor == false) || ((HeroArmor == true) && (armorSpriteDissable == true)))
                    {
                        animations = 1;
                    }
                    else if ((HeroArmor == true) && (armorSpriteDissable == false))
                    {
                        animations = 9;
                    }
                    if ((dashCheck == true) && (leftlockXX2 == false))
                    {
                        invincibility = true;
                    }
                    heroDirCheck = 2;
                    normalMove = true;
                    if (HeroAttackAvailable == true)
                    {
                        transform.GetChild(8).gameObject.SetActive(false);
                        transform.GetChild(9).gameObject.SetActive(false);
                        transform.GetChild(10).gameObject.SetActive(false);
                    }
                    MoveLeft();
                }
                if ((Input.GetKeyDown(KeyCode.D) && (rightlock == false) && (rightUplock == false) && (rightDownlock == false) && (rightlock2 == false) && (rightlockX2 == false) || (Input.GetKeyDown("right"))) && (rightlock == false) && (rightUplock == false) && (rightDownlock == false) && (rightlock2 == false) && (rightlockX2 == false))
                {
                    if ((HeroArmor == false) || ((HeroArmor == true) && (armorSpriteDissable == true)))
                    {
                        animations = 2;
                    }
                    else if ((HeroArmor == true) && (armorSpriteDissable == false))
                    {
                        animations = 10;
                    }
                    if ((dashCheck == true) && (rightlockXX2 == false))
                    {
                        invincibility = true;
                    }
                    heroDirCheck = 3;
                    normalMove = true;
                    if (HeroAttackAvailable == true)
                    {
                        transform.GetChild(8).gameObject.SetActive(false);
                        transform.GetChild(9).gameObject.SetActive(false);
                        transform.GetChild(10).gameObject.SetActive(false);
                    }
                    MoveRight();
                }
            }

            if ((Input.GetKeyDown(KeyCode.Space)) && (HeroAttackAvailable == true) && (attackCheck == false) && (inputLock == false) && (bullets > 0)) //ATTACK
            {
                transform.GetChild(8).gameObject.SetActive(true);
                sword.transform.position = transform.position/* + new Vector3(0, 0.64f, 0)*/;
                attackCheck = true;
                bullets -= 1;
                StartCoroutine(SwordTimer());
            }
            if (((Input.GetKey(KeyCode.LeftShift)) || (Input.GetKey(KeyCode.RightShift))) && (HeroDashAvailable == true) && (inputLock == false)) //JUMP
            {
                dashInput2 = true;
            }
            if (dashInput2 == true)
            {
                dashInput = false;
                if ((uplock == false) && (uplockXX2 == false) && ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown("up"))))  // up
                {
                    dashCheck = true;
                    invincibility = true;
                    MoveUp();
                }
                if ((downlock == false) && (downlockXX2 == false) && ((Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown("down")))) // down
                {
                    dashCheck = true;
                    invincibility = true;
                    MoveDown();
                }
                if ((leftlock == false) && (leftlockXX2 == false) && ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown("left")))) // left
                {
                    dashCheck = true;
                    invincibility = true;
                    MoveLeft();
                }
                if ((rightlock == false) && (rightlockXX2 == false) && ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown("right")))) // right
                {
                    dashCheck = true;
                    invincibility = true;
                    MoveRight();
                }

            }
            if ((Input.GetKey(KeyCode.LeftShift) == false) && (Input.GetKey(KeyCode.RightShift) == false))
            {
                dashInput2 = false;
            }
            if ((Input.GetKey(KeyCode.LeftShift) == false) && (Input.GetKey(KeyCode.RightShift) == false) && dashInput2 == false)
            {
                if (HeroDashAvailable == false)
                {
                    //   dashAvailable = 3;
                }
                dashInput2 = false;
            }
            if (Input.GetKeyDown(KeyCode.T) && (HeroTimeTravel == true) && (travelSwitch == false) && (inputLock == false)) // TIME CONTROL
            {
                Debug.Log("Time Travel Enter");
                StartCoroutine(CoroutineTimeTravel());
            }
            if ((travelSwitch2 == false) && (travelSwitch == true))
            {
                if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown("left")))
                {
                    timeNumber -= 1;
                    Debug.Log("back");
                    StartCoroutine(CoroutineTimeTravelBackward());
                }
                if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown("right")))
                {
                    timeNumber += 1;
                    Debug.Log("forward");
                    StartCoroutine(CoroutineTimeTravelForward());
                }

                if ((Input.GetKeyDown(KeyCode.T)) && (travelSwitch = true))
                {
                    Debug.Log("Time Travel Exit");
                    inputLock = false;
                    travelSwitch = false;
                    HeroTimeTravel = false;
                    if (GameObject.Find("Power-Up Icon") != null)
                    {
                        GameObject Icon = GameObject.Find("Power-Up Icon");
                        power_up_icon_script iconReference = Icon.GetComponent<power_up_icon_script>();

                        iconReference.iconTimeTravel = false;
                    }
                }
            }
        }
        #endregion


        if ((moveupS == true) || (movedownS == true) || (moveleftS == true) || (moverightS == true)) // END MOVE VARIABLES
        {
            EndMove();
        }

        if ((death == true) && (switchReference.levelType != 2))
        {
            if (GameObject.Find("0.noMove enemy (K)") != null)
            {
                GameObject KeyEnemy = GameObject.Find("0.noMove enemy (K)");
                basic_enemy_script respawnReference = KeyEnemy.GetComponent<basic_enemy_script>();
                respawnReference.spawnCheck = 0;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (switchReference.levelType == 2)
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script deathReference = Player2.GetComponent<player_script>();

            if ((death == true) && (deathReference.death2 == true))
            {
                music.SetActive(false);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else
        {
            if (endCheck == true)
            {
                music.SetActive(false);
            }
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

        if (HeroInvTimer == 0)
        {
            HeroInvincibility = false;
            if (GameObject.Find("Power-Up Icon") != null)
            {
                GameObject Icon = GameObject.Find("Power-Up Icon");
                power_up_icon_script iconReference = Icon.GetComponent<power_up_icon_script>();

                iconReference.iconInvincibility = false;
            }
            HeroInvTimer = 5;
        }

        if (dashAvailable <= 0)
        {
            if (GameObject.Find("Power-Up Icon") != null)
            {
                GameObject Icon = GameObject.Find("Power-Up Icon");
                power_up_icon_script iconReference = Icon.GetComponent<power_up_icon_script>();

                iconReference.iconDash = false;
            }
        }

        if (worldPass == true)
        {
            StartCoroutine(NewWorld());
        }

        //  Debug.Log("time " + timeNumber);
        //  Debug.Log("third last is "+ lastMove3 + " second last is " + lastMove2 + " last one is " + lastMove1);
        /*
        foreach (var x in timeList)
        {
            Debug.Log(x.ToString());
        }
        */

        if ((dashAvailable == 0) || (dashAvailable > 3))
        {
            //   Debug.Log("dash limit pass");
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 

    public void EndMove()
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

            if (animations == 9)
            {
                animations = 13;
            }
            if (animations == 10)
            {
                animations = 14;
            }
            if (animations == 11)
            {
                animations = 15;
            }
            if (animations == 12)
            {
                animations = 16;
            }
        if (HeroInvincibility == true)
        {
            HeroInvTimer -= 1;
        }
        inv = false;
        if (endCheck == false)
        {
            if ((portalEnterCheck == false) && (extraTutorialInputLock == false))
            {
                inputLock = false;
            }
        }
        dashInput = false;
        dashCheck = false;
        attackCheck = false;
        invincibility = false;
        normalMove = false;
        moveupS = false;
        movedownS = false;
        moveleftS = false;
        moverightS = false;
        endOfMove = false;
    }

    /// <summary>
    /// ////////////
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
            switchReference.specialMoves += 1;
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
            switchReference.specialMoves += 1;
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
            switchReference.specialMoves += 1;
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
            switchReference.specialMoves += 1;
            if (endCheck == false)
            {
                spriteRenderer.sprite = right;
            }
        }
    }


    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("platform"))
        {
         //   Debug.Log("ENTER!");
            isPLayerOnPlatform = true;
        }
        if (collider.gameObject.tag.Equals("hole"))
        {
            holeCheck = true;
        }
        if (invincibility == false)
        {
            if ((collider.gameObject.tag.Equals("RegularEnemy")) || ((collider.gameObject.tag.Equals("JumpEnemy")) && (inv == true)) || ((collider.gameObject.tag.Equals("Boss"))) || ((collider.gameObject.tag.Equals("ArmourEnemy"))) || ((collider.gameObject.tag.Equals("projectile"))))
            {
                if (soundSpikeCheck == false)
                {
                    IntroLoop_Script musicScript;
                    musicScript = GameObject.Find("BGM").GetComponent<IntroLoop_Script>();
                    musicScript.StopBgm();
                    sound_manager_script.PlaySound("SpikeHit");
                    soundSpikeCheck = true;
                }
                if ((HeroArmor == false) || ((HeroArmor == true) && (holeCheck == true)))
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
            #region portal collision
            if (collision.gameObject.tag.Equals("Portal"))
            {
                GameObject Camera = GameObject.Find("Main Camera");
                camera_script cameraChange = Camera.GetComponent<camera_script>();

                //teleport to same room
                if (collision.gameObject == portal1_1a)
                {
                    player.transform.position = portal1_1b.transform.position;
                }
                if (collision.gameObject == portal1_1b)
                {
                    player.transform.position = portal1_1a.transform.position;
                }
                if (collision.gameObject == portal1_1c)
                {
                    player.transform.position = portal1_1d.transform.position;
                }
                if (collision.gameObject == portal1_1d)
                {
                    player.transform.position = portal1_1c.transform.position;
                }

                if (collision.gameObject == portal2_2a)
                {
                    player.transform.position = portal2_2b.transform.position;
                }
                if (collision.gameObject == portal2_2b)
                {
                    player.transform.position = portal2_2a.transform.position;
                }
                if (collision.gameObject == portal2_2c)
                {
                    player.transform.position = portal2_2d.transform.position;
                }
                if (collision.gameObject == portal2_2d)
                {
                    player.transform.position = portal2_2c.transform.position;
                }

                if (collision.gameObject == portal3_3a)
                {
                    player.transform.position = portal3_3b.transform.position;
                }
                if (collision.gameObject == portal3_3b)
                {
                    player.transform.position = portal3_3a.transform.position;
                }
                if (collision.gameObject == portal3_3c)
                {
                    player.transform.position = portal3_3d.transform.position;
                }
                if (collision.gameObject == portal3_3d)
                {
                    player.transform.position = portal3_3c.transform.position;
                }

                if (collision.gameObject == portal4_4a)
                {
                    player.transform.position = portal4_4b.transform.position;
                }
                if (collision.gameObject == portal4_4b)
                {
                    player.transform.position = portal4_4a.transform.position;
                }
                if (collision.gameObject == portal4_4c)
                {
                    player.transform.position = portal4_4d.transform.position;
                }
                if (collision.gameObject == portal4_4d)
                {
                    player.transform.position = portal4_4c.transform.position;
                }

                if (collision.gameObject == portal5_5a)
                {
                    player.transform.position = portal5_5b.transform.position;
                }
                if (collision.gameObject == portal5_5b)
                {
                    player.transform.position = portal5_5a.transform.position;
                }
                if (collision.gameObject == portal5_5c)
                {
                    player.transform.position = portal5_5d.transform.position;
                }
                if (collision.gameObject == portal5_5d)
                {
                    player.transform.position = portal5_5c.transform.position;
                }

                //teleport to different room
                if (collision.gameObject == portal1_2)
                {
                    player.transform.position = portal2_1.transform.position;
                    roomSet = 2;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal1_3)
                {
                    player.transform.position = portal3_1.transform.position;
                    roomSet = 3;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal1_4)
                {
                    player.transform.position = portal4_1.transform.position;
                    roomSet = 4;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal1_5)
                {
                    player.transform.position = portal5_1.transform.position;
                    roomSet = 5;
                    StartCoroutine(CoroutineRoomChange());
                }

                if (collision.gameObject == portal2_1)
                {
                    player.transform.position = portal1_2.transform.position;
                    roomSet = 1;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal2_3)
                {
                    player.transform.position = portal3_2.transform.position;
                    roomSet = 3;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal2_4)
                {
                    player.transform.position = portal4_2.transform.position;
                    roomSet = 4;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal2_5)
                {
                    player.transform.position = portal5_2.transform.position;
                    roomSet = 5;
                    StartCoroutine(CoroutineRoomChange());
                }

                if (collision.gameObject == portal3_1)
                {
                    player.transform.position = portal1_3.transform.position;
                    roomSet = 1;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal3_2)
                {
                    player.transform.position = portal2_3.transform.position;
                    roomSet = 2;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal3_4)
                {
                    player.transform.position = portal4_3.transform.position;
                    roomSet = 4;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal3_5)
                {
                    player.transform.position = portal5_3.transform.position;
                    roomSet = 5;
                    StartCoroutine(CoroutineRoomChange());
                }

                if (collision.gameObject == portal4_1)
                {
                    player.transform.position = portal1_4.transform.position;
                    roomSet = 1;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal4_2)
                {
                    player.transform.position = portal2_4.transform.position;
                    roomSet = 2;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal4_3)
                {
                    player.transform.position = portal3_4.transform.position;
                    roomSet = 3;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal4_5)
                {
                    player.transform.position = portal5_4.transform.position;
                    roomSet = 5;
                    StartCoroutine(CoroutineRoomChange());
                }

                if (collision.gameObject == portal5_1)
                {
                    player.transform.position = portal1_5.transform.position;
                    roomSet = 1;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal5_2)
                {
                    player.transform.position = portal2_5.transform.position;
                    roomSet = 2;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal5_3)
                {
                    player.transform.position = portal3_5.transform.position;
                    roomSet = 3;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal5_4)
                {
                    player.transform.position = portal4_5.transform.position;
                    roomSet = 4;
                    StartCoroutine(CoroutineRoomChange());
                }

                //maze code

                if (collision.gameObject == portal1_A)
                {
                    player.transform.position = portal2_C.transform.position;
                    roomSet = 2;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal1_B)
                {
                    player.transform.position = portal1_D.transform.position;
                    specialTeleport = true;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal1_C)
                {
                    player.transform.position = portal2_A.transform.position;
                    roomSet = 2;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal1_D)
                {
                    player.transform.position = portal1_B.transform.position;
                    specialTeleport = true;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal2_A)
                {
                    player.transform.position = portal1_C.transform.position;
                    roomSet = 1;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal2_B)
                {
                    player.transform.position = portal4_A.transform.position;
                    roomSet = 4;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal2_C)
                {
                    player.transform.position = portal1_A.transform.position;
                    roomSet = 1;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal2_D)
                {
                    player.transform.position = portal3_D.transform.position;
                    roomSet = 3;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal3_A)
                {
                    player.transform.position = portal5_B.transform.position;
                    roomSet = 5;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal3_B)
                {
                    player.transform.position = portal5_C.transform.position;
                    roomSet = 5;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal3_C)
                {
                    player.transform.position = portal5_D.transform.position;
                    roomSet = 5;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal3_D)
                {
                    player.transform.position = portal2_D.transform.position;
                    roomSet = 2;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal4_A)
                {
                    player.transform.position = portal2_B.transform.position;
                    roomSet = 2;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal4_B)
                {
                    player.transform.position = portal4_C.transform.position;
                    specialTeleport = true;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal4_C)
                {
                    player.transform.position = portal4_B.transform.position;
                    specialTeleport = true;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal4_D)
                {
                    player.transform.position = portal5_A.transform.position;
                    roomSet = 5;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal5_A)
                {
                    player.transform.position = portal4_D.transform.position;
                    roomSet = 4;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal5_B)
                {
                    player.transform.position = portal3_A.transform.position;
                    roomSet = 3;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal5_C)
                {
                    player.transform.position = portal3_B.transform.position;
                    roomSet = 3;
                    StartCoroutine(CoroutineRoomChange());
                }
                if (collision.gameObject == portal5_D)
                {
                    player.transform.position = portal3_C.transform.position;
                    roomSet = 3;
                    StartCoroutine(CoroutineRoomChange());
                }

                portalCheck = true;
            }
            #endregion

            if (GameObject.Find("Power-Up Icon") != null)
            {
                GameObject Icon = GameObject.Find("Power-Up Icon");
                power_up_icon_script iconReference = Icon.GetComponent<power_up_icon_script>();

                if (collision.gameObject.tag.Equals("armour"))
                {
                    if (HeroArmor == false)
                    {
                        armorSpriteDissable = false;
                        if (animations == 1)
                        {
                            animations = 9;
                        }
                        if (animations == 2)
                        {
                            animations = 10;
                        }
                        if (animations == 3)
                        {
                            animations = 11;
                        }
                        if (animations == 4)
                        {
                            animations = 12;
                        }
                        if (animations == 5)
                        {
                            animations = 13;
                        }
                        if (animations == 6)
                        {
                            animations = 14;
                        }
                        if (animations == 7)
                        {
                            animations = 15;
                        }
                        if (animations == 8)
                        {
                            animations = 16;
                        }
                        HeroArmor = true;
                        iconReference.iconArmour = true;
                        Destroy(collision.gameObject);
                    }
                }
                if ((collision.gameObject.tag.Equals("doubleJump")) && (HeroDashAvailable == false))
                {
                    HeroDashAvailable = true;
                    iconReference.iconDash = true;
                    dashAvailable = 3;
                    Destroy(collision.gameObject);
                }
                if ((collision.gameObject.tag.Equals("invincibility")) && (HeroInvincibility == false))
                {
                    HeroInvincibility = true;
                    iconReference.iconInvincibility = true;
                    Destroy(collision.gameObject);
                }
                if ((collision.gameObject.tag.Equals("timeTravel")) && (HeroTimeTravel == false))
                {
                    HeroTimeTravel = true;
                    iconReference.iconTimeTravel = true;
                    Destroy(collision.gameObject);
                }
                if ((collision.gameObject.tag.Equals("weapon")) && (HeroAttackAvailable == false))
                {
                    HeroAttackAvailable = true;
                    iconReference.iconAttack = true;
                    Destroy(collision.gameObject);
                }
                if ((GameObject.Find("Special Power-Up") != null) && (GameObject.Find("SceneUnlocker") != null))
                {
                    GameObject SpecialItem = GameObject.Find("Special Power-Up");
                    special_power_up_script itemReference = SpecialItem.GetComponent<special_power_up_script>();
                    GameObject Unlocker = GameObject.Find("SceneUnlocker");
                    scene_unlocker_script itemReference2 = Unlocker.GetComponent<scene_unlocker_script>();

                    if (collision.gameObject.tag.Equals("special"))
                    {
                        if (itemReference.type == 1)
                        {
                            itemReference2.stage_1_7_attack_power_up = 1;
                        }
                        if (itemReference.type == 2)
                        {
                            itemReference2.stage_2_19_dash_power_up = 1;
                        }
                        if (itemReference.type == 3)
                        {
                            if (itemReference2.firstTimeTutorialSeen == 0)
                            {
                                GameObject TutorialBox = Instantiate(Resources.Load("Tutorial Object")) as GameObject;
                                TutorialBox.transform.position = transform.position;
                                tutorial_object_script itemReference3 = TutorialBox.GetComponent<tutorial_object_script>();
                                itemReference3.type = 21;
                            }
                            if (itemReference2.firstTimeTutorialSeen > 0)
                            {
                                GameObject TutorialBox = Instantiate(Resources.Load("Tutorial Object")) as GameObject;
                                TutorialBox.transform.position = transform.position;
                                tutorial_object_script itemReference3 = TutorialBox.GetComponent<tutorial_object_script>();
                                itemReference3.keyCardHints = true;
                            }
                        }
                        Destroy(collision.gameObject);
                    }
                }
            }
        }
    }


    private void OnTriggerExit2D(Collider2D collider2)
    {
        if (collider2.gameObject.tag.Equals("platform"))
        {
            Debug.Log("ENTER!");
            isPLayerOnPlatform = false;
        }
        if (collider2.gameObject.tag.Equals("hole"))
        {
            holeCheck = false;
        }
    }

        private void EnemiesActions()
    {
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
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
    }

    private void Boss1ActionStop()
    {
        if (GameObject.Find("Boss 1") != null)
        {
            GameObject Boss1 = GameObject.Find("Boss 1");
            boss1_script bossReference = Boss1.GetComponent<boss1_script>();
            if (bossReference.actionStop == true)
            {
                if ((bossReference.animations == 11) || (bossReference.animations == 12))
                {
                    bossReference.animations = 21;
                }
                if ((bossReference.animations == 13) || (bossReference.animations == 14))
                {
                    bossReference.animations = 22;
                }
                if (bossReference.animations == 15)
                {
                    bossReference.animations = 23;
                }
                if (bossReference.animations == 16)
                {
                    bossReference.animations = 24;
                }
            }
        }
    }

    private void ArmorBreak()
    {
        if (armorBreak == true)
        {
            soundSpikeCheck = false;
            HeroArmor = false;
            deathPrevent = true;
            armorBreak = false;
        }
    }
}