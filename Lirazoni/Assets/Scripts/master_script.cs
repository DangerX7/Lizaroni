using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
// using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SceneManagement;

public class master_script : MonoBehaviour
{
    public int levelRows;
    public int levelColumns;
    public int lockKeys; // keys you need to open the door
    public int keys = 0; // current keys
    public int minMoves; //Minumum moves for completing the level
    public int moves = 0; // current moves
    public int sceneIndex; // Get Scene Number
    public int levelType; //Arcade, Story, Versus

    //Versus Mode values
    public int levelRowsV;
    public int levelColumnsV;
    public int keysV = 0;
    public int lockKeysV;
    public int id;

    public short enemyTurn;
    public short enemyTurn2;
    public bool defend;
    public bool giveDamage;

    public byte levelRooms;
    public int levelRows1;
    public int levelColumns1;
    public int levelRows2;
    public int levelColumns2;
    public int levelRows3;
    public int levelColumns3;
    public int levelRows4;
    public int levelColumns4;
    public int levelRows5;
    public int levelColumns5;

    public byte specialMoves;
    public bool movesChange;

    public bool movesEven; // false = odd, true = even

    public GameObject EasyObjects, NormalObjects, Easy1, Easy2, Easy3, Easy4, Easy5, Normal1, Normal2, Normal3, Normal4, Normal5,
        Both1, Both2, Both3, Both4, Both5;

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex; //Get current scene Index
        Debug.Log("Scene Number : " + sceneIndex);

        if (GameObject.Find("SceneUnlocker") != null)
        {
            GameObject Scn = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scn.GetComponent<scene_unlocker_script>();

            if (sceneReference.difficulty == 1)
            {
                if (GameObject.Find("Easy") != null)
                {
                    EasyObjects.SetActive(true);
                }
                if (GameObject.Find("Normal") != null)
                {
                    NormalObjects.SetActive(false);
                }
            }
            if (sceneReference.difficulty == 2)
            {
                if (GameObject.Find("Easy") != null)
                {
                    EasyObjects.SetActive(false);
                }
                if (GameObject.Find("Normal") != null)
                {
                    NormalObjects.SetActive(true);
                }
            }
        }

    }

    public static master_script current;

    private void Awake()
    {
        current = this;
    }

    public event Action<int> onSpriteChange;
    public void SpriteChange(int id)
    {
        if (onSpriteChange != null)
        {
            onSpriteChange(id);
        }
    }
    public event Action<int> onBoomerangTurn;
    public void BoomerangTurn(int id)
    {
        if (onBoomerangTurn != null)
        {
            onBoomerangTurn(id);
        }
    }

    public event Action<int> onTutorialBoxPhase;
    public void TutorialBoxPhase(int id)
    {
        if (onTutorialBoxPhase != null)
        {
            onTutorialBoxPhase(id);
        }
    }

    public event Action<int> onBoomerangTurnReverse;
    public void BoomerangTurnReverse(int id)
    {
        if (onBoomerangTurnReverse != null)
        {
            onBoomerangTurnReverse(id);
        }
    }

    public event Action<int> onWallCollisionLeftEnter;
    public void WallCollisionLeftEnter(int id)
    {
        if (onWallCollisionLeftEnter != null)
        {
            onWallCollisionLeftEnter(id);
        }
    }
    public event Action<int> onWallCollisionLeftExit;
    public void WallCollisionLeftExit(int id)
    {
        if (onWallCollisionLeftExit != null)
        {
            onWallCollisionLeftExit(id);
        }
    }
    public event Action<int> onWallCollisionRightEnter;
    public void WallCollisionRightEnter(int id)
    {
        if (onWallCollisionRightEnter != null)
        {
            onWallCollisionRightEnter(id);
        }
    }
    public event Action<int> onWallCollisionRightExit;
    public void WallCollisionRightExit(int id)
    {
        if (onWallCollisionRightExit != null)
        {
            onWallCollisionRightExit(id);
        }
    }
    public event Action<int> onWallCollisionUpEnter;
    public void WallCollisionUpEnter(int id)
    {
        if (onWallCollisionUpEnter != null)
        {
            onWallCollisionUpEnter(id);
        }
    }
    public event Action<int> onWallCollisionUpExit;
    public void WallCollisionUpExit(int id)
    {
        if (onWallCollisionUpExit != null)
        {
            onWallCollisionUpExit(id);
        }
    }
    public event Action<int> onWallCollisionDownEnter;
    public void WallCollisionDownEnter(int id)
    {
        if (onWallCollisionDownEnter != null)
        {
            onWallCollisionDownEnter(id);
        }
    }
    public event Action<int> onWallCollisionDownExit;
    public void WallCollisionDownExit(int id)
    {
        if (onWallCollisionDownExit != null)
        {
            onWallCollisionDownExit(id);
        }
    }



    public event Action<int> onWallCollisionLeftEnterX2;
    public void WallCollisionLeftEnterX2(int id)
    {
        if (onWallCollisionLeftEnterX2 != null)
        {
            onWallCollisionLeftEnterX2(id);
        }
    }
    public event Action<int> onWallCollisionLeftExitX2;
    public void WallCollisionLeftExitX2(int id)
    {
        if (onWallCollisionLeftExitX2 != null)
        {
            onWallCollisionLeftExitX2(id);
        }
    }
    public event Action<int> onWallCollisionRightEnterX2;
    public void WallCollisionRightEnterX2(int id)
    {
        if (onWallCollisionRightEnterX2 != null)
        {
            onWallCollisionRightEnterX2(id);
        }
    }
    public event Action<int> onWallCollisionRightExitX2;
    public void WallCollisionRightExitX2(int id)
    {
        if (onWallCollisionRightExitX2 != null)
        {
            onWallCollisionRightExitX2(id);
        }
    }
    public event Action<int> onWallCollisionUpEnterX2;
    public void WallCollisionUpEnterX2(int id)
    {
        if (onWallCollisionUpEnterX2 != null)
        {
            onWallCollisionUpEnterX2(id);
        }
    }
    public event Action<int> onWallCollisionUpExitX2;
    public void WallCollisionUpExitX2(int id)
    {
        if (onWallCollisionUpExitX2 != null)
        {
            onWallCollisionUpExitX2(id);
        }
    }
    public event Action<int> onWallCollisionDownEnterX2;
    public void WallCollisionDownEnterX2(int id)
    {
        if (onWallCollisionDownEnterX2 != null)
        {
            onWallCollisionDownEnterX2(id);
        }
    }
    public event Action<int> onWallCollisionDownExitX2;
    public void WallCollisionDownExitX2(int id)
    {
        if (onWallCollisionDownExitX2 != null)
        {
            onWallCollisionDownExitX2(id);
        }
    }



    public event Action<int> onWallCollisionLeftEnterBoss;
    public void WallCollisionLeftEnterBoss(int id)
    {
        if (onWallCollisionLeftEnterBoss != null)
        {
            onWallCollisionLeftEnterBoss(id);
        }
    }
    public event Action<int> onWallCollisionLeftExitBoss;
    public void WallCollisionLeftExitBoss(int id)
    {
        if (onWallCollisionLeftExitBoss != null)
        {
            onWallCollisionLeftExitBoss(id);
        }
    }
    public event Action<int> onWallCollisionRightEnterBoss;
    public void WallCollisionRightEnterBoss(int id)
    {
        if (onWallCollisionRightEnterBoss != null)
        {
            onWallCollisionRightEnterBoss(id);
        }
    }
    public event Action<int> onWallCollisionRightExitBoss;
    public void WallCollisionRightExitBoss(int id)
    {
        if (onWallCollisionRightExitBoss != null)
        {
            onWallCollisionRightExitBoss(id);
        }
    }
    public event Action<int> onWallCollisionUpEnterBoss;
    public void WallCollisionUpEnterBoss(int id)
    {
        if (onWallCollisionUpEnterBoss != null)
        {
            onWallCollisionUpEnterBoss(id);
        }
    }
    public event Action<int> onWallCollisionUpExitBoss;
    public void WallCollisionUpExitBoss(int id)
    {
        if (onWallCollisionUpExitBoss != null)
        {
            onWallCollisionUpExitBoss(id);
        }
    }
    public event Action<int> onWallCollisionDownEnterBoss;
    public void WallCollisionDownEnterBoss(int id)
    {
        if (onWallCollisionDownEnterBoss != null)
        {
            onWallCollisionDownEnterBoss(id);
        }
    }
    public event Action<int> onWallCollisionDownExitBoss;
    public void WallCollisionDownExitBoss(int id)
    {
        if (onWallCollisionDownExitBoss != null)
        {
            onWallCollisionDownExitBoss(id);
        }
    }



    public event Action<int> onEnemiesMove;
    public void EnemiesMove(int id)
    {
        if (onEnemiesMove != null)
        {
            onEnemiesMove(id);
        }
    }

    public event Action<int> onEnemiesMoveHalf;
    public void EnemiesMoveHalf(int id)
    {
        if (onEnemiesMoveHalf != null)
        {
            onEnemiesMoveHalf(id);
        }
    }

    public event Action<int> onEnemiesMoveReverse;
    public void EnemiesMoveReverse(int id)
    {
        if (onEnemiesMoveReverse != null)
        {
            onEnemiesMoveReverse(id);
        }
    }

    public event Action<int> onEnemiesMoveReverseHalf;
    public void EnemiesMoveReverseHalf(int id)
    {
        if (onEnemiesMoveReverseHalf != null)
        {
            onEnemiesMoveReverseHalf(id);
        }
    }

    public event Action<int> onHitboxActivate;
    public void HitboxActivate(int id)
    {
        if (onHitboxActivate != null)
        {
            onHitboxActivate(id);
        }
    }

    public event Action<int> onEnemiesAttack;
    public void EnemiesAttack(int id)
    {
        if (onEnemiesAttack != null)
        {
            if (defend == false)
            {
                defend = true;
            }
            else if (defend == true)
            {
                defend = false;
            }
            onEnemiesAttack(id);
        }
    }


    public event Action<int> onEnemiesAttackReverse;
    public void EnemiesAttackReverse(int id)
    {
        if (onEnemiesAttackReverse != null)
        {
            if (defend == false)
            {
                defend = true;
            }
            else if (defend == true)
            {
                defend = false;
            }
            onEnemiesAttackReverse(id);
        }
    }

    public event Action<int> onThrowerTurn;
    public void ThrowerTurn(int id)
    {
        if (onThrowerTurn != null)
        {
            onThrowerTurn(id);
        }
    }

    public event Action<int> OnEnemiesActionEnd;
    public void EnemiesActionEnd(int id)
    {
        if (OnEnemiesActionEnd != null)
        {
            OnEnemiesActionEnd(id);
        }
    }

    public event Action<int> OnEnemiesActionEndReverse;
    public void EnemiesActionEndReverse(int id)
    {
        if (OnEnemiesActionEndReverse != null)
        {
            OnEnemiesActionEndReverse(id);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (moves % 2 == 0)
        {
            movesEven = true;
        }
        else
        {
            movesEven = false;
        }


        if (GameObject.Find("SceneUnlocker") != null)
        {
            GameObject Scn = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scn.GetComponent<scene_unlocker_script>();
            GameObject Player = GameObject.Find("Player");
            player_script enemiesDissable = Player.GetComponent<player_script>();

            if (sceneReference.difficulty == 1)
            {
                if (levelRooms == 2)
                {
                    if (enemiesDissable.roomOfMap == 1)
                    {
                        Easy1.SetActive(true);
                        Easy2.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 2)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(true);
                    }
                }
                if (levelRooms == 3)
                {
                    if (enemiesDissable.roomOfMap == 1)
                    {
                        Easy1.SetActive(true);
                        Easy2.SetActive(false);
                        Easy3.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 2)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(true);
                        Easy3.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 3)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(false);
                        Easy3.SetActive(true);
                    }
                }
                if (levelRooms == 4)
                {
                    if (enemiesDissable.roomOfMap == 1)
                    {
                        Easy1.SetActive(true);
                        Easy2.SetActive(false);
                        Easy3.SetActive(false);
                        Easy4.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 2)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(true);
                        Easy3.SetActive(false);
                        Easy4.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 3)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(false);
                        Easy3.SetActive(true);
                        Easy4.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 4)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(false);
                        Easy3.SetActive(false);
                        Easy4.SetActive(true);
                    }
                }
                if (levelRooms == 5)
                {
                    if (enemiesDissable.roomOfMap == 1)
                    {
                        Easy1.SetActive(true);
                        Easy2.SetActive(false);
                        Easy3.SetActive(false);
                        Easy4.SetActive(false);
                        Easy5.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 2)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(true);
                        Easy3.SetActive(false);
                        Easy4.SetActive(false);
                        Easy5.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 3)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(false);
                        Easy3.SetActive(true);
                        Easy4.SetActive(false);
                        Easy5.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 4)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(false);
                        Easy3.SetActive(false);
                        Easy4.SetActive(true);
                        Easy5.SetActive(false);
                    }
                    if (enemiesDissable.roomOfMap == 5)
                    {
                        Easy1.SetActive(false);
                        Easy2.SetActive(false);
                        Easy3.SetActive(false);
                        Easy4.SetActive(false);
                        Easy5.SetActive(true);
                    }
                }
            }
            if (sceneReference.difficulty == 2)
            {
                if (GameObject.Find("Normal Exception") != null)
                {

                }
                else
                {
                    if (levelRooms == 2)
                    {
                        if (enemiesDissable.roomOfMap == 1)
                        {
                            Normal1.SetActive(true);
                            Normal2.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 2)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(true);
                        }
                    }
                    if (levelRooms == 3)
                    {
                        if (enemiesDissable.roomOfMap == 1)
                        {
                            Normal1.SetActive(true);
                            Normal2.SetActive(false);
                            Normal3.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 2)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(true);
                            Normal3.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 3)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(false);
                            Normal3.SetActive(true);
                        }
                    }
                    if (levelRooms == 4)
                    {
                        if (enemiesDissable.roomOfMap == 1)
                        {
                            Normal1.SetActive(true);
                            Normal2.SetActive(false);
                            Normal3.SetActive(false);
                            Normal4.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 2)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(true);
                            Normal3.SetActive(false);
                            Normal4.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 3)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(false);
                            Normal3.SetActive(true);
                            Normal4.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 4)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(false);
                            Normal3.SetActive(false);
                            Normal4.SetActive(true);
                        }
                    }
                    if (levelRooms == 5)
                    {
                        if (enemiesDissable.roomOfMap == 1)
                        {
                            Normal1.SetActive(true);
                            Normal2.SetActive(false);
                            Normal3.SetActive(false);
                            Normal4.SetActive(false);
                            Normal5.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 2)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(true);
                            Normal3.SetActive(false);
                            Normal4.SetActive(false);
                            Normal5.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 3)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(false);
                            Normal3.SetActive(true);
                            Normal4.SetActive(false);
                            Normal5.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 4)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(false);
                            Normal3.SetActive(false);
                            Normal4.SetActive(true);
                            Normal5.SetActive(false);
                        }
                        if (enemiesDissable.roomOfMap == 5)
                        {
                            Normal1.SetActive(false);
                            Normal2.SetActive(false);
                            Normal3.SetActive(false);
                            Normal4.SetActive(false);
                            Normal5.SetActive(true);
                        }
                    }
                }
            }
        }

        /*
        Debug.Log("1= " + enemyTurn);
        Debug.Log("2= " + enemyTurn2);
        */
        if (enemyTurn == 32)
        {
            enemyTurn = 0;
        }
        if (enemyTurn2 == 32)
        {
            enemyTurn2 = 0;
        }


    }

}
