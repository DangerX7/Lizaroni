using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class scene_unlocker_script : MonoBehaviour
{
    #region Variables Set
    public GameObject MasterObject, player;
    public int sceneNumber;
    //classicLevel1MinimumMoves
    public bool classic1Min;
    public bool classic2Min;
    public bool classic3Min;
    public bool classic4Min;
    public bool classic5Min;
    public bool classic6Min;
    public bool classic7Min;
    public bool classic8Min;
    public bool classic9Min;
    public bool classic10Min;
    public bool classic11Min;
    public bool classic12Min;
    public bool classic13Min;
    public bool classic14Min;
    public bool classic15Min;
    public bool classic16Min;
    public bool classic17Min;
    public bool classic18Min;
    public bool classic19Min;
    public bool classic20Min;
    public bool classic21Min;
    public bool classic22Min;
    public bool classic23Min;
    public bool classic24Min;
    public bool classic25Min;
    public bool classic26Min;
    public bool classic27Min;
    public bool classic28Min;
    public bool classic29Min;
    public bool classic30Min;
    public bool classic31Min;
    public bool classic32Min;
    public bool classic33Min;
    public bool classic34Min;
    public bool classic35Min;
    public bool classic36Min;
    public bool classic37Min;
    public bool classic38Min;
    public bool classic39Min;
    public bool classic40Min;
    public bool classic41Min;
    public bool classic42Min;
    public bool classic43Min;
    public bool classic44Min;
    public bool classic45Min;
    public bool classic46Min;
    public bool classic47Min;
    public bool classic48Min;
    public bool classic49Min;
    public bool classic50Min;
    //new
    public bool classic1Done;
    public bool classic2Done;
    public bool classic3Done;
    public bool classic4Done;
    public bool classic5Done;
    public bool classic6Done;
    public bool classic7Done;
    public bool classic8Done;
    public bool classic9Done;
    public bool classic10Done;
    public bool classic11Done;
    public bool classic12Done;
    public bool classic13Done;
    public bool classic14Done;
    public bool classic15Done;
    public bool classic16Done;
    public bool classic17Done;
    public bool classic18Done;
    public bool classic19Done;
    public bool classic20Done;
    public bool classic21Done;
    public bool classic22Done;
    public bool classic23Done;
    public bool classic24Done;
    public bool classic25Done;
    public bool classic26Done;
    public bool classic27Done;
    public bool classic28Done;
    public bool classic29Done;
    public bool classic30Done;
    public bool classic31Done;
    public bool classic32Done;
    public bool classic33Done;
    public bool classic34Done;
    public bool classic35Done;
    public bool classic36Done;
    public bool classic37Done;
    public bool classic38Done;
    public bool classic39Done;
    public bool classic40Done;
    public bool classic41Done;
    public bool classic42Done;
    public bool classic43Done;
    public bool classic44Done;
    public bool classic45Done;
    public bool classic46Done;
    public bool classic47Done;
    public bool classic48Done;
    public bool classic49Done;
    public bool classic50Done;
    // completed
    public bool Scene2Active = false;
    public bool Scene3Active = false;
    public bool Scene4Active = false;
    public bool Scene5Active = false;
    public bool Scene6Active = false;
    public bool Scene7Active = false;
    public bool Scene8Active = false;
    public bool Scene9Active = false;
    public bool Scene10Active = false;
    public bool Scene11Active = false;
    public bool Scene12Active = false;
    public bool Scene13Active = false;
    public bool Scene14Active = false;
    public bool Scene15Active = false;
    public bool Scene16Active = false;
    public bool Scene17Active = false;
    public bool Scene18Active = false;
    public bool Scene19Active = false;
    public bool Scene20Active = false;
    public bool Scene21Active = false;
    public bool Scene22Active = false;
    public bool Scene23Active = false;
    public bool Scene24Active = false;
    public bool Scene25Active = false;
    public bool Scene26Active = false;
    public bool Scene27Active = false;
    public bool Scene28Active = false;
    public bool Scene29Active = false;
    public bool Scene30Active = false;
    public bool Scene31Active = false;
    public bool Scene32Active = false;
    public bool Scene33Active = false;
    public bool Scene34Active = false;
    public bool Scene35Active = false;
    public bool Scene36Active = false;
    public bool Scene37Active = false;
    public bool Scene38Active = false;
    public bool Scene39Active = false;
    public bool Scene40Active = false;
    public bool Scene41Active = false;
    public bool Scene42Active = false;
    public bool Scene43Active = false;
    public bool Scene44Active = false;
    public bool Scene45Active = false;
    public bool Scene46Active = false;
    public bool Scene47Active = false;
    public bool Scene48Active = false;
    public bool Scene49Active = false;
    public bool Scene50Active = false;

    public int levels = 1;

    public bool Scene1x2Active = false;
    public bool Scene1x3Active = false;
    public bool Scene1x4Active = false;
    public bool Scene1x5aActive = false;
    public bool Scene1x6aActive = false;
    public bool Scene1x5bActive = false;
    public bool Scene1x6bActive = false;
    public bool Scene1x7Active = false;
    public bool Scene1x8Active = false;
    public bool Scene1x9Active = false;
    public bool Scene1x10Active = false;
    public bool Scene1x11Active = false;
    public bool Scene1x12Active = false;
    public bool Scene1xBActive = false;
    public int levels2 = 1;

    public bool door2_10Lock1 = false;
    public bool door2_10Lock2 = false;

    public bool Scene2x2Active = false;
    public bool Scene2x3Active = false;
    public bool Scene2x4aActive = false;
    public bool Scene2x4bActive = false;
    public bool Scene2x4cActive = false;
    public bool Scene2x5Active = false;
    public bool Scene2x6Active = false;
    public bool Scene2x7Active = false;
    public bool Scene2x8Active = false;
    public bool Scene2x9Active = false;
    public bool Scene2x10Active = false;
    public bool Scene2x11Active = false;
    public bool Scene2x12Active = false;
    public bool Scene2x13Active = false;
    public bool Scene2x14Active = false;
    public bool Scene2x15Active = false;
    public bool Scene2x16Active = false;
    public bool Scene2x17aActive = false;
    public bool Scene2x17bActive = false;
    public bool Scene2x18Active = false;
    public bool Scene2x19Active = false;
    public bool Scene2x20Active = false;
    public bool Scene2xB1Active = false;
    public bool Scene2xB2Active = false;

    public bool Scene3x2Active = false;
    public bool Scene3x3Active = false;
    public bool Scene3x4Active = false;
    public bool Scene3x5Active = false;
    public bool Scene3x6Active = false;
    public bool Scene3x7Active = false;
    public bool Scene3x8Active = false;
    public bool Scene3x9aActive = false;
    public bool Scene3x9bActive = false;
    public bool Scene3x10Active = false;
    public bool Scene3x11Active = false;
    public bool Scene3x12Active = false;
    public bool Scene3x13Active = false;
    public bool Scene3x14aActive = false;
    public bool Scene3x14bActive = false;
    public bool Scene3x14cActive = false;
    public bool Scene3x15bActive = false;
    public bool Scene3x15cActive = false;
    public bool Scene3x16bActive = false;
    public bool Scene3x17Active = false;
    public bool Scene3x18Active = false;
    public bool Scene3x19Active = false;
    public bool Scene3x20Active = false;
    public bool Scene3x21aActive = false;
    public bool Scene3x21bActive = false;
    public bool Scene3x21cActive = false;
    public bool Scene3x21dActive = false;
    public bool Scene3x21eActive = false;
    public bool Scene3x22Active = false;
    public bool Scene3xB1Active = false;
    public bool Scene3xB2Active = false;

    public bool Scene4x2Active = false;
    public bool Scene4x3Active = false;
    public bool Scene4x4Active = false;
    public bool Scene4x5aActive = false;
    public bool Scene4x5bActive = false;
    public bool Scene4x6aActive = false;
    public bool Scene4x6bActive = false;
    public bool Scene4x7aActive = false;
    public bool Scene4x7bActive = false;
    public bool Scene4x8Active = false;
    public bool Scene4x9Active = false;
    public bool Scene4x10Active = false;
    public bool Scene4x11Active = false;
    public bool Scene4x12Active = false;
    public bool Scene4x13Active = false;
    public bool Scene4x14Active = false;
    public bool Scene4xBActive = false;

    public bool Scene5x2Active = false;

    public byte cursorMemory0;
    public byte cursorMemory1;
    public byte cursorMemory2;
    public byte cursorMemory3;
    public byte cursorMemory4;
    public byte cursorMemory5;

    public bool Chapter2Avalaible;
    public bool Chapter3Avalaible;
    public bool Chapter4Avalaible;
    public bool Chapter5Avalaible;
    /*
    public void SaveScene ()
    {
        Save_System.SaveScene(this);
    }

    public void LoadScene()
    {
        SaveData data = Save_System.LoadScenes();

        levels = data.scenesAvailable;
    }
    */

    public bool tutorialObj0;
    public bool tutorialObj1;
    public bool tutorialObj2;
    public bool tutorialObj3;
    public bool tutorialObj4;
    public bool tutorialObj5;
    public bool tutorialObj6;
    public bool tutorialObj7;
    public bool tutorialObj8;
    public bool tutorialObj9;
    public bool tutorialObj10;
    public bool tutorialObj11;
    public bool tutorialObj12;
    public bool tutorialObj13;
    public bool tutorialObj14;
    public bool tutorialObj15;
    public bool tutorialObj16;
    public bool tutorialObj17;
    public bool tutorialObj18;
    public bool tutorialObj19;
    public bool tutorialObj20;

    public bool Scene1x1Clear = false;
    public bool Scene1x2Clear = false;
    public bool Scene1x3Clear = false;
    public bool Scene1x4Clear = false;
    public bool Scene1x5aClear = false;
    public bool Scene1x6aClear = false;
    public bool Scene1x5bClear = false;
    public bool Scene1x6bClear = false;
    public bool Scene1x7Clear = false;
    public bool Scene1x8Clear = false;
    public bool Scene1x9Clear = false;
    public bool Scene1x10Clear = false;
    public bool Scene1x11Clear = false;
    public bool Scene1x12Clear = false;
    public bool Scene1xBClear = false;

    public bool Scene2x1Clear = false;
    public bool Scene2x2Clear = false;
    public bool Scene2x3Clear = false;
    public bool Scene2x4aClear = false;
    public bool Scene2x4bClear = false;
    public bool Scene2x4cClear = false;
    public bool Scene2x5Clear = false;
    public bool Scene2x6Clear = false;
    public bool Scene2x7Clear = false;
    public bool Scene2x8Clear = false;
    public bool Scene2x9Clear = false;
    public bool Scene2x10Clear = false;
    public bool Scene2x11Clear = false;
    public bool Scene2x12Clear = false;
    public bool Scene2x13Clear = false;
    public bool Scene2x14Clear = false;
    public bool Scene2x15Clear = false;
    public bool Scene2x16Clear = false;
    public bool Scene2x17aClear = false;
    public bool Scene2x17bClear = false;
    public bool Scene2x18Clear = false;
    public bool Scene2x19Clear = false;
    public bool Scene2x20Clear = false;
    public bool Scene2xB1Clear = false;
    public bool Scene2xB2Clear = false;

    public bool Scene3x1Clear = false;
    public bool Scene3x2Clear = false;
    public bool Scene3x3Clear = false;
    public bool Scene3x4Clear = false;
    public bool Scene3x5Clear = false;
    public bool Scene3x6Clear = false;
    public bool Scene3x7Clear = false;
    public bool Scene3x8Clear = false;
    public bool Scene3x9aClear = false;
    public bool Scene3x9bClear = false;
    public bool Scene3x10Clear = false;
    public bool Scene3x11Clear = false;
    public bool Scene3x12Clear = false;
    public bool Scene3x13Clear = false;
    public bool Scene3x14aClear = false;
    public bool Scene3x14bClear = false;
    public bool Scene3x14cClear = false;
    public bool Scene3x15bClear = false;
    public bool Scene3x15cClear = false;
    public bool Scene3x16bClear = false;
    public bool Scene3x17Clear = false;
    public bool Scene3x18Clear = false;
    public bool Scene3x19Clear = false;
    public bool Scene3x20Clear = false;
    public bool Scene3x21aClear = false;
    public bool Scene3x21bClear = false;
    public bool Scene3x21cClear = false;
    public bool Scene3x21dClear = false;
    public bool Scene3x21eClear = false;
    public bool Scene3x22Clear = false;
    public bool Scene3xB1Clear = false;
    public bool Scene3xB2Clear = false;

    public bool Scene4x1Clear = false;
    public bool Scene4x2Clear = false;
    public bool Scene4x3Clear = false;
    public bool Scene4x4Clear = false;
    public bool Scene4x5aClear = false;
    public bool Scene4x5bClear = false;
    public bool Scene4x6aClear = false;
    public bool Scene4x6bClear = false;
    public bool Scene4x7aClear = false;
    public bool Scene4x7bClear = false;
    public bool Scene4x8Clear = false;
    public bool Scene4x9Clear = false;
    public bool Scene4x10Clear = false;
    public bool Scene4x11Clear = false;
    public bool Scene4x12Clear = false;
    public bool Scene4x13Clear = false;
    public bool Scene4xBClear = false;

    public bool Scene5x1aClear = false;
    public bool Scene5x1bClear = false;
    public bool Scene5x1cClear = false;
    public bool Scene5x1dClear = false;
    public bool Scene5x2Clear = false;

    Vector3 spawnHidden;
    public byte stage_1_7_attack_power_up;
    public byte stage_2_19_dash_power_up;
    public bool spawnCheck;
    public bool spawnCheck2;

    string sceneName;
    public byte difficulty;

    public byte difficultyVS;
    public int versusLevel;
    public bool versusLevelStart;
    public bool vsCheck0;
    public bool vsCheck1;
    public bool vsCheck2;
    public bool vsCheck3;
    public bool vsCheck4;
    public bool vsCheck5;
    public bool vsCheck6;
    public bool vsCheck7;
    public bool vsCheck8;
    public bool vsCheck9;
    public bool vsCheck10;
    public bool vsCheck11;
    public bool vsCheck12;
    public bool vsCheck13;
    public int player1Wins;
    public int player2Wins;
    public byte vsLevelNumber;
    public bool win1_1;
    public bool win1_2;
    public bool win1_3;
    public bool win2_1;
    public bool win2_2;
    public bool win2_3;
    public bool p1Victory;
    public bool p2Victory;

    public bool dissableFinalLaser;
    public byte firstTimeTutorialSeen;
    public byte firstClue1; //2
    public byte firstClue2; //1
    public byte firstClue3; //2
    public byte firstClue4; //1
    public byte firstClue5; //1
    public byte firstClue6; //1

    public bool extra1;
    public bool extra2;
    public bool extra3;
    public bool extra4;
    public bool extra5;
    public bool extra6;
    public bool extra7;
    public bool extra8;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        levels = PlayerPrefs.GetInt("levels");
        DontDestroyOnLoad(MasterObject);
        //   LoadScene();
    }

    void Update()
    {
     //   Debug.Log("SceneNumber: " + sceneNumber);
        sceneNumber = (SceneManager.GetActiveScene().buildIndex);
        if ((stage_1_7_attack_power_up == 1) && (extra1 == false))
        {
            firstClue1 = 1;
            extra1 = true;
        }
        if ((Scene1xBActive) && (extra2 == false))
        {
            firstClue1 = 2;
            extra2 = true;
        }
        if ((Scene2xB1Active == true) && (extra3 == false))
        {
            firstClue2 = 1;
            extra3 = true;
        }
        if ((stage_2_19_dash_power_up == 1) && (extra4 == false))
        {
            firstClue3 = 1;
            extra4 = true;
        }
        if ((Scene2xB2Active == true) && (extra5 == false))
        {
            firstClue3 = 2;
            extra5 = true;
        }
        if ((Scene3xB1Active == true) && (extra6 == false))
        {
            firstClue4 = 1;
            extra6 = true;
        }
        if ((Scene3xB2Active == true) && (extra7 == false))
        {
            firstClue5 = 1;
            extra7 = true;
        }
        if ((Scene4xBActive == true) && (extra8 == false))
        {
            firstClue6 = 1;
            extra8 = true;
        }

        sceneName = SceneManager.GetActiveScene().name;
        if (GameObject.Find("Player") != null)
        {
            GameObject playerRef = GameObject.Find("Player");
            spawnHidden = new Vector3(playerRef.transform.position.x, playerRef.transform.position.y, playerRef.transform.position.z);
        }

        #region Versus Mode Code

        if ((versusLevelStart == true) && (player1Wins >= 0) && (player2Wins >= 0))
        {
            Debug.Log("It's on!");
            if (difficultyVS == 0)
            {
                versusLevel = Random.Range(0, 14);
                if ((versusLevel == 0) && (vsCheck0 == false))
                {
                    SceneManager.LoadScene("x.Easy1");
                    vsCheck0 = true;
                }
                if ((versusLevel == 1) && (vsCheck1 == false))
                {
                    SceneManager.LoadScene("x.Easy2");
                    vsCheck1 = true;
                }
                if ((versusLevel == 2) && (vsCheck2 == false))
                {
                    SceneManager.LoadScene("x.Easy3");
                    vsCheck2 = true;
                }
                if ((versusLevel == 3) && (vsCheck3 == false))
                {
                    SceneManager.LoadScene("x.Easy4");
                    vsCheck3 = true;
                }
                if ((versusLevel == 4) && (vsCheck4 == false))
                {
                    SceneManager.LoadScene("x.Easy5");
                    vsCheck4 = true;
                }
                if ((versusLevel == 5) && (vsCheck5 == false))
                {
                    SceneManager.LoadScene("x.Easy6");
                    vsCheck5 = true;
                }
                if ((versusLevel == 6) && (vsCheck6 == false))
                {
                    SceneManager.LoadScene("x.Easy7");
                    vsCheck6 = true;
                }
                if ((versusLevel == 7) && (vsCheck7 == false))
                {
                    SceneManager.LoadScene("x.Easy8");
                    vsCheck7 = true;
                }
                if ((versusLevel == 8) && (vsCheck8 == false))
                {
                    SceneManager.LoadScene("x.Easy9");
                    vsCheck8 = true;
                }
                if ((versusLevel == 9) && (vsCheck9 == false))
                {
                    SceneManager.LoadScene("x.Easy10");
                    vsCheck9 = true;
                }
                if ((versusLevel == 10) && (vsCheck10 == false))
                {
                    SceneManager.LoadScene("x.Easy11");
                    vsCheck10 = true;
                }
                if ((versusLevel == 11) && (vsCheck11 == false))
                {
                    SceneManager.LoadScene("x.Easy12");
                    vsCheck11 = true;
                }
                if ((versusLevel == 12) && (vsCheck12 == false))
                {
                    SceneManager.LoadScene("x.Easy13");
                    vsCheck12 = true;
                }
                if ((versusLevel == 13) && (vsCheck13 == false))
                {
                    SceneManager.LoadScene("x.Easy14");
                    vsCheck13 = true;
                }
                if (versusLevel == 14)
                {
                    Debug.Log("LOCK ERROR!!!");
                }
            }
            if (difficultyVS == 1)
            {
                versusLevel = Random.Range(0, 8);
                if ((versusLevel == 0) && (vsCheck0 == false))
                {
                    SceneManager.LoadScene("y.Normal1");
                    vsCheck0 = true;
                }
                if ((versusLevel == 1) && (vsCheck1 == false))
                {
                    SceneManager.LoadScene("y.Normal2");
                    vsCheck1 = true;
                }
                if ((versusLevel == 2) && (vsCheck2 == false))
                {
                    SceneManager.LoadScene("y.Normal3");
                    vsCheck2 = true;
                }
                if ((versusLevel == 3) && (vsCheck3 == false))
                {
                    SceneManager.LoadScene("y.Normal4");
                    vsCheck3 = true;
                }
                if ((versusLevel == 4) && (vsCheck4 == false))
                {
                    SceneManager.LoadScene("y.Normal5");
                    vsCheck4 = true;
                }
                if ((versusLevel == 5) && (vsCheck5 == false))
                {
                    SceneManager.LoadScene("y.Normal6");
                    vsCheck5 = true;
                }
                if ((versusLevel == 6) && (vsCheck6 == false))
                {
                    SceneManager.LoadScene("y.Normal7");
                    vsCheck6 = true;
                }
                if ((versusLevel == 7) && (vsCheck7 == false))
                {
                    SceneManager.LoadScene("y.Normal8");
                    vsCheck7 = true;
                }
            }
            if (difficultyVS == 2)
            {
                versusLevel = Random.Range(0, 8);
                if ((versusLevel == 0) && (vsCheck0 == false))
                {
                    SceneManager.LoadScene("z.Hard1");
                    vsCheck0 = true;
                }
                if ((versusLevel == 1) && (vsCheck1 == false))
                {
                    SceneManager.LoadScene("z.Hard2");
                    vsCheck1 = true;
                }
                if ((versusLevel == 2) && (vsCheck2 == false))
                {
                    SceneManager.LoadScene("z.Hard3");
                    vsCheck2 = true;
                }
                if ((versusLevel == 3) && (vsCheck3 == false))
                {
                    SceneManager.LoadScene("z.Hard4");
                    vsCheck3 = true;
                }
                if ((versusLevel == 4) && (vsCheck4 == false))
                {
                    SceneManager.LoadScene("z.Hard5");
                    vsCheck4 = true;
                }
                if ((versusLevel == 5) && (vsCheck5 == false))
                {
                    SceneManager.LoadScene("z.Hard6");
                    vsCheck5 = true;
                }
                if ((versusLevel == 6) && (vsCheck6 == false))
                {
                    SceneManager.LoadScene("z.Hard7");
                    vsCheck6 = true;
                }
                if ((versusLevel == 7) && (vsCheck7 == false))
                {
                    SceneManager.LoadScene("z.Hard8");
                    vsCheck7 = true;
                }
            }
            versusLevelStart = false;
        }

        #endregion

        #region Code For Secrets (Unlocking Bonus Levels)
        if ((stage_1_7_attack_power_up == 1) && (sceneName == "1Story7"))
        {
            GameObject hiddenItem = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
            hiddenItem.transform.position = spawnHidden;
            stage_1_7_attack_power_up = 2;
        }
        if ((stage_1_7_attack_power_up == 2) && (sceneName != "1Story7"))
        {
            stage_1_7_attack_power_up = 1;
        }

        if ((stage_2_19_dash_power_up == 1) && (sceneName == "2Story19"))
        {
            GameObject hiddenItem = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
            hiddenItem.transform.position = spawnHidden;
            stage_2_19_dash_power_up = 2;
        }
        if ((stage_2_19_dash_power_up == 2) && (sceneName != "2Story19"))
        {
            stage_2_19_dash_power_up = 1;
        }

        if ((spawnCheck == false) && (sceneName == "3Story10") && (difficulty == 2))
        {
            GameObject Master = GameObject.Find("MasterObject");
            master_script switchReference = Master.GetComponent<master_script>();
            if (switchReference.moves == 50)
            {
                GameObject keyCard = Instantiate(Resources.Load("Special Key 7")) as GameObject;
                GameObject KeyPos = GameObject.Find("Secret Key Possition");
                keyCard.transform.position = KeyPos.transform.position;
                spawnCheck = true;
            }
        }

        if ((spawnCheck2 == false) && (sceneName == "4Story7a") && (difficulty == 2))
        {
            GameObject Master = GameObject.Find("MasterObject");
            master_script switchReference = Master.GetComponent<master_script>();
            if (switchReference.keys == 1)
            {
                GameObject keyCard = Instantiate(Resources.Load("Special Key 8")) as GameObject;
                GameObject KeyPos = GameObject.Find("Secret Key Possition");
                keyCard.transform.position = KeyPos.transform.position;
                spawnCheck2 = true;
            }
        }
        #endregion

        #region Chapter Code
        if (GameObject.Find("chapter cursor") != null)
        {
            GameObject MapX = GameObject.Find("chapter cursor");
            chapter_script chapterReference = MapX.GetComponent<chapter_script>();

            if (Chapter2Avalaible == true)
            {
                chapterReference.Chapter2Active = true;
            }
            if (Chapter3Avalaible == true)
            {
                chapterReference.Chapter3Active = true;
            }
            if (Chapter4Avalaible == true)
            {
                chapterReference.Chapter4Active = true;
            }
            if (Chapter5Avalaible == true)
            {
                chapterReference.Chapter5Active = true;
            }
        }
        #endregion

        #region Tutorial Check Code
        if (GameObject.Find("Tutorial Object") != null)
        {
            GameObject Tutorial = GameObject.Find("Tutorial Object");
            tutorial_object_script objReference = Tutorial.GetComponent<tutorial_object_script>();

            if (objReference.objType0 == true)
            {
                tutorialObj0 = true;
            }
            if (objReference.objType1 == true)
            {
                tutorialObj1 = true;
            }
            if (objReference.objType2 == true)
            {
                tutorialObj2 = true;
            }
            if (objReference.objType3 == true)
            {
                tutorialObj3 = true;
            }
            if (objReference.objType4 == true)
            {
                tutorialObj4 = true;
            }
            if (objReference.objType5 == true)
            {
                tutorialObj5 = true;
            }
            if (objReference.objType6 == true)
            {
                tutorialObj6 = true;
            }
            if (objReference.objType7 == true)
            {
                tutorialObj7 = true;
            }
            if (objReference.objType8 == true)
            {
                tutorialObj8 = true;
            }
            if (objReference.objType9 == true)
            {
                tutorialObj9 = true;
            }
            if (objReference.objType10 == true)
            {
                tutorialObj10 = true;
            }
            if (objReference.objType11 == true)
            {
                tutorialObj11 = true;
            }
            if (objReference.objType12 == true)
            {
                tutorialObj12 = true;
            }
            if (objReference.objType13 == true)
            {
                tutorialObj13 = true;
            }
            if (objReference.objType14 == true)
            {
                tutorialObj14 = true;
            }
            if (objReference.objType15 == true)
            {
                tutorialObj15 = true;
            }
            if (objReference.objType16 == true)
            {
                tutorialObj16 = true;
            }
            if (objReference.objType17 == true)
            {
                tutorialObj17 = true;
            }
            if (objReference.objType18 == true)
            {
                tutorialObj18 = true;
            }
            if (objReference.objType19 == true)
            {
                tutorialObj19 = true;
            }
        }
        #endregion

        Chapter5Code();
    }

    public void VersusModeEnd()
    {
        SceneManager.LoadScene("Tittle_Screen");
        vsLevelNumber = 0;
        vsCheck0 = false;
        vsCheck1 = false;
        vsCheck2 = false;
        vsCheck3 = false;
        vsCheck4 = false;
        vsCheck5 = false;
        vsCheck6 = false;
        vsCheck7 = false;
        vsCheck8 = false;
        vsCheck9 = false;
        vsCheck10 = false;
        vsCheck11 = false;
        vsCheck12 = false;
        vsCheck13 = false;
        player1Wins = -1;   // need to stop
        player2Wins = -1;
        win1_1 = false;
        win1_2 = false;
        win1_3 = false;
        win2_1 = false;
        win2_2 = false;
        win2_3 = false;
        p1Victory = false;
        p2Victory = false;
        Debug.Log("DONE!!!");
    }

    public void Chapter5Code()
    {
        if ((Scene1x1Clear == true) && (Scene1x2Clear == true) && (Scene1x3Clear == true) && (Scene1x4Clear == true) && (Scene1x5aClear == true) && (Scene1x5bClear == true)
             && (Scene1x6aClear == true) && (Scene1x6bClear == true) && (Scene1x7Clear == true) && (Scene1x8Clear == true) && (Scene1x9Clear == true) && (Scene1x10Clear == true)
             && (Scene1x11Clear == true) && (Scene1x12Clear == true) && (Scene1xBClear == true) && (Scene2x1Clear == true) && (Scene2x2Clear == true) && (Scene2x3Clear == true)
             && (Scene2x4aClear == true) && (Scene2x4bClear == true) && (Scene2x4cClear == true) && (Scene2x5Clear == true) && (Scene2x6Clear == true) && (Scene2x7Clear == true)
             && (Scene2x8Clear == true) && (Scene2x9Clear == true) && (Scene2x10Clear == true) && (Scene2x11Clear == true) && (Scene2x12Clear == true) && (Scene2x13Clear == true)
             && (Scene2x14Clear == true) && (Scene2x15Clear == true) && (Scene2x16Clear == true) && (Scene2x17aClear == true) && (Scene2x17bClear == true) && (Scene2x18Clear == true)
             && (Scene2x19Clear == true) && (Scene2x20Clear == true) && (Scene2xB1Clear == true) && (Scene2xB2Clear == true) && (Scene3x1Clear == true) && (Scene3x2Clear == true)
             && (Scene3x3Clear == true) && (Scene3x4Clear == true) && (Scene3x5Clear == true) && (Scene3x6Clear == true) && (Scene3x7Clear == true) && (Scene3x8Clear == true)
             && (Scene3x9aClear == true) && (Scene3x9bClear == true) && (Scene3x10Clear == true) && (Scene3x11Clear == true) && (Scene3x12Clear == true) && (Scene3x13Clear == true)
             && (Scene3x14aClear == true) && (Scene3x14bClear == true) && (Scene3x14cClear == true) && (Scene3x15bClear == true) && (Scene3x15cClear == true) && (Scene3x16bClear == true)
             && (Scene3x17Clear == true) && (Scene3x18Clear == true) && (Scene3x19Clear == true) && (Scene3x20Clear == true) && (Scene3x21aClear == true) && (Scene3x21bClear == true)
             && (Scene3x21cClear == true) && (Scene3x21dClear == true) && (Scene3x21eClear == true) && (Scene3x22Clear == true) && (Scene3xB1Clear == true) && (Scene3xB2Clear == true)
             && (Scene4x1Clear == true) && (Scene4x2Clear == true) && (Scene4x3Clear == true) && (Scene4x4Clear == true) && (Scene4x5aClear == true) && (Scene4x5bClear == true)
             && (Scene4x6aClear == true) && (Scene4x6bClear == true) && (Scene4x7aClear == true) && (Scene4x7bClear == true) && (Scene4x8Clear == true) && (Scene4x9Clear == true)
             && (Scene4x10Clear == true) && (Scene4x11Clear == true) && (Scene4x12Clear == true) /*&& (Scene4x13Clear == true)*/ && (Scene4xBClear == true))
        {
            dissableFinalLaser = true;
        }

        if ((Scene5x1aClear == true) && (Scene5x1bClear == true) && (Scene5x1cClear == true) && (Scene5x1dClear == true))
        {
            cursorMemory5 = 5;
            Scene5x2Active = true;
        }
    }
}

