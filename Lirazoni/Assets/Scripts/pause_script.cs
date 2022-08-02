using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_script : MonoBehaviour
{
    public bool isGamePaused;
    public GameObject pause, player, enemies, keys, powerUps, easy, normal, playerEasy,enemies1, enemies2, enemies3, enemies4, enemies5,
                      easy1, easy2, easy3, easy4, easy5, normal1, normal2, normal3, normal4, normal5, platforms;
    bool check1;
    bool check2;
    bool check3;
    bool check4;
    bool check5;
    bool check6;
    bool check7;
    bool check8;
    bool check9;
    bool check10;
    bool check11;
    bool check12;
    bool check13;
    bool check14;
    bool check15;
    bool check16;
    bool check17;
    bool check18;
    bool check19;
    bool check20;
    bool check21;
    bool check22;
    bool check23;
    public byte mapType; // 0 Clasic, 1 Chapter-1, 2 C2, 3 C3, 4 C4, 5 C5, 10 Versus
    public bool timerLock;

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.25f);
        isGamePaused = true;
    }

    void Update()
    {
            GameObject Player = GameObject.Find("Player");
        player_script lockRef = Player.GetComponent<player_script>();


        if ((Input.GetKey(KeyCode.Escape)) && (isGamePaused == false) && (lockRef.inputLock == false))
        {

            //pause game
            pause.SetActive(true);
            lockRef.inputLock = true;

            if (mapType == 10)
            {
                lockRef.rend.enabled = false;
                timerLock = true;
                GameObject Player2 = GameObject.Find("Player2");
                player_script lockRef2 = Player2.GetComponent<player_script>();
                lockRef2.inputLock = true;
                lockRef2.rend.enabled = false;
            }
            /*
            if (GameObject.Find("Player") != null)
            {
                player.SetActive(false);
                check1 = true;
            }
            */

            if (mapType == 10) //pause versus timer
            {
                timerLock = true;
            }
            if (GameObject.Find("Enemies") != null)
            {
                enemies.SetActive(false);
                check2 = true;
            }
            if (GameObject.Find("Spikes") != null)
            {
                enemies.SetActive(false);
                check3 = true;
            }
            if (GameObject.Find("Keys") != null)
            {
                keys.SetActive(false);
                check4 = true;
            }
            if (GameObject.Find("Power-Ups") != null)
            {
                powerUps.SetActive(false);
                check5 = true;
            }
            if (GameObject.Find("Easy") != null)
            {
                easy.SetActive(false);
                check6 = true;
            }
            if (GameObject.Find("Normal") != null)
            {
                normal.SetActive(false);
                check7 = true;
            }
            if (GameObject.Find("Enemies1") != null)
            {
                enemies1.SetActive(false);
                check8 = true;
            }
            if (GameObject.Find("Enemies2") != null)
            {
                enemies2.SetActive(false);
                check9 = true;
            }
            if (GameObject.Find("Enemies3") != null)
            {
                enemies3.SetActive(false);
                check10 = true;
            }
            if (GameObject.Find("Enemies4") != null)
            {
                enemies4.SetActive(false);
                check11 = true;
            }
            if (GameObject.Find("Enemies5") != null)
            {
                enemies5.SetActive(false);
                check12 = true;
            }
            if (GameObject.Find("Holes & PLatforms Prefab") != null)
            {
                platforms.SetActive(false);
                check23 = true;
            }
            /////////////////////////////////////////
            if (GameObject.Find("Easy1") != null)
            {
                easy1.SetActive(false);
                check13 = true;
            }
            if (GameObject.Find("Easy2") != null)
            {
                easy2.SetActive(false);
                check14 = true;
            }
            if (GameObject.Find("Easy3") != null)
            {
                easy3.SetActive(false);
                check15 = true;
            }
            if (GameObject.Find("Easy4") != null)
            {
                easy4.SetActive(false);
                check16 = true;
            }
            if (GameObject.Find("Easy5") != null)
            {
                easy5.SetActive(false);
                check17 = true;
            }
            if (GameObject.Find("Normal1") != null)
            {
                normal1.SetActive(false);
                check18 = true;
            }
            if (GameObject.Find("Normal2") != null)
            {
                normal2.SetActive(false);
                check19 = true;
            }
            if (GameObject.Find("Normal3") != null)
            {
                normal3.SetActive(false);
                check20 = true;
            }
            if (GameObject.Find("Normal4") != null)
            {
                normal4.SetActive(false);
                check21 = true;
            }
            if (GameObject.Find("Normal5") != null)
            {
               normal5.SetActive(false);
                check22 = true;
            }

            StartCoroutine(Wait());
        }
        if ((Input.GetKey(KeyCode.Return)) && (isGamePaused == true))
        {
            // unpause game
            pause.SetActive(false);
            lockRef.inputLock = false;

            if (mapType == 10)
            {
                timerLock = false;
                lockRef.rend.enabled = true;
                GameObject Player2 = GameObject.Find("Player2");
                player_script lockRef2 = Player2.GetComponent<player_script>();
                lockRef2.inputLock = false;
                lockRef2.rend.enabled = true;
            }
            /*
            if (check1 == true)
            {
                player.SetActive(true);
                check1 = false;
            }
            */


            if (mapType == 10) //pause versus timer
            {
                timerLock = false;
            }

            if ((check2 == true) || (check3 == true))
            {
                enemies.SetActive(true);
                check2 = false;
                check3 = false;
            }
            if (check4 == true)
            {
                keys.SetActive(true);
                check4 = false;
            }
            if (check5 == true)
            {
                powerUps.SetActive(true);
                check5 = false;
            }
            if (check6 == true)
            {
                easy.SetActive(true);
                check6 = false;
            }
            if (check7 == true)
            {
                normal.SetActive(true);
                check7 = false;
            }
            if (check8 == true)
            {
                enemies1.SetActive(true);
                check8 = false;
            }
            if (check9 == true)
            {
                enemies2.SetActive(true);
                check9 = false;
            }
            if (check10 == true)
            {
                enemies3.SetActive(true);
                check10 = false;
            }
            if (check11 == true)
            {
                enemies4.SetActive(true);
                check11 = false;
            }
            if (check12 == true)
            {
                enemies5.SetActive(true);
                check12 = false;
            }
            /////////////////////////////
            if (check13 == true)
            {
                easy1.SetActive(true);
                check13 = false;
            }
            if (check14 == true)
            {
                easy2.SetActive(true);
                check14 = false;
            }
            if (check15 == true)
            {
                easy3.SetActive(true);
                check15 = false;
            }
            if (check16 == true)
            {
                easy4.SetActive(true);
                check16 = false;
            }
            if (check17 == true)
            {
                easy5.SetActive(true);
                check17 = false;
            }
            if (check18 == true)
            {
                normal1.SetActive(true);
                check18 = false;
            }
            if (check19 == true)
            {
                normal2.SetActive(true);
                check19 = false;
            }
            if (check20 == true)
            {
                normal3.SetActive(true);
                check20 = false;
            }
            if (check21 == true)
            {
                normal4.SetActive(true);
                check21 = false;
            }
            if (check22 == true)
            {
                normal5.SetActive(true);
                check22 = false;
            }
            if (check23 == true)
            {
                platforms.SetActive(true);
                check23 = false;
            }
            isGamePaused = false;
        }
        if ((Input.GetKey(KeyCode.Escape)) && (isGamePaused == true))
        {
            if (mapType == 0)
            {
                SceneManager.LoadScene("Classic Map");
            }
            if (mapType == 1)
            {
                SceneManager.LoadScene("Chapter 1 Map");
            }
            if (mapType == 2)
            {
                SceneManager.LoadScene("Chapter 2 Map");
            }
            if (mapType == 3)
            {
                SceneManager.LoadScene("Chapter 3 Map");
            }
            if (mapType == 4)
            {
                SceneManager.LoadScene("Chapter 4 Map");
            }
            if (mapType == 5)
            {
                SceneManager.LoadScene("Chapter 5 Map");
            }
            if (mapType == 6)
            {
                ////
            }
            if (mapType == 10)
            {
                SceneManager.LoadScene("Tittle_Screen");
            }
        }
    }
}
