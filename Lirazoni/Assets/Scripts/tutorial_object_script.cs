using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class tutorial_object_script : MonoBehaviour
{
    public GameObject Enter;
    public short type;  /*
    0-player, key, door, no move enemy (1-1)
    1-spike enemy old (1-3)
    2-spike x2 (1-6)
    3-boss 1, attack power up (1-8)
    4-random (2-8)
    5-dash power up (2-12)
    6-invincibility power up (2-7a)
    7-spear enemy (2-16)
    8-armour power up (2-18)
    9-boomerang enemy, XXXXboss 2 (2-20)
    10-invincibility power up, bomb enemy (3-2)
    11-patrolling ai (3-8a) + (3-8b)
    12-zig-zag enemy (3-13)
    13-invincible enemies (3-12)
    14-standing enemy (3-14b)
    15-time travel power up (4-1)
    16-portal (4-4)
    17-bouncing enemy (4-7b)
    18-bouncing enemy, temporary portal (4-8a)
    19-hole, moving platform (4-10)
    20-stage 2-10 help (2-10)

    21-first text for true ending
    22-help 1a
    23-help 1b
    24-help 2
    25-help 3a
    26-help 3b
    27-help 4
    28-help 5
    29-help 6

 */ public bool activeCheck;
    public bool objType0;
    public bool objType1;
    public bool objType2;
    public bool objType3;
    public bool objType4;
    public bool objType5;
    public bool objType6;
    public bool objType7;
    public bool objType8;
    public bool objType9;
    public bool objType10;
    public bool objType11;
    public bool objType12;
    public bool objType13;
    public bool objType14;
    public bool objType15;
    public bool objType16;
    public bool objType17;
    public bool objType18;
    public bool objType19;
    public bool objType20;

    byte orderCheck;
    public int id;
    public bool keyCardHints;
    public byte extraFirstTimeVariable;

    IEnumerator CoroutineWait()
    {
        yield return null;
        GameObject Player = GameObject.Find("Player");
        player_script lockInputs = Player.GetComponent<player_script>();
        lockInputs.extraTutorialInputLock = true;
    }

    // Start is called before the first frame update
    void Start()
    {

        if (GameObject.Find("SceneUnlocker") != null)
        {
            master_script.current.onTutorialBoxPhase += PageChange;

            GameObject Scene = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scene.GetComponent<scene_unlocker_script>();

            if (sceneReference.firstTimeTutorialSeen > 0)
            {
                var random = new System.Random();
                var list = new List<int> { 1, 2, 3, 4, 5, 6};
              //  list.Remove(23);
             //   list.Remove(26);
                int index = random.Next(list.Count);
                Debug.Log(list[index]);
                sceneReference.firstTimeTutorialSeen = 2;

                /*
                if (index == 22)
                {
                    if (sceneReference.firstClue1 == 0)
                    {
                        index == 22
                    }
                    if (sceneReference.firstClue1 == 1)
                    {
                        index == 
                    }
                    if (sceneReference.firstClue1 == 2)
                    {

                    }
                }*/
                /*
                var randomSet = new System.Random();
                var numbers = new List<int>() { 11, 21, 31, 41, 51, 61, 71, 81 };
                if (sceneReference.firstTimeTutorialSeen == 1)
                {
                    numbers.Remove(2);
                    numbers.Remove(5);
                    sceneReference.firstTimeTutorialSeen = 2;
                }
            //    foreach (var number in numbers)
            //    Debug.Log("List: " + numbers);
                int index = randomSet.Next(numbers.Count);
                Debug.Log("Random Value: " + index);

                int x1 = numbers.IndexOf(1);
                int x2 = numbers.IndexOf(2);
                int x3 = numbers.IndexOf(3);
                int x4 = numbers.IndexOf(4);
                int x5 = numbers.IndexOf(5);
                int x6 = numbers.IndexOf(6);
                int x7 = numbers.IndexOf(7);
                int x8 = numbers.IndexOf(8);
                Debug.Log("XXXXX1: " + x1);
                Debug.Log("XXXXX2: " + x2);
                Debug.Log("XXXXX3: " + x3);
                Debug.Log("XXXXX4: " + x4);
                Debug.Log("XXXXX5: " + x5);
                Debug.Log("XXXXX6: " + x6);
                Debug.Log("XXXXX7: " + x7);
                Debug.Log("XXXXX8: " + x8);

                numbers.Add(2);
                numbers.Add(5);
                numbers.Remove(1);
                numbers.Remove(2);
                numbers.Remove(3);
                numbers.Remove(4);
                numbers.Remove(5);
                numbers.Remove(6);
                numbers.Remove(7);
                numbers.Remove(8);
                */
                if (sceneReference.firstTimeTutorialSeen == 2)
                {
                    if ((sceneReference.firstClue1 == 2) && (sceneReference.firstClue2 == 1) && (sceneReference.firstClue3 == 2) && (sceneReference.firstClue4 == 1) && (sceneReference.firstClue5 == 1) && (sceneReference.firstClue6 == 1))
                    {
                        if (sceneReference.dissableFinalLaser == false)
                        {
                            type = 30;
                        }
                        if (sceneReference.dissableFinalLaser == true)
                        {
                            type = 31;
                        }
                    }
                    else
                    {
                        if (index == 0)
                        {
                            if (sceneReference.firstClue1 == 0)
                            {
                                type = 22;
                            }
                            if (sceneReference.firstClue1 == 1)
                            {
                                type = 23;
                            }
                            if (sceneReference.firstClue1 == 2)
                            {
                                VariablesReset();
                            }
                        }
                        if (index == 1)
                        {
                            if (sceneReference.firstClue2 == 0)
                            {
                                type = 24;
                            }
                            if (sceneReference.firstClue2 == 1)
                            {
                                VariablesReset();
                            }
                        }
                        if (index == 2)
                        {
                            if (sceneReference.firstClue3 == 0)
                            {
                                type = 25;
                            }
                            if (sceneReference.firstClue3 == 1)
                            {
                                type = 26;
                            }
                            if (sceneReference.firstClue3 == 2)
                            {
                                VariablesReset();
                            }
                        }
                        if (index == 3)
                        {
                            if (sceneReference.firstClue4 == 0)
                            {
                                type = 27;
                            }
                            if (sceneReference.firstClue4 == 1)
                            {
                                VariablesReset();
                            }
                        }
                        if (index == 4)
                        {
                            if (sceneReference.firstClue5 == 0)
                            {
                                type = 28;
                            }
                            if (sceneReference.firstClue5 == 1)
                            {
                                VariablesReset();
                            }
                        }
                        if (index == 5)
                        {
                            if (sceneReference.firstClue6 == 0)
                            {
                                type = 29;
                            }
                            if (sceneReference.firstClue6 == 1)
                            {
                                VariablesReset();
                            }
                        }
                    }
                }
                Debug.Log("type = " + type);
            }

            if (type == 0)
            {
                if (sceneReference.tutorialObj0 == false)
                {
                    PlayerLock();
                    transform.GetChild(0).gameObject.SetActive(true);
                    objType0 = true;
                }
            }
            if (type == 1)
            {
                if (sceneReference.tutorialObj1 == false)
                {
                    PlayerLock();
                    transform.GetChild(4).gameObject.SetActive(true);
                    objType1 = true;
                }
            }
            if (type == 2)
            {
                if (sceneReference.tutorialObj2 == false)
                {
                    PlayerLock();
                    transform.GetChild(5).gameObject.SetActive(true);
                    objType2 = true;
                }
            }
            if (type == 3)
            {
                if (sceneReference.tutorialObj3 == false)
                {
                    PlayerLock();
                    transform.GetChild(6).gameObject.SetActive(true);
                    objType3 = true;
                }
            }
            if (type == 4)
            {
                if (sceneReference.tutorialObj4 == false)
                {
                    PlayerLock();
                    transform.GetChild(8).gameObject.SetActive(true);
                    objType4 = true;
                }
            }
            if (type == 5)
            {
                if (sceneReference.tutorialObj5 == false)
                {
                    PlayerLock();
                    transform.GetChild(9).gameObject.SetActive(true);
                    objType5 = true;
                }
            }
            if (type == 6)
            {
                if (sceneReference.tutorialObj6 == false)
                {
                    PlayerLock();
                    transform.GetChild(11).gameObject.SetActive(true);
                    objType6 = true;
                }
            }
            if (type == 7)
            {
                if (sceneReference.tutorialObj7 == false)
                {
                    PlayerLock();
                    transform.GetChild(10).gameObject.SetActive(true);
                    objType7 = true;
                }
            }
            if (type == 8)
            {
                if (sceneReference.tutorialObj8 == false)
                {
                    PlayerLock();
                    transform.GetChild(12).gameObject.SetActive(true);
                    objType8 = true;
                }
            }
            if (type == 9)
            {
                if (sceneReference.tutorialObj9 == false)
                {
                    PlayerLock();
                    transform.GetChild(13).gameObject.SetActive(true);
                    objType9 = true;
                }
            }
            if (type == 10)
            {
                if (sceneReference.tutorialObj10 == false)
                {
                    PlayerLock();
                    transform.GetChild(11).gameObject.SetActive(true);
                    objType10 = true;
                }
            }
            if (type == 11)
            {
                if (sceneReference.tutorialObj11 == false)
                {
                    PlayerLock();
                    transform.GetChild(16).gameObject.SetActive(true);
                    objType11 = true;
                }
            }
            if (type == 12)
            {
                if (sceneReference.tutorialObj12 == false)
                {
                    PlayerLock();
                    transform.GetChild(17).gameObject.SetActive(true);
                     objType12 = true;
                }
            }
            if (type == 13)
            {
                if (sceneReference.tutorialObj13 == false)
                {
                    PlayerLock();
                    transform.GetChild(18).gameObject.SetActive(true);
                    objType13 = true;
                }
            }
            if (type == 14)
            {
                if (sceneReference.tutorialObj14 == false)
                {
                    PlayerLock();
                    transform.GetChild(19).gameObject.SetActive(true);
                    objType14 = true;
                }
            }
            if (type == 15)
            {
                if (sceneReference.tutorialObj15 == false)
                {
                    PlayerLock();
                    transform.GetChild(20).gameObject.SetActive(true);
                    objType15 = true;
                }
            }
            if (type == 16)
            {
                if (sceneReference.tutorialObj16 == false)
                {
                    PlayerLock();
                    transform.GetChild(21).gameObject.SetActive(true);
                    objType16 = true;
                }
            }
            if (type == 17)
            {
                if (sceneReference.tutorialObj17 == false)
                {
                    PlayerLock();
                    transform.GetChild(22).gameObject.SetActive(true);
                    objType17 = true;
                }
            }
            if (type == 18)
            {
                if (sceneReference.tutorialObj18 == false)
                {
                    PlayerLock();
                    transform.GetChild(22).gameObject.SetActive(true);
                    objType18 = true;
                }
            }
            if (type == 19)
            {
                if (sceneReference.tutorialObj19 == false)
                {
                    PlayerLock();
                    transform.GetChild(24).gameObject.SetActive(true);
                    objType19 = true;
                }
            }
            if (type == 20)
            {
                if (sceneReference.tutorialObj20 == false)
                {
                    PlayerLock();
                    transform.GetChild(26).gameObject.SetActive(true);
                    objType20 = true;
                }
            }

            if (type == 21)
            {
                StartCoroutine(CoroutineWait());
                PlayerLock();
                transform.GetChild(27).gameObject.SetActive(true);
            }
            if (keyCardHints == true)
            {
                if (type == 22)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(28).gameObject.SetActive(true);
                }
                if (type == 23)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(29).gameObject.SetActive(true);
                }
                if (type == 24)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(30).gameObject.SetActive(true);
                }
                if (type == 25)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(31).gameObject.SetActive(true);
                }
                if (type == 26)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(32).gameObject.SetActive(true);
                }
                if (type == 27)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(33).gameObject.SetActive(true);
                }
                if (type == 28)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(34).gameObject.SetActive(true);
                }
                if (type == 29)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(35).gameObject.SetActive(true);
                }
                if (type == 30)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(36).gameObject.SetActive(true);
                }
                if (type == 30)
                {
                    StartCoroutine(CoroutineWait());
                    PlayerLock();
                    transform.GetChild(37).gameObject.SetActive(true);
                }
            }
        }
    }

    public void PageChange(int id)
    {
        if (GameObject.Find("SceneUnlocker") != null)
        {
            GameObject Scene = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scene.GetComponent<scene_unlocker_script>();

            if (type == 0)
            {
                for (int i = 0; i < 50; i++) // used it for break feature
                {
                    if (orderCheck == 0)
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                        if (sceneReference.tutorialObj1 == false)
                        {
                            transform.GetChild(1).gameObject.SetActive(true);
                        }
                        orderCheck = 1;
                        break;
                    }
                    if (orderCheck == 1)
                    {
                        transform.GetChild(1).gameObject.SetActive(false);
                        if (sceneReference.tutorialObj2 == false)
                        {
                            transform.GetChild(2).gameObject.SetActive(true);
                        }
                        orderCheck = 2;
                        break;
                    }
                    if (orderCheck == 2)
                    {
                        transform.GetChild(2).gameObject.SetActive(false);
                        if (sceneReference.tutorialObj3 == false)
                        {
                            transform.GetChild(3).gameObject.SetActive(true);
                        }
                        orderCheck = 3;
                        break;
                    }
                    if (orderCheck == 3)
                    {
                        transform.GetChild(3).gameObject.SetActive(false);
                        PlayerUnlock();
                        break;
                    }
                }
            }
            if (type == 1)
            {
                transform.GetChild(4).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 2)
            {
                transform.GetChild(5).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 3)
            {
                for (int i = 0; i < 50; i++) // used it for break feature
                {
                    if (orderCheck == 0)
                    {
                        transform.GetChild(6).gameObject.SetActive(false);
                        if (sceneReference.tutorialObj7 == false)
                        {
                            transform.GetChild(7).gameObject.SetActive(true);
                        }
                        orderCheck = 1;
                        break;
                    }
                    if (orderCheck == 1)
                    {
                        transform.GetChild(7).gameObject.SetActive(false);
                        PlayerUnlock();
                        break;
                    }
                }
            }
            if (type == 4)
            {
                transform.GetChild(8).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 5)
            {
                transform.GetChild(9).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 6)
            {
                transform.GetChild(11).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 7)
            {
                transform.GetChild(10).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 8)
            {
                transform.GetChild(12).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 9)
            {
                transform.GetChild(13).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 10)
            {
                for (int i = 0; i < 50; i++) // used it for break feature
                {
                    if (orderCheck == 0)
                    {
                        transform.GetChild(11).gameObject.SetActive(false);
                        transform.GetChild(15).gameObject.SetActive(true);
                        orderCheck = 1;
                        break;
                    }
                    if (orderCheck == 1)
                    {
                        transform.GetChild(15).gameObject.SetActive(false);
                        PlayerUnlock();
                        break;
                    }
                }
            }
            if (type == 11)
            {
                transform.GetChild(16).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 12)
            {
                transform.GetChild(17).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 13)
            {
                transform.GetChild(18).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 14)
            {
                transform.GetChild(19).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 15)
            {
                transform.GetChild(20).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 16)
            {
                transform.GetChild(21).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 17)
            {
                transform.GetChild(22).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 18)
            {
                for (int i = 0; i < 50; i++) // used it for break feature
                {
                    if (orderCheck == 0)
                    {
                        transform.GetChild(22).gameObject.SetActive(false);
                        transform.GetChild(23).gameObject.SetActive(true);
                        orderCheck = 1;
                        break;
                    }
                    if (orderCheck == 1)
                    {
                        transform.GetChild(23).gameObject.SetActive(false);
                        PlayerUnlock();
                        break;
                    }
                }
            }
            if (type == 19)
            {
                for (int i = 0; i < 50; i++) // used it for break feature
                {
                    if (orderCheck == 0)
                    {
                        transform.GetChild(24).gameObject.SetActive(false);
                        transform.GetChild(25).gameObject.SetActive(true);
                        orderCheck = 1;
                        break;
                    }
                    if (orderCheck == 1)
                    {
                        transform.GetChild(25).gameObject.SetActive(false);
                        PlayerUnlock();
                        break;
                    }
                }
            }
            if (type == 20)
            {
                transform.GetChild(26).gameObject.SetActive(false);
                PlayerUnlock();
            }

            if (type == 21)
            {
                transform.GetChild(27).gameObject.SetActive(false);
                sceneReference.firstTimeTutorialSeen = 1;
                PlayerUnlock();
            }

            if (type == 22)
            {
                transform.GetChild(28).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 23)
            {
                transform.GetChild(29).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 24)
            {
                transform.GetChild(30).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 25)
            {
                transform.GetChild(31).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 26)
            {
                transform.GetChild(32).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 27)
            {
                transform.GetChild(33).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 28)
            {
                transform.GetChild(34).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 29)
            {
                transform.GetChild(35).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 30)
            {
                transform.GetChild(36).gameObject.SetActive(false);
                PlayerUnlock();
            }
            if (type == 31)
            {
                transform.GetChild(37).gameObject.SetActive(false);
                PlayerUnlock();
            }
        }

    }
    public void PlayerLock()
    {
        activeCheck = true;
        Enter.SetActive(true);
    }

    public void PlayerUnlock()
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockInputs = Player.GetComponent<player_script>();
        lockInputs.inputLock = false;
        lockInputs.extraTutorialInputLock = false;
        Enter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log("check: " + orderCheck);

    if (Input.GetKeyDown(KeyCode.Return))
        {
            PageChange(id);
        }

    }

    public void VariablesReset()
    {
        if (GameObject.Find("SceneUnlocker") != null)
        {
            GameObject Scene = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scene.GetComponent<scene_unlocker_script>();

            if (sceneReference.firstClue6 == 0)
            {
                type = 29;
            }
            if (sceneReference.firstClue5 == 0)
            {
                type = 28;
            }
            if (sceneReference.firstClue4 == 0)
            {
                type = 27;
            }
            if (sceneReference.firstClue3 == 0)
            {
                type = 25;
            }
            if (sceneReference.firstClue3 == 1)
            {
                type = 26;
            }
            if (sceneReference.firstClue2 == 0)
            {
                type = 24;
            }
            if (sceneReference.firstClue1 == 0)
            {
                type = 22;
            }
            if (sceneReference.firstClue1 == 1)
            {
                type = 23;
            }
        }
    }
}
