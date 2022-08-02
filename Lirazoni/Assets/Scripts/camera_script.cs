using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    public GameObject centerMap1, centerMap2, centerMap3, centerMap4, centerMap5, cursor;
    public int cameraMove;
    public bool teleportCheck;
    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator TeleportCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        if (cameraMove == 101)
        {
            Debug.Log("xzc");
            transform.position = new Vector3(centerMap1.transform.position.x, centerMap1.transform.position.y, -10);
            cameraMove = 100;
        }
        if (cameraMove == 102)
        {
            transform.position = new Vector3(centerMap2.transform.position.x, centerMap2.transform.position.y, -10);
            cameraMove = 100;
        }
        if (cameraMove == 103)
        {
            transform.position = new Vector3(centerMap3.transform.position.x, centerMap3.transform.position.y, -10);
            cameraMove = 100;
        }
        if (cameraMove == 104)
        {
            transform.position = new Vector3(centerMap4.transform.position.x, centerMap4.transform.position.y, -10);
            cameraMove = 100;
        }
        if (cameraMove == 105)
        {
            transform.position = new Vector3(centerMap5.transform.position.x, centerMap5.transform.position.y, -10);
            cameraMove = 100;
        }
        if (cameraMove == 100)
        {
            Debug.Log("xzcdgeg");
            transform.position = transform.position + new Vector3(0, 0, -10);
            cameraMove = 200;
        }
     //   portalCheck2.portalCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            GameObject Player = GameObject.Find("Player");
            player_script portalCheck2 = Player.GetComponent<player_script>();

            if (portalCheck2.roomOfMap == 1)
            {
                if (GameObject.Find("map mark 1") != null)
                {
                    transform.position = new Vector3(centerMap1.transform.position.x, centerMap1.transform.position.y, -10);
              //      Debug.Log("camera1");
                }
                cameraMove = 100;
            }
            if (portalCheck2.roomOfMap == 2)
            {
                if (GameObject.Find("map mark 2") != null)
                {
                    transform.position = new Vector3(centerMap2.transform.position.x, centerMap2.transform.position.y, -10);
            //        Debug.Log("camera2");
                }
                cameraMove = 100;
            }
            if (portalCheck2.roomOfMap == 3)
            {
                if (GameObject.Find("map mark 3") != null)
                {
                    transform.position = new Vector3(centerMap3.transform.position.x, centerMap3.transform.position.y, -10);
             //       Debug.Log("camera3");
                }
                cameraMove = 100;
            }
            if (portalCheck2.roomOfMap == 4)
            {
                if (GameObject.Find("map mark 4") != null)
                {
                    transform.position = new Vector3(centerMap4.transform.position.x, centerMap4.transform.position.y, -10);
             //       Debug.Log("camera4");
                }
                cameraMove = 100;
            }
            if (portalCheck2.roomOfMap == 5)
            {
                if (GameObject.Find("map mark 5") != null)
                {
                    transform.position = new Vector3(centerMap5.transform.position.x, centerMap5.transform.position.y, -10);
               //     Debug.Log("camera5");
                }
                cameraMove = 100;
            }
        }

        if (GameObject.Find("stage_cursor") != null)
        {
            transform.position = new Vector3(cursor.transform.position.x, cursor.transform.position.y, -10);
        }

        if (cameraMove == 1) // move to right
        {
            Debug.Log("3X");
        //    transform.position = transform.position + new Vector3(10, 0, 0);
         //   cameraMove = 2;
        }
        if (cameraMove == 3) // move to left
        {
            Debug.Log("4X");
         //   transform.position = transform.position - new Vector3(10, 0, 0);
         //   cameraMove = 0;
        }
        if (GameObject.Find("Player") != null)
        {
            GameObject Player = GameObject.Find("Player");
            player_script portalCheck2 = Player.GetComponent<player_script>();

            if (portalCheck2.portalCheck == true)
            {
                StartCoroutine(TeleportCoroutine());
            }
        }
    }
}
