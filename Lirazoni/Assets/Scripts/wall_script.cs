using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_script : MonoBehaviour
{

    public int id;
    public bool destroyCheck;
    public byte DESTROY_DIR_CHECK;// 1-left,2-right,3-up,4-down
    public byte laserValue;
    // Start is called before the first frame update
    void Start()
    {

        if ((GameObject.Find("SceneUnlocker") != null))
        {
            GameObject Scene = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scene.GetComponent<scene_unlocker_script>();

            if ((laserValue == 1) && (sceneReference.door2_10Lock1 == true))
            {
                Destroy(this.gameObject);
            }
            if ((laserValue == 2) && (sceneReference.door2_10Lock2 == true))
            {
                Destroy(this.gameObject);
            }
            if ((laserValue == 3) && (sceneReference.dissableFinalLaser == true))
            {
                Destroy(this.gameObject);
            }
        }


        master_script.current.onWallCollisionLeftEnter += OnWallCollisionLeftEnterCheck;
        master_script.current.onWallCollisionLeftExit += OnWallCollisionLeftExitCheck;
        master_script.current.onWallCollisionRightEnter += OnWallCollisionRightEnterCheck;
        master_script.current.onWallCollisionRightExit += OnWallCollisionRightExitCheck;
        master_script.current.onWallCollisionUpEnter += OnWallCollisionUpEnterCheck;
        master_script.current.onWallCollisionUpExit += OnWallCollisionUpExitCheck;
        master_script.current.onWallCollisionDownEnter += OnWallCollisionDownEnterCheck;
        master_script.current.onWallCollisionDownExit += OnWallCollisionDownExitCheck;

        master_script.current.onWallCollisionLeftEnterBoss += OnWallCollisionLeftEnterCheck;
        master_script.current.onWallCollisionLeftExitBoss += OnWallCollisionLeftExitCheck;
        master_script.current.onWallCollisionRightEnterBoss += OnWallCollisionRightEnterCheck;
        master_script.current.onWallCollisionRightExitBoss += OnWallCollisionRightExitCheck;
        master_script.current.onWallCollisionUpEnterBoss += OnWallCollisionUpEnterCheck;
        master_script.current.onWallCollisionUpExitBoss += OnWallCollisionUpExitCheck;
        master_script.current.onWallCollisionDownEnterBoss += OnWallCollisionDownEnterCheck;
        master_script.current.onWallCollisionDownExitBoss += OnWallCollisionDownExitCheck;

        master_script.current.onWallCollisionLeftEnterX2 += OnWallCollisionLeftEnterCheckX2;
        master_script.current.onWallCollisionLeftExitX2 += OnWallCollisionLeftExitCheckX2;
        master_script.current.onWallCollisionRightEnterX2 += OnWallCollisionRightEnterCheckX2;
        master_script.current.onWallCollisionRightExitX2 += OnWallCollisionRightExitCheckX2;
        master_script.current.onWallCollisionUpEnterX2 += OnWallCollisionUpEnterCheckX2;
        master_script.current.onWallCollisionUpExitX2 += OnWallCollisionUpExitCheckX2;
        master_script.current.onWallCollisionDownEnterX2 += OnWallCollisionDownEnterCheckX2;
        master_script.current.onWallCollisionDownExitX2 += OnWallCollisionDownExitCheckX2;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            GameObject Player = GameObject.Find("Player");
            player_script lockReference = Player.GetComponent<player_script>();

            if (destroyCheck == true)
            {
                if (DESTROY_DIR_CHECK == 1)
                {
                    lockReference.leftlock = false;
                }
                if (DESTROY_DIR_CHECK == 2)
                {
                    lockReference.rightlock = false;
                }
                if (DESTROY_DIR_CHECK == 3)
                {
                    lockReference.uplock = false;
                }
                if (DESTROY_DIR_CHECK == 4)
                {
                    lockReference.downlock = false;
                }
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.GetChild(0).gameObject.SetActive(false);
            }
        }
    }

    private void OnWallCollisionLeftEnterCheck(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();


            if (id == 0)
        {
         //      Debug.Log("left_limit_enter");
            lockReference.leftlock = true;
        }
        if ((id == 1) && (GameObject.Find("Player2") != null))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script lockReference2 = Player2.GetComponent<player_script>();
            lockReference2.leftlock2 = true;
        }

        if (id == 10)
        {
            if (GameObject.Find("Real") != null)
            {
                GameObject Boss = GameObject.Find("Real");
                boss4a_script wallReff = Boss.GetComponent<boss4a_script>();

                wallReff.wallLeft = true;
            }
        }
    }
    private void OnWallCollisionLeftExitCheck(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();


        if (id == 0)
        {
         //   Debug.Log("left_limit_exit");
              lockReference.leftlock = false;
        }
        if ((id == 1) && (GameObject.Find("Player2") != null))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script lockReference2 = Player2.GetComponent<player_script>();
            lockReference2.leftlock2 = false;
        }

        if (id == 10)
        {
            if (GameObject.Find("Real") != null)
            {
                GameObject Boss = GameObject.Find("Real");
                boss4a_script wallReff = Boss.GetComponent<boss4a_script>();

                wallReff.wallLeft = false;
            }
        }
    }
    private void OnWallCollisionRightEnterCheck(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();


        if (id == 0)
        {
            //    Debug.Log("right_limit_enter");
            lockReference.rightlock = true;
        }
        if ((id == 1) && (GameObject.Find("Player2") != null))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script lockReference2 = Player2.GetComponent<player_script>();
            lockReference2.rightlock2 = true;
        }

        if (id == 10)
        {
            if (GameObject.Find("Real") != null)
            {
                GameObject Boss = GameObject.Find("Real");
                boss4a_script wallReff = Boss.GetComponent<boss4a_script>();

                wallReff.wallRight = true;
            }
        }
    }
    private void OnWallCollisionRightExitCheck(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();


        if (id == 0)
        {
         //       Debug.Log("right_limit_exit");
            lockReference.rightlock = false;
        }
        if ((id == 1) && (GameObject.Find("Player2") != null))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script lockReference2 = Player2.GetComponent<player_script>();
            lockReference2.rightlock2 = false;
        }

        if (id == 10)
        {
            if (GameObject.Find("Real") != null)
            {
                GameObject Boss = GameObject.Find("Real");
                boss4a_script wallReff = Boss.GetComponent<boss4a_script>();

                wallReff.wallRight = false;
            }
        }
    }

    private void OnWallCollisionUpEnterCheck(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();


        if (id == 0)
        {
            //    Debug.Log("up_limit_enter");
            lockReference.uplock = true;
            
        }
        if ((id == 1) && (GameObject.Find("Player2") != null))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script lockReference2 = Player2.GetComponent<player_script>();
            lockReference2.uplock2 = true;
        }

        if (id == 10)
        {
            if (GameObject.Find("Real") != null)
            {
                GameObject Boss = GameObject.Find("Real");
                boss4a_script wallReff = Boss.GetComponent<boss4a_script>();

                wallReff.wallUp = true;
            }
        }
    }
    private void OnWallCollisionUpExitCheck(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();


        if (id == 0)
        {
         //      Debug.Log("up_limit_exit");
            lockReference.uplock = false;
        }
        if ((id == 1) && (GameObject.Find("Player2") != null))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script lockReference2 = Player2.GetComponent<player_script>();
            lockReference2.uplock2 = false;
        }

        if (id == 10)
        {
            if (GameObject.Find("Real") != null)
            {
                GameObject Boss = GameObject.Find("Real");
                boss4a_script wallReff = Boss.GetComponent<boss4a_script>();

                wallReff.wallUp = false;
            }
        }
    }
    private void OnWallCollisionDownEnterCheck(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();


        if (id == 0)
        {
         //      Debug.Log("down_limit_enter");
            lockReference.downlock = true;
            
        }
        if ((id == 1) && (GameObject.Find("Player2") != null))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script lockReference2 = Player2.GetComponent<player_script>();
            lockReference2.downlock2 = true;
        }

        if (id == 10)
        {
            if (GameObject.Find("Real") != null)
            {
                GameObject Boss = GameObject.Find("Real");
                boss4a_script wallReff = Boss.GetComponent<boss4a_script>();

                wallReff.wallDown = true;
            }
        }
    }
    private void OnWallCollisionDownExitCheck(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();


        if (id == 0)
        {
         //      Debug.Log("down_limit_exit");
            lockReference.downlock = false;
        }
        if ((id == 1) && (GameObject.Find("Player2") != null))
        {
            GameObject Player2 = GameObject.Find("Player2");
            player_script lockReference2 = Player2.GetComponent<player_script>();
            lockReference2.downlock2 = false;
        }

        if (id == 10)
        {
            if (GameObject.Find("Real") != null)
            {
                GameObject Boss = GameObject.Find("Real");
                boss4a_script wallReff = Boss.GetComponent<boss4a_script>();

                wallReff.wallDown = false;
            }
        }
    }





    private void OnWallCollisionLeftEnterCheckX2(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();

        if (id == 0)
        {
        //    Debug.Log("left_limit_enterX2");
            lockReference.leftlockXX2 = true;
        }
    }
    private void OnWallCollisionLeftExitCheckX2(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();

        if (id == 0)
        {
        //    Debug.Log("left_limit_exitX2");
            lockReference.leftlockXX2 = false;
        }
    }
    private void OnWallCollisionRightEnterCheckX2(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();

        if (id == 0)
        {
         //   Debug.Log("right_limit_enterX2");
            lockReference.rightlockXX2 = true;
        }
    }
    private void OnWallCollisionRightExitCheckX2(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();

        if (id == 0)
        {
         //   Debug.Log("right_limit_exitX2");
            lockReference.rightlockXX2 = false;
        }
    }

    private void OnWallCollisionUpEnterCheckX2(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();

        if (id == 0)
        {
        //    Debug.Log("up_limit_enterX2");
            lockReference.uplockXX2 = true;
        }
    }
    private void OnWallCollisionUpExitCheckX2(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();

        if (id == 0)
        {
         //   Debug.Log("up_limit_exitX2");
            lockReference.uplockXX2 = false;
        }
    }
    private void OnWallCollisionDownEnterCheckX2(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();

        if (id == 0)
        {
       //     Debug.Log("down_limit_enterX2");
            lockReference.downlockXX2 = true;
        }
    }
    private void OnWallCollisionDownExitCheckX2(int id)
    {
        GameObject Player = GameObject.Find("Player");
        player_script lockReference = Player.GetComponent<player_script>();

        if (id == 0)
        {
        //    Debug.Log("down_limit_exitX2");
            lockReference.downlockXX2 = false;
        }
    }
}
