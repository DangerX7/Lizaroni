using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dev_keyboard : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0)) // Return to Clasic Map
        {
            KeyLock();
            SceneManager.LoadScene("Classic Map");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Return to Story Map - Chapter 1
        {
            KeyLock();
            SceneManager.LoadScene("Chapter 1 Map");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // Return to Story Map - Chapter 2
        {
            KeyLock();
            SceneManager.LoadScene("Chapter 2 Map");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) // Return to Story Map - Chapter 3
        {
            KeyLock();
            SceneManager.LoadScene("Chapter 3 Map");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) // Return to Story Map - Chapter 4
        {
            KeyLock();
            SceneManager.LoadScene("Chapter 4 Map");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) // Return to Story Map - Chapter 5
        {
            KeyLock();
            SceneManager.LoadScene("Chapter 5 Map");
        }
        if (Input.GetKeyDown(KeyCode.Keypad5)) // Get Back to Tittle Screen
        {
            KeyLock();
            SceneManager.LoadScene("Tittle_Screen");
        }
        if (Input.GetKeyDown(KeyCode.R)) // Reset current level
        {
            KeyLock();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.L)) // Complete current level
        {
            KeyLock();
            if (GameObject.Find("Door") != null)
            {
                GameObject Master = GameObject.Find("MasterObject");
                master_script sceneCompleteReference1 = Master.GetComponent<master_script>();
                sceneCompleteReference1.keys = sceneCompleteReference1.lockKeys;

                GameObject Door = GameObject.Find("Door");
                door_script sceneCompleteReference2 = Door.GetComponent<door_script>();
                sceneCompleteReference2.complete = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.O)) // Load previous level
        {
            KeyLock();
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) - 1);
        }
        if (Input.GetKeyDown(KeyCode.P)) // Load next level
        {
            KeyLock();
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
        }
        if (Input.GetKeyDown(KeyCode.G)) // GOD MODE on
        {
            GameObject Player = GameObject.Find("Player");
            player_script playerReference = Player.GetComponent<player_script>();
                playerReference.HeroInvincibility = true;
                playerReference.HeroInvTimer = 1000000000;
                playerReference.HeroAttackAvailable = true;
                playerReference.unlimitedAttacksCheck = true;
                playerReference.HeroDashAvailable = true;
                playerReference.HeroTimeTravel = true;
}
        if (Input.GetKeyDown(KeyCode.H)) // GOD MODE off
        {
            GameObject Player = GameObject.Find("Player");
            player_script playerReference = Player.GetComponent<player_script>();
                playerReference.HeroInvincibility = false;
                playerReference.HeroInvTimer = 6;
                playerReference.HeroAttackAvailable = false;
                playerReference.unlimitedAttacksCheck = false;
                playerReference.HeroDashAvailable = false;
                playerReference.HeroTimeTravel = false;
        }
        if (Input.GetKeyDown(KeyCode.K)) // Unlock all Levels
        {
            if (GameObject.Find("SceneUnlocker") != null)
            {
                Debug.Log("All Chapters and Levels Unlocked!");
                GameObject SU = GameObject.Find("SceneUnlocker");
                scene_unlocker_script sceneUnlockReference = SU.GetComponent<scene_unlocker_script>();
                sceneUnlockReference.Chapter2Avalaible = true;
                sceneUnlockReference.Chapter3Avalaible = true;
                sceneUnlockReference.Chapter4Avalaible = true;
                sceneUnlockReference.Chapter5Avalaible = true;

                sceneUnlockReference.Scene2Active = true;
                sceneUnlockReference.Scene3Active = true;
                sceneUnlockReference.Scene4Active = true;
                sceneUnlockReference.Scene5Active = true;
                sceneUnlockReference.Scene6Active = true;
                sceneUnlockReference.Scene7Active = true;
                sceneUnlockReference.Scene8Active = true;
                sceneUnlockReference.Scene9Active = true;
                sceneUnlockReference.Scene10Active = true;
                sceneUnlockReference.Scene11Active = true;
                sceneUnlockReference.Scene12Active = true;
                sceneUnlockReference.Scene13Active = true;
                sceneUnlockReference.Scene14Active = true;
                sceneUnlockReference.Scene15Active = true;
                sceneUnlockReference.Scene16Active = true;
                sceneUnlockReference.Scene17Active = true;
                sceneUnlockReference.Scene18Active = true;
                sceneUnlockReference.Scene19Active = true;
                sceneUnlockReference.Scene20Active = true;
                sceneUnlockReference.Scene21Active = true;
                sceneUnlockReference.Scene22Active = true;
                sceneUnlockReference.Scene23Active = true;
                sceneUnlockReference.Scene24Active = true;
                sceneUnlockReference.Scene25Active = true;
                sceneUnlockReference.Scene26Active = true;
                sceneUnlockReference.Scene27Active = true;
                sceneUnlockReference.Scene28Active = true;
                sceneUnlockReference.Scene29Active = true;
                sceneUnlockReference.Scene30Active = true;
                sceneUnlockReference.Scene31Active = true;
                sceneUnlockReference.Scene32Active = true;
                sceneUnlockReference.Scene33Active = true;
                sceneUnlockReference.Scene34Active = true;
                sceneUnlockReference.Scene35Active = true;
                sceneUnlockReference.Scene36Active = true;
                sceneUnlockReference.Scene37Active = true;
                sceneUnlockReference.Scene38Active = true;
                sceneUnlockReference.Scene39Active = true;
                sceneUnlockReference.Scene40Active = true;
                sceneUnlockReference.Scene41Active = true;
                sceneUnlockReference.Scene42Active = true;
                sceneUnlockReference.Scene43Active = true;
                sceneUnlockReference.Scene44Active = true;
                sceneUnlockReference.Scene45Active = true;
                sceneUnlockReference.Scene46Active = true;
                sceneUnlockReference.Scene47Active = true;
                sceneUnlockReference.Scene48Active = true;
                sceneUnlockReference.Scene49Active = true;
                sceneUnlockReference.Scene50Active = true;

                sceneUnlockReference.Scene1x2Active = true;
                sceneUnlockReference.Scene1x3Active = true;
                sceneUnlockReference.Scene1x4Active = true;
                sceneUnlockReference.Scene1x5aActive = true;
                sceneUnlockReference.Scene1x5bActive = true;
                sceneUnlockReference.Scene1x6aActive = true;
                sceneUnlockReference.Scene1x6bActive = true;
                sceneUnlockReference.Scene1x7Active = true;
                sceneUnlockReference.Scene1x8Active = true;
                sceneUnlockReference.Scene1x9Active = true;
                sceneUnlockReference.Scene1x10Active = true;
                sceneUnlockReference.Scene1x11Active = true;
                sceneUnlockReference.Scene1x12Active = true;
                sceneUnlockReference.Scene1xBActive = true;
                sceneUnlockReference.Scene2x2Active = true;
                sceneUnlockReference.Scene2x3Active = true;
                sceneUnlockReference.Scene2x4aActive = true;
                sceneUnlockReference.Scene2x4bActive = true;
                sceneUnlockReference.Scene2x4cActive = true;
                sceneUnlockReference.Scene2x5Active = true;
                sceneUnlockReference.Scene2x6Active = true;
                sceneUnlockReference.Scene2x7Active = true;
                sceneUnlockReference.Scene2x8Active = true;
                sceneUnlockReference.Scene2x9Active = true;
                sceneUnlockReference.Scene2x10Active = true;
                sceneUnlockReference.Scene2x11Active = true;
                sceneUnlockReference.Scene2x12Active = true;
                sceneUnlockReference.Scene2x13Active = true;
                sceneUnlockReference.Scene2x14Active = true;
                sceneUnlockReference.Scene2x15Active = true;
                sceneUnlockReference.Scene2x16Active = true;
                sceneUnlockReference.Scene2x17aActive = true;
                sceneUnlockReference.Scene2x17bActive = true;
                sceneUnlockReference.Scene2x18Active = true;
                sceneUnlockReference.Scene2x19Active = true;
                sceneUnlockReference.Scene2x20Active = true;
                sceneUnlockReference.Scene2xB1Active = true;
                sceneUnlockReference.Scene2xB2Active = true;
                sceneUnlockReference.Scene3x2Active = true;
                sceneUnlockReference.Scene3x3Active = true;
                sceneUnlockReference.Scene3x4Active = true;
                sceneUnlockReference.Scene3x5Active = true;
                sceneUnlockReference.Scene3x6Active = true;
                sceneUnlockReference.Scene3x7Active = true;
                sceneUnlockReference.Scene3x8Active = true;
                sceneUnlockReference.Scene3x9aActive = true;
                sceneUnlockReference.Scene3x9bActive = true;
                sceneUnlockReference.Scene3x10Active = true;
                sceneUnlockReference.Scene3x11Active = true;
                sceneUnlockReference.Scene3x12Active = true;
                sceneUnlockReference.Scene3x13Active = true;
                sceneUnlockReference.Scene3x14aActive = true;
                sceneUnlockReference.Scene3x14bActive = true;
                sceneUnlockReference.Scene3x14cActive = true;
                sceneUnlockReference.Scene3x15bActive = true;
                sceneUnlockReference.Scene3x15cActive = true;
                sceneUnlockReference.Scene3x16bActive = true;
                sceneUnlockReference.Scene3x17Active = true;
                sceneUnlockReference.Scene3x18Active = true;
                sceneUnlockReference.Scene3x19Active = true;
                sceneUnlockReference.Scene3x20Active = true;
                sceneUnlockReference.Scene3x21aActive = true;
                sceneUnlockReference.Scene3x21bActive = true;
                sceneUnlockReference.Scene3x21cActive = true;
                sceneUnlockReference.Scene3x21dActive = true;
                sceneUnlockReference.Scene3x21eActive = true;
                sceneUnlockReference.Scene3x22Active = true;
                sceneUnlockReference.Scene3xB1Active = true;
                sceneUnlockReference.Scene3xB2Active = true;
                sceneUnlockReference.Scene4x2Active = true;
                sceneUnlockReference.Scene4x3Active = true;
                sceneUnlockReference.Scene4x4Active = true;
                sceneUnlockReference.Scene4x5aActive = true;
                sceneUnlockReference.Scene4x5bActive = true;
                sceneUnlockReference.Scene4x6aActive = true;
                sceneUnlockReference.Scene4x6bActive = true;
                sceneUnlockReference.Scene4x7aActive = true;
                sceneUnlockReference.Scene4x7bActive = true;
                sceneUnlockReference.Scene4x8Active = true;
                sceneUnlockReference.Scene4x9Active = true;
                sceneUnlockReference.Scene4x10Active = true;
                sceneUnlockReference.Scene4x11Active = true;
                sceneUnlockReference.Scene4x12Active = true;
                sceneUnlockReference.Scene4x13Active = true;
                sceneUnlockReference.Scene4x14Active = true;
                sceneUnlockReference.Scene4xBActive = true;
                sceneUnlockReference.Scene5x2Active = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.M)) // Lock all Levels

            if (GameObject.Find("SceneUnlocker") != null)
            {
                Debug.Log("All Chapters and Levels Unlocked!");
                GameObject SU = GameObject.Find("SceneUnlocker");
                scene_unlocker_script sceneUnlockReference = SU.GetComponent<scene_unlocker_script>();
                sceneUnlockReference.Chapter2Avalaible = false;
                sceneUnlockReference.Chapter3Avalaible = false;
                sceneUnlockReference.Chapter4Avalaible = false;
                sceneUnlockReference.Chapter5Avalaible = false;

                sceneUnlockReference.Scene2Active = false;
                sceneUnlockReference.Scene3Active = false;
                sceneUnlockReference.Scene4Active = false;
                sceneUnlockReference.Scene5Active = false;
                sceneUnlockReference.Scene6Active = false;
                sceneUnlockReference.Scene7Active = false;
                sceneUnlockReference.Scene8Active = false;
                sceneUnlockReference.Scene9Active = false;
                sceneUnlockReference.Scene10Active = false;
                sceneUnlockReference.Scene11Active = false;
                sceneUnlockReference.Scene12Active = false;
                sceneUnlockReference.Scene13Active = false;
                sceneUnlockReference.Scene14Active = false;
                sceneUnlockReference.Scene15Active = false;
                sceneUnlockReference.Scene16Active = false;
                sceneUnlockReference.Scene17Active = false;
                sceneUnlockReference.Scene18Active = false;
                sceneUnlockReference.Scene19Active = false;
                sceneUnlockReference.Scene20Active = false;
                sceneUnlockReference.Scene21Active = false;
                sceneUnlockReference.Scene22Active = false;
                sceneUnlockReference.Scene23Active = false;
                sceneUnlockReference.Scene24Active = false;
                sceneUnlockReference.Scene25Active = false;
                sceneUnlockReference.Scene26Active = false;
                sceneUnlockReference.Scene27Active = false;
                sceneUnlockReference.Scene28Active = false;
                sceneUnlockReference.Scene29Active = false;
                sceneUnlockReference.Scene30Active = false;
                sceneUnlockReference.Scene31Active = false;
                sceneUnlockReference.Scene32Active = false;
                sceneUnlockReference.Scene33Active = false;
                sceneUnlockReference.Scene34Active = false;
                sceneUnlockReference.Scene35Active = false;
                sceneUnlockReference.Scene36Active = false;
                sceneUnlockReference.Scene37Active = false;
                sceneUnlockReference.Scene38Active = false;
                sceneUnlockReference.Scene39Active = false;
                sceneUnlockReference.Scene40Active = false;
                sceneUnlockReference.Scene41Active = false;
                sceneUnlockReference.Scene42Active = false;
                sceneUnlockReference.Scene43Active = false;
                sceneUnlockReference.Scene44Active = false;
                sceneUnlockReference.Scene45Active = false;
                sceneUnlockReference.Scene46Active = false;
                sceneUnlockReference.Scene47Active = false;
                sceneUnlockReference.Scene48Active = false;
                sceneUnlockReference.Scene49Active = false;
                sceneUnlockReference.Scene50Active = false;

                sceneUnlockReference.Scene1x2Active = false;
                sceneUnlockReference.Scene1x3Active = false;
                sceneUnlockReference.Scene1x4Active = false;
                sceneUnlockReference.Scene1x5aActive = false;
                sceneUnlockReference.Scene1x5bActive = false;
                sceneUnlockReference.Scene1x6aActive = false;
                sceneUnlockReference.Scene1x6bActive = false;
                sceneUnlockReference.Scene1x7Active = false;
                sceneUnlockReference.Scene1x8Active = false;
                sceneUnlockReference.Scene1x9Active = false;
                sceneUnlockReference.Scene1x10Active = false;
                sceneUnlockReference.Scene1x11Active = false;
                sceneUnlockReference.Scene1x12Active = false;
                sceneUnlockReference.Scene1xBActive = false;
                sceneUnlockReference.Scene2x2Active = false;
                sceneUnlockReference.Scene2x3Active = false;
                sceneUnlockReference.Scene2x4aActive = false;
                sceneUnlockReference.Scene2x4bActive = false;
                sceneUnlockReference.Scene2x4cActive = false;
                sceneUnlockReference.Scene2x5Active = false;
                sceneUnlockReference.Scene2x6Active = false;
                sceneUnlockReference.Scene2x7Active = false;
                sceneUnlockReference.Scene2x8Active = false;
                sceneUnlockReference.Scene2x9Active = false;
                sceneUnlockReference.Scene2x10Active = false;
                sceneUnlockReference.Scene2x11Active = false;
                sceneUnlockReference.Scene2x12Active = false;
                sceneUnlockReference.Scene2x13Active = false;
                sceneUnlockReference.Scene2x14Active = false;
                sceneUnlockReference.Scene2x15Active = false;
                sceneUnlockReference.Scene2x16Active = false;
                sceneUnlockReference.Scene2x17aActive = false;
                sceneUnlockReference.Scene2x17bActive = false;
                sceneUnlockReference.Scene2x18Active = false;
                sceneUnlockReference.Scene2x19Active = false;
                sceneUnlockReference.Scene2x20Active = false;
                sceneUnlockReference.Scene2xB1Active = false;
                sceneUnlockReference.Scene2xB2Active = false;
                sceneUnlockReference.Scene3x2Active = false;
                sceneUnlockReference.Scene3x3Active = false;
                sceneUnlockReference.Scene3x4Active = false;
                sceneUnlockReference.Scene3x5Active = false;
                sceneUnlockReference.Scene3x6Active = false;
                sceneUnlockReference.Scene3x7Active = false;
                sceneUnlockReference.Scene3x8Active = false;
                sceneUnlockReference.Scene3x9aActive = false;
                sceneUnlockReference.Scene3x9bActive = false;
                sceneUnlockReference.Scene3x10Active = false;
                sceneUnlockReference.Scene3x11Active = false;
                sceneUnlockReference.Scene3x12Active = false;
                sceneUnlockReference.Scene3x13Active = false;
                sceneUnlockReference.Scene3x14aActive = false;
                sceneUnlockReference.Scene3x14bActive = false;
                sceneUnlockReference.Scene3x14cActive = false;
                sceneUnlockReference.Scene3x15bActive = false;
                sceneUnlockReference.Scene3x15cActive = false;
                sceneUnlockReference.Scene3x16bActive = false;
                sceneUnlockReference.Scene3x17Active = false;
                sceneUnlockReference.Scene3x18Active = false;
                sceneUnlockReference.Scene3x19Active = false;
                sceneUnlockReference.Scene3x20Active = false;
                sceneUnlockReference.Scene3x21aActive = false;
                sceneUnlockReference.Scene3x21bActive = false;
                sceneUnlockReference.Scene3x21cActive = false;
                sceneUnlockReference.Scene3x21dActive = false;
                sceneUnlockReference.Scene3x21eActive = false;
                sceneUnlockReference.Scene3x22Active = false;
                sceneUnlockReference.Scene3xB1Active = false;
                sceneUnlockReference.Scene3xB2Active = false;
                sceneUnlockReference.Scene4x2Active = false;
                sceneUnlockReference.Scene4x3Active = false;
                sceneUnlockReference.Scene4x4Active = false;
                sceneUnlockReference.Scene4x5aActive = false;
                sceneUnlockReference.Scene4x5bActive = false;
                sceneUnlockReference.Scene4x6aActive = false;
                sceneUnlockReference.Scene4x6bActive = false;
                sceneUnlockReference.Scene4x7aActive = false;
                sceneUnlockReference.Scene4x7bActive = false;
                sceneUnlockReference.Scene4x8Active = false;
                sceneUnlockReference.Scene4x9Active = false;
                sceneUnlockReference.Scene4x10Active = false;
                sceneUnlockReference.Scene4x11Active = false;
                sceneUnlockReference.Scene4x12Active = false;
                sceneUnlockReference.Scene4x13Active = false;
                sceneUnlockReference.Scene4x14Active = false;
                sceneUnlockReference.Scene4xBActive = false;
                sceneUnlockReference.Scene5x2Active = false;
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
