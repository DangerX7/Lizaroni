using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door_script : MonoBehaviour
{
    //  public bool isDoorOpen = false;

    public GameObject player1, player2;
    public SpriteRenderer  playerRenderer;
    public Sprite win, superWin, lose;
    public int doorNumber;
    public bool isDoorOpen = false;
    public bool isDoor2Open = false;
    public bool pass = false;
    public bool enter = false;

    public bool s2_10locka;
    public bool s2_10lockb;

    public int chapterNumber;

    public bool complete;
    public bool mazeComplete;
    public bool chapterDoor;
    private Vector3 scaleChange;
    public bool doorExtraOpen;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(-200, -200, -200);
    }

    IEnumerator EnterDoor()
    {
        GameObject Player = GameObject.Find("Player");
        player_script playerRef = Player.GetComponent<player_script>();
        GameObject Master = GameObject.Find("MasterObject");
        master_script masterReference = Master.GetComponent<master_script>();

        yield return new WaitForSeconds(0.1f);
        if (playerRef.endCheck == false)
        {
            enter = true;
            playerRef.endCheck = true;
        }

        if (enter == true)
        {
            if ((isDoorOpen == true) && (masterReference.moves != masterReference.minMoves))
            {
                //    playerRenderer.sprite = win;
                playerRef.animationStop = true;
                playerRef.doorWinSprite = 1;
                if (masterReference.levelType == 0)
                {
                    IntroLoop_Script musicScript;
                    musicScript = GameObject.Find("BGM").GetComponent<IntroLoop_Script>();
                    musicScript.StopBgm();
                    sound_manager_script.PlaySound("EnterDoor");
                    yield return new WaitForSeconds(6);
                    pass = true;
                    AdvanceLevel();
                }
                else if (masterReference.levelType == 1)
                {
                    if (doorNumber == 100)
                    {
                        IntroLoop_Script musicScript;
                        musicScript = GameObject.Find("BGM").GetComponent<IntroLoop_Script>();
                        musicScript.StopBgm();
                        sound_manager_script.PlaySound("PerfectWin");
                    }
                    else
                    {
                        IntroLoop_Script musicScript;
                        musicScript = GameObject.Find("BGM").GetComponent<IntroLoop_Script>();
                        musicScript.StopBgm();
                        sound_manager_script.PlaySound("EnterDoor");
                    }
                    yield return new WaitForSeconds(6);
                    pass = true;
                    AdvanceLevel();
                }
                else if (masterReference.levelType == 2)
                {
                    Debug.Log("Player 1 Wins!");
                }
            }
            else if ((isDoorOpen == true) && (masterReference.moves == masterReference.minMoves))
            {
                //    playerRenderer.sprite = superWin;
                playerRef.animationStop = true;
                playerRef.doorWinSprite = 2;
                IntroLoop_Script musicScript;
                musicScript = GameObject.Find("BGM").GetComponent<IntroLoop_Script>();
                musicScript.StopBgm();
                sound_manager_script.PlaySound("PerfectWin");
                yield return new WaitForSeconds(6);
                if (masterReference.levelType == 0)
                {
                    pass = true;
                    AdvanceLevel();
                }
                else if (masterReference.levelType == 1)
                {
                    /// Nothing
                }
            }
            else if (isDoor2Open == true)
            {
                Debug.Log("Player 2 Wins!");
            }
        }
        
    }

    IEnumerator Versus()
    {
        GameObject Player = GameObject.Find("Player");
        player_script passReference = Player.GetComponent<player_script>();
        GameObject Player2 = GameObject.Find("Player2");
        player_script passReference2 = Player2.GetComponent<player_script>();
        GameObject SceneUnlocker = GameObject.Find("SceneUnlocker");
        scene_unlocker_script sceneReference = SceneUnlocker.GetComponent<scene_unlocker_script>();
        yield return new WaitForSeconds(0.1f);
        passReference.endCheck = true;
        passReference2.endCheck = true;
        IntroLoop_Script musicScript;
        musicScript = GameObject.Find("BGM").GetComponent<IntroLoop_Script>();
        musicScript.StopBgm();
        sound_manager_script.PlaySound("PerfectWin");

        if (doorNumber == 0)
        {
            sceneReference.player1Wins += 1;
            passReference.doorWinSprite = 1;
            if (sceneReference.vsLevelNumber == 0)
            {
                sceneReference.win1_1 = true;
            }
            if (sceneReference.vsLevelNumber == 1)
            {
                sceneReference.win1_2 = true;
            }
            if (sceneReference.vsLevelNumber == 2)
            {
                sceneReference.win1_3 = true;
            }
        }
        if (doorNumber == 1)
        {
            sceneReference.player2Wins += 1;
            passReference2.doorWinSprite = 1;
            if (sceneReference.vsLevelNumber == 0)
            {
                sceneReference.win2_1 = true;
            }
            if (sceneReference.vsLevelNumber == 1)
            {
                sceneReference.win2_2 = true;
            }
            if (sceneReference.vsLevelNumber == 2)
            {
                sceneReference.win2_3 = true;
            }
        }
        if (sceneReference.player1Wins == 2)
        {
            passReference.doorWinSprite = 2;
            sceneReference.p1Victory = true;
        }
        if (sceneReference.player2Wins == 2)
        {
            passReference2.doorWinSprite = 2;
            sceneReference.p2Victory = true;
        }

        /*
        if ((sceneReference.player1Wins == 2) || (sceneReference.player2Wins == 2))
        {
            playerRenderer.sprite = superWin;
        }
        else
        {
            playerRenderer.sprite = win;
        }
        */
        yield return new WaitForSeconds(6);
        sceneReference.vsLevelNumber += 1;
        if (sceneReference.player1Wins == 2)
        {
            Debug.Log("PLAYER 1 WINS!!!");
            SceneUnlocker.GetComponent<scene_unlocker_script>().VersusModeEnd();
        }
        if (sceneReference.player2Wins == 2)
        {
            SceneUnlocker.GetComponent<scene_unlocker_script>().VersusModeEnd();
            Debug.Log("PLAYER 2 WINS!!!");
        }
        else if ((sceneReference.player1Wins < 2) && (sceneReference.player2Wins < 2))
        {
            sceneReference.versusLevelStart = true;
        }
    }


    IEnumerator CoroutineExtraWait()
    {
        yield return new WaitForSeconds(0.2f);
        mazeComplete = true;
    }
    IEnumerator CoroutineWait()
    {
        if (doorExtraOpen == false)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
            isDoorOpen = true;
            yield return new WaitForSeconds(0.001f);
            doorExtraOpen = true;
        }
    }
    IEnumerator CoroutineWaitVersus()
    {
        if (doorExtraOpen == false)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
            isDoor2Open = true;
            yield return new WaitForSeconds(0.001f);
            doorExtraOpen = true;
        }
    }


    IEnumerator CoroutineWait2()
    {
        yield return new WaitForSeconds(0.2f);
        transform.localScale -= scaleChange;
        chapterDoor = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (chapterDoor == true)
        {
            StartCoroutine(CoroutineWait2());
        }

        if (complete == true)
        {
            transform.position = player1.transform.position;
            GameObject Player = GameObject.Find("Player");
            player_script XReference = Player.GetComponent<player_script>();
            XReference.specialVariable = true;
        }

        GameObject Master = GameObject.Find("MasterObject");
        master_script keysReference = Master.GetComponent<master_script>();
        if ((keysReference.lockKeys ==  keysReference.keys) && ((doorNumber == 0) || (doorNumber > 1)))
        {
            if (GameObject.Find("Normal Exception") != null)
            {
                StartCoroutine(CoroutineExtraWait());
                if (mazeComplete == true)
                {
                    transform.position = player1.transform.position;
                }    
            }
                StartCoroutine(CoroutineWait());
        }
        if ((keysReference.lockKeysV == keysReference.keysV) && (doorNumber == 1))
        {
            StartCoroutine(CoroutineWaitVersus());
        }

        if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story10")) && (GameObject.Find("SceneUnlocker") != null))
        {
            GameObject Scene = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scene.GetComponent<scene_unlocker_script>();
            if ((sceneReference.door2_10Lock1 == true) && (sceneReference.door2_10Lock2 == true))
            {
                keysReference.keys = 2;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
       // var enemies = GameObject.FindGameObjectsWithTag("EnemyAI");
       // for (enemy in enemies) enemy.GetComponent(EnemyShipAI).RaceBeginnerEnemy = true;

        GameObject Master = GameObject.Find("MasterObject");
        master_script keysReference = Master.GetComponent<master_script>();

        if ((col.gameObject.tag.Equals("Player")) || (complete == true))
        {
            if ((keysReference.lockKeys == keysReference.keys) && (keysReference.levelType != 2))
            {
                StartCoroutine(EnterDoor());
            }
            else if (keysReference.levelType == 2)
            {
                if (keysReference.lockKeys == keysReference.keys)
                {
                    StartCoroutine(Versus());
                }
                else if (keysReference.lockKeysV == keysReference.keysV)
                {
                    StartCoroutine(Versus());
                }
            }
        }

    }

    public void AdvanceLevel()
    {
        GameObject Master2 = GameObject.Find("MasterObject");
        master_script levelReference = Master2.GetComponent<master_script>();

        if ((pass == true) && (GameObject.Find("SceneUnlocker") != null))
        {
        //    Debug.Log("SceneUnlockerLog2");
            GameObject Scene = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scene.GetComponent<scene_unlocker_script>();

            if (levelReference.levelType == 0)
            {
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Main_Gate-1"))
                {
                    Debug.Log("unlocked scene 2");
                    sceneReference.classic1Done = true;
                    sceneReference.Scene2Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic1Min = true;
                    }
                    sceneReference.cursorMemory0 = 2;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Main_Gate-2"))
                {
                    sceneReference.classic2Done = true;
                    sceneReference.Scene3Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic2Min = true;
                    }
                    sceneReference.cursorMemory0 = 3;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Main_Gate-3"))
                {
                    sceneReference.classic3Done = true;
                    sceneReference.Scene4Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic3Min = true;
                    }
                    sceneReference.cursorMemory0 = 4;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Long_Corridor-1"))
                {
                    sceneReference.classic4Done = true;
                    sceneReference.Scene5Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic4Min = true;
                    }
                    sceneReference.cursorMemory0 = 5;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Long_Corridor-2"))
                {
                    sceneReference.classic5Done = true;
                    sceneReference.Scene6Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic5Min = true;
                    }
                    sceneReference.cursorMemory0 = 6;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Long_Corridor-3"))
                {
                    sceneReference.classic6Done = true;
                    sceneReference.Scene7Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic6Min = true;
                    }
                    sceneReference.cursorMemory0 = 7;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Long_Corridor-4"))
                {
                    sceneReference.classic7Done = true;
                    sceneReference.Scene8Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic7Min = true;
                    }
                    sceneReference.cursorMemory0 = 8;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Long_Corridor-5"))
                {
                    sceneReference.classic8Done = true;
                    sceneReference.Scene9Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic8Min = true;
                    }
                    sceneReference.cursorMemory0 = 9;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Secret_Passage-1"))
                {
                    sceneReference.classic9Done = true;
                    sceneReference.Scene10Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic9Min = true;
                    }
                    sceneReference.cursorMemory0 = 10;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Secret_Passage-2"))
                {
                    sceneReference.classic10Done = true;
                    sceneReference.Scene11Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic10Min = true;
                    }
                    sceneReference.cursorMemory0 = 11;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Secret_Passage-3"))
                {
                    sceneReference.classic11Done = true;
                    sceneReference.Scene12Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic11Min = true;
                    }
                    sceneReference.cursorMemory0 = 12;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Secret_Passage-4"))
                {
                    sceneReference.classic12Done = true;
                    sceneReference.Scene13Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic12Min = true;
                    }
                    sceneReference.cursorMemory0 = 13;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Secret_Passage-4Ex"))
                {
                    sceneReference.classic13Done = true;
                    sceneReference.Scene14Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic13Min = true;
                    }
                    sceneReference.cursorMemory0 = 14;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Secret_Passage-5"))
                {
                    sceneReference.classic14Done = true;
                    sceneReference.Scene15Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic14Min = true;
                    }
                    sceneReference.cursorMemory0 = 15;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Dungeon-1"))
                {
                    sceneReference.classic15Done = true;
                    sceneReference.Scene16Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic15Min = true;
                    }
                    sceneReference.cursorMemory0 = 16;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Dungeon-2"))
                {
                    sceneReference.classic16Done = true;
                    sceneReference.Scene17Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic16Min = true;
                    }
                    sceneReference.cursorMemory0 = 17;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Dungeon-2Ex"))
                {
                    sceneReference.classic17Done = true;
                    sceneReference.Scene18Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic17Min = true;
                    }
                    sceneReference.cursorMemory0 = 18;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Dungeon-3"))
                {
                    sceneReference.classic18Done = true;
                    sceneReference.Scene19Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic18Min = true;
                    }
                    sceneReference.cursorMemory0 = 19;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Dungeon-4"))
                {
                    sceneReference.classic19Done = true;
                    sceneReference.Scene20Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic19Min = true;
                    }
                    sceneReference.cursorMemory0 = 20;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Dungeon-4Ex"))
                {
                    sceneReference.classic20Done = true;
                    sceneReference.Scene21Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic20Min = true;
                    }
                    sceneReference.cursorMemory0 = 21;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Dungeon-5"))
                {
                    sceneReference.classic21Done = true;
                    sceneReference.Scene22Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic21Min = true;
                    }
                    sceneReference.cursorMemory0 = 22;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-1"))
                {
                    sceneReference.classic22Done = true;
                    sceneReference.Scene23Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic22Min = true;
                    }
                    sceneReference.cursorMemory0 = 23;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-2"))
                {
                    sceneReference.classic23Done = true;
                    sceneReference.Scene24Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic23Min = true;
                    }
                    sceneReference.cursorMemory0 = 24;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-3"))
                {
                    sceneReference.classic24Done = true;
                    sceneReference.Scene25Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic24Min = true;
                    }
                    sceneReference.cursorMemory0 = 25;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-3Ex"))
                {
                    sceneReference.classic25Done = true;
                    sceneReference.Scene26Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic25Min = true;
                    }
                    sceneReference.cursorMemory0 = 26;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-4"))
                {
                    sceneReference.classic26Done = true;
                    sceneReference.Scene27Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic26Min = true;
                    }
                    sceneReference.cursorMemory0 = 27;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-5"))
                {
                    sceneReference.classic27Done = true;
                    sceneReference.Scene28Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic27Min = true;
                    }
                    sceneReference.cursorMemory0 = 28;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-6"))
                {
                    sceneReference.classic28Done = true;
                    sceneReference.Scene29Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic28Min = true;
                    }
                    sceneReference.cursorMemory0 = 29;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-6Ex"))
                {
                    sceneReference.classic29Done = true;
                    sceneReference.Scene30Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic29Min = true;
                    }
                    sceneReference.cursorMemory0 = 30;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-7"))
                {
                    sceneReference.classic30Done = true;
                    sceneReference.Scene31Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic30Min = true;
                    }
                    sceneReference.cursorMemory0 = 31;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Dojo-8"))
                {
                    sceneReference.classic31Done = true;
                    sceneReference.Scene32Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic31Min = true;
                    }
                    sceneReference.cursorMemory0 = 32;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-1"))
                {
                    sceneReference.classic32Done = true;
                    sceneReference.Scene33Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic32Min = true;
                    }
                    sceneReference.cursorMemory0 = 33;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-2"))
                {
                    sceneReference.classic33Done = true;
                    sceneReference.Scene34Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic33Min = true;
                    }
                    sceneReference.cursorMemory0 = 34;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-3"))
                {
                    sceneReference.classic34Done = true;
                    sceneReference.Scene35Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic34Min = true;
                    }
                    sceneReference.cursorMemory0 = 35;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-3Ex"))
                {
                    sceneReference.classic35Done = true;
                    sceneReference.Scene36Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic35Min = true;
                    }
                    sceneReference.cursorMemory0 = 36;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-4"))
                {
                    sceneReference.classic36Done = true;
                    sceneReference.Scene37Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic36Min = true;
                    }
                    sceneReference.cursorMemory0 = 37;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-5"))
                {
                    sceneReference.classic37Done = true;
                    sceneReference.Scene38Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic37Min = true;
                    }
                    sceneReference.cursorMemory0 = 38;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-6"))
                {
                    sceneReference.classic38Done = true;
                    sceneReference.Scene39Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic38Min = true;
                    }
                    sceneReference.cursorMemory0 = 39;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-7"))
                {
                    sceneReference.classic39Done = true;
                    sceneReference.Scene40Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic39Min = true;
                    }
                    sceneReference.cursorMemory0 = 40;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-7Ex"))
                {
                    sceneReference.classic40Done = true;
                    sceneReference.Scene41Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic40Min = true;
                    }
                    sceneReference.cursorMemory0 = 41;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-8"))
                {
                    sceneReference.classic41Done = true;
                    sceneReference.Scene42Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic41Min = true;
                    }
                    sceneReference.cursorMemory0 = 42;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-9"))
                {
                    sceneReference.classic42Done = true;
                    sceneReference.Scene43Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic42Min = true;
                    }
                    sceneReference.cursorMemory0 = 43;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-10"))
                {
                    sceneReference.classic43Done = true;
                    sceneReference.Scene44Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic43Min = true;
                    }
                    sceneReference.cursorMemory0 = 44;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-10Ex"))
                {
                    sceneReference.classic44Done = true;
                    sceneReference.Scene45Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic44Min = true;
                    }
                    sceneReference.cursorMemory0 = 45;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("6Dark_Castle-11"))
                {
                    sceneReference.classic45Done = true;
                    sceneReference.Scene46Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic45Min = true;
                    }
                    sceneReference.cursorMemory0 = 46;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("7Secret_Cave-1"))
                {
                    sceneReference.classic46Done = true;
                    sceneReference.Scene47Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic46Min = true;
                    }
                    sceneReference.cursorMemory0 = 47;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("7Secret_Cave-2"))
                {
                    sceneReference.classic47Done = true;
                    sceneReference.Scene48Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic47Min = true;
                    }
                    sceneReference.cursorMemory0 = 48;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("7Secret_Cave-3"))
                {
                    sceneReference.classic48Done = true;
                    sceneReference.Scene49Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic48Min = true;
                    }
                    sceneReference.cursorMemory0 = 49;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("7Secret_Cave-4"))
                {
                    sceneReference.classic49Done = true;
                    sceneReference.Scene50Active = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic49Min = true;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("7Secret_Cave-5"))
                {
                    sceneReference.classic50Done = true;
                    if (levelReference.moves == levelReference.minMoves)
                    {
                        sceneReference.classic50Min = true;
                    }
                    sceneReference.cursorMemory0 = 50;
                    Debug.Log("YOU WIN CLASSIC MODE");
                }
                SceneManager.LoadScene("Classic Map");
            }

            else if (levelReference.levelType == 1)
            {
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story1"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x1Clear = true;
                    Debug.Log("unlocked scene 1-2");
                    sceneReference.Scene1x2Active = true;
                    sceneReference.cursorMemory1 = 1;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story2"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x2Clear = true;
                    Debug.Log("unlocked scene 1-3");
                    sceneReference.Scene1x3Active = true;
                    sceneReference.cursorMemory1 = 2;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story3"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x3Clear = true;
                    Debug.Log("unlocked scene 1-4");
                    sceneReference.Scene1x4Active = true;
                    sceneReference.cursorMemory1 = 3;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story4"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x4Clear = true;
                    if (doorNumber == 0)
                    {
                        Debug.Log("unlocked scene 1-5a");
                        sceneReference.Scene1x5aActive = true;
                        sceneReference.cursorMemory1 = 4;
                    }
                    if (doorNumber == 2)
                    {
                        Debug.Log("unlocked scene 1-5b");
                        sceneReference.Scene1x5bActive = true;
                        sceneReference.cursorMemory1 = 5;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story5a"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x5aClear = true;
                    Debug.Log("unlocked scene 1-6a");
                    sceneReference.Scene1x6aActive = true;
                    sceneReference.cursorMemory1 = 6;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story5b"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x5bClear = true;
                    Debug.Log("unlocked scene 1-6b");
                    sceneReference.Scene1x6bActive = true;
                    sceneReference.cursorMemory1 = 7;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story6a"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x6aClear = true;
                    Debug.Log("unlocked scene 1-7");
                    sceneReference.Scene1x7Active = true;
                    sceneReference.cursorMemory1 = 8;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story6b"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x6bClear = true;
                    Debug.Log("unlocked scene 1-7");
                    sceneReference.Scene1x7Active = true;
                    sceneReference.cursorMemory1 = 8;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story7"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x7Clear = true;
                    Debug.Log("unlocked scene 1-8");
                    sceneReference.Scene1x8Active = true;
                    sceneReference.cursorMemory1 = 9;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story8"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x8Clear = true;
                    Debug.Log("unlocked scene 1-9");
                    sceneReference.Scene1x9Active = true;
                    sceneReference.cursorMemory1 = 10;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story9"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x9Clear = true;
                    Debug.Log("unlocked scene 1-10");
                    sceneReference.Scene1x10Active = true;
                    sceneReference.cursorMemory1 = 11;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story10"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x10Clear = true;
                    Debug.Log("unlocked scene 1-11");
                    sceneReference.Scene1x11Active = true;
                    sceneReference.cursorMemory1 = 12;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story11"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1x11Clear = true;
                    Debug.Log("unlocked scene 1-12");
                    sceneReference.Scene1x12Active = true;
                    sceneReference.cursorMemory1 = 13;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1Story12"))
                {
                    chapterNumber = 0;
                    sceneReference.Scene1x12Clear = true;
                    Debug.Log("unlocked scene 2-1" + chapterNumber);
                    sceneReference.Chapter2Avalaible = true;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("1StoryEx1"))
                {
                    chapterNumber = 1;
                    sceneReference.Scene1xBClear = true;
                    sceneReference.cursorMemory1 = 14;
                }

                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story1"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x1Clear = true;
                    Debug.Log("unlocked scene 2-2");
                    sceneReference.Scene2x2Active = true;
                    sceneReference.cursorMemory2 = 1;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story2"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x2Clear = true;
                    Debug.Log("unlocked scene 2-3");
                    sceneReference.Scene2x3Active = true;
                    sceneReference.cursorMemory2 = 2;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story3"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x3Clear = true;
                    if (doorNumber == 2)
                    {
                        Debug.Log("unlocked scene 2-4a");
                        sceneReference.Scene2x4aActive = true;
                        sceneReference.cursorMemory2 = 3;
                    }
                    if (doorNumber == 0)
                    {
                        Debug.Log("unlocked scene 2-4b");
                        sceneReference.Scene2x4bActive = true;
                        sceneReference.cursorMemory2 = 4;
                    }
                    if (doorNumber == 3)
                    {
                        Debug.Log("unlocked scene 2-4c");
                        sceneReference.Scene2x4cActive = true;
                        sceneReference.cursorMemory2 = 5;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story4a"))
                {
                    KeyLock();
                    chapterNumber = 2;
                    sceneReference.Scene2x4aClear = true;
                    sceneReference.cursorMemory2 = 3;
                    if (s2_10locka == true)
                    {
                        sceneReference.door2_10Lock1 = true;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story4b"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x4bClear = true;
                    Debug.Log("unlocked scene 2-5");
                    sceneReference.Scene2x5Active = true;
                    sceneReference.cursorMemory2 = 6;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story4c"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x4cClear = true;
                    sceneReference.cursorMemory2 = 5;
                    if (s2_10lockb == true)
                    {
                        sceneReference.door2_10Lock2 = true;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story5"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x5Clear = true;
                    Debug.Log("unlocked scene 2-6");
                    sceneReference.Scene2x6Active = true;
                    sceneReference.cursorMemory2 = 7;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story6"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x6Clear = true;
                    Debug.Log("unlocked scene 2-7");
                    sceneReference.Scene2x7Active = true;
                    sceneReference.cursorMemory2 = 8;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story7"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x7Clear = true;
                    Debug.Log("unlocked scene 2-8");
                    sceneReference.Scene2x8Active = true;
                    sceneReference.cursorMemory2 = 9;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story8"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x8Clear = true;
                    Debug.Log("unlocked scene 2-9");
                    sceneReference.Scene2x9Active = true;
                    sceneReference.cursorMemory2 = 10;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story9"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x9Clear = true;
                    Debug.Log("unlocked scene 2-10");
                    sceneReference.Scene2x10Active = true;
                    sceneReference.cursorMemory2 = 11;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story10"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x10Clear = true;
                    Debug.Log("unlocked scene 2-11");
                    sceneReference.Scene2x11Active = true;
                    sceneReference.cursorMemory2 = 12;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story11"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x11Clear = true;
                    Debug.Log("unlocked scene 2-12");
                    sceneReference.Scene2x12Active = true;
                    sceneReference.cursorMemory2 = 13;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story12"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x12Clear = true;
                    Debug.Log("unlocked scene 2-13");
                    sceneReference.Scene2x13Active = true;
                    sceneReference.cursorMemory2 = 14;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story13"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x13Clear = true;
                    Debug.Log("unlocked scene 2-14");
                    sceneReference.Scene2x14Active = true;
                    sceneReference.cursorMemory2 = 15;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story14"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x14Clear = true;
                    Debug.Log("unlocked scene 2-15");
                    sceneReference.Scene2x15Active = true;
                    sceneReference.cursorMemory2 = 16;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story15"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x15Clear = true;
                    Debug.Log("unlocked scene 2-16");
                    sceneReference.Scene2x16Active = true;
                    sceneReference.cursorMemory2 = 17;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story16"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x16Clear = true;
                    if (doorNumber == 0)
                    {
                        Debug.Log("unlocked scene 2-17a");
                        sceneReference.Scene2x17aActive = true;
                        sceneReference.cursorMemory2 = 18;
                    }
                    if (doorNumber == 2)
                    {
                        Debug.Log("unlocked scene 2-17b");
                        sceneReference.Scene2x17bActive = true;
                        sceneReference.cursorMemory2 = 19;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story17a"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x17aClear = true;
                    Debug.Log("unlocked scene 2-18");
                    sceneReference.Scene2x18Active = true;
                    sceneReference.cursorMemory2 = 20;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story17b"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x17bClear = true;
                    Debug.Log("unlocked scene 2-18");
                    sceneReference.Scene2x18Active = true;
                    sceneReference.cursorMemory2 = 20;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story18"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x18Clear = true;
                    Debug.Log("unlocked scene 2-19");
                    sceneReference.Scene2x19Active = true;
                    sceneReference.cursorMemory2 = 21;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story19"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2x19Clear = true;
                    Debug.Log("unlocked scene 2-20");
                    sceneReference.Scene2x20Active = true;
                    sceneReference.cursorMemory2 = 22;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Story20"))
                {
                    chapterNumber = 0;
                    sceneReference.Scene2x20Clear = true;
                    Debug.Log("unlocked scene 3-1");
                    sceneReference.Chapter3Avalaible = true;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2StoryEx1"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2xB1Clear = true;
                    sceneReference.cursorMemory2 = 23;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2StoryEx2"))
                {
                    chapterNumber = 2;
                    sceneReference.Scene2xB2Clear = true;
                    sceneReference.cursorMemory2 = 24;
                }

                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story1"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x1Clear = true;
                    Debug.Log("unlocked scene 3-2");
                    sceneReference.Scene3x2Active = true;
                    sceneReference.cursorMemory3 = 1;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story2"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x2Clear = true;
                    Debug.Log("unlocked scene 3-3");
                    sceneReference.Scene3x3Active = true;
                    sceneReference.cursorMemory3 = 2;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story3"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x3Clear = true;
                    Debug.Log("unlocked scene 3-4");
                    sceneReference.Scene3x4Active = true;
                    sceneReference.cursorMemory3 = 3;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story4"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x4Clear = true;
                    Debug.Log("unlocked scene 3-5");
                    sceneReference.Scene3x5Active = true;
                    sceneReference.cursorMemory3 = 4;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story5"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x5Clear = true;
                    Debug.Log("unlocked scene 3-6");
                    sceneReference.Scene3x6Active = true;
                    sceneReference.cursorMemory3 = 5;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story6"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x6Clear = true;
                    Debug.Log("unlocked scene 3-7");
                    sceneReference.Scene3x7Active = true;
                    sceneReference.cursorMemory3 = 6;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story7"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x7Clear = true;
                    Debug.Log("unlocked scene 3-8");
                    sceneReference.Scene3x8Active = true;
                    sceneReference.cursorMemory3 = 7;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story8"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x8Clear = true;
                    if (doorNumber == 0)
                    {
                        Debug.Log("unlocked scene 3-9a");
                        sceneReference.Scene3x9aActive = true;
                        sceneReference.cursorMemory3 = 8;
                    }
                    if (doorNumber == 2)
                    {
                        Debug.Log("unlocked scene 3-9b");
                        sceneReference.Scene3x9bActive = true;
                        sceneReference.cursorMemory3 = 9;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story9a"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x9aClear = true;
                    Debug.Log("unlocked scene 3-10");
                    sceneReference.Scene3x10Active = true;
                    sceneReference.cursorMemory3 = 10;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story9b"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x9bClear = true;
                    Debug.Log("unlocked scene 3-10");
                    sceneReference.Scene3x10Active = true;
                    sceneReference.cursorMemory3 = 10;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story10"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x10Clear = true;
                    Debug.Log("unlocked scene 3-11");
                    sceneReference.Scene3x11Active = true;
                    sceneReference.cursorMemory3 = 11;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story11"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x11Clear = true;
                    Debug.Log("unlocked scene 3-12");
                    sceneReference.Scene3x12Active = true;
                    sceneReference.cursorMemory3 = 12;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story12"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x12Clear = true;
                    Debug.Log("unlocked scene 3-13");
                    sceneReference.Scene3x13Active = true;
                    sceneReference.cursorMemory3 = 13;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story13"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x13Clear = true;
                    if (doorNumber == 0)
                    {
                        Debug.Log("unlocked scene 3-14a");
                        sceneReference.Scene3x14aActive = true;
                        sceneReference.cursorMemory3 = 14;
                    }
                    if (doorNumber == 2)
                    {
                        Debug.Log("unlocked scene 3-14b");
                        sceneReference.Scene3x14bActive = true;
                        sceneReference.cursorMemory3 = 15;
                    }
                    if (doorNumber == 3)
                    {
                        Debug.Log("unlocked scene 3-14c");
                        sceneReference.Scene3x14cActive = true;
                        sceneReference.cursorMemory3 = 16;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story14a"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x14aClear = true;
                    Debug.Log("unlocked scene 3-17");
                    sceneReference.Scene3x17Active = true;
                    sceneReference.cursorMemory3 = 20;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story14b"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x14bClear = true;
                    Debug.Log("unlocked scene 3-15b");
                    sceneReference.Scene3x15bActive = true;
                    sceneReference.cursorMemory3 = 17;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story14c"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x14cClear = true;
                    Debug.Log("unlocked scene 3-15c");
                    sceneReference.Scene3x15cActive = true;
                    sceneReference.cursorMemory3 = 18;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story15b"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x15bClear = true;
                    Debug.Log("unlocked scene 3-16b");
                    sceneReference.Scene3x16bActive = true;
                    sceneReference.cursorMemory3 = 19;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story15c"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x15cClear = true;
                    Debug.Log("unlocked scene 3-17");
                    sceneReference.Scene3x17Active = true;
                    sceneReference.cursorMemory3 = 20;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story16b"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x16bClear = true;
                    Debug.Log("unlocked scene 3-17");
                    sceneReference.Scene3x17Active = true;
                    sceneReference.cursorMemory3 = 20;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story17"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x17Clear = true;
                    Debug.Log("unlocked scene 3-18");
                    sceneReference.Scene3x18Active = true;
                    sceneReference.cursorMemory3 = 21;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story18"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x18Clear = true;
                    Debug.Log("unlocked scene 3-19");
                    sceneReference.Scene3x19Active = true;
                    sceneReference.cursorMemory3 = 22;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story19"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x19Clear = true;
                    Debug.Log("unlocked scene 3-20");
                    sceneReference.Scene3x20Active = true;
                    sceneReference.cursorMemory3 = 23;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story20"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x20Clear = true;
                    if (doorNumber == 0)
                    {
                        Debug.Log("unlocked scene 3-21a");
                        sceneReference.Scene3x21aActive = true;
                        sceneReference.cursorMemory3 = 24;
                    }
                    if (doorNumber == 2)
                    {
                        Debug.Log("unlocked scene 3-21b");
                        sceneReference.Scene3x21bActive = true;
                        sceneReference.cursorMemory3 = 25;
                    }
                    if (doorNumber == 3)
                    {
                        Debug.Log("unlocked scene 3-21c");
                        sceneReference.Scene3x21cActive = true;
                        sceneReference.cursorMemory3 = 26;
                    }
                    if (doorNumber == 4)
                    {
                        Debug.Log("unlocked scene 3-21d");
                        sceneReference.Scene3x21dActive = true;
                        sceneReference.cursorMemory3 = 27;
                    }
                    if (doorNumber == 5)
                    {
                        Debug.Log("unlocked scene 3-21e");
                        sceneReference.Scene3x21eActive = true;
                        sceneReference.cursorMemory3 = 28;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story21a"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x21aClear = true;
                    Debug.Log("unlocked scene 3-22");
                    sceneReference.Scene3x22Active = true;
                    sceneReference.cursorMemory3 = 29;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story21b"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x21bClear = true;
                    Debug.Log("unlocked scene 3-22");
                    sceneReference.Scene3x22Active = true;
                    sceneReference.cursorMemory3 = 29;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story21c"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x21cClear = true;
                    Debug.Log("unlocked scene 3-22");
                    sceneReference.Scene3x22Active = true;
                    sceneReference.cursorMemory3 = 29;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story21d"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x21dClear = true;
                    Debug.Log("unlocked scene 3-22");
                    sceneReference.Scene3x22Active = true;
                    sceneReference.cursorMemory3 = 29;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story21e"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3x21eClear = true;
                    Debug.Log("unlocked scene 3-22");
                    sceneReference.Scene3x22Active = true;
                    sceneReference.cursorMemory3 = 29;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3Story22"))
                {
                    chapterNumber = 0;
                    sceneReference.Scene3x22Clear = true;
                    Debug.Log("unlocked scene 4-1");
                    sceneReference.Chapter4Avalaible = true;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3StoryEx1"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3xB1Clear = true;
                    sceneReference.cursorMemory3 = 30;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("3StoryEx2"))
                {
                    chapterNumber = 3;
                    sceneReference.Scene3xB2Clear = true;
                    sceneReference.cursorMemory3 = 31;
                }

                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story1"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x1Clear = true;
                    Debug.Log("unlocked scene 4-2");
                    sceneReference.Scene4x2Active = true;
                    sceneReference.cursorMemory4 = 1;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story2"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x2Clear = true;
                    Debug.Log("unlocked scene 4-3");
                    sceneReference.Scene4x3Active = true;
                    sceneReference.cursorMemory4 = 2;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story3"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x3Clear = true;
                    Debug.Log("unlocked scene 4-4");
                    sceneReference.Scene4x4Active = true;
                    sceneReference.cursorMemory4 = 3;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story4"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x4Clear = true;
                    if (doorNumber == 0)
                    {
                        Debug.Log("unlocked scene 4-5a");
                        sceneReference.Scene4x5aActive = true;
                        sceneReference.cursorMemory4 = 4;
                    }
                    if (doorNumber == 2)
                    {
                        Debug.Log("unlocked scene 4-5b");
                        sceneReference.Scene4x5bActive = true;
                        sceneReference.cursorMemory4 = 5;                    
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story5a"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x5aClear = true;
                    Debug.Log("unlocked scene 4-6a");
                    sceneReference.Scene4x6aActive = true;
                    sceneReference.cursorMemory4 = 6;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story5b"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x5bClear = true;
                    Debug.Log("unlocked scene 4-6b");
                    sceneReference.Scene4x6bActive = true;
                    sceneReference.cursorMemory4 = 7;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story6a"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x6aClear = true;
                    Debug.Log("unlocked scene 4-7a");
                    sceneReference.Scene4x7aActive = true;
                    sceneReference.cursorMemory4 = 8;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story6b"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x6bClear = true;
                    Debug.Log("unlocked scene 4-7b");
                    sceneReference.Scene4x7bActive = true;
                    sceneReference.cursorMemory4 = 9;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story7a"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x7aClear = true;
                    Debug.Log("unlocked scene 4-8");
                    sceneReference.Scene4x8Active = true;
                    sceneReference.cursorMemory4 = 10;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story7b"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x7bClear = true;
                    Debug.Log("unlocked scene 4-8");
                    sceneReference.Scene4x8Active = true;
                    sceneReference.cursorMemory4 = 10;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story8"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x8Clear = true;
                    Debug.Log("unlocked scene 4-9");
                    sceneReference.Scene4x9Active = true;
                    sceneReference.cursorMemory4 = 11;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story9"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x9Clear = true;
                    Debug.Log("unlocked scene 4-10");
                    sceneReference.Scene4x10Active = true;
                    sceneReference.cursorMemory4 = 12;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story10"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x10Clear = true;
                    Debug.Log("unlocked scene 4-11");
                    sceneReference.Scene4x11Active = true;
                    sceneReference.cursorMemory4 = 13;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story11"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x11Clear = true;
                    Debug.Log("unlocked scene 4-12");
                    sceneReference.Scene4x12Active = true;
                    sceneReference.cursorMemory4 = 14;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story12"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4x12Clear = true;
                    Debug.Log("unlocked scene 4-13");
                    sceneReference.Scene4x13Active = true;
                    sceneReference.cursorMemory4 = 15;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story13"))
                {
                    if (doorNumber == 0)
                    {
                        chapterNumber = 4;
                        Debug.Log("last stage 4");
                        sceneReference.Scene4x14Active = true;
                        sceneReference.cursorMemory4 = 16;
                    }
                    if (doorNumber == 2)
                    {
                        chapterNumber = 0;
                        Debug.Log("chapter 5");
                        sceneReference.Chapter5Avalaible = true;
                    }
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4Story14"))
                {
                    chapterNumber = 0;
                  ///////  sceneReference.Scene4x10Clear = true;
                    // Regular Ending
                    // finish all bonus levels, regular levels and this one to unlock chapter 5
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("4StoryEx1"))
                {
                    chapterNumber = 4;
                    sceneReference.Scene4xBClear = true;
                    sceneReference.cursorMemory4 = 17;
                }

                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Story1a"))
                {
                    chapterNumber = 5;
                    sceneReference.Scene5x1aClear = true;
                    sceneReference.cursorMemory5 = 1;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Story1b"))
                {
                    chapterNumber = 5;
                    sceneReference.Scene5x1bClear = true;
                    sceneReference.cursorMemory5 = 2;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Story1c"))
                {
                    chapterNumber = 5;
                    sceneReference.Scene5x1cClear = true;
                    sceneReference.cursorMemory5 = 3;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Story1d"))
                {
                    chapterNumber = 5;
                    sceneReference.Scene5x1dClear = true;
                    sceneReference.cursorMemory5 = 4;
                }
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("5Story2"))
                {
                    chapterNumber = 5;
                    sceneReference.Scene5x2Clear = true;
                    sceneReference.cursorMemory5 = 5;
                    // True Ending
                }

                if (chapterNumber == 0)
                {
                    SceneManager.LoadScene("Chapter Select");
                }
                if (chapterNumber == 1)
                {
                    SceneManager.LoadScene("Chapter 1 Map");
                }
                if (chapterNumber == 2)
                {
                    SceneManager.LoadScene("Chapter 2 Map");
                }
                if (chapterNumber == 3)
                {
                    SceneManager.LoadScene("Chapter 3 Map");
                }
                if (chapterNumber == 4)
                {
                    SceneManager.LoadScene("Chapter 4 Map");
                }
                if (chapterNumber == 5)
                {
                    SceneManager.LoadScene("Chapter 5 Map");
                }
                ////
            }

        }
        else
        {
            if (levelReference.levelType == 0)
            {
                SceneManager.LoadScene("Classic Map");
            }
            if (levelReference.levelType == 1)
            {
                SceneManager.LoadScene("Chapter Select");
            }
        }
    }



    public void KeyLock()
    {
        if (GameObject.Find("0.noMove enemy (K)") != null)
        {
            GameObject KeyEnemy = GameObject.Find("0.noMove enemy (K)");
            basic_enemy_script respawnReference = KeyEnemy.GetComponent<basic_enemy_script>();
            respawnReference.spawnCheck = 0;
        }
    }





}
