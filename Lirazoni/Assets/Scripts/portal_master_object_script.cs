using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_master_object_script : MonoBehaviour
{
    scene_unlocker_script difficultyReference;
    public bool enemiesActivationCheck;
    public int roomOfMap2;
    public bool variablesReset;


    /// <summary>
    /// /////////////////////////
    /// </summary>

    public GameObject enemies1, enemies2, enemies3, enemies4, enemies5,
                      easy1, easy2, easy3, easy4, easy5, normal1, normal2, normal3, normal4, normal5,
                      ChildGameObject1_0, ChildGameObject1_1, ChildGameObject1_2, ChildGameObject1_3, ChildGameObject1_4,
                      ChildGameObject1_5, ChildGameObject1_6, ChildGameObject1_7, ChildGameObject1_8, ChildGameObject1_9, ChildGameObject1_10, ChildGameObject1_11,
                      ChildGameObject2_0, ChildGameObject2_1, ChildGameObject2_2, ChildGameObject2_3, ChildGameObject2_4,
                      ChildGameObject2_5, ChildGameObject2_6, ChildGameObject2_7, ChildGameObject2_8, ChildGameObject2_9,
                      ChildGameObject3_0, ChildGameObject3_1, ChildGameObject3_2, ChildGameObject3_3, ChildGameObject3_4,
                      ChildGameObject3_5, ChildGameObject3_6, ChildGameObject3_7, ChildGameObject3_8, ChildGameObject3_9,
                      ChildGameObject4_0, ChildGameObject4_1, ChildGameObject4_2, ChildGameObject4_3, ChildGameObject4_4,
                      ChildGameObject4_5, ChildGameObject4_6, ChildGameObject4_7, ChildGameObject4_8, ChildGameObject4_9,
                      ChildGameObject5_0, ChildGameObject5_1, ChildGameObject5_2, ChildGameObject5_3, ChildGameObject5_4,
                      ChildGameObject5_5, ChildGameObject5_6, ChildGameObject5_7, ChildGameObject5_8, ChildGameObject5_9,
                      ChildGameObject1_0E, ChildGameObject1_1E, ChildGameObject1_2E, ChildGameObject1_3E, ChildGameObject1_4E,
                      ChildGameObject2_0E, ChildGameObject2_1E, ChildGameObject2_2E, ChildGameObject2_3E, ChildGameObject2_4E,
                      ChildGameObject3_0E, ChildGameObject3_1E, ChildGameObject3_2E, ChildGameObject3_3E, ChildGameObject3_4E,
                      ChildGameObject4_0E, ChildGameObject4_1E, ChildGameObject4_2E, ChildGameObject4_3E, ChildGameObject4_4E,
                      ChildGameObject5_0E, ChildGameObject5_1E, ChildGameObject5_2E, ChildGameObject5_3E, ChildGameObject5_4E,
                      ChildGameObject1_0N, ChildGameObject1_1N, ChildGameObject1_2N, ChildGameObject1_3N, ChildGameObject1_4N,
                      ChildGameObject2_0N, ChildGameObject2_1N, ChildGameObject2_2N, ChildGameObject2_3N, ChildGameObject2_4N,
                      ChildGameObject3_0N, ChildGameObject3_1N, ChildGameObject3_2N, ChildGameObject3_3N, ChildGameObject3_4N,
                      ChildGameObject4_0N, ChildGameObject4_1N, ChildGameObject4_2N, ChildGameObject4_3N, ChildGameObject4_4N,
                      ChildGameObject5_0N, ChildGameObject5_1N, ChildGameObject5_2N, ChildGameObject5_3N, ChildGameObject5_4N,
                      ExtraChild1, ExtraChild2, ExtraChild3, ExtraChild4, ExtraChild5,
                      ExtraParent1;

    Vector3 originalPos1_0, originalPos1_1, originalPos1_2, originalPos1_3, originalPos1_4,
            originalPos1_5, originalPos1_6, originalPos1_7, originalPos1_8, originalPos1_9, originalPos1_10, originalPos1_11,
            originalPos2_0, originalPos2_1, originalPos2_2, originalPos2_3, originalPos2_4,
            originalPos2_5, originalPos2_6, originalPos2_7, originalPos2_8, originalPos2_9,
            originalPos3_0, originalPos3_1, originalPos3_2, originalPos3_3, originalPos3_4,
            originalPos3_5, originalPos3_6, originalPos3_7, originalPos3_8, originalPos3_9,
            originalPos4_0, originalPos4_1, originalPos4_2, originalPos4_3, originalPos4_4,
            originalPos4_5, originalPos4_6, originalPos4_7, originalPos4_8, originalPos4_9,
            originalPos5_0, originalPos5_1, originalPos5_2, originalPos5_3, originalPos5_4,
            originalPos5_5, originalPos5_6, originalPos5_7, originalPos5_8, originalPos5_9,
            originalPos1_0E, originalPos1_1E, originalPos1_2E, originalPos1_3E, originalPos1_4E,
            originalPos2_0E, originalPos2_1E, originalPos2_2E, originalPos2_3E, originalPos2_4E,
            originalPos3_0E, originalPos3_1E, originalPos3_2E, originalPos3_3E, originalPos3_4E,
            originalPos4_0E, originalPos4_1E, originalPos4_2E, originalPos4_3E, originalPos4_4E,
            originalPos5_0E, originalPos5_1E, originalPos5_2E, originalPos5_3E, originalPos5_4E,
            originalPos1_0N, originalPos1_1N, originalPos1_2N, originalPos1_3N, originalPos1_4N,
            originalPos2_0N, originalPos2_1N, originalPos2_2N, originalPos2_3N, originalPos2_4N,
            originalPos3_0N, originalPos3_1N, originalPos3_2N, originalPos3_3N, originalPos3_4N,
            originalPos4_0N, originalPos4_1N, originalPos4_2N, originalPos4_3N, originalPos4_4N,
            originalPos5_0N, originalPos5_1N, originalPos5_2N, originalPos5_3N, originalPos5_4N,
            originalPosEx1, originalPosEx2, originalPosEx3, originalPosEx4, originalPosEx5;


    // Start is called before the first frame update
    void Start()
    {
        SetEnemiesInitialPosition();

        GameObject SceneUnlockerX = GameObject.Find("SceneUnlocker");
        difficultyReference = SceneUnlockerX.GetComponent<scene_unlocker_script>();
    }
    IEnumerator EnemiesResetTimer()
    {
        GameObject Player = GameObject.Find("Player");
        player_script enemiesDissable = Player.GetComponent<player_script>();
        yield return new WaitForSeconds(0.2f);
        roomOfMap2 = enemiesDissable.roomOfMap;
        enemiesDissable.specialTeleport = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        player_script enemiesDissable = Player.GetComponent<player_script>();


        //Debug.Log("player " + enemiesDissable.roomOfMap);
        //Debug.Log("portal " + roomOfMap2);

        if ((roomOfMap2 != enemiesDissable.roomOfMap) || (enemiesDissable.specialTeleport == true))
        {
            variablesReset = true;
            //    Debug.Log("Change Value");
            enemiesActivationCheck = false;
            StartCoroutine(EnemiesResetTimer());
        }
        else if (roomOfMap2 == enemiesDissable.roomOfMap)
        {
                variablesReset = false;
        }

        if (enemiesActivationCheck == false)
        {
            EnemiesDisable();
        }

    }



    public void SetEnemiesInitialPosition()
    {

        if (enemies1 != null)
        {
            if (enemies1.transform.childCount >= 1)
            {
                originalPos1_0 = new Vector3(ChildGameObject1_0.transform.position.x, ChildGameObject1_0.transform.position.y, ChildGameObject1_0.transform.position.z);
            }
            if (enemies1.transform.childCount >= 2)
            {
                originalPos1_1 = new Vector3(ChildGameObject1_1.transform.position.x, ChildGameObject1_1.transform.position.y, ChildGameObject1_1.transform.position.z);
            }
            if (enemies1.transform.childCount >= 3)
            {
                originalPos1_2 = new Vector3(ChildGameObject1_2.transform.position.x, ChildGameObject1_2.transform.position.y, ChildGameObject1_2.transform.position.z);
            }
            if (enemies1.transform.childCount >= 4)
            {
                originalPos1_3 = new Vector3(ChildGameObject1_3.transform.position.x, ChildGameObject1_3.transform.position.y, ChildGameObject1_3.transform.position.z);
            }
            if (enemies1.transform.childCount >= 5)
            {
                originalPos1_4 = new Vector3(ChildGameObject1_4.transform.position.x, ChildGameObject1_4.transform.position.y, ChildGameObject1_4.transform.position.z);
            }
            if (enemies1.transform.childCount >= 6)
            {
                originalPos1_5 = new Vector3(ChildGameObject1_5.transform.position.x, ChildGameObject1_5.transform.position.y, ChildGameObject1_5.transform.position.z);
            }
            if (enemies1.transform.childCount >= 7)
            {
                originalPos1_6 = new Vector3(ChildGameObject1_6.transform.position.x, ChildGameObject1_6.transform.position.y, ChildGameObject1_6.transform.position.z);
            }
            if (enemies1.transform.childCount >= 8)
            {
                originalPos1_7 = new Vector3(ChildGameObject1_7.transform.position.x, ChildGameObject1_7.transform.position.y, ChildGameObject1_7.transform.position.z);
            }
            if (enemies1.transform.childCount >= 9)
            {
                originalPos1_8 = new Vector3(ChildGameObject1_8.transform.position.x, ChildGameObject1_8.transform.position.y, ChildGameObject1_8.transform.position.z);
            }
            if (enemies1.transform.childCount >= 10)
            {
                originalPos1_9 = new Vector3(ChildGameObject1_9.transform.position.x, ChildGameObject1_9.transform.position.y, ChildGameObject1_9.transform.position.z);
            }
            if (enemies1.transform.childCount >= 11)
            {
                originalPos1_10 = new Vector3(ChildGameObject1_10.transform.position.x, ChildGameObject1_10.transform.position.y, ChildGameObject1_10.transform.position.z);
            }
            if (enemies1.transform.childCount >= 12)
            {
                originalPos1_11 = new Vector3(ChildGameObject1_11.transform.position.x, ChildGameObject1_11.transform.position.y, ChildGameObject1_11.transform.position.z);
            }
        }
        if (enemies2 != null)
        {
            if (enemies2.transform.childCount >= 1)
            {
                originalPos2_0 = new Vector3(ChildGameObject2_0.transform.position.x, ChildGameObject2_0.transform.position.y, ChildGameObject2_0.transform.position.z);
            }
            if (enemies2.transform.childCount >= 2)
            {
                originalPos2_1 = new Vector3(ChildGameObject2_1.transform.position.x, ChildGameObject2_1.transform.position.y, ChildGameObject2_1.transform.position.z);
            }
            if (enemies2.transform.childCount >= 3)
            {
                originalPos2_2 = new Vector3(ChildGameObject2_2.transform.position.x, ChildGameObject2_2.transform.position.y, ChildGameObject2_2.transform.position.z);
            }
            if (enemies2.transform.childCount >= 4)
            {
                originalPos2_3 = new Vector3(ChildGameObject2_3.transform.position.x, ChildGameObject2_3.transform.position.y, ChildGameObject2_3.transform.position.z);
            }
            if (enemies2.transform.childCount >= 5)
            {
                originalPos2_4 = new Vector3(ChildGameObject2_4.transform.position.x, ChildGameObject2_4.transform.position.y, ChildGameObject2_4.transform.position.z);
            }
            if (enemies2.transform.childCount >= 6)
            {
                originalPos2_5 = new Vector3(ChildGameObject2_5.transform.position.x, ChildGameObject2_5.transform.position.y, ChildGameObject2_5.transform.position.z);
            }
            if (enemies2.transform.childCount >= 7)
            {
                originalPos2_6 = new Vector3(ChildGameObject2_6.transform.position.x, ChildGameObject2_6.transform.position.y, ChildGameObject2_6.transform.position.z);
            }
            if (enemies2.transform.childCount >= 8)
            {
                originalPos2_7 = new Vector3(ChildGameObject2_7.transform.position.x, ChildGameObject2_7.transform.position.y, ChildGameObject2_7.transform.position.z);
            }
            if (enemies2.transform.childCount >= 9)
            {
                originalPos2_8 = new Vector3(ChildGameObject2_8.transform.position.x, ChildGameObject2_8.transform.position.y, ChildGameObject2_8.transform.position.z);
            }
            if (enemies2.transform.childCount >= 10)
            {
                originalPos2_9 = new Vector3(ChildGameObject2_9.transform.position.x, ChildGameObject2_9.transform.position.y, ChildGameObject2_9.transform.position.z);
            }
        }
        if (enemies3 != null)
        {
            if (enemies3.transform.childCount >= 1)
            {
                originalPos3_0 = new Vector3(ChildGameObject3_0.transform.position.x, ChildGameObject3_0.transform.position.y, ChildGameObject3_0.transform.position.z);
            }
            if (enemies3.transform.childCount >= 2)
            {
                originalPos3_1 = new Vector3(ChildGameObject3_1.transform.position.x, ChildGameObject3_1.transform.position.y, ChildGameObject3_1.transform.position.z);
            }
            if (enemies3.transform.childCount >= 3)
            {
                originalPos3_2 = new Vector3(ChildGameObject3_2.transform.position.x, ChildGameObject3_2.transform.position.y, ChildGameObject3_2.transform.position.z);
            }
            if (enemies3.transform.childCount >= 4)
            {
                originalPos3_3 = new Vector3(ChildGameObject3_3.transform.position.x, ChildGameObject3_3.transform.position.y, ChildGameObject3_3.transform.position.z);
            }
            if (enemies3.transform.childCount >= 5)
            {
                originalPos3_4 = new Vector3(ChildGameObject3_4.transform.position.x, ChildGameObject3_4.transform.position.y, ChildGameObject3_4.transform.position.z);
            }
            if (enemies3.transform.childCount >= 6)
            {
                originalPos3_5 = new Vector3(ChildGameObject3_5.transform.position.x, ChildGameObject3_5.transform.position.y, ChildGameObject3_5.transform.position.z);
            }
            if (enemies3.transform.childCount >= 7)
            {
                originalPos3_6 = new Vector3(ChildGameObject3_6.transform.position.x, ChildGameObject3_6.transform.position.y, ChildGameObject3_6.transform.position.z);
            }
            if (enemies3.transform.childCount >= 8)
            {
                originalPos3_7 = new Vector3(ChildGameObject3_7.transform.position.x, ChildGameObject3_7.transform.position.y, ChildGameObject3_7.transform.position.z);
            }
            if (enemies3.transform.childCount >= 9)
            {
                originalPos3_8 = new Vector3(ChildGameObject3_8.transform.position.x, ChildGameObject3_8.transform.position.y, ChildGameObject3_8.transform.position.z);
            }
            if (enemies3.transform.childCount >= 10)
            {
                originalPos3_9 = new Vector3(ChildGameObject3_9.transform.position.x, ChildGameObject3_9.transform.position.y, ChildGameObject3_9.transform.position.z);
            }
        }
        if (enemies4 != null)
        {
            if (enemies4.transform.childCount >= 1)
            {
                originalPos4_0 = new Vector3(ChildGameObject4_0.transform.position.x, ChildGameObject4_0.transform.position.y, ChildGameObject4_0.transform.position.z);
            }
            if (enemies4.transform.childCount >= 2)
            {
                originalPos4_1 = new Vector3(ChildGameObject4_1.transform.position.x, ChildGameObject4_1.transform.position.y, ChildGameObject4_1.transform.position.z);
            }
            if (enemies4.transform.childCount >= 3)
            {
                originalPos4_2 = new Vector3(ChildGameObject4_2.transform.position.x, ChildGameObject4_2.transform.position.y, ChildGameObject4_2.transform.position.z);
            }
            if (enemies4.transform.childCount >= 4)
            {
                originalPos4_3 = new Vector3(ChildGameObject4_3.transform.position.x, ChildGameObject4_3.transform.position.y, ChildGameObject4_3.transform.position.z);
            }
            if (enemies4.transform.childCount >= 5)
            {
                originalPos4_4 = new Vector3(ChildGameObject4_4.transform.position.x, ChildGameObject4_4.transform.position.y, ChildGameObject4_4.transform.position.z);
            }
            if (enemies4.transform.childCount >= 6)
            {
                originalPos4_5 = new Vector3(ChildGameObject4_5.transform.position.x, ChildGameObject4_5.transform.position.y, ChildGameObject4_5.transform.position.z);
            }
            if (enemies4.transform.childCount >= 7)
            {
                originalPos4_6 = new Vector3(ChildGameObject4_6.transform.position.x, ChildGameObject4_6.transform.position.y, ChildGameObject4_6.transform.position.z);
            }
            if (enemies4.transform.childCount >= 8)
            {
                originalPos4_7 = new Vector3(ChildGameObject4_7.transform.position.x, ChildGameObject4_7.transform.position.y, ChildGameObject4_7.transform.position.z);
            }
            if (enemies4.transform.childCount >= 9)
            {
                originalPos4_8 = new Vector3(ChildGameObject4_8.transform.position.x, ChildGameObject4_8.transform.position.y, ChildGameObject4_8.transform.position.z);
            }
            if (enemies4.transform.childCount >= 10)
            {
                originalPos4_9 = new Vector3(ChildGameObject4_9.transform.position.x, ChildGameObject4_9.transform.position.y, ChildGameObject4_9.transform.position.z);
            }
        }
        if (enemies5 != null)
        {
            if (enemies5.transform.childCount >= 1)
            {
                originalPos5_0 = new Vector3(ChildGameObject5_0.transform.position.x, ChildGameObject5_0.transform.position.y, ChildGameObject5_0.transform.position.z);
            }
            if (enemies5.transform.childCount >= 2)
            {
                originalPos5_1 = new Vector3(ChildGameObject5_1.transform.position.x, ChildGameObject5_1.transform.position.y, ChildGameObject5_1.transform.position.z);
            }
            if (enemies5.transform.childCount >= 3)
            {
                originalPos5_2 = new Vector3(ChildGameObject5_2.transform.position.x, ChildGameObject5_2.transform.position.y, ChildGameObject5_2.transform.position.z);
            }
            if (enemies5.transform.childCount >= 4)
            {
                originalPos5_3 = new Vector3(ChildGameObject5_3.transform.position.x, ChildGameObject5_3.transform.position.y, ChildGameObject5_3.transform.position.z);
            }
            if (enemies5.transform.childCount >= 5)
            {
                originalPos5_4 = new Vector3(ChildGameObject5_4.transform.position.x, ChildGameObject5_4.transform.position.y, ChildGameObject5_4.transform.position.z);
            }
            if (enemies5.transform.childCount >= 6)
            {
                originalPos5_5 = new Vector3(ChildGameObject5_5.transform.position.x, ChildGameObject5_5.transform.position.y, ChildGameObject5_5.transform.position.z);
            }
            if (enemies5.transform.childCount >= 7)
            {
                originalPos5_6 = new Vector3(ChildGameObject5_6.transform.position.x, ChildGameObject5_6.transform.position.y, ChildGameObject5_6.transform.position.z);
            }
            if (enemies5.transform.childCount >= 8)
            {
                originalPos5_7 = new Vector3(ChildGameObject5_7.transform.position.x, ChildGameObject5_7.transform.position.y, ChildGameObject5_7.transform.position.z);
            }
            if (enemies5.transform.childCount >= 9)
            {
                originalPos5_8 = new Vector3(ChildGameObject5_8.transform.position.x, ChildGameObject5_8.transform.position.y, ChildGameObject5_8.transform.position.z);
            }
            if (enemies5.transform.childCount >= 10)
            {
                originalPos5_9 = new Vector3(ChildGameObject5_9.transform.position.x, ChildGameObject5_9.transform.position.y, ChildGameObject5_9.transform.position.z);
            }
        }
        //////////////
        if (easy1 != null)
        {
            if (easy1.transform.childCount >= 1)
            {
                originalPos1_0E = new Vector3(ChildGameObject1_0E.transform.position.x, ChildGameObject1_0E.transform.position.y, ChildGameObject1_0E.transform.position.z);
            }
            if (easy1.transform.childCount >= 2)
            {
                originalPos1_1E = new Vector3(ChildGameObject1_1E.transform.position.x, ChildGameObject1_1E.transform.position.y, ChildGameObject1_1E.transform.position.z);
            }
            if (easy1.transform.childCount >= 3)
            {
                originalPos1_2E = new Vector3(ChildGameObject1_2E.transform.position.x, ChildGameObject1_2E.transform.position.y, ChildGameObject1_2E.transform.position.z);
            }
            if (easy1.transform.childCount >= 4)
            {
                originalPos1_3E = new Vector3(ChildGameObject1_3E.transform.position.x, ChildGameObject1_3E.transform.position.y, ChildGameObject1_3E.transform.position.z);
            }
            if (easy1.transform.childCount >= 5)
            {
                originalPos1_4E = new Vector3(ChildGameObject1_4E.transform.position.x, ChildGameObject1_4E.transform.position.y, ChildGameObject1_4E.transform.position.z);
            }
        }
        if (easy2 != null)
        {
            if (easy2.transform.childCount >= 1)
            {
                originalPos2_0E = new Vector3(ChildGameObject2_0E.transform.position.x, ChildGameObject2_0E.transform.position.y, ChildGameObject2_0E.transform.position.z);
            }
            if (easy2.transform.childCount >= 2)
            {
                originalPos2_1E = new Vector3(ChildGameObject2_1E.transform.position.x, ChildGameObject2_1E.transform.position.y, ChildGameObject2_1E.transform.position.z);
            }
            if (easy2.transform.childCount >= 3)
            {
                originalPos2_2E = new Vector3(ChildGameObject2_2E.transform.position.x, ChildGameObject2_2E.transform.position.y, ChildGameObject2_2E.transform.position.z);
            }
            if (easy2.transform.childCount >= 4)
            {
                originalPos2_3E = new Vector3(ChildGameObject2_3E.transform.position.x, ChildGameObject2_3E.transform.position.y, ChildGameObject2_3E.transform.position.z);
            }
            if (easy2.transform.childCount >= 5)
            {
                originalPos2_4E = new Vector3(ChildGameObject2_4E.transform.position.x, ChildGameObject2_4E.transform.position.y, ChildGameObject2_4E.transform.position.z);
            }
        }
        if (easy3 != null)
        {
            if (easy3.transform.childCount >= 1)
            {
                originalPos3_0E = new Vector3(ChildGameObject3_0E.transform.position.x, ChildGameObject3_0E.transform.position.y, ChildGameObject3_0E.transform.position.z);
            }
            if (easy3.transform.childCount >= 2)
            {
                originalPos3_1E = new Vector3(ChildGameObject3_1E.transform.position.x, ChildGameObject3_1E.transform.position.y, ChildGameObject3_1E.transform.position.z);
            }
            if (easy3.transform.childCount >= 3)
            {
                originalPos3_2E = new Vector3(ChildGameObject3_2E.transform.position.x, ChildGameObject3_2E.transform.position.y, ChildGameObject3_2E.transform.position.z);
            }
            if (easy3.transform.childCount >= 4)
            {
                originalPos3_3E = new Vector3(ChildGameObject3_3E.transform.position.x, ChildGameObject3_3E.transform.position.y, ChildGameObject3_3E.transform.position.z);
            }
            if (easy3.transform.childCount >= 5)
            {
                originalPos3_4E = new Vector3(ChildGameObject3_4E.transform.position.x, ChildGameObject3_4E.transform.position.y, ChildGameObject3_4E.transform.position.z);
            }
        }
        if (easy4 != null)
        {
            if (easy4.transform.childCount >= 1)
            {
                originalPos4_0E = new Vector3(ChildGameObject4_0E.transform.position.x, ChildGameObject4_0E.transform.position.y, ChildGameObject4_0E.transform.position.z);
            }
            if (easy4.transform.childCount >= 2)
            {
                originalPos4_1E = new Vector3(ChildGameObject4_1E.transform.position.x, ChildGameObject4_1E.transform.position.y, ChildGameObject4_1E.transform.position.z);
            }
            if (easy4.transform.childCount >= 3)
            {
                originalPos4_2E = new Vector3(ChildGameObject4_2E.transform.position.x, ChildGameObject4_2E.transform.position.y, ChildGameObject4_2E.transform.position.z);
            }
            if (easy4.transform.childCount >= 4)
            {
                originalPos4_3E = new Vector3(ChildGameObject4_3E.transform.position.x, ChildGameObject4_3E.transform.position.y, ChildGameObject4_3E.transform.position.z);
            }
            if (easy4.transform.childCount >= 5)
            {
                originalPos4_4E = new Vector3(ChildGameObject4_4E.transform.position.x, ChildGameObject4_4E.transform.position.y, ChildGameObject4_4E.transform.position.z);
            }
        }
        if (easy5 != null)
        {
            if (easy5.transform.childCount >= 1)
            {
                originalPos5_0E = new Vector3(ChildGameObject5_0E.transform.position.x, ChildGameObject5_0E.transform.position.y, ChildGameObject5_0E.transform.position.z);
            }
            if (easy5.transform.childCount >= 2)
            {
                originalPos5_1E = new Vector3(ChildGameObject5_1E.transform.position.x, ChildGameObject5_1E.transform.position.y, ChildGameObject5_1E.transform.position.z);
            }
            if (easy5.transform.childCount >= 3)
            {
                originalPos5_2E = new Vector3(ChildGameObject5_2E.transform.position.x, ChildGameObject5_2E.transform.position.y, ChildGameObject5_2E.transform.position.z);
            }
            if (easy5.transform.childCount >= 4)
            {
                originalPos5_3E = new Vector3(ChildGameObject5_3E.transform.position.x, ChildGameObject5_3E.transform.position.y, ChildGameObject5_3E.transform.position.z);
            }
            if (easy5.transform.childCount >= 5)
            {
                originalPos5_4E = new Vector3(ChildGameObject5_4E.transform.position.x, ChildGameObject5_4E.transform.position.y, ChildGameObject5_4E.transform.position.z);
            }
        }
        if (normal1 != null)
        {
            if (normal1.transform.childCount >= 1)
            {
                originalPos1_0N = new Vector3(ChildGameObject1_0N.transform.position.x, ChildGameObject1_0N.transform.position.y, ChildGameObject1_0N.transform.position.z);
            }
            if (normal1.transform.childCount >= 2)
            {
                originalPos1_1N = new Vector3(ChildGameObject1_1N.transform.position.x, ChildGameObject1_1N.transform.position.y, ChildGameObject1_1N.transform.position.z);
            }
            if (normal1.transform.childCount >= 3)
            {
                originalPos1_2N = new Vector3(ChildGameObject1_2N.transform.position.x, ChildGameObject1_2N.transform.position.y, ChildGameObject1_2N.transform.position.z);
            }
            if (normal1.transform.childCount >= 4)
            {
                originalPos1_3N = new Vector3(ChildGameObject1_3N.transform.position.x, ChildGameObject1_3N.transform.position.y, ChildGameObject1_3N.transform.position.z);
            }
            if (normal1.transform.childCount >= 5)
            {
                originalPos1_4N = new Vector3(ChildGameObject1_4N.transform.position.x, ChildGameObject1_4N.transform.position.y, ChildGameObject1_4N.transform.position.z);
            }
        }
        if (normal2 != null)
        {
            if (normal2.transform.childCount >= 1)
            {
                originalPos2_0N = new Vector3(ChildGameObject2_0N.transform.position.x, ChildGameObject2_0N.transform.position.y, ChildGameObject2_0N.transform.position.z);
            }
            if (normal2.transform.childCount >= 2)
            {
                originalPos2_1N = new Vector3(ChildGameObject2_1N.transform.position.x, ChildGameObject2_1N.transform.position.y, ChildGameObject2_1N.transform.position.z);
            }
            if (normal2.transform.childCount >= 3)
            {
                originalPos2_2N = new Vector3(ChildGameObject2_2N.transform.position.x, ChildGameObject2_2N.transform.position.y, ChildGameObject2_2N.transform.position.z);
            }
            if (normal2.transform.childCount >= 4)
            {
                originalPos2_3N = new Vector3(ChildGameObject2_3N.transform.position.x, ChildGameObject2_3N.transform.position.y, ChildGameObject2_3N.transform.position.z);
            }
            if (normal2.transform.childCount >= 5)
            {
                originalPos2_4N = new Vector3(ChildGameObject2_4N.transform.position.x, ChildGameObject2_4N.transform.position.y, ChildGameObject2_4N.transform.position.z);
            }
        }
        if (normal3 != null)
        {
            if (normal3.transform.childCount >= 1)
            {
                originalPos3_0N = new Vector3(ChildGameObject3_0N.transform.position.x, ChildGameObject3_0N.transform.position.y, ChildGameObject3_0N.transform.position.z);
            }
            if (normal3.transform.childCount >= 2)
            {
                originalPos3_1N = new Vector3(ChildGameObject3_1N.transform.position.x, ChildGameObject3_1N.transform.position.y, ChildGameObject3_1N.transform.position.z);
            }
            if (normal3.transform.childCount >= 3)
            {
                originalPos3_2N = new Vector3(ChildGameObject3_2N.transform.position.x, ChildGameObject3_2N.transform.position.y, ChildGameObject3_2N.transform.position.z);
            }
            if (normal3.transform.childCount >= 4)
            {
                originalPos3_3N = new Vector3(ChildGameObject3_3N.transform.position.x, ChildGameObject3_3N.transform.position.y, ChildGameObject3_3N.transform.position.z);
            }
            if (normal3.transform.childCount >= 5)
            {
                originalPos3_4N = new Vector3(ChildGameObject3_4N.transform.position.x, ChildGameObject3_4N.transform.position.y, ChildGameObject3_4N.transform.position.z);
            }
        }
        if (normal4 != null)
        {
            if (normal4.transform.childCount >= 1)
            {
                originalPos4_0N = new Vector3(ChildGameObject4_0N.transform.position.x, ChildGameObject4_0N.transform.position.y, ChildGameObject4_0N.transform.position.z);
            }
            if (normal4.transform.childCount >= 2)
            {
                originalPos4_1N = new Vector3(ChildGameObject4_1N.transform.position.x, ChildGameObject4_1N.transform.position.y, ChildGameObject4_1N.transform.position.z);
            }
            if (normal4.transform.childCount >= 3)
            {
                originalPos4_2N = new Vector3(ChildGameObject4_2N.transform.position.x, ChildGameObject4_2N.transform.position.y, ChildGameObject4_2N.transform.position.z);
            }
            if (normal4.transform.childCount >= 4)
            {
                originalPos4_3N = new Vector3(ChildGameObject4_3N.transform.position.x, ChildGameObject4_3N.transform.position.y, ChildGameObject4_3N.transform.position.z);
            }
            if (normal4.transform.childCount >= 5)
            {
                originalPos4_4N = new Vector3(ChildGameObject4_4N.transform.position.x, ChildGameObject4_4N.transform.position.y, ChildGameObject4_4N.transform.position.z);
            }
        }
        if (normal5 != null)
        {
            if (normal5.transform.childCount >= 1)
            {
                originalPos5_0N = new Vector3(ChildGameObject5_0N.transform.position.x, ChildGameObject5_0.transform.position.y, ChildGameObject5_0.transform.position.z);
            }
            if (normal5.transform.childCount >= 2)
            {
                originalPos5_1N = new Vector3(ChildGameObject5_1N.transform.position.x, ChildGameObject5_1.transform.position.y, ChildGameObject5_1.transform.position.z);
            }
            if (normal5.transform.childCount >= 3)
            {
                originalPos5_2N = new Vector3(ChildGameObject5_2N.transform.position.x, ChildGameObject5_2.transform.position.y, ChildGameObject5_2.transform.position.z);
            }
            if (normal5.transform.childCount >= 4)
            {
                originalPos5_3N = new Vector3(ChildGameObject5_3N.transform.position.x, ChildGameObject5_3.transform.position.y, ChildGameObject5_3.transform.position.z);
            }
            if (normal5.transform.childCount >= 5)
            {
                originalPos5_4N = new Vector3(ChildGameObject5_4N.transform.position.x, ChildGameObject5_4.transform.position.y, ChildGameObject5_4.transform.position.z);
            }
        }

        if (ExtraChild1 != null)
        {
            originalPosEx1 = new Vector3(ExtraChild1.transform.position.x, ExtraChild1.transform.position.y, ExtraChild1.transform.position.z);
        }
        if (ExtraChild2 != null)
        {
            Debug.Log("shit");
            originalPosEx2 = new Vector3(ExtraChild2.transform.position.x, ExtraChild2.transform.position.y, ExtraChild2.transform.position.z);
        }
        if (ExtraChild3 != null)
        {
            originalPosEx3 = new Vector3(ExtraChild3.transform.position.x, ExtraChild3.transform.position.y, ExtraChild3.transform.position.z);
        }
        if (ExtraChild4 != null)
        {
            originalPosEx4 = new Vector3(ExtraChild4.transform.position.x, ExtraChild4.transform.position.y, ExtraChild4.transform.position.z);
        }
        if (ExtraChild5 != null)
        {
            originalPosEx5 = new Vector3(ExtraChild5.transform.position.x, ExtraChild5.transform.position.y, ExtraChild5.transform.position.z);
        }
    }

    public void EnemiesDisable()
    {
        GameObject Player = GameObject.Find("Player");
        player_script enemiesDissable = Player.GetComponent<player_script>();
        GameObject Camera = GameObject.Find("Main Camera");
        camera_script cameraChange = Camera.GetComponent<camera_script>();
        GameObject Master = GameObject.Find("MasterObject");
        master_script rowsAndColumnsReference = Master.GetComponent<master_script>();

        if (ExtraChild1 != null) // for boomerangs
        {
            ExtraChild1 = ExtraParent1.transform.GetChild(0).gameObject;
            ExtraChild1.transform.position = originalPosEx1;
        }

        //Disable enemies that are not in the current room
        if (enemiesDissable.roomOfMap == 1)
        {
            rowsAndColumnsReference.levelColumns = rowsAndColumnsReference.levelColumns1;
            rowsAndColumnsReference.levelRows = rowsAndColumnsReference.levelRows1;
            cameraChange.cameraMove = 101;
            if (enemies1 != null)
            {
                enemies1.SetActive(true);
                if (enemies1.transform.childCount >= 1)
                {
                    ChildGameObject1_0 = enemies1.transform.GetChild(0).gameObject;
                    ChildGameObject1_0.SetActive(true);
                    ChildGameObject1_0.transform.position = originalPos1_0;
                }
                if (enemies1.transform.childCount >= 2)
                {
                    ChildGameObject1_1 = enemies1.transform.GetChild(1).gameObject;
                    ChildGameObject1_1.SetActive(true);
                    ChildGameObject1_1.transform.position = originalPos1_1;
                }
                if (enemies1.transform.childCount >= 3)
                {
                    ChildGameObject1_2 = enemies1.transform.GetChild(2).gameObject;
                    ChildGameObject1_2.SetActive(true);
                    ChildGameObject1_2.transform.position = originalPos1_2;
                }
                if (enemies1.transform.childCount >= 4)
                {
                    ChildGameObject1_3 = enemies1.transform.GetChild(3).gameObject;
                    ChildGameObject1_3.SetActive(true);
                    ChildGameObject1_3.transform.position = originalPos1_3;
                }
                if (enemies1.transform.childCount >= 5)
                {
                    ChildGameObject1_4 = enemies1.transform.GetChild(4).gameObject;
                    ChildGameObject1_4.SetActive(true);
                    ChildGameObject1_4.transform.position = originalPos1_4;
                }
                if (enemies1.transform.childCount >= 6)
                {
                    ChildGameObject1_5 = enemies1.transform.GetChild(5).gameObject;
                    ChildGameObject1_5.SetActive(true);
                    ChildGameObject1_5.transform.position = originalPos1_5;
                }
                if (enemies1.transform.childCount >= 7)
                {
                    ChildGameObject1_6 = enemies1.transform.GetChild(6).gameObject;
                    ChildGameObject1_6.SetActive(true);
                    ChildGameObject1_6.transform.position = originalPos1_6;
                }
                if (enemies1.transform.childCount >= 8)
                {
                    ChildGameObject1_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject1_7.SetActive(true);
                    ChildGameObject1_7.transform.position = originalPos1_7;
                }
                if (enemies1.transform.childCount >= 9)
                {
                    ChildGameObject1_8 = enemies1.transform.GetChild(8).gameObject;
                    ChildGameObject1_8.SetActive(true);
                    ChildGameObject1_8.transform.position = originalPos1_8;
                }
                if (enemies1.transform.childCount >= 10)
                {
                    ChildGameObject1_9 = enemies1.transform.GetChild(9).gameObject;
                    ChildGameObject1_9.SetActive(true);
                    ChildGameObject1_9.transform.position = originalPos1_9;
                }
                if (enemies1.transform.childCount >= 11)
                {
                    ChildGameObject1_10 = enemies1.transform.GetChild(10).gameObject;
                    ChildGameObject1_10.SetActive(true);
                    ChildGameObject1_10.transform.position = originalPos1_10;
                }
                if (enemies1.transform.childCount >= 12)
                {
                    ChildGameObject1_11 = enemies1.transform.GetChild(11).gameObject;
                    ChildGameObject1_11.SetActive(true);
                    ChildGameObject1_11.transform.position = originalPos1_11;
                }
            }
            if (enemies2 != null)
            {
                enemies2.SetActive(false);
                if (enemies2.transform.childCount >= 1)
                {
                    ChildGameObject2_0 = enemies2.transform.GetChild(0).gameObject;
                    ChildGameObject2_0.SetActive(false);
                }
                if (enemies2.transform.childCount >= 2)
                {
                    ChildGameObject2_1 = enemies2.transform.GetChild(1).gameObject;
                    ChildGameObject2_1.SetActive(false);
                }
                if (enemies2.transform.childCount >= 3)
                {
                    ChildGameObject2_2 = enemies2.transform.GetChild(2).gameObject;
                    ChildGameObject2_2.SetActive(false);
                }
                if (enemies2.transform.childCount >= 4)
                {
                    ChildGameObject2_3 = enemies2.transform.GetChild(3).gameObject;
                    ChildGameObject2_3.SetActive(false);
                }
                if (enemies2.transform.childCount >= 5)
                {
                    ChildGameObject2_4 = enemies2.transform.GetChild(4).gameObject;
                    ChildGameObject2_4.SetActive(false);
                }
                if (enemies2.transform.childCount >= 6)
                {
                    ChildGameObject2_5 = enemies2.transform.GetChild(5).gameObject;
                    ChildGameObject2_5.SetActive(false);
                }
                if (enemies2.transform.childCount >= 7)
                {
                    ChildGameObject2_6 = enemies2.transform.GetChild(6).gameObject;
                    ChildGameObject2_6.SetActive(false);
                }
                if (enemies2.transform.childCount >= 8)
                {
                    ChildGameObject2_7 = enemies2.transform.GetChild(7).gameObject;
                    ChildGameObject2_7.SetActive(false);
                }
                if (enemies2.transform.childCount >= 9)
                {
                    ChildGameObject2_8 = enemies2.transform.GetChild(8).gameObject;
                    ChildGameObject2_8.SetActive(false);
                }
                if (enemies2.transform.childCount >= 10)
                {
                    ChildGameObject2_9 = enemies2.transform.GetChild(9).gameObject;
                    ChildGameObject2_9.SetActive(false);
                }
            }
            if (enemies3 != null)
            {
                enemies3.SetActive(false);
                if (enemies3.transform.childCount >= 1)
                {
                    ChildGameObject3_0 = enemies3.transform.GetChild(0).gameObject;
                    ChildGameObject3_0.SetActive(false);
                }
                if (enemies3.transform.childCount >= 2)
                {
                    ChildGameObject3_1 = enemies3.transform.GetChild(1).gameObject;
                    ChildGameObject3_1.SetActive(false);
                }
                if (enemies3.transform.childCount >= 3)
                {
                    ChildGameObject3_2 = enemies3.transform.GetChild(2).gameObject;
                    ChildGameObject3_2.SetActive(false);
                }
                if (enemies3.transform.childCount >= 4)
                {
                    ChildGameObject3_3 = enemies3.transform.GetChild(3).gameObject;
                    ChildGameObject3_3.SetActive(false);
                }
                if (enemies3.transform.childCount >= 5)
                {
                    ChildGameObject3_4 = enemies3.transform.GetChild(4).gameObject;
                    ChildGameObject3_4.SetActive(false);
                }
                if (enemies3.transform.childCount >= 6)
                {
                    ChildGameObject3_5 = enemies3.transform.GetChild(5).gameObject;
                    ChildGameObject3_5.SetActive(false);
                }
                if (enemies3.transform.childCount >= 7)
                {
                    ChildGameObject3_6 = enemies3.transform.GetChild(6).gameObject;
                    ChildGameObject3_6.SetActive(false);
                }
                if (enemies3.transform.childCount >= 8)
                {
                    ChildGameObject3_7 = enemies3.transform.GetChild(7).gameObject;
                    ChildGameObject3_7.SetActive(false);
                }
                if (enemies3.transform.childCount >= 9)
                {
                    ChildGameObject3_8 = enemies3.transform.GetChild(8).gameObject;
                    ChildGameObject3_8.SetActive(false);
                }
                if (enemies3.transform.childCount >= 10)
                {
                    ChildGameObject3_9 = enemies3.transform.GetChild(9).gameObject;
                    ChildGameObject3_9.SetActive(false);
                }
            }
            if (enemies4 != null)
            {
                enemies4.SetActive(false);
                if (enemies4.transform.childCount >= 1)
                {
                    ChildGameObject4_0 = enemies4.transform.GetChild(0).gameObject;
                    ChildGameObject4_0.SetActive(false);
                }
                if (enemies4.transform.childCount >= 2)
                {
                    ChildGameObject4_1 = enemies4.transform.GetChild(1).gameObject;
                    ChildGameObject4_1.SetActive(false);
                }
                if (enemies4.transform.childCount >= 3)
                {
                    ChildGameObject4_2 = enemies4.transform.GetChild(2).gameObject;
                    ChildGameObject4_2.SetActive(false);
                }
                if (enemies4.transform.childCount >= 4)
                {
                    ChildGameObject4_3 = enemies4.transform.GetChild(3).gameObject;
                    ChildGameObject4_3.SetActive(false);
                }
                if (enemies4.transform.childCount >= 5)
                {
                    ChildGameObject4_4 = enemies4.transform.GetChild(4).gameObject;
                    ChildGameObject4_4.SetActive(false);
                }
                if (enemies4.transform.childCount >= 6)
                {
                    ChildGameObject4_5 = enemies4.transform.GetChild(5).gameObject;
                    ChildGameObject4_5.SetActive(false);
                }
                if (enemies4.transform.childCount >= 7)
                {
                    ChildGameObject4_6 = enemies4.transform.GetChild(6).gameObject;
                    ChildGameObject4_6.SetActive(false);
                }
                if (enemies4.transform.childCount >= 8)
                {
                    ChildGameObject4_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject4_7.SetActive(false);
                }
                if (enemies4.transform.childCount >= 9)
                {
                    ChildGameObject4_8 = enemies4.transform.GetChild(8).gameObject;
                    ChildGameObject4_8.SetActive(false);
                }
                if (enemies4.transform.childCount >= 10)
                {
                    ChildGameObject4_9 = enemies4.transform.GetChild(9).gameObject;
                    ChildGameObject4_9.SetActive(false);
                }
            }
            if (enemies5 != null)
            {
                enemies5.SetActive(false);
                if (enemies5.transform.childCount >= 1)
                {
                    ChildGameObject5_0 = enemies5.transform.GetChild(0).gameObject;
                    ChildGameObject5_0.SetActive(false);
                }
                if (enemies5.transform.childCount >= 2)
                {
                    ChildGameObject5_1 = enemies5.transform.GetChild(1).gameObject;
                    ChildGameObject5_1.SetActive(false);
                }
                if (enemies5.transform.childCount >= 3)
                {
                    ChildGameObject5_2 = enemies5.transform.GetChild(2).gameObject;
                    ChildGameObject5_2.SetActive(false);
                }
                if (enemies5.transform.childCount >= 4)
                {
                    ChildGameObject5_3 = enemies5.transform.GetChild(3).gameObject;
                    ChildGameObject5_3.SetActive(false);
                }
                if (enemies5.transform.childCount >= 5)
                {
                    ChildGameObject5_4 = enemies5.transform.GetChild(4).gameObject;
                    ChildGameObject5_4.SetActive(false);
                }
                if (enemies5.transform.childCount >= 6)
                {
                    ChildGameObject5_5 = enemies5.transform.GetChild(5).gameObject;
                    ChildGameObject5_5.SetActive(false);
                }
                if (enemies5.transform.childCount >= 7)
                {
                    ChildGameObject5_6 = enemies5.transform.GetChild(6).gameObject;
                    ChildGameObject5_6.SetActive(false);
                }
                if (enemies5.transform.childCount >= 8)
                {
                    ChildGameObject5_7 = enemies5.transform.GetChild(7).gameObject;
                    ChildGameObject5_7.SetActive(false);
                }
                if (enemies5.transform.childCount >= 9)
                {
                    ChildGameObject5_8 = enemies5.transform.GetChild(8).gameObject;
                    ChildGameObject5_8.SetActive(false);
                }
                if (enemies5.transform.childCount >= 10)
                {
                    ChildGameObject5_9 = enemies5.transform.GetChild(9).gameObject;
                    ChildGameObject5_9.SetActive(false);
                }
            }

            if (GameObject.Find("SceneUnlocker") != null)
            {


                if (difficultyReference.difficulty == 1)
                {
                    if (easy1 != null)
                    {
                        easy1.SetActive(true);
                        if (easy1.transform.childCount >= 1)
                        {
                            ChildGameObject1_0E = easy1.transform.GetChild(0).gameObject;
                            ChildGameObject1_0E.SetActive(true);
                            ChildGameObject1_0E.transform.position = originalPos1_0E;
                        }
                        if (easy1.transform.childCount >= 2)
                        {
                            ChildGameObject1_1E = easy1.transform.GetChild(1).gameObject;
                            ChildGameObject1_1E.SetActive(true);
                            ChildGameObject1_1E.transform.position = originalPos1_1E;
                        }
                        if (easy1.transform.childCount >= 3)
                        {
                            ChildGameObject1_2E = easy1.transform.GetChild(2).gameObject;
                            ChildGameObject1_2E.SetActive(true);
                            ChildGameObject1_2E.transform.position = originalPos1_2E;
                        }
                        if (easy1.transform.childCount >= 4)
                        {
                            ChildGameObject1_3E = easy1.transform.GetChild(3).gameObject;
                            ChildGameObject1_3E.SetActive(true);
                            ChildGameObject1_3E.transform.position = originalPos1_3E;
                        }
                        if (easy1.transform.childCount >= 5)
                        {
                            ChildGameObject1_4E = easy1.transform.GetChild(4).gameObject;
                            ChildGameObject1_4E.SetActive(true);
                            ChildGameObject1_4E.transform.position = originalPos1_4E;
                        }
                    }
                    if (easy2 != null)
                    {
                        easy2.SetActive(false);
                        if (easy2.transform.childCount >= 1)
                        {
                            ChildGameObject2_0E = easy2.transform.GetChild(0).gameObject;
                            ChildGameObject2_0E.SetActive(false);
                            ChildGameObject2_0E.transform.position = originalPos2_0E;
                        }
                        if (easy2.transform.childCount >= 2)
                        {
                            ChildGameObject2_1E = easy2.transform.GetChild(1).gameObject;
                            ChildGameObject2_1E.SetActive(false);
                            ChildGameObject2_1E.transform.position = originalPos2_1E;
                        }
                        if (easy2.transform.childCount >= 3)
                        {
                            ChildGameObject2_2E = easy2.transform.GetChild(2).gameObject;
                            ChildGameObject2_2E.SetActive(false);
                            ChildGameObject2_2E.transform.position = originalPos2_2E;
                        }
                        if (easy2.transform.childCount >= 4)
                        {
                            ChildGameObject2_3E = easy2.transform.GetChild(3).gameObject;
                            ChildGameObject2_3E.SetActive(false);
                            ChildGameObject2_3E.transform.position = originalPos2_3E;
                        }
                        if (easy2.transform.childCount >= 5)
                        {
                            ChildGameObject2_4E = easy2.transform.GetChild(4).gameObject;
                            ChildGameObject2_4E.SetActive(false);
                            ChildGameObject2_4E.transform.position = originalPos2_4E;
                        }
                    }
                    if (easy3 != null)
                    {
                        easy3.SetActive(false);
                        if (easy3.transform.childCount >= 1)
                        {
                            ChildGameObject3_0E = easy3.transform.GetChild(0).gameObject;
                            ChildGameObject3_0E.SetActive(false);
                            ChildGameObject3_0E.transform.position = originalPos3_0E;
                        }
                        if (easy3.transform.childCount >= 2)
                        {
                            ChildGameObject3_1E = easy3.transform.GetChild(1).gameObject;
                            ChildGameObject3_1E.SetActive(false);
                            ChildGameObject3_1E.transform.position = originalPos3_1E;
                        }
                        if (easy3.transform.childCount >= 3)
                        {
                            ChildGameObject3_2E = easy3.transform.GetChild(2).gameObject;
                            ChildGameObject3_2E.SetActive(false);
                            ChildGameObject3_2E.transform.position = originalPos3_2E;
                        }
                        if (easy3.transform.childCount >= 4)
                        {
                            ChildGameObject3_3E = easy3.transform.GetChild(3).gameObject;
                            ChildGameObject3_3E.SetActive(false);
                            ChildGameObject3_3E.transform.position = originalPos3_3E;
                        }
                        if (easy3.transform.childCount >= 5)
                        {
                            ChildGameObject3_4E = easy3.transform.GetChild(4).gameObject;
                            ChildGameObject3_4E.SetActive(false);
                            ChildGameObject3_4E.transform.position = originalPos3_4E;
                        }
                    }
                    if (easy4 != null)
                    {
                        easy1.SetActive(false);
                        if (easy4.transform.childCount >= 1)
                        {
                            ChildGameObject4_0E = easy4.transform.GetChild(0).gameObject;
                            ChildGameObject4_0E.SetActive(false);
                            ChildGameObject4_0E.transform.position = originalPos4_0E;
                        }
                        if (easy4.transform.childCount >= 2)
                        {
                            ChildGameObject4_1E = easy4.transform.GetChild(1).gameObject;
                            ChildGameObject4_1E.SetActive(false);
                            ChildGameObject4_1E.transform.position = originalPos4_1E;
                        }
                        if (easy4.transform.childCount >= 3)
                        {
                            ChildGameObject4_2E = easy4.transform.GetChild(2).gameObject;
                            ChildGameObject4_2E.SetActive(false);
                            ChildGameObject4_2E.transform.position = originalPos4_2E;
                        }
                        if (easy4.transform.childCount >= 4)
                        {
                            ChildGameObject4_3E = easy4.transform.GetChild(3).gameObject;
                            ChildGameObject4_3E.SetActive(false);
                            ChildGameObject4_3E.transform.position = originalPos4_3E;
                        }
                        if (easy4.transform.childCount >= 5)
                        {
                            ChildGameObject4_4E = easy4.transform.GetChild(4).gameObject;
                            ChildGameObject4_4E.SetActive(false);
                            ChildGameObject4_4E.transform.position = originalPos4_4E;
                        }
                    }
                    if (easy5 != null)
                    {
                        easy5.SetActive(false);
                        if (easy5.transform.childCount >= 1)
                        {
                            ChildGameObject5_0E = easy5.transform.GetChild(0).gameObject;
                            ChildGameObject5_0E.SetActive(false);
                            ChildGameObject5_0E.transform.position = originalPos5_0E;
                        }
                        if (easy5.transform.childCount >= 2)
                        {
                            ChildGameObject5_1E = easy5.transform.GetChild(1).gameObject;
                            ChildGameObject5_1E.SetActive(false);
                            ChildGameObject5_1E.transform.position = originalPos5_1E;
                        }
                        if (easy5.transform.childCount >= 3)
                        {
                            ChildGameObject5_2E = easy5.transform.GetChild(2).gameObject;
                            ChildGameObject5_2E.SetActive(false);
                            ChildGameObject5_2E.transform.position = originalPos5_2E;
                        }
                        if (easy5.transform.childCount >= 4)
                        {
                            ChildGameObject5_3E = easy5.transform.GetChild(3).gameObject;
                            ChildGameObject5_3E.SetActive(false);
                            ChildGameObject5_3E.transform.position = originalPos5_3E;
                        }
                        if (easy5.transform.childCount >= 5)
                        {
                            ChildGameObject5_4E = easy5.transform.GetChild(4).gameObject;
                            ChildGameObject5_4E.SetActive(false);
                            ChildGameObject5_4E.transform.position = originalPos5_4E;
                        }
                    }
                }
                if (difficultyReference.difficulty == 2)
                {
                    if (normal1 != null)
                    {
                        normal1.SetActive(true);
                        if (normal1.transform.childCount >= 1)
                        {
                            ChildGameObject1_0N = normal1.transform.GetChild(0).gameObject;
                            ChildGameObject1_0N.SetActive(true);
                            ChildGameObject1_0N.transform.position = originalPos1_0N;
                        }
                        if (normal1.transform.childCount >= 2)
                        {
                            ChildGameObject1_1N = normal1.transform.GetChild(1).gameObject;
                            ChildGameObject1_1N.SetActive(true);
                            ChildGameObject1_1N.transform.position = originalPos1_1N;
                        }
                        if (normal1.transform.childCount >= 3)
                        {
                            ChildGameObject1_2N = normal1.transform.GetChild(2).gameObject;
                            ChildGameObject1_2N.SetActive(true);
                            ChildGameObject1_2N.transform.position = originalPos1_2N;
                        }
                        if (normal1.transform.childCount >= 4)
                        {
                            ChildGameObject1_3N = normal1.transform.GetChild(3).gameObject;
                            ChildGameObject1_3N.SetActive(true);
                            ChildGameObject1_3N.transform.position = originalPos1_3N;
                        }
                        if (normal1.transform.childCount >= 5)
                        {
                            ChildGameObject1_4N = normal1.transform.GetChild(4).gameObject;
                            ChildGameObject1_4N.SetActive(true);
                            ChildGameObject1_4N.transform.position = originalPos1_4N;
                        }
                    }
                    if (normal2 != null)
                    {
                        normal2.SetActive(false);
                        if (normal2.transform.childCount >= 1)
                        {
                            ChildGameObject2_0N = normal2.transform.GetChild(0).gameObject;
                            ChildGameObject2_0N.SetActive(false);
                            ChildGameObject2_0N.transform.position = originalPos2_0N;
                        }
                        if (normal2.transform.childCount >= 2)
                        {
                            ChildGameObject2_1N = normal2.transform.GetChild(1).gameObject;
                            ChildGameObject2_1N.SetActive(false);
                            ChildGameObject2_1N.transform.position = originalPos2_1N;
                        }
                        if (normal2.transform.childCount >= 3)
                        {
                            ChildGameObject2_2N = normal2.transform.GetChild(2).gameObject;
                            ChildGameObject2_2N.SetActive(false);
                            ChildGameObject2_2N.transform.position = originalPos2_2N;
                        }
                        if (normal2.transform.childCount >= 4)
                        {
                            ChildGameObject2_3N = normal2.transform.GetChild(3).gameObject;
                            ChildGameObject2_3N.SetActive(false);
                            ChildGameObject2_3N.transform.position = originalPos2_3N;
                        }
                        if (normal2.transform.childCount >= 5)
                        {
                            ChildGameObject2_4N = normal2.transform.GetChild(4).gameObject;
                            ChildGameObject2_4N.SetActive(false);
                            ChildGameObject2_4N.transform.position = originalPos2_4N;
                        }
                    }
                    if (normal3 != null)
                    {
                        normal3.SetActive(false);
                        if (normal3.transform.childCount >= 1)
                        {
                            ChildGameObject3_0N = normal3.transform.GetChild(0).gameObject;
                            ChildGameObject3_0N.SetActive(false);
                            ChildGameObject3_0N.transform.position = originalPos3_0N;
                        }
                        if (normal3.transform.childCount >= 2)
                        {
                            ChildGameObject3_1N = normal3.transform.GetChild(1).gameObject;
                            ChildGameObject3_1N.SetActive(false);
                            ChildGameObject3_1N.transform.position = originalPos3_1N;
                        }
                        if (normal3.transform.childCount >= 3)
                        {
                            ChildGameObject3_2N = normal3.transform.GetChild(2).gameObject;
                            ChildGameObject3_2N.SetActive(false);
                            ChildGameObject3_2N.transform.position = originalPos3_2N;
                        }
                        if (normal3.transform.childCount >= 4)
                        {
                            ChildGameObject3_3N = normal3.transform.GetChild(3).gameObject;
                            ChildGameObject3_3N.SetActive(false);
                            ChildGameObject3_3N.transform.position = originalPos3_3N;
                        }
                        if (normal3.transform.childCount >= 5)
                        {
                            ChildGameObject3_4N = normal3.transform.GetChild(4).gameObject;
                            ChildGameObject3_4N.SetActive(false);
                            ChildGameObject3_4N.transform.position = originalPos3_4N;
                        }
                    }
                    if (normal4 != null)
                    {
                        normal1.SetActive(false);
                        if (normal4.transform.childCount >= 1)
                        {
                            ChildGameObject4_0N = normal4.transform.GetChild(0).gameObject;
                            ChildGameObject4_0N.SetActive(false);
                            ChildGameObject4_0N.transform.position = originalPos4_0N;
                        }
                        if (normal4.transform.childCount >= 2)
                        {
                            ChildGameObject4_1N = normal4.transform.GetChild(1).gameObject;
                            ChildGameObject4_1N.SetActive(false);
                            ChildGameObject4_1N.transform.position = originalPos4_1N;
                        }
                        if (normal4.transform.childCount >= 3)
                        {
                            ChildGameObject4_2N = normal4.transform.GetChild(2).gameObject;
                            ChildGameObject4_2N.SetActive(false);
                            ChildGameObject4_2N.transform.position = originalPos4_2N;
                        }
                        if (normal4.transform.childCount >= 4)
                        {
                            ChildGameObject4_3N = normal4.transform.GetChild(3).gameObject;
                            ChildGameObject4_3N.SetActive(false);
                            ChildGameObject4_3N.transform.position = originalPos4_3N;
                        }
                        if (normal4.transform.childCount >= 5)
                        {
                            ChildGameObject4_4N = normal4.transform.GetChild(4).gameObject;
                            ChildGameObject4_4N.SetActive(false);
                            ChildGameObject4_4N.transform.position = originalPos4_4N;
                        }
                    }
                    if (normal5 != null)
                    {
                        normal5.SetActive(false);
                        if (normal5.transform.childCount >= 1)
                        {
                            ChildGameObject5_0N = normal5.transform.GetChild(0).gameObject;
                            ChildGameObject5_0N.SetActive(false);
                            ChildGameObject5_0N.transform.position = originalPos5_0N;
                        }
                        if (normal5.transform.childCount >= 2)
                        {
                            ChildGameObject5_1N = normal5.transform.GetChild(1).gameObject;
                            ChildGameObject5_1N.SetActive(false);
                            ChildGameObject5_1N.transform.position = originalPos5_1N;
                        }
                        if (normal5.transform.childCount >= 3)
                        {
                            ChildGameObject5_2N = normal5.transform.GetChild(2).gameObject;
                            ChildGameObject5_2N.SetActive(false);
                            ChildGameObject5_2N.transform.position = originalPos5_2N;
                        }
                        if (normal5.transform.childCount >= 4)
                        {
                            ChildGameObject5_3N = normal5.transform.GetChild(3).gameObject;
                            ChildGameObject5_3N.SetActive(false);
                            ChildGameObject5_3N.transform.position = originalPos5_3N;
                        }
                        if (normal5.transform.childCount >= 5)
                        {
                            ChildGameObject5_4N = normal5.transform.GetChild(4).gameObject;
                            ChildGameObject5_4N.SetActive(false);
                            ChildGameObject5_4N.transform.position = originalPos5_4N;
                        }
                    }
                }

            }

        }

        if (enemiesDissable.roomOfMap == 2)
        {
            rowsAndColumnsReference.levelColumns = rowsAndColumnsReference.levelColumns2;
            rowsAndColumnsReference.levelRows = rowsAndColumnsReference.levelRows2;
            cameraChange.cameraMove = 102;

            if (enemies1 != null)
            {
                enemies1.SetActive(false);
                if (enemies1.transform.childCount >= 1)
                {
                    ChildGameObject1_0 = enemies1.transform.GetChild(0).gameObject;
                    ChildGameObject1_0.SetActive(false);
                }
                if (enemies1.transform.childCount >= 2)
                {
                    ChildGameObject1_1 = enemies1.transform.GetChild(1).gameObject;
                    ChildGameObject1_1.SetActive(false);
                }
                if (enemies1.transform.childCount >= 3)
                {
                    ChildGameObject1_2 = enemies1.transform.GetChild(2).gameObject;
                    ChildGameObject1_2.SetActive(false);
                }
                if (enemies1.transform.childCount >= 4)
                {
                    ChildGameObject1_3 = enemies1.transform.GetChild(3).gameObject;
                    ChildGameObject1_3.SetActive(false);
                }
                if (enemies1.transform.childCount >= 5)
                {
                    ChildGameObject1_4 = enemies1.transform.GetChild(4).gameObject;
                    ChildGameObject1_4.SetActive(false);
                }
                if (enemies1.transform.childCount >= 6)
                {
                    ChildGameObject1_5 = enemies1.transform.GetChild(5).gameObject;
                    ChildGameObject1_5.SetActive(false);
                }
                if (enemies1.transform.childCount >= 7)
                {
                    ChildGameObject1_6 = enemies1.transform.GetChild(6).gameObject;
                    ChildGameObject1_6.SetActive(false);
                }
                if (enemies1.transform.childCount >= 8)
                {
                    ChildGameObject1_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject1_7.SetActive(false);
                }
                if (enemies1.transform.childCount >= 9)
                {
                    ChildGameObject1_8 = enemies1.transform.GetChild(8).gameObject;
                    ChildGameObject1_8.SetActive(false);
                }
                if (enemies1.transform.childCount >= 10)
                {
                    ChildGameObject1_9 = enemies1.transform.GetChild(9).gameObject;
                    ChildGameObject1_9.SetActive(false);
                }
                if (enemies1.transform.childCount >= 11)
                {
                    ChildGameObject1_10 = enemies1.transform.GetChild(10).gameObject;
                    ChildGameObject1_10.SetActive(false);
                }
                if (enemies1.transform.childCount >= 12)
                {
                    ChildGameObject1_11 = enemies1.transform.GetChild(11).gameObject;
                    ChildGameObject1_11.SetActive(false);
                }
            }
            if (enemies2 != null)
            {
                enemies2.SetActive(true);
                if (enemies2.transform.childCount >= 1)
                {
                    ChildGameObject2_0 = enemies2.transform.GetChild(0).gameObject;
                    ChildGameObject2_0.SetActive(true);
                    ChildGameObject2_0.transform.position = originalPos2_0;
                }
                if (enemies2.transform.childCount >= 2)
                {
                    ChildGameObject2_1 = enemies2.transform.GetChild(1).gameObject;
                    ChildGameObject2_1.SetActive(true);
                    ChildGameObject2_1.transform.position = originalPos2_1;
                }
                if (enemies2.transform.childCount >= 3)
                {
                    ChildGameObject2_2 = enemies2.transform.GetChild(2).gameObject;
                    ChildGameObject2_2.SetActive(true);
                    ChildGameObject2_2.transform.position = originalPos2_2;
                }
                if (enemies2.transform.childCount >= 4)
                {
                    ChildGameObject2_3 = enemies2.transform.GetChild(3).gameObject;
                    ChildGameObject2_3.SetActive(true);
                    ChildGameObject2_3.transform.position = originalPos2_3;
                }
                if (enemies2.transform.childCount >= 5)
                {
                    ChildGameObject2_4 = enemies2.transform.GetChild(4).gameObject;
                    ChildGameObject2_4.SetActive(true);
                    ChildGameObject2_4.transform.position = originalPos2_4;
                }
                if (enemies2.transform.childCount >= 6)
                {
                    ChildGameObject2_5 = enemies2.transform.GetChild(5).gameObject;
                    ChildGameObject2_5.SetActive(true);
                    ChildGameObject2_5.transform.position = originalPos2_5;
                }
                if (enemies2.transform.childCount >= 7)
                {
                    ChildGameObject2_6 = enemies2.transform.GetChild(6).gameObject;
                    ChildGameObject2_6.SetActive(true);
                    ChildGameObject2_6.transform.position = originalPos2_6;
                }
                if (enemies2.transform.childCount >= 8)
                {
                    ChildGameObject2_7 = enemies2.transform.GetChild(7).gameObject;
                    ChildGameObject2_7.SetActive(true);
                    ChildGameObject2_7.transform.position = originalPos2_7;
                }
                if (enemies2.transform.childCount >= 9)
                {
                    ChildGameObject2_8 = enemies2.transform.GetChild(8).gameObject;
                    ChildGameObject2_8.SetActive(true);
                    ChildGameObject2_8.transform.position = originalPos2_8;
                }
                if (enemies2.transform.childCount >= 10)
                {
                    ChildGameObject2_9 = enemies2.transform.GetChild(9).gameObject;
                    ChildGameObject2_9.SetActive(true);
                    ChildGameObject2_9.transform.position = originalPos2_9;
                }
            }
            if (enemies3 != null)
            {
                enemies3.SetActive(false);
                if (enemies3.transform.childCount >= 1)
                {
                    ChildGameObject3_0 = enemies3.transform.GetChild(0).gameObject;
                    ChildGameObject3_0.SetActive(false);
                }
                if (enemies3.transform.childCount >= 2)
                {
                    ChildGameObject3_1 = enemies3.transform.GetChild(1).gameObject;
                    ChildGameObject3_1.SetActive(false);
                }
                if (enemies3.transform.childCount >= 3)
                {
                    ChildGameObject3_2 = enemies3.transform.GetChild(2).gameObject;
                    ChildGameObject3_2.SetActive(false);
                }
                if (enemies3.transform.childCount >= 4)
                {
                    ChildGameObject3_3 = enemies3.transform.GetChild(3).gameObject;
                    ChildGameObject3_3.SetActive(false);
                }
                if (enemies3.transform.childCount >= 5)
                {
                    ChildGameObject3_4 = enemies3.transform.GetChild(4).gameObject;
                    ChildGameObject3_4.SetActive(false);
                }
                if (enemies3.transform.childCount >= 6)
                {
                    ChildGameObject3_5 = enemies3.transform.GetChild(5).gameObject;
                    ChildGameObject3_5.SetActive(false);
                }
                if (enemies3.transform.childCount >= 7)
                {
                    ChildGameObject3_6 = enemies3.transform.GetChild(6).gameObject;
                    ChildGameObject3_6.SetActive(false);
                }
                if (enemies3.transform.childCount >= 8)
                {
                    ChildGameObject3_7 = enemies3.transform.GetChild(7).gameObject;
                    ChildGameObject3_7.SetActive(false);
                }
                if (enemies3.transform.childCount >= 9)
                {
                    ChildGameObject3_8 = enemies3.transform.GetChild(8).gameObject;
                    ChildGameObject3_8.SetActive(false);
                }
                if (enemies3.transform.childCount >= 10)
                {
                    ChildGameObject3_9 = enemies3.transform.GetChild(9).gameObject;
                    ChildGameObject3_9.SetActive(false);
                }
            }
            if (enemies4 != null)
            {
                enemies4.SetActive(false);
                if (enemies4.transform.childCount >= 1)
                {
                    ChildGameObject4_0 = enemies4.transform.GetChild(0).gameObject;
                    ChildGameObject4_0.SetActive(false);
                }
                if (enemies4.transform.childCount >= 2)
                {
                    ChildGameObject4_1 = enemies4.transform.GetChild(1).gameObject;
                    ChildGameObject4_1.SetActive(false);
                }
                if (enemies4.transform.childCount >= 3)
                {
                    ChildGameObject4_2 = enemies4.transform.GetChild(2).gameObject;
                    ChildGameObject4_2.SetActive(false);
                }
                if (enemies4.transform.childCount >= 4)
                {
                    ChildGameObject4_3 = enemies4.transform.GetChild(3).gameObject;
                    ChildGameObject4_3.SetActive(false);
                }
                if (enemies4.transform.childCount >= 5)
                {
                    ChildGameObject4_4 = enemies4.transform.GetChild(4).gameObject;
                    ChildGameObject4_4.SetActive(false);
                }
                if (enemies4.transform.childCount >= 6)
                {
                    ChildGameObject4_5 = enemies4.transform.GetChild(5).gameObject;
                    ChildGameObject4_5.SetActive(false);
                }
                if (enemies4.transform.childCount >= 7)
                {
                    ChildGameObject4_6 = enemies4.transform.GetChild(6).gameObject;
                    ChildGameObject4_6.SetActive(false);
                }
                if (enemies4.transform.childCount >= 8)
                {
                    ChildGameObject4_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject4_7.SetActive(false);
                }
                if (enemies4.transform.childCount >= 9)
                {
                    ChildGameObject4_8 = enemies4.transform.GetChild(8).gameObject;
                    ChildGameObject4_8.SetActive(false);
                }
                if (enemies4.transform.childCount >= 10)
                {
                    ChildGameObject4_9 = enemies4.transform.GetChild(9).gameObject;
                    ChildGameObject4_9.SetActive(false);
                }
            }
            if (enemies5 != null)
            {
                enemies5.SetActive(false);
                if (enemies5.transform.childCount >= 1)
                {
                    ChildGameObject5_0 = enemies5.transform.GetChild(0).gameObject;
                    ChildGameObject5_0.SetActive(false);
                }
                if (enemies5.transform.childCount >= 2)
                {
                    ChildGameObject5_1 = enemies5.transform.GetChild(1).gameObject;
                    ChildGameObject5_1.SetActive(false);
                }
                if (enemies5.transform.childCount >= 3)
                {
                    ChildGameObject5_2 = enemies5.transform.GetChild(2).gameObject;
                    ChildGameObject5_2.SetActive(false);
                }
                if (enemies5.transform.childCount >= 4)
                {
                    ChildGameObject5_3 = enemies5.transform.GetChild(3).gameObject;
                    ChildGameObject5_3.SetActive(false);
                }
                if (enemies5.transform.childCount >= 5)
                {
                    ChildGameObject5_4 = enemies5.transform.GetChild(4).gameObject;
                    ChildGameObject5_4.SetActive(false);
                }
                if (enemies5.transform.childCount >= 6)
                {
                    ChildGameObject5_5 = enemies5.transform.GetChild(5).gameObject;
                    ChildGameObject5_5.SetActive(false);
                }
                if (enemies5.transform.childCount >= 7)
                {
                    ChildGameObject5_6 = enemies5.transform.GetChild(6).gameObject;
                    ChildGameObject5_6.SetActive(false);
                }
                if (enemies5.transform.childCount >= 8)
                {
                    ChildGameObject5_7 = enemies5.transform.GetChild(7).gameObject;
                    ChildGameObject5_7.SetActive(false);
                }
                if (enemies5.transform.childCount >= 9)
                {
                    ChildGameObject5_8 = enemies5.transform.GetChild(8).gameObject;
                    ChildGameObject5_8.SetActive(false);
                }
                if (enemies5.transform.childCount >= 10)
                {
                    ChildGameObject5_9 = enemies5.transform.GetChild(9).gameObject;
                    ChildGameObject5_9.SetActive(false);
                }
            }


            if (difficultyReference.difficulty == 1)
            {
                if (easy1 != null)
                {
                    easy1.SetActive(false);
                    if (easy1.transform.childCount >= 1)
                    {
                        ChildGameObject1_0E = easy1.transform.GetChild(0).gameObject;
                        ChildGameObject1_0E.SetActive(false);
                        ChildGameObject1_0E.transform.position = originalPos1_0E;
                    }
                    if (easy1.transform.childCount >= 2)
                    {
                        ChildGameObject1_1E = easy1.transform.GetChild(1).gameObject;
                        ChildGameObject1_1E.SetActive(false);
                        ChildGameObject1_1E.transform.position = originalPos1_1E;
                    }
                    if (easy1.transform.childCount >= 3)
                    {
                        ChildGameObject1_2E = easy1.transform.GetChild(2).gameObject;
                        ChildGameObject1_2E.SetActive(false);
                        ChildGameObject1_2E.transform.position = originalPos1_2E;
                    }
                    if (easy1.transform.childCount >= 4)
                    {
                        ChildGameObject1_3E = easy1.transform.GetChild(3).gameObject;
                        ChildGameObject1_3E.SetActive(false);
                        ChildGameObject1_3E.transform.position = originalPos1_3E;
                    }
                    if (easy1.transform.childCount >= 5)
                    {
                        ChildGameObject1_4E = easy1.transform.GetChild(4).gameObject;
                        ChildGameObject1_4E.SetActive(false);
                        ChildGameObject1_4E.transform.position = originalPos1_4E;
                    }
                }
                if (easy2 != null)
                {
                    easy2.SetActive(true);
                    if (easy2.transform.childCount >= 1)
                    {
                        ChildGameObject2_0E = easy2.transform.GetChild(0).gameObject;
                        ChildGameObject2_0E.SetActive(true);
                        ChildGameObject2_0E.transform.position = originalPos2_0E;
                    }
                    if (easy2.transform.childCount >= 2)
                    {
                        ChildGameObject2_1E = easy2.transform.GetChild(1).gameObject;
                        ChildGameObject2_1E.SetActive(true);
                        ChildGameObject2_1E.transform.position = originalPos2_1E;
                    }
                    if (easy2.transform.childCount >= 3)
                    {
                        ChildGameObject2_2E = easy2.transform.GetChild(2).gameObject;
                        ChildGameObject2_2E.SetActive(true);
                        ChildGameObject2_2E.transform.position = originalPos2_2E;
                    }
                    if (easy2.transform.childCount >= 4)
                    {
                        ChildGameObject2_3E = easy2.transform.GetChild(3).gameObject;
                        ChildGameObject2_3E.SetActive(true);
                        ChildGameObject2_3E.transform.position = originalPos2_3E;
                    }
                    if (easy2.transform.childCount >= 5)
                    {
                        ChildGameObject2_4E = easy2.transform.GetChild(4).gameObject;
                        ChildGameObject2_4E.SetActive(true);
                        ChildGameObject2_4E.transform.position = originalPos2_4E;
                    }
                }
                if (easy3 != null)
                {
                    easy3.SetActive(false);
                    if (easy3.transform.childCount >= 1)
                    {
                        ChildGameObject3_0E = easy3.transform.GetChild(0).gameObject;
                        ChildGameObject3_0E.SetActive(false);
                        ChildGameObject3_0E.transform.position = originalPos3_0E;
                    }
                    if (easy3.transform.childCount >= 2)
                    {
                        ChildGameObject3_1E = easy3.transform.GetChild(1).gameObject;
                        ChildGameObject3_1E.SetActive(false);
                        ChildGameObject3_1E.transform.position = originalPos3_1E;
                    }
                    if (easy3.transform.childCount >= 3)
                    {
                        ChildGameObject3_2E = easy3.transform.GetChild(2).gameObject;
                        ChildGameObject3_2E.SetActive(false);
                        ChildGameObject3_2E.transform.position = originalPos3_2E;
                    }
                    if (easy3.transform.childCount >= 4)
                    {
                        ChildGameObject3_3E = easy3.transform.GetChild(3).gameObject;
                        ChildGameObject3_3E.SetActive(false);
                        ChildGameObject3_3E.transform.position = originalPos3_3E;
                    }
                    if (easy3.transform.childCount >= 5)
                    {
                        ChildGameObject3_4E = easy3.transform.GetChild(4).gameObject;
                        ChildGameObject3_4E.SetActive(false);
                        ChildGameObject3_4E.transform.position = originalPos3_4E;
                    }
                }
                if (easy4 != null)
                {
                    easy1.SetActive(false);
                    if (easy4.transform.childCount >= 1)
                    {
                        ChildGameObject4_0E = easy4.transform.GetChild(0).gameObject;
                        ChildGameObject4_0E.SetActive(false);
                        ChildGameObject4_0E.transform.position = originalPos4_0E;
                    }
                    if (easy4.transform.childCount >= 2)
                    {
                        ChildGameObject4_1E = easy4.transform.GetChild(1).gameObject;
                        ChildGameObject4_1E.SetActive(false);
                        ChildGameObject4_1E.transform.position = originalPos4_1E;
                    }
                    if (easy4.transform.childCount >= 3)
                    {
                        ChildGameObject4_2E = easy4.transform.GetChild(2).gameObject;
                        ChildGameObject4_2E.SetActive(false);
                        ChildGameObject4_2E.transform.position = originalPos4_2E;
                    }
                    if (easy4.transform.childCount >= 4)
                    {
                        ChildGameObject4_3E = easy4.transform.GetChild(3).gameObject;
                        ChildGameObject4_3E.SetActive(false);
                        ChildGameObject4_3E.transform.position = originalPos4_3E;
                    }
                    if (easy4.transform.childCount >= 5)
                    {
                        ChildGameObject4_4E = easy4.transform.GetChild(4).gameObject;
                        ChildGameObject4_4E.SetActive(false);
                        ChildGameObject4_4E.transform.position = originalPos4_4E;
                    }
                }
                if (easy5 != null)
                {
                    easy5.SetActive(false);
                    if (easy5.transform.childCount >= 1)
                    {
                        ChildGameObject5_0E = easy5.transform.GetChild(0).gameObject;
                        ChildGameObject5_0E.SetActive(false);
                        ChildGameObject5_0E.transform.position = originalPos5_0E;
                    }
                    if (easy5.transform.childCount >= 2)
                    {
                        ChildGameObject5_1E = easy5.transform.GetChild(1).gameObject;
                        ChildGameObject5_1E.SetActive(false);
                        ChildGameObject5_1E.transform.position = originalPos5_1E;
                    }
                    if (easy5.transform.childCount >= 3)
                    {
                        ChildGameObject5_2E = easy5.transform.GetChild(2).gameObject;
                        ChildGameObject5_2E.SetActive(false);
                        ChildGameObject5_2E.transform.position = originalPos5_2E;
                    }
                    if (easy5.transform.childCount >= 4)
                    {
                        ChildGameObject5_3E = easy5.transform.GetChild(3).gameObject;
                        ChildGameObject5_3E.SetActive(false);
                        ChildGameObject5_3E.transform.position = originalPos5_3E;
                    }
                    if (easy5.transform.childCount >= 5)
                    {
                        ChildGameObject5_4E = easy5.transform.GetChild(4).gameObject;
                        ChildGameObject5_4E.SetActive(false);
                        ChildGameObject5_4E.transform.position = originalPos5_4E;
                    }
                }
            }
            if (difficultyReference.difficulty == 2)
            {
                if (normal1 != null)
                {
                    normal1.SetActive(false);
                    if (normal1.transform.childCount >= 1)
                    {
                        ChildGameObject1_0N = normal1.transform.GetChild(0).gameObject;
                        ChildGameObject1_0N.SetActive(false);
                        ChildGameObject1_0N.transform.position = originalPos1_0N;
                    }
                    if (normal1.transform.childCount >= 2)
                    {
                        ChildGameObject1_1N = normal1.transform.GetChild(1).gameObject;
                        ChildGameObject1_1N.SetActive(false);
                        ChildGameObject1_1N.transform.position = originalPos1_1N;
                    }
                    if (normal1.transform.childCount >= 3)
                    {
                        ChildGameObject1_2N = normal1.transform.GetChild(2).gameObject;
                        ChildGameObject1_2N.SetActive(false);
                        ChildGameObject1_2N.transform.position = originalPos1_2N;
                    }
                    if (normal1.transform.childCount >= 4)
                    {
                        ChildGameObject1_3N = normal1.transform.GetChild(3).gameObject;
                        ChildGameObject1_3N.SetActive(false);
                        ChildGameObject1_3N.transform.position = originalPos1_3N;
                    }
                    if (normal1.transform.childCount >= 5)
                    {
                        ChildGameObject1_4N = normal1.transform.GetChild(4).gameObject;
                        ChildGameObject1_4N.SetActive(false);
                        ChildGameObject1_4N.transform.position = originalPos1_4N;
                    }
                }
                if (normal2 != null)
                {
                    normal2.SetActive(true);
                    if (normal2.transform.childCount >= 1)
                    {
                        ChildGameObject2_0N = normal2.transform.GetChild(0).gameObject;
                        ChildGameObject2_0N.SetActive(true);
                        ChildGameObject2_0N.transform.position = originalPos2_0N;
                    }
                    if (normal2.transform.childCount >= 2)
                    {
                        ChildGameObject2_1N = normal2.transform.GetChild(1).gameObject;
                        ChildGameObject2_1N.SetActive(true);
                        ChildGameObject2_1N.transform.position = originalPos2_1N;
                    }
                    if (normal2.transform.childCount >= 3)
                    {
                        ChildGameObject2_2N = normal2.transform.GetChild(2).gameObject;
                        ChildGameObject2_2N.SetActive(true);
                        ChildGameObject2_2N.transform.position = originalPos2_2N;
                    }
                    if (normal2.transform.childCount >= 4)
                    {
                        ChildGameObject2_3N = normal2.transform.GetChild(3).gameObject;
                        ChildGameObject2_3N.SetActive(true);
                        ChildGameObject2_3N.transform.position = originalPos2_3N;
                    }
                    if (normal2.transform.childCount >= 5)
                    {
                        ChildGameObject2_4N = normal2.transform.GetChild(4).gameObject;
                        ChildGameObject2_4N.SetActive(true);
                        ChildGameObject2_4N.transform.position = originalPos2_4N;
                    }
                }
                if (normal3 != null)
                {
                    normal3.SetActive(false);
                    if (normal3.transform.childCount >= 1)
                    {
                        ChildGameObject3_0N = normal3.transform.GetChild(0).gameObject;
                        ChildGameObject3_0N.SetActive(false);
                        ChildGameObject3_0N.transform.position = originalPos3_0N;
                    }
                    if (normal3.transform.childCount >= 2)
                    {
                        ChildGameObject3_1N = normal3.transform.GetChild(1).gameObject;
                        ChildGameObject3_1N.SetActive(false);
                        ChildGameObject3_1N.transform.position = originalPos3_1N;
                    }
                    if (normal3.transform.childCount >= 3)
                    {
                        ChildGameObject3_2N = normal3.transform.GetChild(2).gameObject;
                        ChildGameObject3_2N.SetActive(false);
                        ChildGameObject3_2N.transform.position = originalPos3_2N;
                    }
                    if (normal3.transform.childCount >= 4)
                    {
                        ChildGameObject3_3N = normal3.transform.GetChild(3).gameObject;
                        ChildGameObject3_3N.SetActive(false);
                        ChildGameObject3_3N.transform.position = originalPos3_3N;
                    }
                    if (normal3.transform.childCount >= 5)
                    {
                        ChildGameObject3_4N = normal3.transform.GetChild(4).gameObject;
                        ChildGameObject3_4N.SetActive(false);
                        ChildGameObject3_4N.transform.position = originalPos3_4N;
                    }
                }
                if (normal4 != null)
                {
                    normal1.SetActive(false);
                    if (normal4.transform.childCount >= 1)
                    {
                        ChildGameObject4_0N = normal4.transform.GetChild(0).gameObject;
                        ChildGameObject4_0N.SetActive(false);
                        ChildGameObject4_0N.transform.position = originalPos4_0N;
                    }
                    if (normal4.transform.childCount >= 2)
                    {
                        ChildGameObject4_1N = normal4.transform.GetChild(1).gameObject;
                        ChildGameObject4_1N.SetActive(false);
                        ChildGameObject4_1N.transform.position = originalPos4_1N;
                    }
                    if (normal4.transform.childCount >= 3)
                    {
                        ChildGameObject4_2N = normal4.transform.GetChild(2).gameObject;
                        ChildGameObject4_2N.SetActive(false);
                        ChildGameObject4_2N.transform.position = originalPos4_2N;
                    }
                    if (normal4.transform.childCount >= 4)
                    {
                        ChildGameObject4_3N = normal4.transform.GetChild(3).gameObject;
                        ChildGameObject4_3N.SetActive(false);
                        ChildGameObject4_3N.transform.position = originalPos4_3N;
                    }
                    if (normal4.transform.childCount >= 5)
                    {
                        ChildGameObject4_4N = normal4.transform.GetChild(4).gameObject;
                        ChildGameObject4_4N.SetActive(false);
                        ChildGameObject4_4N.transform.position = originalPos4_4N;
                    }
                }
                if (normal5 != null)
                {
                    normal5.SetActive(false);
                    if (normal5.transform.childCount >= 1)
                    {
                        ChildGameObject5_0N = normal5.transform.GetChild(0).gameObject;
                        ChildGameObject5_0N.SetActive(false);
                        ChildGameObject5_0N.transform.position = originalPos5_0N;
                    }
                    if (normal5.transform.childCount >= 2)
                    {
                        ChildGameObject5_1N = normal5.transform.GetChild(1).gameObject;
                        ChildGameObject5_1N.SetActive(false);
                        ChildGameObject5_1N.transform.position = originalPos5_1N;
                    }
                    if (normal5.transform.childCount >= 3)
                    {
                        ChildGameObject5_2N = normal5.transform.GetChild(2).gameObject;
                        ChildGameObject5_2N.SetActive(false);
                        ChildGameObject5_2N.transform.position = originalPos5_2N;
                    }
                    if (normal5.transform.childCount >= 4)
                    {
                        ChildGameObject5_3N = normal5.transform.GetChild(3).gameObject;
                        ChildGameObject5_3N.SetActive(false);
                        ChildGameObject5_3N.transform.position = originalPos5_3N;
                    }
                    if (normal5.transform.childCount >= 5)
                    {
                        ChildGameObject5_4N = normal5.transform.GetChild(4).gameObject;
                        ChildGameObject5_4N.SetActive(false);
                        ChildGameObject5_4N.transform.position = originalPos5_4N;
                    }
                }
            }

        }

        if (enemiesDissable.roomOfMap == 3)
        {
            rowsAndColumnsReference.levelColumns = rowsAndColumnsReference.levelColumns3;
            rowsAndColumnsReference.levelRows = rowsAndColumnsReference.levelRows3;
            cameraChange.cameraMove = 103;
            if (enemies1 != null)
            {
                enemies1.SetActive(false);
                if (enemies1.transform.childCount >= 1)
                {
                    ChildGameObject1_0 = enemies1.transform.GetChild(0).gameObject;
                    ChildGameObject1_0.SetActive(false);
                }
                if (enemies1.transform.childCount >= 2)
                {
                    ChildGameObject1_1 = enemies1.transform.GetChild(1).gameObject;
                    ChildGameObject1_1.SetActive(false);
                }
                if (enemies1.transform.childCount >= 3)
                {
                    ChildGameObject1_2 = enemies1.transform.GetChild(2).gameObject;
                    ChildGameObject1_2.SetActive(false);
                }
                if (enemies1.transform.childCount >= 4)
                {
                    ChildGameObject1_3 = enemies1.transform.GetChild(3).gameObject;
                    ChildGameObject1_3.SetActive(false);
                }
                if (enemies1.transform.childCount >= 5)
                {
                    ChildGameObject1_4 = enemies1.transform.GetChild(4).gameObject;
                    ChildGameObject1_4.SetActive(false);
                }
                if (enemies1.transform.childCount >= 6)
                {
                    ChildGameObject1_5 = enemies1.transform.GetChild(5).gameObject;
                    ChildGameObject1_5.SetActive(false);
                }
                if (enemies1.transform.childCount >= 7)
                {
                    ChildGameObject1_6 = enemies1.transform.GetChild(6).gameObject;
                    ChildGameObject1_6.SetActive(false);
                }
                if (enemies1.transform.childCount >= 8)
                {
                    ChildGameObject1_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject1_7.SetActive(false);
                }
                if (enemies1.transform.childCount >= 9)
                {
                    ChildGameObject1_8 = enemies1.transform.GetChild(8).gameObject;
                    ChildGameObject1_8.SetActive(false);
                }
                if (enemies1.transform.childCount >= 10)
                {
                    ChildGameObject1_9 = enemies1.transform.GetChild(9).gameObject;
                    ChildGameObject1_9.SetActive(false);
                }
                if (enemies1.transform.childCount >= 11)
                {
                    ChildGameObject1_10 = enemies1.transform.GetChild(10).gameObject;
                    ChildGameObject1_10.SetActive(false);
                }
                if (enemies1.transform.childCount >= 12)
                {
                    ChildGameObject1_11 = enemies1.transform.GetChild(11).gameObject;
                    ChildGameObject1_11.SetActive(false);
                }
            }
            if (enemies2 != null)
            {
                enemies2.SetActive(false);
                if (enemies2.transform.childCount >= 1)
                {
                    ChildGameObject2_0 = enemies2.transform.GetChild(0).gameObject;
                    ChildGameObject2_0.SetActive(false);
                }
                if (enemies2.transform.childCount >= 2)
                {
                    ChildGameObject2_1 = enemies2.transform.GetChild(1).gameObject;
                    ChildGameObject2_1.SetActive(false);
                }
                if (enemies2.transform.childCount >= 3)
                {
                    ChildGameObject2_2 = enemies2.transform.GetChild(2).gameObject;
                    ChildGameObject2_2.SetActive(false);
                }
                if (enemies2.transform.childCount >= 4)
                {
                    ChildGameObject2_3 = enemies2.transform.GetChild(3).gameObject;
                    ChildGameObject2_3.SetActive(false);
                }
                if (enemies2.transform.childCount >= 5)
                {
                    ChildGameObject2_4 = enemies2.transform.GetChild(4).gameObject;
                    ChildGameObject2_4.SetActive(false);
                }
                if (enemies2.transform.childCount >= 6)
                {
                    ChildGameObject2_5 = enemies2.transform.GetChild(5).gameObject;
                    ChildGameObject2_5.SetActive(false);
                }
                if (enemies2.transform.childCount >= 7)
                {
                    ChildGameObject2_6 = enemies2.transform.GetChild(6).gameObject;
                    ChildGameObject2_6.SetActive(false);
                }
                if (enemies2.transform.childCount >= 8)
                {
                    ChildGameObject2_7 = enemies2.transform.GetChild(7).gameObject;
                    ChildGameObject2_7.SetActive(false);
                }
                if (enemies2.transform.childCount >= 9)
                {
                    ChildGameObject2_8 = enemies2.transform.GetChild(8).gameObject;
                    ChildGameObject2_8.SetActive(false);
                }
                if (enemies2.transform.childCount >= 10)
                {
                    ChildGameObject2_9 = enemies2.transform.GetChild(9).gameObject;
                    ChildGameObject2_9.SetActive(false);
                }
            }
            if (enemies3 != null)
            {
                enemies3.SetActive(true);
                if (enemies3.transform.childCount >= 1)
                {
                    ChildGameObject3_0 = enemies3.transform.GetChild(0).gameObject;
                    ChildGameObject3_0.SetActive(true);
                    ChildGameObject3_0.transform.position = originalPos3_0;
                }
                if (enemies3.transform.childCount >= 2)
                {
                    ChildGameObject3_1 = enemies3.transform.GetChild(1).gameObject;
                    ChildGameObject3_1.SetActive(true);
                    ChildGameObject3_1.transform.position = originalPos3_1;
                }
                if (enemies3.transform.childCount >= 3)
                {
                    ChildGameObject3_2 = enemies3.transform.GetChild(2).gameObject;
                    ChildGameObject3_2.SetActive(true);
                    ChildGameObject3_2.transform.position = originalPos3_2;
                }
                if (enemies3.transform.childCount >= 4)
                {
                    ChildGameObject3_3 = enemies3.transform.GetChild(3).gameObject;
                    ChildGameObject3_3.SetActive(true);
                    ChildGameObject3_3.transform.position = originalPos3_3;
                }
                if (enemies3.transform.childCount >= 5)
                {
                    ChildGameObject3_4 = enemies3.transform.GetChild(4).gameObject;
                    ChildGameObject3_4.SetActive(true);
                    ChildGameObject3_4.transform.position = originalPos3_4;
                }
                if (enemies3.transform.childCount >= 6)
                {
                    ChildGameObject3_5 = enemies3.transform.GetChild(5).gameObject;
                    ChildGameObject3_5.SetActive(true);
                    ChildGameObject3_5.transform.position = originalPos3_5;
                }
                if (enemies3.transform.childCount >= 7)
                {
                    ChildGameObject3_6 = enemies3.transform.GetChild(6).gameObject;
                    ChildGameObject3_6.SetActive(true);
                    ChildGameObject3_6.transform.position = originalPos3_6;
                }
                if (enemies3.transform.childCount >= 8)
                {
                    ChildGameObject3_7 = enemies3.transform.GetChild(7).gameObject;
                    ChildGameObject3_7.SetActive(true);
                    ChildGameObject3_7.transform.position = originalPos3_7;
                }
                if (enemies3.transform.childCount >= 9)
                {
                    ChildGameObject3_8 = enemies3.transform.GetChild(8).gameObject;
                    ChildGameObject3_8.SetActive(true);
                    ChildGameObject3_8.transform.position = originalPos3_8;
                }
                if (enemies3.transform.childCount >= 10)
                {
                    ChildGameObject3_9 = enemies3.transform.GetChild(9).gameObject;
                    ChildGameObject3_9.SetActive(true);
                    ChildGameObject3_9.transform.position = originalPos3_9;
                }
            }
            if (enemies4 != null)
            {
                enemies4.SetActive(false);
                if (enemies4.transform.childCount >= 1)
                {
                    ChildGameObject4_0 = enemies4.transform.GetChild(0).gameObject;
                    ChildGameObject4_0.SetActive(false);
                }
                if (enemies4.transform.childCount >= 2)
                {
                    ChildGameObject4_1 = enemies4.transform.GetChild(1).gameObject;
                    ChildGameObject4_1.SetActive(false);
                }
                if (enemies4.transform.childCount >= 3)
                {
                    ChildGameObject4_2 = enemies4.transform.GetChild(2).gameObject;
                    ChildGameObject4_2.SetActive(false);
                }
                if (enemies4.transform.childCount >= 4)
                {
                    ChildGameObject4_3 = enemies4.transform.GetChild(3).gameObject;
                    ChildGameObject4_3.SetActive(false);
                }
                if (enemies4.transform.childCount >= 5)
                {
                    ChildGameObject4_4 = enemies4.transform.GetChild(4).gameObject;
                    ChildGameObject4_4.SetActive(false);
                }
                if (enemies4.transform.childCount >= 6)
                {
                    ChildGameObject4_5 = enemies4.transform.GetChild(5).gameObject;
                    ChildGameObject4_5.SetActive(false);
                }
                if (enemies4.transform.childCount >= 7)
                {
                    ChildGameObject4_6 = enemies4.transform.GetChild(6).gameObject;
                    ChildGameObject4_6.SetActive(false);
                }
                if (enemies4.transform.childCount >= 8)
                {
                    ChildGameObject4_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject4_7.SetActive(false);
                }
                if (enemies4.transform.childCount >= 9)
                {
                    ChildGameObject4_8 = enemies4.transform.GetChild(8).gameObject;
                    ChildGameObject4_8.SetActive(false);
                }
                if (enemies4.transform.childCount >= 10)
                {
                    ChildGameObject4_9 = enemies4.transform.GetChild(9).gameObject;
                    ChildGameObject4_9.SetActive(false);
                }
            }
            if (enemies5 != null)
            {
                enemies5.SetActive(false);
                if (enemies5.transform.childCount >= 1)
                {
                    ChildGameObject5_0 = enemies5.transform.GetChild(0).gameObject;
                    ChildGameObject5_0.SetActive(false);
                }
                if (enemies5.transform.childCount >= 2)
                {
                    ChildGameObject5_1 = enemies5.transform.GetChild(1).gameObject;
                    ChildGameObject5_1.SetActive(false);
                }
                if (enemies5.transform.childCount >= 3)
                {
                    ChildGameObject5_2 = enemies5.transform.GetChild(2).gameObject;
                    ChildGameObject5_2.SetActive(false);
                }
                if (enemies5.transform.childCount >= 4)
                {
                    ChildGameObject5_3 = enemies5.transform.GetChild(3).gameObject;
                    ChildGameObject5_3.SetActive(false);
                }
                if (enemies5.transform.childCount >= 5)
                {
                    ChildGameObject5_4 = enemies5.transform.GetChild(4).gameObject;
                    ChildGameObject5_4.SetActive(false);
                }
                if (enemies5.transform.childCount >= 6)
                {
                    ChildGameObject5_5 = enemies5.transform.GetChild(5).gameObject;
                    ChildGameObject5_5.SetActive(false);
                }
                if (enemies5.transform.childCount >= 7)
                {
                    ChildGameObject5_6 = enemies5.transform.GetChild(6).gameObject;
                    ChildGameObject5_6.SetActive(false);
                }
                if (enemies5.transform.childCount >= 8)
                {
                    ChildGameObject5_7 = enemies5.transform.GetChild(7).gameObject;
                    ChildGameObject5_7.SetActive(false);
                }
                if (enemies5.transform.childCount >= 9)
                {
                    ChildGameObject5_8 = enemies5.transform.GetChild(8).gameObject;
                    ChildGameObject5_8.SetActive(false);
                }
                if (enemies5.transform.childCount >= 10)
                {
                    ChildGameObject5_9 = enemies5.transform.GetChild(9).gameObject;
                    ChildGameObject5_9.SetActive(false);
                }
            }


            if (difficultyReference.difficulty == 1)
            {
                if (easy1 != null)
                {
                    easy1.SetActive(false);
                    if (easy1.transform.childCount >= 1)
                    {
                        ChildGameObject1_0E = easy1.transform.GetChild(0).gameObject;
                        ChildGameObject1_0E.SetActive(false);
                        ChildGameObject1_0E.transform.position = originalPos1_0E;
                    }
                    if (easy1.transform.childCount >= 2)
                    {
                        ChildGameObject1_1E = easy1.transform.GetChild(1).gameObject;
                        ChildGameObject1_1E.SetActive(false);
                        ChildGameObject1_1E.transform.position = originalPos1_1E;
                    }
                    if (easy1.transform.childCount >= 3)
                    {
                        ChildGameObject1_2E = easy1.transform.GetChild(2).gameObject;
                        ChildGameObject1_2E.SetActive(false);
                        ChildGameObject1_2E.transform.position = originalPos1_2E;
                    }
                    if (easy1.transform.childCount >= 4)
                    {
                        ChildGameObject1_3E = easy1.transform.GetChild(3).gameObject;
                        ChildGameObject1_3E.SetActive(false);
                        ChildGameObject1_3E.transform.position = originalPos1_3E;
                    }
                    if (easy1.transform.childCount >= 5)
                    {
                        ChildGameObject1_4E = easy1.transform.GetChild(4).gameObject;
                        ChildGameObject1_4E.SetActive(false);
                        ChildGameObject1_4E.transform.position = originalPos1_4E;
                    }
                }
                if (easy2 != null)
                {
                    easy2.SetActive(false);
                    if (easy2.transform.childCount >= 1)
                    {
                        ChildGameObject2_0E = easy2.transform.GetChild(0).gameObject;
                        ChildGameObject2_0E.SetActive(false);
                        ChildGameObject2_0E.transform.position = originalPos2_0E;
                    }
                    if (easy2.transform.childCount >= 2)
                    {
                        ChildGameObject2_1E = easy2.transform.GetChild(1).gameObject;
                        ChildGameObject2_1E.SetActive(false);
                        ChildGameObject2_1E.transform.position = originalPos2_1E;
                    }
                    if (easy2.transform.childCount >= 3)
                    {
                        ChildGameObject2_2E = easy2.transform.GetChild(2).gameObject;
                        ChildGameObject2_2E.SetActive(false);
                        ChildGameObject2_2E.transform.position = originalPos2_2E;
                    }
                    if (easy2.transform.childCount >= 4)
                    {
                        ChildGameObject2_3E = easy2.transform.GetChild(3).gameObject;
                        ChildGameObject2_3E.SetActive(false);
                        ChildGameObject2_3E.transform.position = originalPos2_3E;
                    }
                    if (easy2.transform.childCount >= 5)
                    {
                        ChildGameObject2_4E = easy2.transform.GetChild(4).gameObject;
                        ChildGameObject2_4E.SetActive(false);
                        ChildGameObject2_4E.transform.position = originalPos2_4E;
                    }
                }
                if (easy3 != null)
                {
                    easy3.SetActive(true);
                    if (easy3.transform.childCount >= 1)
                    {
                        ChildGameObject3_0E = easy3.transform.GetChild(0).gameObject;
                        ChildGameObject3_0E.SetActive(true);
                        ChildGameObject3_0E.transform.position = originalPos3_0E;
                    }
                    if (easy3.transform.childCount >= 2)
                    {
                        ChildGameObject3_1E = easy3.transform.GetChild(1).gameObject;
                        ChildGameObject3_1E.SetActive(true);
                        ChildGameObject3_1E.transform.position = originalPos3_1E;
                    }
                    if (easy3.transform.childCount >= 3)
                    {
                        ChildGameObject3_2E = easy3.transform.GetChild(2).gameObject;
                        ChildGameObject3_2E.SetActive(true);
                        ChildGameObject3_2E.transform.position = originalPos3_2E;
                    }
                    if (easy3.transform.childCount >= 4)
                    {
                        ChildGameObject3_3E = easy3.transform.GetChild(3).gameObject;
                        ChildGameObject3_3E.SetActive(true);
                        ChildGameObject3_3E.transform.position = originalPos3_3E;
                    }
                    if (easy3.transform.childCount >= 5)
                    {
                        ChildGameObject3_4E = easy3.transform.GetChild(4).gameObject;
                        ChildGameObject3_4E.SetActive(true);
                        ChildGameObject3_4E.transform.position = originalPos3_4E;
                    }
                }
                if (easy4 != null)
                {
                    easy1.SetActive(false);
                    if (easy4.transform.childCount >= 1)
                    {
                        ChildGameObject4_0E = easy4.transform.GetChild(0).gameObject;
                        ChildGameObject4_0E.SetActive(false);
                        ChildGameObject4_0E.transform.position = originalPos4_0E;
                    }
                    if (easy4.transform.childCount >= 2)
                    {
                        ChildGameObject4_1E = easy4.transform.GetChild(1).gameObject;
                        ChildGameObject4_1E.SetActive(false);
                        ChildGameObject4_1E.transform.position = originalPos4_1E;
                    }
                    if (easy4.transform.childCount >= 3)
                    {
                        ChildGameObject4_2E = easy4.transform.GetChild(2).gameObject;
                        ChildGameObject4_2E.SetActive(false);
                        ChildGameObject4_2E.transform.position = originalPos4_2E;
                    }
                    if (easy4.transform.childCount >= 4)
                    {
                        ChildGameObject4_3E = easy4.transform.GetChild(3).gameObject;
                        ChildGameObject4_3E.SetActive(false);
                        ChildGameObject4_3E.transform.position = originalPos4_3E;
                    }
                    if (easy4.transform.childCount >= 5)
                    {
                        ChildGameObject4_4E = easy4.transform.GetChild(4).gameObject;
                        ChildGameObject4_4E.SetActive(false);
                        ChildGameObject4_4E.transform.position = originalPos4_4E;
                    }
                }
                if (easy5 != null)
                {
                    easy5.SetActive(false);
                    if (easy5.transform.childCount >= 1)
                    {
                        ChildGameObject5_0E = easy5.transform.GetChild(0).gameObject;
                        ChildGameObject5_0E.SetActive(false);
                        ChildGameObject5_0E.transform.position = originalPos5_0E;
                    }
                    if (easy5.transform.childCount >= 2)
                    {
                        ChildGameObject5_1E = easy5.transform.GetChild(1).gameObject;
                        ChildGameObject5_1E.SetActive(false);
                        ChildGameObject5_1E.transform.position = originalPos5_1E;
                    }
                    if (easy5.transform.childCount >= 3)
                    {
                        ChildGameObject5_2E = easy5.transform.GetChild(2).gameObject;
                        ChildGameObject5_2E.SetActive(false);
                        ChildGameObject5_2E.transform.position = originalPos5_2E;
                    }
                    if (easy5.transform.childCount >= 4)
                    {
                        ChildGameObject5_3E = easy5.transform.GetChild(3).gameObject;
                        ChildGameObject5_3E.SetActive(false);
                        ChildGameObject5_3E.transform.position = originalPos5_3E;
                    }
                    if (easy5.transform.childCount >= 5)
                    {
                        ChildGameObject5_4E = easy5.transform.GetChild(4).gameObject;
                        ChildGameObject5_4E.SetActive(false);
                        ChildGameObject5_4E.transform.position = originalPos5_4E;
                    }
                }
            }
            if (difficultyReference.difficulty == 2)
            {
                if (normal1 != null)
                {
                    normal1.SetActive(false);
                    if (normal1.transform.childCount >= 1)
                    {
                        ChildGameObject1_0N = normal1.transform.GetChild(0).gameObject;
                        ChildGameObject1_0N.SetActive(false);
                        ChildGameObject1_0N.transform.position = originalPos1_0N;
                    }
                    if (normal1.transform.childCount >= 2)
                    {
                        ChildGameObject1_1N = normal1.transform.GetChild(1).gameObject;
                        ChildGameObject1_1N.SetActive(false);
                        ChildGameObject1_1N.transform.position = originalPos1_1N;
                    }
                    if (normal1.transform.childCount >= 3)
                    {
                        ChildGameObject1_2N = normal1.transform.GetChild(2).gameObject;
                        ChildGameObject1_2N.SetActive(false);
                        ChildGameObject1_2N.transform.position = originalPos1_2N;
                    }
                    if (normal1.transform.childCount >= 4)
                    {
                        ChildGameObject1_3N = normal1.transform.GetChild(3).gameObject;
                        ChildGameObject1_3N.SetActive(false);
                        ChildGameObject1_3N.transform.position = originalPos1_3N;
                    }
                    if (normal1.transform.childCount >= 5)
                    {
                        ChildGameObject1_4N = normal1.transform.GetChild(4).gameObject;
                        ChildGameObject1_4N.SetActive(false);
                        ChildGameObject1_4N.transform.position = originalPos1_4N;
                    }
                }
                if (normal2 != null)
                {
                    normal2.SetActive(false);
                    if (normal2.transform.childCount >= 1)
                    {
                        ChildGameObject2_0N = normal2.transform.GetChild(0).gameObject;
                        ChildGameObject2_0N.SetActive(false);
                        ChildGameObject2_0N.transform.position = originalPos2_0N;
                    }
                    if (normal2.transform.childCount >= 2)
                    {
                        ChildGameObject2_1N = normal2.transform.GetChild(1).gameObject;
                        ChildGameObject2_1N.SetActive(false);
                        ChildGameObject2_1N.transform.position = originalPos2_1N;
                    }
                    if (normal2.transform.childCount >= 3)
                    {
                        ChildGameObject2_2N = normal2.transform.GetChild(2).gameObject;
                        ChildGameObject2_2N.SetActive(false);
                        ChildGameObject2_2N.transform.position = originalPos2_2N;
                    }
                    if (normal2.transform.childCount >= 4)
                    {
                        ChildGameObject2_3N = normal2.transform.GetChild(3).gameObject;
                        ChildGameObject2_3N.SetActive(false);
                        ChildGameObject2_3N.transform.position = originalPos2_3N;
                    }
                    if (normal2.transform.childCount >= 5)
                    {
                        ChildGameObject2_4N = normal2.transform.GetChild(4).gameObject;
                        ChildGameObject2_4N.SetActive(false);
                        ChildGameObject2_4N.transform.position = originalPos2_4N;
                    }
                }
                if (normal3 != null)
                {
                    normal3.SetActive(true);
                    if (normal3.transform.childCount >= 1)
                    {
                        ChildGameObject3_0N = normal3.transform.GetChild(0).gameObject;
                        ChildGameObject3_0N.SetActive(true);
                        ChildGameObject3_0N.transform.position = originalPos3_0N;
                    }
                    if (normal3.transform.childCount >= 2)
                    {
                        ChildGameObject3_1N = normal3.transform.GetChild(1).gameObject;
                        ChildGameObject3_1N.SetActive(true);
                        ChildGameObject3_1N.transform.position = originalPos3_1N;
                    }
                    if (normal3.transform.childCount >= 3)
                    {
                        ChildGameObject3_2N = normal3.transform.GetChild(2).gameObject;
                        ChildGameObject3_2N.SetActive(true);
                        ChildGameObject3_2N.transform.position = originalPos3_2N;
                    }
                    if (normal3.transform.childCount >= 4)
                    {
                        ChildGameObject3_3N = normal3.transform.GetChild(3).gameObject;
                        ChildGameObject3_3N.SetActive(true);
                        ChildGameObject3_3N.transform.position = originalPos3_3N;
                    }
                    if (normal3.transform.childCount >= 5)
                    {
                        ChildGameObject3_4N = normal3.transform.GetChild(4).gameObject;
                        ChildGameObject3_4N.SetActive(true);
                        ChildGameObject3_4N.transform.position = originalPos3_4N;
                    }
                }
                if (normal4 != null)
                {
                    normal1.SetActive(false);
                    if (normal4.transform.childCount >= 1)
                    {
                        ChildGameObject4_0N = normal4.transform.GetChild(0).gameObject;
                        ChildGameObject4_0N.SetActive(false);
                        ChildGameObject4_0N.transform.position = originalPos4_0N;
                    }
                    if (normal4.transform.childCount >= 2)
                    {
                        ChildGameObject4_1N = normal4.transform.GetChild(1).gameObject;
                        ChildGameObject4_1N.SetActive(false);
                        ChildGameObject4_1N.transform.position = originalPos4_1N;
                    }
                    if (normal4.transform.childCount >= 3)
                    {
                        ChildGameObject4_2N = normal4.transform.GetChild(2).gameObject;
                        ChildGameObject4_2N.SetActive(false);
                        ChildGameObject4_2N.transform.position = originalPos4_2N;
                    }
                    if (normal4.transform.childCount >= 4)
                    {
                        ChildGameObject4_3N = normal4.transform.GetChild(3).gameObject;
                        ChildGameObject4_3N.SetActive(false);
                        ChildGameObject4_3N.transform.position = originalPos4_3N;
                    }
                    if (normal4.transform.childCount >= 5)
                    {
                        ChildGameObject4_4N = normal4.transform.GetChild(4).gameObject;
                        ChildGameObject4_4N.SetActive(false);
                        ChildGameObject4_4N.transform.position = originalPos4_4N;
                    }
                }
                if (normal5 != null)
                {
                    normal5.SetActive(false);
                    if (normal5.transform.childCount >= 1)
                    {
                        ChildGameObject5_0N = normal5.transform.GetChild(0).gameObject;
                        ChildGameObject5_0N.SetActive(false);
                        ChildGameObject5_0N.transform.position = originalPos5_0N;
                    }
                    if (normal5.transform.childCount >= 2)
                    {
                        ChildGameObject5_1N = normal5.transform.GetChild(1).gameObject;
                        ChildGameObject5_1N.SetActive(false);
                        ChildGameObject5_1N.transform.position = originalPos5_1N;
                    }
                    if (normal5.transform.childCount >= 3)
                    {
                        ChildGameObject5_2N = normal5.transform.GetChild(2).gameObject;
                        ChildGameObject5_2N.SetActive(false);
                        ChildGameObject5_2N.transform.position = originalPos5_2N;
                    }
                    if (normal5.transform.childCount >= 4)
                    {
                        ChildGameObject5_3N = normal5.transform.GetChild(3).gameObject;
                        ChildGameObject5_3N.SetActive(false);
                        ChildGameObject5_3N.transform.position = originalPos5_3N;
                    }
                    if (normal5.transform.childCount >= 5)
                    {
                        ChildGameObject5_4N = normal5.transform.GetChild(4).gameObject;
                        ChildGameObject5_4N.SetActive(false);
                        ChildGameObject5_4N.transform.position = originalPos5_4N;
                    }
                }
            }

        }

        if (enemiesDissable.roomOfMap == 4)
        {
            rowsAndColumnsReference.levelColumns = rowsAndColumnsReference.levelColumns4;
            rowsAndColumnsReference.levelRows = rowsAndColumnsReference.levelRows4;
            cameraChange.cameraMove = 104;
            if (enemies1 != null)
            {
                enemies1.SetActive(false);
                if (enemies1.transform.childCount >= 1)
                {
                    ChildGameObject1_0 = enemies1.transform.GetChild(0).gameObject;
                    ChildGameObject1_0.SetActive(false);
                }
                if (enemies1.transform.childCount >= 2)
                {
                    ChildGameObject1_1 = enemies1.transform.GetChild(1).gameObject;
                    ChildGameObject1_1.SetActive(false);
                }
                if (enemies1.transform.childCount >= 3)
                {
                    ChildGameObject1_2 = enemies1.transform.GetChild(2).gameObject;
                    ChildGameObject1_2.SetActive(false);
                }
                if (enemies1.transform.childCount >= 4)
                {
                    ChildGameObject1_3 = enemies1.transform.GetChild(3).gameObject;
                    ChildGameObject1_3.SetActive(false);
                }
                if (enemies1.transform.childCount >= 5)
                {
                    ChildGameObject1_4 = enemies1.transform.GetChild(4).gameObject;
                    ChildGameObject1_4.SetActive(false);
                }
                if (enemies1.transform.childCount >= 6)
                {
                    ChildGameObject1_5 = enemies1.transform.GetChild(5).gameObject;
                    ChildGameObject1_5.SetActive(false);
                }
                if (enemies1.transform.childCount >= 7)
                {
                    ChildGameObject1_6 = enemies1.transform.GetChild(6).gameObject;
                    ChildGameObject1_6.SetActive(false);
                }
                if (enemies1.transform.childCount >= 8)
                {
                    ChildGameObject1_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject1_7.SetActive(false);
                }
                if (enemies1.transform.childCount >= 9)
                {
                    ChildGameObject1_8 = enemies1.transform.GetChild(8).gameObject;
                    ChildGameObject1_8.SetActive(false);
                }
                if (enemies1.transform.childCount >= 10)
                {
                    ChildGameObject1_9 = enemies1.transform.GetChild(9).gameObject;
                    ChildGameObject1_9.SetActive(false);
                }
                if (enemies1.transform.childCount >= 11)
                {
                    ChildGameObject1_10 = enemies1.transform.GetChild(10).gameObject;
                    ChildGameObject1_10.SetActive(false);
                }
                if (enemies1.transform.childCount >= 12)
                {
                    ChildGameObject1_11 = enemies1.transform.GetChild(11).gameObject;
                    ChildGameObject1_11.SetActive(false);
                }
            }
            if (enemies2 != null)
            {
                enemies2.SetActive(false);
                if (enemies2.transform.childCount >= 1)
                {
                    ChildGameObject2_0 = enemies2.transform.GetChild(0).gameObject;
                    ChildGameObject2_0.SetActive(false);
                }
                if (enemies2.transform.childCount >= 2)
                {
                    ChildGameObject2_1 = enemies2.transform.GetChild(1).gameObject;
                    ChildGameObject2_1.SetActive(false);
                }
                if (enemies2.transform.childCount >= 3)
                {
                    ChildGameObject2_2 = enemies2.transform.GetChild(2).gameObject;
                    ChildGameObject2_2.SetActive(false);
                }
                if (enemies2.transform.childCount >= 4)
                {
                    ChildGameObject2_3 = enemies2.transform.GetChild(3).gameObject;
                    ChildGameObject2_3.SetActive(false);
                }
                if (enemies2.transform.childCount >= 5)
                {
                    ChildGameObject2_4 = enemies2.transform.GetChild(4).gameObject;
                    ChildGameObject2_4.SetActive(false);
                }
                if (enemies2.transform.childCount >= 6)
                {
                    ChildGameObject2_5 = enemies2.transform.GetChild(5).gameObject;
                    ChildGameObject2_5.SetActive(false);
                }
                if (enemies2.transform.childCount >= 7)
                {
                    ChildGameObject2_6 = enemies2.transform.GetChild(6).gameObject;
                    ChildGameObject2_6.SetActive(false);
                }
                if (enemies2.transform.childCount >= 8)
                {
                    ChildGameObject2_7 = enemies2.transform.GetChild(7).gameObject;
                    ChildGameObject2_7.SetActive(false);
                }
                if (enemies2.transform.childCount >= 9)
                {
                    ChildGameObject2_8 = enemies2.transform.GetChild(8).gameObject;
                    ChildGameObject2_8.SetActive(false);
                }
                if (enemies2.transform.childCount >= 10)
                {
                    ChildGameObject2_9 = enemies2.transform.GetChild(9).gameObject;
                    ChildGameObject2_9.SetActive(false);
                }
            }
            if (enemies3 != null)
            {
                enemies3.SetActive(false);
                if (enemies3.transform.childCount >= 1)
                {
                    ChildGameObject3_0 = enemies3.transform.GetChild(0).gameObject;
                    ChildGameObject3_0.SetActive(false);
                }
                if (enemies3.transform.childCount >= 2)
                {
                    ChildGameObject3_1 = enemies3.transform.GetChild(1).gameObject;
                    ChildGameObject3_1.SetActive(false);
                }
                if (enemies3.transform.childCount >= 3)
                {
                    ChildGameObject3_2 = enemies3.transform.GetChild(2).gameObject;
                    ChildGameObject3_2.SetActive(false);
                }
                if (enemies3.transform.childCount >= 4)
                {
                    ChildGameObject3_3 = enemies3.transform.GetChild(3).gameObject;
                    ChildGameObject3_3.SetActive(false);
                }
                if (enemies3.transform.childCount >= 5)
                {
                    ChildGameObject3_4 = enemies3.transform.GetChild(4).gameObject;
                    ChildGameObject3_4.SetActive(false);
                }
                if (enemies3.transform.childCount >= 6)
                {
                    ChildGameObject3_5 = enemies3.transform.GetChild(5).gameObject;
                    ChildGameObject3_5.SetActive(false);
                }
                if (enemies3.transform.childCount >= 7)
                {
                    ChildGameObject3_6 = enemies3.transform.GetChild(6).gameObject;
                    ChildGameObject3_6.SetActive(false);
                }
                if (enemies3.transform.childCount >= 8)
                {
                    ChildGameObject3_7 = enemies3.transform.GetChild(7).gameObject;
                    ChildGameObject3_7.SetActive(false);
                }
                if (enemies3.transform.childCount >= 9)
                {
                    ChildGameObject3_8 = enemies3.transform.GetChild(8).gameObject;
                    ChildGameObject3_8.SetActive(false);
                }
                if (enemies3.transform.childCount >= 10)
                {
                    ChildGameObject3_9 = enemies3.transform.GetChild(9).gameObject;
                    ChildGameObject3_9.SetActive(false);
                }
            }
            if (enemies4 != null)
            {
                enemies4.SetActive(true);
                if (enemies4.transform.childCount >= 1)
                {
                    ChildGameObject4_0 = enemies4.transform.GetChild(0).gameObject;
                    ChildGameObject4_0.SetActive(true);
                    ChildGameObject4_0.transform.position = originalPos4_0;
                }
                if (enemies4.transform.childCount >= 2)
                {
                    ChildGameObject4_1 = enemies4.transform.GetChild(1).gameObject;
                    ChildGameObject4_1.SetActive(true);
                    ChildGameObject4_1.transform.position = originalPos4_1;
                }
                if (enemies4.transform.childCount >= 3)
                {
                    ChildGameObject4_2 = enemies4.transform.GetChild(2).gameObject;
                    ChildGameObject4_2.SetActive(true);
                    ChildGameObject4_2.transform.position = originalPos4_2;
                }
                if (enemies4.transform.childCount >= 4)
                {
                    ChildGameObject4_3 = enemies4.transform.GetChild(3).gameObject;
                    ChildGameObject4_3.SetActive(true);
                    ChildGameObject4_3.transform.position = originalPos4_3;
                }
                if (enemies4.transform.childCount >= 5)
                {
                    ChildGameObject4_4 = enemies4.transform.GetChild(4).gameObject;
                    ChildGameObject4_4.SetActive(true);
                    ChildGameObject4_4.transform.position = originalPos4_4;
                }
                if (enemies4.transform.childCount >= 6)
                {
                    ChildGameObject4_5 = enemies4.transform.GetChild(5).gameObject;
                    ChildGameObject4_5.SetActive(true);
                    ChildGameObject4_5.transform.position = originalPos4_5;
                }
                if (enemies4.transform.childCount >= 7)
                {
                    ChildGameObject4_6 = enemies4.transform.GetChild(6).gameObject;
                    ChildGameObject4_6.SetActive(true);
                    ChildGameObject4_6.transform.position = originalPos4_6;
                }
                if (enemies4.transform.childCount >= 8)
                {
                    ChildGameObject4_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject4_7.SetActive(true);
                    ChildGameObject4_7.transform.position = originalPos4_7;
                }
                if (enemies4.transform.childCount >= 9)
                {
                    ChildGameObject4_8 = enemies4.transform.GetChild(8).gameObject;
                    ChildGameObject4_8.SetActive(true);
                    ChildGameObject4_8.transform.position = originalPos4_8;
                }
                if (enemies4.transform.childCount >= 10)
                {
                    ChildGameObject4_9 = enemies4.transform.GetChild(9).gameObject;
                    ChildGameObject4_9.SetActive(true);
                    ChildGameObject4_9.transform.position = originalPos4_9;
                }
            }
            if (enemies5 != null)
            {
                enemies5.SetActive(false);
                if (enemies5.transform.childCount >= 1)
                {
                    ChildGameObject5_0 = enemies5.transform.GetChild(0).gameObject;
                    ChildGameObject5_0.SetActive(false);
                }
                if (enemies5.transform.childCount >= 2)
                {
                    ChildGameObject5_1 = enemies5.transform.GetChild(1).gameObject;
                    ChildGameObject5_1.SetActive(false);
                }
                if (enemies5.transform.childCount >= 3)
                {
                    ChildGameObject5_2 = enemies5.transform.GetChild(2).gameObject;
                    ChildGameObject5_2.SetActive(false);
                }
                if (enemies5.transform.childCount >= 4)
                {
                    ChildGameObject5_3 = enemies5.transform.GetChild(3).gameObject;
                    ChildGameObject5_3.SetActive(false);
                }
                if (enemies5.transform.childCount >= 5)
                {
                    ChildGameObject5_4 = enemies5.transform.GetChild(4).gameObject;
                    ChildGameObject5_4.SetActive(false);
                }
                if (enemies5.transform.childCount >= 6)
                {
                    ChildGameObject5_5 = enemies5.transform.GetChild(5).gameObject;
                    ChildGameObject5_5.SetActive(false);
                }
                if (enemies5.transform.childCount >= 7)
                {
                    ChildGameObject5_6 = enemies5.transform.GetChild(6).gameObject;
                    ChildGameObject5_6.SetActive(false);
                }
                if (enemies5.transform.childCount >= 8)
                {
                    ChildGameObject5_7 = enemies5.transform.GetChild(7).gameObject;
                    ChildGameObject5_7.SetActive(false);
                }
                if (enemies5.transform.childCount >= 9)
                {
                    ChildGameObject5_8 = enemies5.transform.GetChild(8).gameObject;
                    ChildGameObject5_8.SetActive(false);
                }
                if (enemies5.transform.childCount >= 10)
                {
                    ChildGameObject5_9 = enemies5.transform.GetChild(9).gameObject;
                    ChildGameObject5_9.SetActive(false);
                }
            }


            if (difficultyReference.difficulty == 1)
            {
                if (easy1 != null)
                {
                    easy1.SetActive(false);
                    if (easy1.transform.childCount >= 1)
                    {
                        ChildGameObject1_0E = easy1.transform.GetChild(0).gameObject;
                        ChildGameObject1_0E.SetActive(false);
                        ChildGameObject1_0E.transform.position = originalPos1_0E;
                    }
                    if (easy1.transform.childCount >= 2)
                    {
                        ChildGameObject1_1E = easy1.transform.GetChild(1).gameObject;
                        ChildGameObject1_1E.SetActive(false);
                        ChildGameObject1_1E.transform.position = originalPos1_1E;
                    }
                    if (easy1.transform.childCount >= 3)
                    {
                        ChildGameObject1_2E = easy1.transform.GetChild(2).gameObject;
                        ChildGameObject1_2E.SetActive(false);
                        ChildGameObject1_2E.transform.position = originalPos1_2E;
                    }
                    if (easy1.transform.childCount >= 4)
                    {
                        ChildGameObject1_3E = easy1.transform.GetChild(3).gameObject;
                        ChildGameObject1_3E.SetActive(false);
                        ChildGameObject1_3E.transform.position = originalPos1_3E;
                    }
                    if (easy1.transform.childCount >= 5)
                    {
                        ChildGameObject1_4E = easy1.transform.GetChild(4).gameObject;
                        ChildGameObject1_4E.SetActive(false);
                        ChildGameObject1_4E.transform.position = originalPos1_4E;
                    }
                }
                if (easy2 != null)
                {
                    easy2.SetActive(false);
                    if (easy2.transform.childCount >= 1)
                    {
                        ChildGameObject2_0E = easy2.transform.GetChild(0).gameObject;
                        ChildGameObject2_0E.SetActive(false);
                        ChildGameObject2_0E.transform.position = originalPos2_0E;
                    }
                    if (easy2.transform.childCount >= 2)
                    {
                        ChildGameObject2_1E = easy2.transform.GetChild(1).gameObject;
                        ChildGameObject2_1E.SetActive(false);
                        ChildGameObject2_1E.transform.position = originalPos2_1E;
                    }
                    if (easy2.transform.childCount >= 3)
                    {
                        ChildGameObject2_2E = easy2.transform.GetChild(2).gameObject;
                        ChildGameObject2_2E.SetActive(false);
                        ChildGameObject2_2E.transform.position = originalPos2_2E;
                    }
                    if (easy2.transform.childCount >= 4)
                    {
                        ChildGameObject2_3E = easy2.transform.GetChild(3).gameObject;
                        ChildGameObject2_3E.SetActive(false);
                        ChildGameObject2_3E.transform.position = originalPos2_3E;
                    }
                    if (easy2.transform.childCount >= 5)
                    {
                        ChildGameObject2_4E = easy2.transform.GetChild(4).gameObject;
                        ChildGameObject2_4E.SetActive(false);
                        ChildGameObject2_4E.transform.position = originalPos2_4E;
                    }
                }
                if (easy3 != null)
                {
                    easy3.SetActive(false);
                    if (easy3.transform.childCount >= 1)
                    {
                        ChildGameObject3_0E = easy3.transform.GetChild(0).gameObject;
                        ChildGameObject3_0E.SetActive(false);
                        ChildGameObject3_0E.transform.position = originalPos3_0E;
                    }
                    if (easy3.transform.childCount >= 2)
                    {
                        ChildGameObject3_1E = easy3.transform.GetChild(1).gameObject;
                        ChildGameObject3_1E.SetActive(false);
                        ChildGameObject3_1E.transform.position = originalPos3_1E;
                    }
                    if (easy3.transform.childCount >= 3)
                    {
                        ChildGameObject3_2E = easy3.transform.GetChild(2).gameObject;
                        ChildGameObject3_2E.SetActive(false);
                        ChildGameObject3_2E.transform.position = originalPos3_2E;
                    }
                    if (easy3.transform.childCount >= 4)
                    {
                        ChildGameObject3_3E = easy3.transform.GetChild(3).gameObject;
                        ChildGameObject3_3E.SetActive(false);
                        ChildGameObject3_3E.transform.position = originalPos3_3E;
                    }
                    if (easy3.transform.childCount >= 5)
                    {
                        ChildGameObject3_4E = easy3.transform.GetChild(4).gameObject;
                        ChildGameObject3_4E.SetActive(false);
                        ChildGameObject3_4E.transform.position = originalPos3_4E;
                    }
                }
                if (easy4 != null)
                {
                    easy1.SetActive(true);
                    if (easy4.transform.childCount >= 1)
                    {
                        ChildGameObject4_0E = easy4.transform.GetChild(0).gameObject;
                        ChildGameObject4_0E.SetActive(true);
                        ChildGameObject4_0E.transform.position = originalPos4_0E;
                    }
                    if (easy4.transform.childCount >= 2)
                    {
                        ChildGameObject4_1E = easy4.transform.GetChild(1).gameObject;
                        ChildGameObject4_1E.SetActive(true);
                        ChildGameObject4_1E.transform.position = originalPos4_1E;
                    }
                    if (easy4.transform.childCount >= 3)
                    {
                        ChildGameObject4_2E = easy4.transform.GetChild(2).gameObject;
                        ChildGameObject4_2E.SetActive(true);
                        ChildGameObject4_2E.transform.position = originalPos4_2E;
                    }
                    if (easy4.transform.childCount >= 4)
                    {
                        ChildGameObject4_3E = easy4.transform.GetChild(3).gameObject;
                        ChildGameObject4_3E.SetActive(true);
                        ChildGameObject4_3E.transform.position = originalPos4_3E;
                    }
                    if (easy4.transform.childCount >= 5)
                    {
                        ChildGameObject4_4E = easy4.transform.GetChild(4).gameObject;
                        ChildGameObject4_4E.SetActive(true);
                        ChildGameObject4_4E.transform.position = originalPos4_4E;
                    }
                }
                if (easy5 != null)
                {
                    easy5.SetActive(false);
                    if (easy5.transform.childCount >= 1)
                    {
                        ChildGameObject5_0E = easy5.transform.GetChild(0).gameObject;
                        ChildGameObject5_0E.SetActive(false);
                        ChildGameObject5_0E.transform.position = originalPos5_0E;
                    }
                    if (easy5.transform.childCount >= 2)
                    {
                        ChildGameObject5_1E = easy5.transform.GetChild(1).gameObject;
                        ChildGameObject5_1E.SetActive(false);
                        ChildGameObject5_1E.transform.position = originalPos5_1E;
                    }
                    if (easy5.transform.childCount >= 3)
                    {
                        ChildGameObject5_2E = easy5.transform.GetChild(2).gameObject;
                        ChildGameObject5_2E.SetActive(false);
                        ChildGameObject5_2E.transform.position = originalPos5_2E;
                    }
                    if (easy5.transform.childCount >= 4)
                    {
                        ChildGameObject5_3E = easy5.transform.GetChild(3).gameObject;
                        ChildGameObject5_3E.SetActive(false);
                        ChildGameObject5_3E.transform.position = originalPos5_3E;
                    }
                    if (easy5.transform.childCount >= 5)
                    {
                        ChildGameObject5_4E = easy5.transform.GetChild(4).gameObject;
                        ChildGameObject5_4E.SetActive(false);
                        ChildGameObject5_4E.transform.position = originalPos5_4E;
                    }
                }
            }
            if (difficultyReference.difficulty == 2)
            {
                if (normal1 != null)
                {
                    normal1.SetActive(false);
                    if (normal1.transform.childCount >= 1)
                    {
                        ChildGameObject1_0N = normal1.transform.GetChild(0).gameObject;
                        ChildGameObject1_0N.SetActive(false);
                        ChildGameObject1_0N.transform.position = originalPos1_0N;
                    }
                    if (normal1.transform.childCount >= 2)
                    {
                        ChildGameObject1_1N = normal1.transform.GetChild(1).gameObject;
                        ChildGameObject1_1N.SetActive(false);
                        ChildGameObject1_1N.transform.position = originalPos1_1N;
                    }
                    if (normal1.transform.childCount >= 3)
                    {
                        ChildGameObject1_2N = normal1.transform.GetChild(2).gameObject;
                        ChildGameObject1_2N.SetActive(false);
                        ChildGameObject1_2N.transform.position = originalPos1_2N;
                    }
                    if (normal1.transform.childCount >= 4)
                    {
                        ChildGameObject1_3N = normal1.transform.GetChild(3).gameObject;
                        ChildGameObject1_3N.SetActive(false);
                        ChildGameObject1_3N.transform.position = originalPos1_3N;
                    }
                    if (normal1.transform.childCount >= 5)
                    {
                        ChildGameObject1_4N = normal1.transform.GetChild(4).gameObject;
                        ChildGameObject1_4N.SetActive(false);
                        ChildGameObject1_4N.transform.position = originalPos1_4N;
                    }
                }
                if (normal2 != null)
                {
                    normal2.SetActive(false);
                    if (normal2.transform.childCount >= 1)
                    {
                        ChildGameObject2_0N = normal2.transform.GetChild(0).gameObject;
                        ChildGameObject2_0N.SetActive(false);
                        ChildGameObject2_0N.transform.position = originalPos2_0N;
                    }
                    if (normal2.transform.childCount >= 2)
                    {
                        ChildGameObject2_1N = normal2.transform.GetChild(1).gameObject;
                        ChildGameObject2_1N.SetActive(false);
                        ChildGameObject2_1N.transform.position = originalPos2_1N;
                    }
                    if (normal2.transform.childCount >= 3)
                    {
                        ChildGameObject2_2N = normal2.transform.GetChild(2).gameObject;
                        ChildGameObject2_2N.SetActive(false);
                        ChildGameObject2_2N.transform.position = originalPos2_2N;
                    }
                    if (normal2.transform.childCount >= 4)
                    {
                        ChildGameObject2_3N = normal2.transform.GetChild(3).gameObject;
                        ChildGameObject2_3N.SetActive(false);
                        ChildGameObject2_3N.transform.position = originalPos2_3N;
                    }
                    if (normal2.transform.childCount >= 5)
                    {
                        ChildGameObject2_4N = normal2.transform.GetChild(4).gameObject;
                        ChildGameObject2_4N.SetActive(false);
                        ChildGameObject2_4N.transform.position = originalPos2_4N;
                    }
                }
                if (normal3 != null)
                {
                    normal3.SetActive(false);
                    if (normal3.transform.childCount >= 1)
                    {
                        ChildGameObject3_0N = normal3.transform.GetChild(0).gameObject;
                        ChildGameObject3_0N.SetActive(false);
                        ChildGameObject3_0N.transform.position = originalPos3_0N;
                    }
                    if (normal3.transform.childCount >= 2)
                    {
                        ChildGameObject3_1N = normal3.transform.GetChild(1).gameObject;
                        ChildGameObject3_1N.SetActive(false);
                        ChildGameObject3_1N.transform.position = originalPos3_1N;
                    }
                    if (normal3.transform.childCount >= 3)
                    {
                        ChildGameObject3_2N = normal3.transform.GetChild(2).gameObject;
                        ChildGameObject3_2N.SetActive(false);
                        ChildGameObject3_2N.transform.position = originalPos3_2N;
                    }
                    if (normal3.transform.childCount >= 4)
                    {
                        ChildGameObject3_3N = normal3.transform.GetChild(3).gameObject;
                        ChildGameObject3_3N.SetActive(false);
                        ChildGameObject3_3N.transform.position = originalPos3_3N;
                    }
                    if (normal3.transform.childCount >= 5)
                    {
                        ChildGameObject3_4N = normal3.transform.GetChild(4).gameObject;
                        ChildGameObject3_4N.SetActive(false);
                        ChildGameObject3_4N.transform.position = originalPos3_4N;
                    }
                }
                if (normal4 != null)
                {
                    normal1.SetActive(true);
                    if (normal4.transform.childCount >= 1)
                    {
                        ChildGameObject4_0N = normal4.transform.GetChild(0).gameObject;
                        ChildGameObject4_0N.SetActive(true);
                        ChildGameObject4_0N.transform.position = originalPos4_0N;
                    }
                    if (normal4.transform.childCount >= 2)
                    {
                        ChildGameObject4_1N = normal4.transform.GetChild(1).gameObject;
                        ChildGameObject4_1N.SetActive(true);
                        ChildGameObject4_1N.transform.position = originalPos4_1N;
                    }
                    if (normal4.transform.childCount >= 3)
                    {
                        ChildGameObject4_2N = normal4.transform.GetChild(2).gameObject;
                        ChildGameObject4_2N.SetActive(true);
                        ChildGameObject4_2N.transform.position = originalPos4_2N;
                    }
                    if (normal4.transform.childCount >= 4)
                    {
                        ChildGameObject4_3N = normal4.transform.GetChild(3).gameObject;
                        ChildGameObject4_3N.SetActive(true);
                        ChildGameObject4_3N.transform.position = originalPos4_3N;
                    }
                    if (normal4.transform.childCount >= 5)
                    {
                        ChildGameObject4_4N = normal4.transform.GetChild(4).gameObject;
                        ChildGameObject4_4N.SetActive(true);
                        ChildGameObject4_4N.transform.position = originalPos4_4N;
                    }
                }
                if (normal5 != null)
                {
                    normal5.SetActive(false);
                    if (normal5.transform.childCount >= 1)
                    {
                        ChildGameObject5_0N = normal5.transform.GetChild(0).gameObject;
                        ChildGameObject5_0N.SetActive(false);
                        ChildGameObject5_0N.transform.position = originalPos5_0N;
                    }
                    if (normal5.transform.childCount >= 2)
                    {
                        ChildGameObject5_1N = normal5.transform.GetChild(1).gameObject;
                        ChildGameObject5_1N.SetActive(false);
                        ChildGameObject5_1N.transform.position = originalPos5_1N;
                    }
                    if (normal5.transform.childCount >= 3)
                    {
                        ChildGameObject5_2N = normal5.transform.GetChild(2).gameObject;
                        ChildGameObject5_2N.SetActive(false);
                        ChildGameObject5_2N.transform.position = originalPos5_2N;
                    }
                    if (normal5.transform.childCount >= 4)
                    {
                        ChildGameObject5_3N = normal5.transform.GetChild(3).gameObject;
                        ChildGameObject5_3N.SetActive(false);
                        ChildGameObject5_3N.transform.position = originalPos5_3N;
                    }
                    if (normal5.transform.childCount >= 5)
                    {
                        ChildGameObject5_4N = normal5.transform.GetChild(4).gameObject;
                        ChildGameObject5_4N.SetActive(false);
                        ChildGameObject5_4N.transform.position = originalPos5_4N;
                    }
                }
            }

        }

        if (enemiesDissable.roomOfMap == 5)
        {
            rowsAndColumnsReference.levelColumns = rowsAndColumnsReference.levelColumns5;
            rowsAndColumnsReference.levelRows = rowsAndColumnsReference.levelRows5;
            cameraChange.cameraMove = 105;
            if (enemies1 != null)
            {
                enemies1.SetActive(false);
                if (enemies1.transform.childCount >= 1)
                {
                    ChildGameObject1_0 = enemies1.transform.GetChild(0).gameObject;
                    ChildGameObject1_0.SetActive(false);
                }
                if (enemies1.transform.childCount >= 2)
                {
                    ChildGameObject1_1 = enemies1.transform.GetChild(1).gameObject;
                    ChildGameObject1_1.SetActive(false);
                }
                if (enemies1.transform.childCount >= 3)
                {
                    ChildGameObject1_2 = enemies1.transform.GetChild(2).gameObject;
                    ChildGameObject1_2.SetActive(false);
                }
                if (enemies1.transform.childCount >= 4)
                {
                    ChildGameObject1_3 = enemies1.transform.GetChild(3).gameObject;
                    ChildGameObject1_3.SetActive(false);
                }
                if (enemies1.transform.childCount >= 5)
                {
                    ChildGameObject1_4 = enemies1.transform.GetChild(4).gameObject;
                    ChildGameObject1_4.SetActive(false);
                }
                if (enemies1.transform.childCount >= 6)
                {
                    ChildGameObject1_5 = enemies1.transform.GetChild(5).gameObject;
                    ChildGameObject1_5.SetActive(false);
                }
                if (enemies1.transform.childCount >= 7)
                {
                    ChildGameObject1_6 = enemies1.transform.GetChild(6).gameObject;
                    ChildGameObject1_6.SetActive(false);
                }
                if (enemies1.transform.childCount >= 8)
                {
                    ChildGameObject1_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject1_7.SetActive(false);
                }
                if (enemies1.transform.childCount >= 9)
                {
                    ChildGameObject1_8 = enemies1.transform.GetChild(8).gameObject;
                    ChildGameObject1_8.SetActive(false);
                }
                if (enemies1.transform.childCount >= 10)
                {
                    ChildGameObject1_9 = enemies1.transform.GetChild(9).gameObject;
                    ChildGameObject1_9.SetActive(false);
                }
                if (enemies1.transform.childCount >= 11)
                {
                    ChildGameObject1_10 = enemies1.transform.GetChild(10).gameObject;
                    ChildGameObject1_10.SetActive(false);
                }
                if (enemies1.transform.childCount >= 12)
                {
                    ChildGameObject1_11 = enemies1.transform.GetChild(11).gameObject;
                    ChildGameObject1_11.SetActive(false);
                }
            }
            if (enemies2 != null)
            {
                enemies2.SetActive(false);
                if (enemies2.transform.childCount >= 1)
                {
                    ChildGameObject2_0 = enemies2.transform.GetChild(0).gameObject;
                    ChildGameObject2_0.SetActive(false);
                }
                if (enemies2.transform.childCount >= 2)
                {
                    ChildGameObject2_1 = enemies2.transform.GetChild(1).gameObject;
                    ChildGameObject2_1.SetActive(false);
                }
                if (enemies2.transform.childCount >= 3)
                {
                    ChildGameObject2_2 = enemies2.transform.GetChild(2).gameObject;
                    ChildGameObject2_2.SetActive(false);
                }
                if (enemies2.transform.childCount >= 4)
                {
                    ChildGameObject2_3 = enemies2.transform.GetChild(3).gameObject;
                    ChildGameObject2_3.SetActive(false);
                }
                if (enemies2.transform.childCount >= 5)
                {
                    ChildGameObject2_4 = enemies2.transform.GetChild(4).gameObject;
                    ChildGameObject2_4.SetActive(false);
                }
                if (enemies2.transform.childCount >= 6)
                {
                    ChildGameObject2_5 = enemies2.transform.GetChild(5).gameObject;
                    ChildGameObject2_5.SetActive(false);
                }
                if (enemies2.transform.childCount >= 7)
                {
                    ChildGameObject2_6 = enemies2.transform.GetChild(6).gameObject;
                    ChildGameObject2_6.SetActive(false);
                }
                if (enemies2.transform.childCount >= 8)
                {
                    ChildGameObject2_7 = enemies2.transform.GetChild(7).gameObject;
                    ChildGameObject2_7.SetActive(false);
                }
                if (enemies2.transform.childCount >= 9)
                {
                    ChildGameObject2_8 = enemies2.transform.GetChild(8).gameObject;
                    ChildGameObject2_8.SetActive(false);
                }
                if (enemies2.transform.childCount >= 10)
                {
                    ChildGameObject2_9 = enemies2.transform.GetChild(9).gameObject;
                    ChildGameObject2_9.SetActive(false);
                }
            }
            if (enemies3 != null)
            {
                enemies3.SetActive(false);
                if (enemies3.transform.childCount >= 1)
                {
                    ChildGameObject3_0 = enemies3.transform.GetChild(0).gameObject;
                    ChildGameObject3_0.SetActive(false);
                }
                if (enemies3.transform.childCount >= 2)
                {
                    ChildGameObject3_1 = enemies3.transform.GetChild(1).gameObject;
                    ChildGameObject3_1.SetActive(false);
                }
                if (enemies3.transform.childCount >= 3)
                {
                    ChildGameObject3_2 = enemies3.transform.GetChild(2).gameObject;
                    ChildGameObject3_2.SetActive(false);
                }
                if (enemies3.transform.childCount >= 4)
                {
                    ChildGameObject3_3 = enemies3.transform.GetChild(3).gameObject;
                    ChildGameObject3_3.SetActive(false);
                }
                if (enemies3.transform.childCount >= 5)
                {
                    ChildGameObject3_4 = enemies3.transform.GetChild(4).gameObject;
                    ChildGameObject3_4.SetActive(false);
                }
                if (enemies3.transform.childCount >= 6)
                {
                    ChildGameObject3_5 = enemies3.transform.GetChild(5).gameObject;
                    ChildGameObject3_5.SetActive(false);
                }
                if (enemies3.transform.childCount >= 7)
                {
                    ChildGameObject3_6 = enemies3.transform.GetChild(6).gameObject;
                    ChildGameObject3_6.SetActive(false);
                }
                if (enemies3.transform.childCount >= 8)
                {
                    ChildGameObject3_7 = enemies3.transform.GetChild(7).gameObject;
                    ChildGameObject3_7.SetActive(false);
                }
                if (enemies3.transform.childCount >= 9)
                {
                    ChildGameObject3_8 = enemies3.transform.GetChild(8).gameObject;
                    ChildGameObject3_8.SetActive(false);
                }
                if (enemies3.transform.childCount >= 10)
                {
                    ChildGameObject3_9 = enemies3.transform.GetChild(9).gameObject;
                    ChildGameObject3_9.SetActive(false);
                }
            }
            if (enemies4 != null)
            {
                enemies4.SetActive(false);
                if (enemies4.transform.childCount >= 1)
                {
                    ChildGameObject4_0 = enemies4.transform.GetChild(0).gameObject;
                    ChildGameObject4_0.SetActive(false);
                }
                if (enemies4.transform.childCount >= 2)
                {
                    ChildGameObject4_1 = enemies4.transform.GetChild(1).gameObject;
                    ChildGameObject4_1.SetActive(false);
                }
                if (enemies4.transform.childCount >= 3)
                {
                    ChildGameObject4_2 = enemies4.transform.GetChild(2).gameObject;
                    ChildGameObject4_2.SetActive(false);
                }
                if (enemies4.transform.childCount >= 4)
                {
                    ChildGameObject4_3 = enemies4.transform.GetChild(3).gameObject;
                    ChildGameObject4_3.SetActive(false);
                }
                if (enemies4.transform.childCount >= 5)
                {
                    ChildGameObject4_4 = enemies4.transform.GetChild(4).gameObject;
                    ChildGameObject4_4.SetActive(false);
                }
                if (enemies4.transform.childCount >= 6)
                {
                    ChildGameObject4_5 = enemies4.transform.GetChild(5).gameObject;
                    ChildGameObject4_5.SetActive(false);
                }
                if (enemies4.transform.childCount >= 7)
                {
                    ChildGameObject4_6 = enemies4.transform.GetChild(6).gameObject;
                    ChildGameObject4_6.SetActive(false);
                }
                if (enemies4.transform.childCount >= 8)
                {
                    ChildGameObject4_7 = enemies1.transform.GetChild(7).gameObject;
                    ChildGameObject4_7.SetActive(false);
                }
                if (enemies4.transform.childCount >= 9)
                {
                    ChildGameObject4_8 = enemies4.transform.GetChild(8).gameObject;
                    ChildGameObject4_8.SetActive(false);
                }
                if (enemies4.transform.childCount >= 10)
                {
                    ChildGameObject4_9 = enemies4.transform.GetChild(9).gameObject;
                    ChildGameObject4_9.SetActive(false);
                }
            }
            if (enemies5 != null)
            {
                enemies5.SetActive(true);
                if (enemies5.transform.childCount >= 1)
                {
                    ChildGameObject5_0 = enemies5.transform.GetChild(0).gameObject;
                    ChildGameObject5_0.SetActive(true);
                    ChildGameObject5_0.transform.position = originalPos5_0;
                }
                if (enemies5.transform.childCount >= 2)
                {
                    ChildGameObject5_1 = enemies5.transform.GetChild(1).gameObject;
                    ChildGameObject5_1.SetActive(true);
                    ChildGameObject5_1.transform.position = originalPos5_1;
                }
                if (enemies5.transform.childCount >= 3)
                {
                    ChildGameObject5_2 = enemies5.transform.GetChild(2).gameObject;
                    ChildGameObject5_2.SetActive(true);
                    ChildGameObject5_2.transform.position = originalPos5_2;
                }
                if (enemies5.transform.childCount >= 4)
                {
                    ChildGameObject5_3 = enemies5.transform.GetChild(3).gameObject;
                    ChildGameObject5_3.SetActive(true);
                    ChildGameObject5_3.transform.position = originalPos5_3;
                }
                if (enemies5.transform.childCount >= 5)
                {
                    ChildGameObject5_4 = enemies5.transform.GetChild(4).gameObject;
                    ChildGameObject5_4.SetActive(true);
                    ChildGameObject5_4.transform.position = originalPos5_4;
                }
                if (enemies5.transform.childCount >= 6)
                {
                    ChildGameObject5_5 = enemies5.transform.GetChild(5).gameObject;
                    ChildGameObject5_5.SetActive(true);
                    ChildGameObject5_5.transform.position = originalPos5_5;
                }
                if (enemies5.transform.childCount >= 7)
                {
                    ChildGameObject5_6 = enemies5.transform.GetChild(6).gameObject;
                    ChildGameObject5_6.SetActive(true);
                    ChildGameObject5_6.transform.position = originalPos5_6;
                }
                if (enemies5.transform.childCount >= 8)
                {
                    ChildGameObject5_7 = enemies5.transform.GetChild(7).gameObject;
                    ChildGameObject5_7.SetActive(true);
                    ChildGameObject5_7.transform.position = originalPos5_7;
                }
                if (enemies5.transform.childCount >= 9)
                {
                    ChildGameObject5_8 = enemies5.transform.GetChild(8).gameObject;
                    ChildGameObject5_8.SetActive(true);
                    ChildGameObject5_8.transform.position = originalPos5_8;
                }
                if (enemies5.transform.childCount >= 10)
                {
                    ChildGameObject5_9 = enemies5.transform.GetChild(9).gameObject;
                    ChildGameObject5_9.SetActive(true);
                    ChildGameObject5_9.transform.position = originalPos5_9;
                }
            }


            if (difficultyReference.difficulty == 1)
            {
                if (easy1 != null)
                {
                    easy1.SetActive(false);
                    if (easy1.transform.childCount >= 1)
                    {
                        ChildGameObject1_0E = easy1.transform.GetChild(0).gameObject;
                        ChildGameObject1_0E.SetActive(false);
                        ChildGameObject1_0E.transform.position = originalPos1_0E;
                    }
                    if (easy1.transform.childCount >= 2)
                    {
                        ChildGameObject1_1E = easy1.transform.GetChild(1).gameObject;
                        ChildGameObject1_1E.SetActive(false);
                        ChildGameObject1_1E.transform.position = originalPos1_1E;
                    }
                    if (easy1.transform.childCount >= 3)
                    {
                        ChildGameObject1_2E = easy1.transform.GetChild(2).gameObject;
                        ChildGameObject1_2E.SetActive(false);
                        ChildGameObject1_2E.transform.position = originalPos1_2E;
                    }
                    if (easy1.transform.childCount >= 4)
                    {
                        ChildGameObject1_3E = easy1.transform.GetChild(3).gameObject;
                        ChildGameObject1_3E.SetActive(false);
                        ChildGameObject1_3E.transform.position = originalPos1_3E;
                    }
                    if (easy1.transform.childCount >= 5)
                    {
                        ChildGameObject1_4E = easy1.transform.GetChild(4).gameObject;
                        ChildGameObject1_4E.SetActive(false);
                        ChildGameObject1_4E.transform.position = originalPos1_4E;
                    }
                }
                if (easy2 != null)
                {
                    easy2.SetActive(false);
                    if (easy2.transform.childCount >= 1)
                    {
                        ChildGameObject2_0E = easy2.transform.GetChild(0).gameObject;
                        ChildGameObject2_0E.SetActive(false);
                        ChildGameObject2_0E.transform.position = originalPos2_0E;
                    }
                    if (easy2.transform.childCount >= 2)
                    {
                        ChildGameObject2_1E = easy2.transform.GetChild(1).gameObject;
                        ChildGameObject2_1E.SetActive(false);
                        ChildGameObject2_1E.transform.position = originalPos2_1E;
                    }
                    if (easy2.transform.childCount >= 3)
                    {
                        ChildGameObject2_2E = easy2.transform.GetChild(2).gameObject;
                        ChildGameObject2_2E.SetActive(false);
                        ChildGameObject2_2E.transform.position = originalPos2_2E;
                    }
                    if (easy2.transform.childCount >= 4)
                    {
                        ChildGameObject2_3E = easy2.transform.GetChild(3).gameObject;
                        ChildGameObject2_3E.SetActive(false);
                        ChildGameObject2_3E.transform.position = originalPos2_3E;
                    }
                    if (easy2.transform.childCount >= 5)
                    {
                        ChildGameObject2_4E = easy2.transform.GetChild(4).gameObject;
                        ChildGameObject2_4E.SetActive(false);
                        ChildGameObject2_4E.transform.position = originalPos2_4E;
                    }
                }
                if (easy3 != null)
                {
                    easy3.SetActive(false);
                    if (easy3.transform.childCount >= 1)
                    {
                        ChildGameObject3_0E = easy3.transform.GetChild(0).gameObject;
                        ChildGameObject3_0E.SetActive(false);
                        ChildGameObject3_0E.transform.position = originalPos3_0E;
                    }
                    if (easy3.transform.childCount >= 2)
                    {
                        ChildGameObject3_1E = easy3.transform.GetChild(1).gameObject;
                        ChildGameObject3_1E.SetActive(false);
                        ChildGameObject3_1E.transform.position = originalPos3_1E;
                    }
                    if (easy3.transform.childCount >= 3)
                    {
                        ChildGameObject3_2E = easy3.transform.GetChild(2).gameObject;
                        ChildGameObject3_2E.SetActive(false);
                        ChildGameObject3_2E.transform.position = originalPos3_2E;
                    }
                    if (easy3.transform.childCount >= 4)
                    {
                        ChildGameObject3_3E = easy3.transform.GetChild(3).gameObject;
                        ChildGameObject3_3E.SetActive(false);
                        ChildGameObject3_3E.transform.position = originalPos3_3E;
                    }
                    if (easy3.transform.childCount >= 5)
                    {
                        ChildGameObject3_4E = easy3.transform.GetChild(4).gameObject;
                        ChildGameObject3_4E.SetActive(false);
                        ChildGameObject3_4E.transform.position = originalPos3_4E;
                    }
                }
                if (easy4 != null)
                {
                    easy1.SetActive(false);
                    if (easy4.transform.childCount >= 1)
                    {
                        ChildGameObject4_0E = easy4.transform.GetChild(0).gameObject;
                        ChildGameObject4_0E.SetActive(false);
                        ChildGameObject4_0E.transform.position = originalPos4_0E;
                    }
                    if (easy4.transform.childCount >= 2)
                    {
                        ChildGameObject4_1E = easy4.transform.GetChild(1).gameObject;
                        ChildGameObject4_1E.SetActive(false);
                        ChildGameObject4_1E.transform.position = originalPos4_1E;
                    }
                    if (easy4.transform.childCount >= 3)
                    {
                        ChildGameObject4_2E = easy4.transform.GetChild(2).gameObject;
                        ChildGameObject4_2E.SetActive(false);
                        ChildGameObject4_2E.transform.position = originalPos4_2E;
                    }
                    if (easy4.transform.childCount >= 4)
                    {
                        ChildGameObject4_3E = easy4.transform.GetChild(3).gameObject;
                        ChildGameObject4_3E.SetActive(false);
                        ChildGameObject4_3E.transform.position = originalPos4_3E;
                    }
                    if (easy4.transform.childCount >= 5)
                    {
                        ChildGameObject4_4E = easy4.transform.GetChild(4).gameObject;
                        ChildGameObject4_4E.SetActive(false);
                        ChildGameObject4_4E.transform.position = originalPos4_4E;
                    }
                }
                if (easy5 != null)
                {
                    easy5.SetActive(true);
                    if (easy5.transform.childCount >= 1)
                    {
                        ChildGameObject5_0E = easy5.transform.GetChild(0).gameObject;
                        ChildGameObject5_0E.SetActive(true);
                        ChildGameObject5_0E.transform.position = originalPos5_0E;
                    }
                    if (easy5.transform.childCount >= 2)
                    {
                        ChildGameObject5_1E = easy5.transform.GetChild(1).gameObject;
                        ChildGameObject5_1E.SetActive(true);
                        ChildGameObject5_1E.transform.position = originalPos5_1E;
                    }
                    if (easy5.transform.childCount >= 3)
                    {
                        ChildGameObject5_2E = easy5.transform.GetChild(2).gameObject;
                        ChildGameObject5_2E.SetActive(true);
                        ChildGameObject5_2E.transform.position = originalPos5_2E;
                    }
                    if (easy5.transform.childCount >= 4)
                    {
                        ChildGameObject5_3E = easy5.transform.GetChild(3).gameObject;
                        ChildGameObject5_3E.SetActive(true);
                        ChildGameObject5_3E.transform.position = originalPos5_3E;
                    }
                    if (easy5.transform.childCount >= 5)
                    {
                        ChildGameObject5_4E = easy5.transform.GetChild(4).gameObject;
                        ChildGameObject5_4E.SetActive(true);
                        ChildGameObject5_4E.transform.position = originalPos5_4E;
                    }
                }
            }
            if (difficultyReference.difficulty == 2)
            {
                if (normal1 != null)
                {
                    normal1.SetActive(false);
                    if (normal1.transform.childCount >= 1)
                    {
                        ChildGameObject1_0N = normal1.transform.GetChild(0).gameObject;
                        ChildGameObject1_0N.SetActive(false);
                        ChildGameObject1_0N.transform.position = originalPos1_0N;
                    }
                    if (normal1.transform.childCount >= 2)
                    {
                        ChildGameObject1_1N = normal1.transform.GetChild(1).gameObject;
                        ChildGameObject1_1N.SetActive(false);
                        ChildGameObject1_1N.transform.position = originalPos1_1N;
                    }
                    if (normal1.transform.childCount >= 3)
                    {
                        ChildGameObject1_2N = normal1.transform.GetChild(2).gameObject;
                        ChildGameObject1_2N.SetActive(false);
                        ChildGameObject1_2N.transform.position = originalPos1_2N;
                    }
                    if (normal1.transform.childCount >= 4)
                    {
                        ChildGameObject1_3N = normal1.transform.GetChild(3).gameObject;
                        ChildGameObject1_3N.SetActive(false);
                        ChildGameObject1_3N.transform.position = originalPos1_3N;
                    }
                    if (normal1.transform.childCount >= 5)
                    {
                        ChildGameObject1_4N = normal1.transform.GetChild(4).gameObject;
                        ChildGameObject1_4N.SetActive(false);
                        ChildGameObject1_4N.transform.position = originalPos1_4N;
                    }
                }
                if (normal2 != null)
                {
                    normal2.SetActive(false);
                    if (normal2.transform.childCount >= 1)
                    {
                        ChildGameObject2_0N = normal2.transform.GetChild(0).gameObject;
                        ChildGameObject2_0N.SetActive(false);
                        ChildGameObject2_0N.transform.position = originalPos2_0N;
                    }
                    if (normal2.transform.childCount >= 2)
                    {
                        ChildGameObject2_1N = normal2.transform.GetChild(1).gameObject;
                        ChildGameObject2_1N.SetActive(false);
                        ChildGameObject2_1N.transform.position = originalPos2_1N;
                    }
                    if (normal2.transform.childCount >= 3)
                    {
                        ChildGameObject2_2N = normal2.transform.GetChild(2).gameObject;
                        ChildGameObject2_2N.SetActive(false);
                        ChildGameObject2_2N.transform.position = originalPos2_2N;
                    }
                    if (normal2.transform.childCount >= 4)
                    {
                        ChildGameObject2_3N = normal2.transform.GetChild(3).gameObject;
                        ChildGameObject2_3N.SetActive(false);
                        ChildGameObject2_3N.transform.position = originalPos2_3N;
                    }
                    if (normal2.transform.childCount >= 5)
                    {
                        ChildGameObject2_4N = normal2.transform.GetChild(4).gameObject;
                        ChildGameObject2_4N.SetActive(false);
                        ChildGameObject2_4N.transform.position = originalPos2_4N;
                    }
                }
                if (normal3 != null)
                {
                    normal3.SetActive(false);
                    if (normal3.transform.childCount >= 1)
                    {
                        ChildGameObject3_0N = normal3.transform.GetChild(0).gameObject;
                        ChildGameObject3_0N.SetActive(false);
                        ChildGameObject3_0N.transform.position = originalPos3_0N;
                    }
                    if (normal3.transform.childCount >= 2)
                    {
                        ChildGameObject3_1N = normal3.transform.GetChild(1).gameObject;
                        ChildGameObject3_1N.SetActive(false);
                        ChildGameObject3_1N.transform.position = originalPos3_1N;
                    }
                    if (normal3.transform.childCount >= 3)
                    {
                        ChildGameObject3_2N = normal3.transform.GetChild(2).gameObject;
                        ChildGameObject3_2N.SetActive(false);
                        ChildGameObject3_2N.transform.position = originalPos3_2N;
                    }
                    if (normal3.transform.childCount >= 4)
                    {
                        ChildGameObject3_3N = normal3.transform.GetChild(3).gameObject;
                        ChildGameObject3_3N.SetActive(false);
                        ChildGameObject3_3N.transform.position = originalPos3_3N;
                    }
                    if (normal3.transform.childCount >= 5)
                    {
                        ChildGameObject3_4N = normal3.transform.GetChild(4).gameObject;
                        ChildGameObject3_4N.SetActive(false);
                        ChildGameObject3_4N.transform.position = originalPos3_4N;
                    }
                }
                if (normal4 != null)
                {
                    normal1.SetActive(false);
                    if (normal4.transform.childCount >= 1)
                    {
                        ChildGameObject4_0N = normal4.transform.GetChild(0).gameObject;
                        ChildGameObject4_0N.SetActive(false);
                        ChildGameObject4_0N.transform.position = originalPos4_0N;
                    }
                    if (normal4.transform.childCount >= 2)
                    {
                        ChildGameObject4_1N = normal4.transform.GetChild(1).gameObject;
                        ChildGameObject4_1N.SetActive(false);
                        ChildGameObject4_1N.transform.position = originalPos4_1N;
                    }
                    if (normal4.transform.childCount >= 3)
                    {
                        ChildGameObject4_2N = normal4.transform.GetChild(2).gameObject;
                        ChildGameObject4_2N.SetActive(false);
                        ChildGameObject4_2N.transform.position = originalPos4_2N;
                    }
                    if (normal4.transform.childCount >= 4)
                    {
                        ChildGameObject4_3N = normal4.transform.GetChild(3).gameObject;
                        ChildGameObject4_3N.SetActive(false);
                        ChildGameObject4_3N.transform.position = originalPos4_3N;
                    }
                    if (normal4.transform.childCount >= 5)
                    {
                        ChildGameObject4_4N = normal4.transform.GetChild(4).gameObject;
                        ChildGameObject4_4N.SetActive(false);
                        ChildGameObject4_4N.transform.position = originalPos4_4N;
                    }
                }
                if (normal5 != null)
                {
                    normal5.SetActive(true);
                    if (normal5.transform.childCount >= 1)
                    {
                        ChildGameObject5_0N = normal5.transform.GetChild(0).gameObject;
                        ChildGameObject5_0N.SetActive(true);
                        ChildGameObject5_0N.transform.position = originalPos5_0N;
                    }
                    if (normal5.transform.childCount >= 2)
                    {
                        ChildGameObject5_1N = normal5.transform.GetChild(1).gameObject;
                        ChildGameObject5_1N.SetActive(true);
                        ChildGameObject5_1N.transform.position = originalPos5_1N;
                    }
                    if (normal5.transform.childCount >= 3)
                    {
                        ChildGameObject5_2N = normal5.transform.GetChild(2).gameObject;
                        ChildGameObject5_2N.SetActive(true);
                        ChildGameObject5_2N.transform.position = originalPos5_2N;
                    }
                    if (normal5.transform.childCount >= 4)
                    {
                        ChildGameObject5_3N = normal5.transform.GetChild(3).gameObject;
                        ChildGameObject5_3N.SetActive(true);
                        ChildGameObject5_3N.transform.position = originalPos5_3N;
                    }
                    if (normal5.transform.childCount >= 5)
                    {
                        ChildGameObject5_4N = normal5.transform.GetChild(4).gameObject;
                        ChildGameObject5_4N.SetActive(true);
                        ChildGameObject5_4N.transform.position = originalPos5_4N;
                    }
                }
            }

        }


        /*
        if (ExtraChild2 != null)
        {
            ExtraChild3.SetActive(true);
            ExtraChild2.transform.position = originalPosEx2;
        }
        if (ExtraChild3 != null)
        {
            ExtraChild3.SetActive(true);
            ExtraChild3.transform.position = originalPosEx3;
        }
        if (ExtraChild4 != null)
        {
            ExtraChild4.SetActive(true);
            ExtraChild4.transform.position = originalPosEx4;
        }
        if (ExtraChild5 != null)
        {
            ExtraChild5.SetActive(true);
            ExtraChild5.transform.position = originalPosEx5;
        }
        */

        enemiesActivationCheck = true;
    }
}
