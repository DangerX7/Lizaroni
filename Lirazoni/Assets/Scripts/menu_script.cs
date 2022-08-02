using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_script : MonoBehaviour
{

    public GameObject cursor, menu, options, difficulty, resolution, difficultyVS;
    public int scene;
    public int option;
    public int resolutionType;
    public bool windowType;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

     //    Debug.Log(resolutionType);
        if ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown("up")))
        {
            if ((scene != 1) && (scene != 6) && (scene != 11) && (scene != 13) && (scene != 15))
            {
                Vector3 temp = new Vector3(0, 1.05f, 0);
                cursor.transform.position += temp;
            }
        }
        if ((Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown("down")))
        {
            if ((scene != 5) && (scene != 10) && (scene != 12) && (scene != 14) && (scene != 17))
            {
                Vector3 temp = new Vector3(0, -1.05f, 0);
                cursor.transform.position += temp;
            }
        }

    //    Debug.Log(scene);


        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (scene == 0)
            {
                Debug.Log("Nothing happened");
            }
            if (scene == 1)
            {
                SceneManager.LoadScene("Classic Map");
            }
            if (scene == 2)
            {
                menu.SetActive(false);
                difficulty.SetActive(true);
            }
            if (scene == 3)
            {
                menu.SetActive(false);
                difficultyVS.SetActive(true);
            }
            if (scene == 4)
            {
                menu.SetActive(false);
                Vector3 posReset = new Vector3(0, 3.15f, 0);
                cursor.transform.position += posReset;
                options.SetActive(true);
                scene = 0;
                Debug.Log("You entered Settings");
            }
            if (scene == 5)
            {
                Application.Quit();
            }
            if (scene == 6)
            {
                //Change Sound Volume
            }
            if (scene == 7)
            {
                //Change Music Volume
            }
            if (scene == 8)
            {
                options.SetActive(false);
                Vector3 posReset = new Vector3(0, 2.1f, 0);
                cursor.transform.position += posReset;
                resolution.SetActive(true);
            }
            if (scene == 9)
            {
                //Change Controls
            }
            if (scene == 10)
            {
                options.SetActive(false);
                Vector3 posReset = new Vector3(0, 4.2f, 0);
                cursor.transform.position += posReset;
                menu.SetActive(true);
                Debug.Log("You exited Settings");
            }
            if (GameObject.Find("SceneUnlocker") != null)
            {
                GameObject Scene = GameObject.Find("SceneUnlocker");
                scene_unlocker_script difRef = Scene.GetComponent<scene_unlocker_script>();
                if (scene == 11)
                {
                    difRef.difficulty = 1;
                    SceneManager.LoadScene("Chapter Select");
                }
                if (scene == 12)
                {
                    difRef.difficulty = 2;
                    SceneManager.LoadScene("Chapter Select");
                }
            }
            if (scene == 14)
            {
                Screen.fullScreen = !Screen.fullScreen;
            }
            if (GameObject.Find("SceneUnlocker") != null)
            {
                GameObject Scene = GameObject.Find("SceneUnlocker");
                scene_unlocker_script difRef = Scene.GetComponent<scene_unlocker_script>();
                if (scene == 15)
                {
                    difRef.difficultyVS = 0;
                    difRef.player1Wins = 0;
                    difRef.player2Wins = 0;
                    difRef.versusLevelStart = true;
                }
                if (scene == 16)
                {
                    difRef.difficultyVS = 1;
                    difRef.player1Wins = 0;
                    difRef.player2Wins = 0;
                    difRef.versusLevelStart = true;
                }
                if (scene == 17)
                {
                    difRef.difficultyVS = 2;
                    difRef.player1Wins = 0;
                    difRef.player2Wins = 0;
                    difRef.versusLevelStart = true;
                }
            }
        }

        if (Input.GetKeyDown("left"))
        {
            if (scene == 13)
            {
                resolutionType -= 1;
                ResolutionChange();
            }
        }
        if (Input.GetKeyDown("right"))
        {
            if (scene == 13)
            {
                resolutionType += 1;
                ResolutionChange();
            }
        }



        if ((Input.GetKeyDown(KeyCode.Escape)) && (scene > 5))
        {
            options.SetActive(false);
            difficulty.SetActive(false);
            resolution.SetActive(false);
            difficultyVS.SetActive(false);
            menu.SetActive(true);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //hit.transform.gameObject.name == "name"

        if (col.transform.gameObject.name == ("Classic"))
        {
            scene = 1;
        }
        if (col.transform.gameObject.name == ("Deluxe"))
        {
            scene = 2;
        }
        if (col.transform.gameObject.name == ("Versus"))
        {
            scene = 3;
        }
        if (col.transform.gameObject.name == ("Options"))
        {
            scene = 4;
        }
        if (col.transform.gameObject.name == ("Exit"))
        {
            scene = 5;
        }

        if (col.transform.gameObject.name == ("Sound"))
        {
            scene = 6;
        }
        if (col.transform.gameObject.name == ("Music"))
        {
            scene = 7;
        }
        if (col.transform.gameObject.name == ("Resolution"))
        {
            scene = 8;
        }
        if (col.transform.gameObject.name == ("Controls"))
        {
            scene = 9;
        }
        if (col.transform.gameObject.name == ("Save"))
        {
           scene = 10;
        }

        if (col.transform.gameObject.name == ("Easy"))
        {
            scene = 11;
        }
        if (col.transform.gameObject.name == ("Normal"))
        {
            scene = 12;
        }


        if (col.transform.gameObject.name == ("ResolutionSet"))
        {
            scene = 13;
        }
        if (col.transform.gameObject.name == ("Screen"))
        {
            scene = 14;
        }

        if (col.transform.gameObject.name == ("EasyVS"))
        {
            scene = 15;
        }
        if (col.transform.gameObject.name == ("NormalVS"))
        {
            scene = 16;
        }
        if (col.transform.gameObject.name == ("HardVS"))
        {
            scene = 17;
        }
    }

    public void ResolutionChange()
    {
        if (resolutionType == -1)
        {
            resolutionType = 5;
        }
        if (resolutionType == 6)
        {
            resolutionType = 0;
        }

        if (resolutionType == 5)
        {
            Screen.SetResolution(1920, 1080, false);
        }
        if (resolutionType == 4)
        {
            Screen.SetResolution(1536, 864, false);
        }
        if (resolutionType == 3)
        {
            Screen.SetResolution(1280, 720, false);
        }
        if (resolutionType == 2)
        {
            Screen.SetResolution(960, 540, false);
        }
        if (resolutionType == 1)
        {
            Screen.SetResolution(720, 405, false);
        }
        if (resolutionType == 0)
        {
            Screen.SetResolution(480, 270, false);
        }
    }
}
