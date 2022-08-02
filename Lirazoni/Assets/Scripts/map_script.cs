using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map_script : MonoBehaviour
{
    public byte mapType;
    public int scene = 0;
    public int scene2;

    public GameObject cursor, SceneUnlocker, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19, S20, S21, S22,
        S23, S24, S25, S26, S27, S28, S29, S30, S31, S32, S33, S34, S35, S36, S37, S38, S39, S40, S41, S42, S43, S44, S45, S46, S47, S48, S49, S50,
        S1x1, S1x2, S1x3, S1x4, S1x5a, S1x6a, S1x5b, S1x6b, S1x7, S1x8, S1x9, S1x10, S1x11, S1x12, S1xB,
        S2x1, S2x2, S2x3, S2x4a, S2x4b, S2x4c, S2x5, S2x6, S2x7, S2x8, S2x9, S2x10, S2x11, S2x12, S2x13, S2x14, S2x15, S2x16,
        S2x17a, S2x17b, S2x18, S2x19, S2x20, S2xB1, S2xB2,
        S3x1, S3x2, S3x3, S3x4, S3x5, S3x6, S3x7, S3x8, S3x9a, S3x9b, S3x10, S3x11, S3x12, S3x13, S3x14a, S3x14b, S3x14c, S3x15b, S3x15c, S3x16b,
        S3x17, S3x18, S3x19, S3x20, S3x21a, S3x21b, S3x21c, S3x21d, S3x21e, S3x22, S3xB1, S3xB2,
        S4x1, S4x2, S4x3, S4x4, S4x5a, S4x5b, S4x6a, S4x6b, S4x7a, S4x7b, S4x8, S4x9, S4x10, S4x11, S4x12, S4x13, S4x14, S4xB,
        S5x1a, S5x1b, S5x1c, S5x1d, S5x2,
        S1X, S2X, S3X, S4X, S5X, S6X, S7X, S8X, S9X, S10X, S11X, S12X, S13X, S14X, S15X, S16X, S17X, S18X, S19X, S20X,
        S21X, S22X, S23X, S24X, S25X, S26X, S27X, S28X, S29X, S30X, S31X, S32X, S33X, S34X, S35X, S36X, S37X, S38X, S39X, S40X,
        S41X, S42X, S43X, S44X, S45X, S46X, S47X, S48X, S49X, S50X,
        S1D, S2D, S3D, S4D, S5D, S6D, S7D, S8D, S9D, S10D, S11D, S12D, S13D, S14D, S15D, S16D, S17D, S18D, S19D, S20D,
        S21D, S22D, S23D, S24D, S25D, S26D, S27D, S28D, S29D, S30D, S31D, S32D, S33D, S34D, S35D, S36D, S37D, S38D, S39D, S40D,
        S41D, S42D, S43D, S44D, S45D, S46D, S47D, S48D, S49D, S50D;


    public bool swithSU = false;
    public bool accessLevel;
    public bool sceneLoad;

    public SpriteRenderer spriteRenderer;
    public Sprite stand, enter;

    public bool StoryModeMap;
    public bool LeftLimit;
    public bool RightLimit;
    public bool UpLimit;
    public bool DownLimit;
    public byte oldLevelStatus;
    public bool preventChilds = true;

    // Start is called before the first frame update
    void Start()
    {
        if (StoryModeMap == true)
        {
            spriteRenderer.sprite = stand;
        }
        if (GameObject.Find("SceneUnlocker") != null)
        {
            GameObject Scene = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = Scene.GetComponent<scene_unlocker_script>();

            #region Set Map Cursor

            if (mapType == 0)
            {
                if (sceneReference.cursorMemory0 == 2)
                {
                    transform.position = S2.transform.position;
                }
                if (sceneReference.cursorMemory0 == 3)
                {
                    transform.position = S3.transform.position;
                }
                if (sceneReference.cursorMemory0 == 4)
                {
                    transform.position = S4.transform.position;
                }
                if (sceneReference.cursorMemory0 == 5)
                {
                    transform.position = S5.transform.position;
                }
                if (sceneReference.cursorMemory0 == 6)
                {
                    transform.position = S6.transform.position;
                }
                if (sceneReference.cursorMemory0 == 7)
                {
                    transform.position = S7.transform.position;
                }
                if (sceneReference.cursorMemory0 == 8)
                {
                    transform.position = S8.transform.position;
                }
                if (sceneReference.cursorMemory0 == 9)
                {
                    transform.position = S9.transform.position;
                }
                if (sceneReference.cursorMemory0 == 10)
                {
                    transform.position = S10.transform.position;
                }
                if (sceneReference.cursorMemory0 == 11)
                {
                    transform.position = S11.transform.position;
                }
                if (sceneReference.cursorMemory0 == 12)
                {
                    transform.position = S12.transform.position;
                }
                if (sceneReference.cursorMemory0 == 13)
                {
                    transform.position = S13.transform.position;
                }
                if (sceneReference.cursorMemory0 == 14)
                {
                    transform.position = S14.transform.position;
                }
                if (sceneReference.cursorMemory0 == 15)
                {
                    transform.position = S15.transform.position;
                }
                if (sceneReference.cursorMemory0 == 16)
                {
                    transform.position = S16.transform.position;
                }
                if (sceneReference.cursorMemory0 == 17)
                {
                    transform.position = S17.transform.position;
                }
                if (sceneReference.cursorMemory0 == 18)
                {
                    transform.position = S18.transform.position;
                }
                if (sceneReference.cursorMemory0 == 19)
                {
                    transform.position = S19.transform.position;
                }
                if (sceneReference.cursorMemory0 == 20)
                {
                    transform.position = S20.transform.position;
                }
                if (sceneReference.cursorMemory0 == 21)
                {
                    transform.position = S21.transform.position;
                }
                if (sceneReference.cursorMemory0 == 22)
                {
                    transform.position = S22.transform.position;
                }
                if (sceneReference.cursorMemory0 == 23)
                {
                    transform.position = S23.transform.position;
                }
                if (sceneReference.cursorMemory0 == 24)
                {
                    transform.position = S24.transform.position;
                }
                if (sceneReference.cursorMemory0 == 25)
                {
                    transform.position = S25.transform.position;
                }
                if (sceneReference.cursorMemory0 == 26)
                {
                    transform.position = S26.transform.position;
                }
                if (sceneReference.cursorMemory0 == 27)
                {
                    transform.position = S27.transform.position;
                }
                if (sceneReference.cursorMemory0 == 28)
                {
                    transform.position = S28.transform.position;
                }
                if (sceneReference.cursorMemory0 == 29)
                {
                    transform.position = S29.transform.position;
                }
                if (sceneReference.cursorMemory0 == 30)
                {
                    transform.position = S30.transform.position;
                }
                if (sceneReference.cursorMemory0 == 31)
                {
                    transform.position = S31.transform.position;
                }
                if (sceneReference.cursorMemory0 == 32)
                {
                    transform.position = S32.transform.position;
                }
                if (sceneReference.cursorMemory0 == 33)
                {
                    transform.position = S33.transform.position;
                }
                if (sceneReference.cursorMemory0 == 34)
                {
                    transform.position = S34.transform.position;
                }
                if (sceneReference.cursorMemory0 == 35)
                {
                    transform.position = S35.transform.position;
                }
                if (sceneReference.cursorMemory0 == 36)
                {
                    transform.position = S36.transform.position;
                }
                if (sceneReference.cursorMemory0 == 37)
                {
                    transform.position = S37.transform.position;
                }
                if (sceneReference.cursorMemory0 == 38)
                {
                    transform.position = S38.transform.position;
                }
                if (sceneReference.cursorMemory0 == 39)
                {
                    transform.position = S39.transform.position;
                }
                if (sceneReference.cursorMemory0 == 40)
                {
                    transform.position = S40.transform.position;
                }
                if (sceneReference.cursorMemory0 == 41)
                {
                    transform.position = S41.transform.position;
                }
                if (sceneReference.cursorMemory0 == 42)
                {
                    transform.position = S42.transform.position;
                }
                if (sceneReference.cursorMemory0 == 43)
                {
                    transform.position = S43.transform.position;
                }
                if (sceneReference.cursorMemory0 == 44)
                {
                    transform.position = S44.transform.position;
                }
                if (sceneReference.cursorMemory0 == 45)
                {
                    transform.position = S45.transform.position;
                }
                if (sceneReference.cursorMemory0 == 46)
                {
                    transform.position = S46.transform.position;
                }
                if (sceneReference.cursorMemory0 == 47)
                {
                    transform.position = S47.transform.position;
                }
                if (sceneReference.cursorMemory0 == 48)
                {
                    transform.position = S48.transform.position;
                }
                if (sceneReference.cursorMemory0 == 49)
                {
                    transform.position = S49.transform.position;
                }
                if (sceneReference.cursorMemory0 == 50)
                {
                    transform.position = S50.transform.position;
                }
            }
            if (mapType == 1)
            {
                if (sceneReference.cursorMemory1 == 1)
                {
                    transform.position = S1x2.transform.position;
                }
                if (sceneReference.cursorMemory1 == 2)
                {
                    transform.position = S1x3.transform.position;
                }
                if (sceneReference.cursorMemory1 == 3)
                {
                    transform.position = S1x4.transform.position;
                }
                if (sceneReference.cursorMemory1 == 4)
                {
                    transform.position = S1x5a.transform.position;
                }
                if (sceneReference.cursorMemory1 == 5)
                {
                    transform.position = S1x5b.transform.position;
                }
                if (sceneReference.cursorMemory1 == 6)
                {
                    transform.position = S1x6a.transform.position;
                }
                if (sceneReference.cursorMemory1 == 7)
                {
                    transform.position = S1x6b.transform.position;
                }
                if (sceneReference.cursorMemory1 == 8)
                {
                    transform.position = S1x7.transform.position;
                }
                if (sceneReference.cursorMemory1 == 9)
                {
                    transform.position = S1x8.transform.position;
                }
                if (sceneReference.cursorMemory1 == 10)
                {
                    transform.position = S1x9.transform.position;
                }
                if (sceneReference.cursorMemory1 == 11)
                {
                    transform.position = S1x10.transform.position;
                }
                if (sceneReference.cursorMemory1 == 12)
                {
                    transform.position = S1x11.transform.position;
                }
                if (sceneReference.cursorMemory1 == 13)
                {
                    transform.position = S1x12.transform.position;
                }
                if (sceneReference.cursorMemory1 == 14)
                {
                    transform.position = S1xB.transform.position;
                }
            }
            if (mapType == 2)
            {
                if (sceneReference.cursorMemory2 == 1)
                {
                    transform.position = S2x2.transform.position;
                }
                if (sceneReference.cursorMemory2 == 2)
                {
                    transform.position = S2x3.transform.position;
                }
                if (sceneReference.cursorMemory2 == 3)
                {
                    transform.position = S2x4a.transform.position;
                }
                if (sceneReference.cursorMemory2 == 4)
                {
                    transform.position = S2x4b.transform.position;
                }
                if (sceneReference.cursorMemory2 == 5)
                {
                    transform.position = S2x4c.transform.position;
                }
                if (sceneReference.cursorMemory2 == 6)
                {
                    transform.position = S2x5.transform.position;
                }
                if (sceneReference.cursorMemory2 == 7)
                {
                    transform.position = S2x6.transform.position;
                }
                if (sceneReference.cursorMemory2 == 8)
                {
                    transform.position = S2x7.transform.position;
                }
                if (sceneReference.cursorMemory2 == 9)
                {
                    transform.position = S2x8.transform.position;
                }
                if (sceneReference.cursorMemory2 == 10)
                {
                    transform.position = S2x9.transform.position;
                }
                if (sceneReference.cursorMemory2 == 11)
                {
                    transform.position = S2x10.transform.position;
                }
                if (sceneReference.cursorMemory2 == 12)
                {
                    transform.position = S2x11.transform.position;
                }
                if (sceneReference.cursorMemory2 == 13)
                {
                    transform.position = S2x12.transform.position;
                }
                if (sceneReference.cursorMemory2 == 14)
                {
                    transform.position = S2x13.transform.position;
                }
                if (sceneReference.cursorMemory2 == 15)
                {
                    transform.position = S2x14.transform.position;
                }
                if (sceneReference.cursorMemory2 == 16)
                {
                    transform.position = S2x15.transform.position;
                }
                if (sceneReference.cursorMemory2 == 17)
                {
                    transform.position = S2x16.transform.position;
                }
                if (sceneReference.cursorMemory2 == 18)
                {
                    transform.position = S2x17a.transform.position;
                }
                if (sceneReference.cursorMemory2 == 19)
                {
                    transform.position = S2x17b.transform.position;
                }
                if (sceneReference.cursorMemory2 == 20)
                {
                    transform.position = S2x18.transform.position;
                }
                if (sceneReference.cursorMemory2 == 21)
                {
                    transform.position = S2x19.transform.position;
                }
                if (sceneReference.cursorMemory2 == 22)
                {
                    transform.position = S2x20.transform.position;
                }
                if (sceneReference.cursorMemory2 == 23)
                {
                    transform.position = S2xB1.transform.position;
                }
                if (sceneReference.cursorMemory2 == 24)
                {
                    transform.position = S2xB2.transform.position;
                }
            }
            if (mapType == 3)
            {
                if (sceneReference.cursorMemory3 == 1)
                {
                    transform.position = S3x2.transform.position;
                }
                if (sceneReference.cursorMemory3 == 2)
                {
                    transform.position = S3x3.transform.position;
                }
                if (sceneReference.cursorMemory3 == 3)
                {
                    transform.position = S3x4.transform.position;
                }
                if (sceneReference.cursorMemory3 == 4)
                {
                    transform.position = S3x5.transform.position;
                }
                if (sceneReference.cursorMemory3 == 5)
                {
                    transform.position = S3x6.transform.position;
                }
                if (sceneReference.cursorMemory3 == 6)
                {
                    transform.position = S3x7.transform.position;
                }
                if (sceneReference.cursorMemory3 == 7)
                {
                    transform.position = S3x8.transform.position;
                }
                if (sceneReference.cursorMemory3 == 8)
                {
                    transform.position = S3x9a.transform.position;
                }
                if (sceneReference.cursorMemory3 == 9)
                {
                    transform.position = S3x9b.transform.position;
                }
                if (sceneReference.cursorMemory3 == 10)
                {
                    transform.position = S3x10.transform.position;
                }
                if (sceneReference.cursorMemory3 == 11)
                {
                    transform.position = S3x11.transform.position;
                }
                if (sceneReference.cursorMemory3 == 12)
                {
                    transform.position = S3x12.transform.position;
                }
                if (sceneReference.cursorMemory3 == 13)
                {
                    transform.position = S3x13.transform.position;
                }
                if (sceneReference.cursorMemory3 == 14)
                {
                    transform.position = S3x14a.transform.position;
                }
                if (sceneReference.cursorMemory3 == 15)
                {
                    transform.position = S3x14b.transform.position;
                }
                if (sceneReference.cursorMemory3 == 16)
                {
                    transform.position = S3x14c.transform.position;
                }
                if (sceneReference.cursorMemory3 == 17)
                {
                    transform.position = S3x15b.transform.position;
                }
                if (sceneReference.cursorMemory3 == 18)
                {
                    transform.position = S3x15c.transform.position;
                }
                if (sceneReference.cursorMemory3 == 19)
                {
                    transform.position = S3x16b.transform.position;
                }
                if (sceneReference.cursorMemory3 == 20)
                {
                    transform.position = S3x17.transform.position;
                }
                if (sceneReference.cursorMemory3 == 21)
                {
                    transform.position = S3x18.transform.position;
                }
                if (sceneReference.cursorMemory3 == 22)
                {
                    transform.position = S3x19.transform.position;
                }
                if (sceneReference.cursorMemory3 == 23)
                {
                    transform.position = S3x20.transform.position;
                }
                if (sceneReference.cursorMemory3 == 24)
                {
                    transform.position = S3x21a.transform.position;
                }
                if (sceneReference.cursorMemory3 == 25)
                {
                    transform.position = S3x21b.transform.position;
                }
                if (sceneReference.cursorMemory3 == 26)
                {
                    transform.position = S3x21c.transform.position;
                }
                if (sceneReference.cursorMemory3 == 27)
                {
                    transform.position = S3x21d.transform.position;
                }
                if (sceneReference.cursorMemory3 == 28)
                {
                    transform.position = S3x21e.transform.position;
                }
                if (sceneReference.cursorMemory3 == 29)
                {
                    transform.position = S3x22.transform.position;
                }
                if (sceneReference.cursorMemory3 == 30)
                {
                    transform.position = S3xB1.transform.position;
                }
                if (sceneReference.cursorMemory3 == 31)
                {
                    transform.position = S3xB2.transform.position;
                }
            }
            if (mapType == 4)
            {
                if (sceneReference.cursorMemory4 == 1)
                {
                    transform.position = S4x2.transform.position;
                }
                if (sceneReference.cursorMemory4 == 2)
                {
                    transform.position = S4x3.transform.position;
                }
                if (sceneReference.cursorMemory4 == 3)
                {
                    transform.position = S4x4.transform.position;
                }
                if (sceneReference.cursorMemory4 == 4)
                {
                    transform.position = S4x5a.transform.position;
                }
                if (sceneReference.cursorMemory4 == 5)
                {
                    transform.position = S4x5b.transform.position;
                }
                if (sceneReference.cursorMemory4 == 6)
                {
                    transform.position = S4x6a.transform.position;
                }
                if (sceneReference.cursorMemory4 == 7)
                {
                    transform.position = S4x6b.transform.position;
                }
                if (sceneReference.cursorMemory4 == 8)
                {
                    transform.position = S4x7a.transform.position;
                }
                if (sceneReference.cursorMemory4 == 9)
                {
                    transform.position = S4x7b.transform.position;
                }
                if (sceneReference.cursorMemory4 == 10)
                {
                    transform.position = S4x8.transform.position;
                }
                if (sceneReference.cursorMemory4 == 11)
                {
                    transform.position = S4x9.transform.position;
                }
                if (sceneReference.cursorMemory4 == 12)
                {
                    transform.position = S4x10.transform.position;
                }
                if (sceneReference.cursorMemory4 == 13)
                {
                    transform.position = S4x11.transform.position;
                }
                if (sceneReference.cursorMemory4 == 14)
                {
                    transform.position = S4x12.transform.position;
                }
                if (sceneReference.cursorMemory4 == 15)
                {
                    transform.position = S4x13.transform.position;
                }
                if (sceneReference.cursorMemory4 == 16)
                {
                    transform.position = S4x14.transform.position;
                }
                if (sceneReference.cursorMemory4 == 17)
                {
                    transform.position = S4xB.transform.position;
                }
            }
            if (mapType == 5)
            {
                if (sceneReference.cursorMemory5 == 1)
                {
                    transform.position = S5x1a.transform.position;
                }
                if (sceneReference.cursorMemory5 == 2)
                {
                    transform.position = S5x1b.transform.position;
                }
                if (sceneReference.cursorMemory5 == 3)
                {
                    transform.position = S5x1c.transform.position;
                }
                if (sceneReference.cursorMemory5 == 4)
                {
                    transform.position = S5x1d.transform.position;
                }
                if (sceneReference.cursorMemory5 == 5)
                {
                    transform.position = S5x2.transform.position;
                }
            }

            #endregion
        }
    }

    IEnumerator CoroutineScenePreload()
    {
        accessLevel = true;
        Debug.Log("1baaa");
        yield return new WaitForSeconds(0.3f);
        if (StoryModeMap == true)
        {
            spriteRenderer.sprite = enter;
        }
        yield return new WaitForSeconds(1.5f);
        accessLevel = false;
        Debug.Log("2baaa");
        sceneLoad = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Scene number : " + scene + " Story number : " + scene2); // GET SCENES NUMBER
        /*
        if (swithSU == false)
        {
            Instantiate(SceneUnlocker);
            swithSU = true;
        }
        */

        GameObject Scene = GameObject.Find("SceneUnlocker");
        scene_unlocker_script sceneReference = Scene.GetComponent<scene_unlocker_script>();

        #region Controls

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (mapType == 0)
            {
                SceneManager.LoadScene("Tittle_Screen");
            }
            if (mapType == 1)
            {
                SceneManager.LoadScene("Chapter Select");
            }
            if (mapType == 2)
            {
                SceneManager.LoadScene("Chapter Select");
            }
            if (mapType == 3)
            {
                SceneManager.LoadScene("Chapter Select");
            }
            if (mapType == 4)
            {
                SceneManager.LoadScene("Chapter Select");
            }
        }
        if (accessLevel == false)
        {
            if ((Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown("up"))) &&(UpLimit == false))
            {
                Vector3 temp = new Vector3(0, 1, 0);
                cursor.transform.position += temp;
            }
            if ((Input.GetKeyDown(KeyCode.S) || (Input.GetKeyDown("down"))) && (DownLimit == false))
            {
                Vector3 temp = new Vector3(0, -1, 0);
                cursor.transform.position += temp;
            }
            if ((Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown("left"))) && (LeftLimit == false))
            {
                Vector3 temp = new Vector3(-1, 0, 0);
                cursor.transform.position += temp;
            }
            if ((Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown("right")))&& (RightLimit == false))
            {
                Vector3 temp = new Vector3(1, 0, 0);
                cursor.transform.position += temp;
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (((StoryModeMap == false) && (scene !=0)) || ((StoryModeMap == true) && (scene2 != 0)))
                {
                    StartCoroutine(CoroutineScenePreload());
                }
            }
        }

        #endregion


        #region Load Scene

        if (sceneLoad == true)
        {
            Debug.Log("sdfsdfdsv");
            if (scene == 1)
            {
                Debug.Log("Nothing happened");
            }
            if (scene == 2)
            {
                SceneManager.LoadScene("1Main_Gate-1");
            }
            if (scene == 3)
            {
                SceneManager.LoadScene("1Main_Gate-2");
            }
            if (scene == 4)
            {
                SceneManager.LoadScene("1Main_Gate-3");
            }
            if (scene == 5)
            {
                SceneManager.LoadScene("2Long_Corridor-1");
            }
            if (scene == 6)
            {
                SceneManager.LoadScene("2Long_Corridor-2");
            }
            if (scene == 7)
            {
                SceneManager.LoadScene("2Long_Corridor-3");
            }
            if (scene == 8)
            {
                SceneManager.LoadScene("2Long_Corridor-4");
            }
            if (scene == 9)
            {
                SceneManager.LoadScene("2Long_Corridor-5");
            }
            if (scene == 10)
            {
                SceneManager.LoadScene("3Secret_Passage-1");
            }
            if (scene == 11)
            {
                SceneManager.LoadScene("3Secret_Passage-2");
            }
            if (scene == 12)
            {
                SceneManager.LoadScene("3Secret_Passage-3");
            }
            if (scene == 13)
            {
                SceneManager.LoadScene("3Secret_Passage-4");
            }
            if (scene == 14)
            {
                SceneManager.LoadScene("3Secret_Passage-4Ex");
            }
            if (scene == 15)
            {
                SceneManager.LoadScene("3Secret_Passage-5");
            }
            if (scene == 16)
            {
                SceneManager.LoadScene("4Dungeon-1");
            }
            if (scene == 17)
            {
                SceneManager.LoadScene("4Dungeon-2");
            }
            if (scene == 18)
            {
                SceneManager.LoadScene("4Dungeon-2Ex");
            }
            if (scene == 19)
            {
                SceneManager.LoadScene("4Dungeon-3");
            }
            if (scene == 20)
            {
                SceneManager.LoadScene("4Dungeon-4");
            }
            if (scene == 21)
            {
                SceneManager.LoadScene("4Dungeon-4Ex");
            }
            if (scene == 22)
            {
                SceneManager.LoadScene("4Dungeon-5");
            }
            if (scene == 23)
            {
                SceneManager.LoadScene("5Dojo-1");
            }
            if (scene == 24)
            {
                SceneManager.LoadScene("5Dojo-2");
            }
            if (scene == 25)
            {
                SceneManager.LoadScene("5Dojo-3");
            }
            if (scene == 26)
            {
                SceneManager.LoadScene("5Dojo-3Ex");
            }
            if (scene == 27)
            {
                SceneManager.LoadScene("5Dojo-4");
            }
            if (scene == 28)
            {
                SceneManager.LoadScene("5Dojo-5");
            }
            if (scene == 29)
            {
                SceneManager.LoadScene("5Dojo-6");
            }
            if (scene == 30)
            {
                SceneManager.LoadScene("5Dojo-6Ex");
            }
            if (scene == 31)
            {
                SceneManager.LoadScene("5Dojo-7");
            }
            if (scene == 32)
            {
                SceneManager.LoadScene("5Dojo-8");
            }
            if (scene == 33)
            {
                SceneManager.LoadScene("6Dark_Castle-1");
            }
            if (scene == 34)
            {
                SceneManager.LoadScene("6Dark_Castle-2");
            }
            if (scene == 35)
            {
                SceneManager.LoadScene("6Dark_Castle-3");
            }
            if (scene == 36)
            {
                SceneManager.LoadScene("6Dark_Castle-3Ex");
            }
            if (scene == 37)
            {
                SceneManager.LoadScene("6Dark_Castle-4");
            }
            if (scene == 38)
            {
                SceneManager.LoadScene("6Dark_Castle-5");
            }
            if (scene == 39)
            {
                SceneManager.LoadScene("6Dark_Castle-6");
            }
            if (scene == 40)
            {
                SceneManager.LoadScene("6Dark_Castle-7");
            }
            if (scene == 41)
            {
                SceneManager.LoadScene("6Dark_Castle-7Ex");
            }
            if (scene == 42)
            {
                SceneManager.LoadScene("6Dark_Castle-8");
            }
            if (scene == 43)
            {
                SceneManager.LoadScene("6Dark_Castle-9");
            }
            if (scene == 44)
            {
                SceneManager.LoadScene("6Dark_Castle-10");
            }
            if (scene == 45)
            {
                SceneManager.LoadScene("6Dark_Castle-10Ex");
            }
            if (scene == 46)
            {
                SceneManager.LoadScene("6Dark_Castle-11");
            }
            if (scene == 47)
            {
                SceneManager.LoadScene("7Secret_Cave-1");
            }
            if (scene == 48)
            {
                SceneManager.LoadScene("7Secret_Cave-2");
            }
            if (scene == 49)
            {
                SceneManager.LoadScene("7Secret_Cave-3");
            }
            if (scene == 50)
            {
                SceneManager.LoadScene("7Secret_Cave-4");
            }
            if (scene == 51)
            {
                SceneManager.LoadScene("7Secret_Cave-5");
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (scene2 == 2)
            {
                SceneManager.LoadScene("1Story1");
            }
            if (scene2 == 3)
            {
                SceneManager.LoadScene("1Story2");
            }
            if (scene2 == 4)
            {
                SceneManager.LoadScene("1Story3");
            }
            if (scene2 == 5)
            {
                SceneManager.LoadScene("1Story4");
            }
            if (scene2 == 6)
            {
                SceneManager.LoadScene("1Story5a");
            }
            if (scene2 == 7)
            {
                SceneManager.LoadScene("1Story6a");
            }
            if (scene2 == 8)
            {
                SceneManager.LoadScene("1Story5b");
            }
            if (scene2 == 9)
            {
                SceneManager.LoadScene("1Story6b");
            }
            if (scene2 == 10)
            {
                SceneManager.LoadScene("1Story7");
            }
            if (scene2 == 11)
            {
                SceneManager.LoadScene("1Story8");
            }
            if (scene2 == 12)
            {
                SceneManager.LoadScene("1Story9");
            }
            if (scene2 == 13)
            {
                SceneManager.LoadScene("1Story10");
            }
            if (scene2 == 14)
            {
                SceneManager.LoadScene("1Story11");
            }
            if (scene2 == 15)
            {
                SceneManager.LoadScene("1Story12");
            }

            if (scene2 == 16)
            {
                SceneManager.LoadScene("2Story1");
            }
            if (scene2 == 17)
            {
                SceneManager.LoadScene("2Story2");
            }
            if (scene2 == 18)
            {
                SceneManager.LoadScene("2Story3");
            }
            if (scene2 == 19)
            {
                SceneManager.LoadScene("2Story4a");
            }
            if (scene2 == 20)
            {
                SceneManager.LoadScene("2Story4b");
            }
            if (scene2 == 21)
            {
                SceneManager.LoadScene("2Story4c");
            }
            if (scene2 == 22)
            {
                SceneManager.LoadScene("2Story5");
            }
            if (scene2 == 23)
            {
                SceneManager.LoadScene("2Story6");
            }
            if (scene2 == 24)
            {
                SceneManager.LoadScene("2Story7");
            }
            if (scene2 == 25)
            {
                SceneManager.LoadScene("2Story8");
            }
            if (scene2 == 26)
            {
                SceneManager.LoadScene("2Story9");
            }
            if (scene2 == 27)
            {
                SceneManager.LoadScene("2Story10");
            }
            if (scene2 == 28)
            {
                SceneManager.LoadScene("2Story11");
            }
            if (scene2 == 29)
            {
                SceneManager.LoadScene("2Story12");
            }
            if (scene2 == 30)
            {
                SceneManager.LoadScene("2Story13");
            }
            if (scene2 == 31)
            {
                SceneManager.LoadScene("2Story14");
            }
            if (scene2 == 32)
            {
                SceneManager.LoadScene("2Story15");
            }
            if (scene2 == 33)
            {
                SceneManager.LoadScene("2Story16");
            }
            if (scene2 == 34)
            {
                SceneManager.LoadScene("2Story17a");
            }
            if (scene2 == 35)
            {
                SceneManager.LoadScene("2Story17b");
            }
            if (scene2 == 36)
            {
                SceneManager.LoadScene("2Story18");
            }
            if (scene2 == 37)
            {
                SceneManager.LoadScene("2Story19");
            }
            if (scene2 == 38)
            {
                SceneManager.LoadScene("2Story20");
            }
            if (scene2 == 39)
            {
                SceneManager.LoadScene("3Story1");
            }
            if (scene2 == 40)
            {
                SceneManager.LoadScene("3Story2");
            }
            if (scene2 == 41)
            {
                SceneManager.LoadScene("3Story3");
            }
            if (scene2 == 42)
            {
                SceneManager.LoadScene("3Story4");
            }
            if (scene2 == 43)
            {
                SceneManager.LoadScene("3Story5");
            }
            if (scene2 == 44)
            {
                SceneManager.LoadScene("3Story6");
            }
            if (scene2 == 45)
            {
                SceneManager.LoadScene("3Story7");
            }
            if (scene2 == 46)
            {
                SceneManager.LoadScene("3Story8");
            }
            if (scene2 == 47)
            {
                SceneManager.LoadScene("3Story9a");
            }
            if (scene2 == 48)
            {
                SceneManager.LoadScene("3Story9b");
            }
            if (scene2 == 49)
            {
                SceneManager.LoadScene("3Story10");
            }
            if (scene2 == 50)
            {
                SceneManager.LoadScene("3Story11");
            }
            if (scene2 == 51)
            {
                SceneManager.LoadScene("3Story12");
            }
            if (scene2 == 52)
            {
                SceneManager.LoadScene("3Story13");
            }
            if (scene2 == 53)
            {
                SceneManager.LoadScene("3Story14a");
            }
            if (scene2 == 54)
            {
                SceneManager.LoadScene("3Story14b");
            }
            if (scene2 == 55)
            {
                SceneManager.LoadScene("3Story14c");
            }
            if (scene2 == 56)
            {
                SceneManager.LoadScene("3Story15b");
            }
            if (scene2 == 57)
            {
                SceneManager.LoadScene("3Story15c");
            }
            if (scene2 == 58)
            {
                SceneManager.LoadScene("3Story16b");
            }
            if (scene2 == 59)
            {
                SceneManager.LoadScene("3Story17");
            }
            if (scene2 == 60)
            {
                SceneManager.LoadScene("3Story18");
            }
            if (scene2 == 61)
            {
                SceneManager.LoadScene("3Story19");
            }
            if (scene2 == 62)
            {
                SceneManager.LoadScene("3Story20");
            }
            if (scene2 == 63)
            {
                SceneManager.LoadScene("3Story21a");
            }
            if (scene2 == 64)
            {
                SceneManager.LoadScene("3Story21b");
            }
            if (scene2 == 65)
            {
                SceneManager.LoadScene("3Story21c");
            }
            if (scene2 == 66)
            {
                SceneManager.LoadScene("3Story21d");
            }
            if (scene2 == 67)
            {
                SceneManager.LoadScene("3Story21e");
            }
            if (scene2 == 68)
            {
                SceneManager.LoadScene("3Story22");
            }
            if (scene2 == 69)
            {
                SceneManager.LoadScene("4Story1");
            }
            if (scene2 == 70)
            {
                SceneManager.LoadScene("4Story2");
            }
            if (scene2 == 71)
            {
                SceneManager.LoadScene("4Story3");
            }
            if (scene2 == 72)
            {
                SceneManager.LoadScene("4Story4");
            }
            if (scene2 == 73)
            {
                SceneManager.LoadScene("4Story5a");
            }
            if (scene2 == 74)
            {
                SceneManager.LoadScene("4Story5b");
            }
            if (scene2 == 75)
            {
                SceneManager.LoadScene("4Story6a");
            }
            if (scene2 == 76)
            {
                SceneManager.LoadScene("4Story6b");
            }
            if (scene2 == 77)
            {
                SceneManager.LoadScene("4Story7a");
            }
            if (scene2 == 78)
            {
                SceneManager.LoadScene("4Story7b");
            }
            if (scene2 == 79)
            {
                SceneManager.LoadScene("4Story8");
            }
            if (scene2 == 80)
            {
                SceneManager.LoadScene("4Story9");
            }
            if (scene2 == 81)
            {
                SceneManager.LoadScene("4Story10");
            }
            if (scene2 == 82)
            {
                SceneManager.LoadScene("4Story11");
            }
            if (scene2 == 83)
            {
                SceneManager.LoadScene("4Story12");
            }
            if (scene2 == 84)
            {
                SceneManager.LoadScene("4Story13");
            }
            if (scene2 == 85)
            {
                SceneManager.LoadScene("4Story14");
            }
            /////////////////////////////////////
            if (scene2 == 101)
            {
                SceneManager.LoadScene("1StoryEx1");
            }
            if (scene2 == 102)
            {
                SceneManager.LoadScene("2StoryEx1");
            }
            if (scene2 == 103)
            {
                SceneManager.LoadScene("2StoryEx2");
            }
            if (scene2 == 104)
            {
                SceneManager.LoadScene("3StoryEx1");
            }
            if (scene2 == 105)
            {
                SceneManager.LoadScene("3StoryEx2");
            }
            if (scene2 == 106)
            {
                SceneManager.LoadScene("4StoryEx1");
            }
            if (scene2 == 86)
            {
                SceneManager.LoadScene("5Story1a");
            }
            if (scene2 == 87)
            {
                SceneManager.LoadScene("5Story1b");
            }
            if (scene2 == 88)
            {
                SceneManager.LoadScene("5Story1c");
            }
            if (scene2 == 89)
            {
                SceneManager.LoadScene("5Story1d");
            }
            if (scene2 == 90)
            {
                SceneManager.LoadScene("5Story2");
            }
        }

        #endregion

        #region Set Map Pieces Active

        if (mapType == 0)
        {
            if (sceneReference.Scene2Active == false)
            {
                S2.SetActive(false);
            }
            if (sceneReference.Scene3Active == false)
            {
                S3.SetActive(false);
            }
            if (sceneReference.Scene4Active == false)
            {
                S4.SetActive(false);
            }
            if (sceneReference.Scene5Active == false)
            {
                S5.SetActive(false);
            }
            if (sceneReference.Scene6Active == false)
            {
                S6.SetActive(false);
            }
            if (sceneReference.Scene7Active == false)
            {
                S7.SetActive(false);
            }
            if (sceneReference.Scene8Active == false)
            {
                S8.SetActive(false);
            }
            if (sceneReference.Scene9Active == false)
            {
                S9.SetActive(false);
            }
            if (sceneReference.Scene10Active == false)
            {
                S10.SetActive(false);
            }
            if (sceneReference.Scene11Active == false)
            {
                S11.SetActive(false);
            }
            if (sceneReference.Scene12Active == false)
            {
                S12.SetActive(false);
            }
            if (sceneReference.Scene13Active == false)
            {
                S13.SetActive(false);
            }
            if (sceneReference.Scene14Active == false)
            {
                S14.SetActive(false);
            }
            if (sceneReference.Scene15Active == false)
            {
                S15.SetActive(false);
            }
            if (sceneReference.Scene16Active == false)
            {
                S16.SetActive(false);
            }
            if (sceneReference.Scene17Active == false)
            {
                S17.SetActive(false);
            }
            if (sceneReference.Scene18Active == false)
            {
                S18.SetActive(false);
            }
            if (sceneReference.Scene19Active == false)
            {
                S19.SetActive(false);
            }
            if (sceneReference.Scene20Active == false)
            {
                S20.SetActive(false);
            }
            if (sceneReference.Scene21Active == false)
            {
                S21.SetActive(false);
            }
            if (sceneReference.Scene22Active == false)
            {
                S22.SetActive(false);
            }
            if (sceneReference.Scene23Active == false)
            {
                S23.SetActive(false);
            }
            if (sceneReference.Scene24Active == false)
            {
                S24.SetActive(false);
            }
            if (sceneReference.Scene25Active == false)
            {
                S25.SetActive(false);
            }
            if (sceneReference.Scene26Active == false)
            {
                S26.SetActive(false);
            }
            if (sceneReference.Scene27Active == false)
            {
                S27.SetActive(false);
            }
            if (sceneReference.Scene28Active == false)
            {
                S28.SetActive(false);
            }
            if (sceneReference.Scene29Active == false)
            {
                S29.SetActive(false);
            }
            if (sceneReference.Scene30Active == false)
            {
                S30.SetActive(false);
            }
            if (sceneReference.Scene31Active == false)
            {
                S31.SetActive(false);
            }
            if (sceneReference.Scene32Active == false)
            {
                S32.SetActive(false);
            }
            if (sceneReference.Scene33Active == false)
            {
                S33.SetActive(false);
            }
            if (sceneReference.Scene34Active == false)
            {
                S34.SetActive(false);
            }
            if (sceneReference.Scene35Active == false)
            {
                S35.SetActive(false);
            }
            if (sceneReference.Scene36Active == false)
            {
                S36.SetActive(false);
            }
            if (sceneReference.Scene37Active == false)
            {
                S37.SetActive(false);
            }
            if (sceneReference.Scene38Active == false)
            {
                S38.SetActive(false);
            }
            if (sceneReference.Scene39Active == false)
            {
                S39.SetActive(false);
            }
            if (sceneReference.Scene40Active == false)
            {
                S40.SetActive(false);
            }
            if (sceneReference.Scene41Active == false)
            {
                S41.SetActive(false);
            }
            if (sceneReference.Scene42Active == false)
            {
                S42.SetActive(false);
            }
            if (sceneReference.Scene43Active == false)
            {
                S43.SetActive(false);
            }
            if (sceneReference.Scene44Active == false)
            {
                S44.SetActive(false);
            }
            if (sceneReference.Scene45Active == false)
            {
                S45.SetActive(false);
            }
            if (sceneReference.Scene46Active == false)
            {
                S46.SetActive(false);
            }
            if (sceneReference.Scene47Active == false)
            {
                S47.SetActive(false);
            }
            if (sceneReference.Scene48Active == false)
            {
                S48.SetActive(false);
            }
            if (sceneReference.Scene49Active == false)
            {
                S49.SetActive(false);
            }
            if (sceneReference.Scene50Active == false)
            {
                S50.SetActive(false);
            }
        }
        if (mapType == 1)
        {
            if (sceneReference.Scene1x2Active == false)
            {
                S1x2.SetActive(false);
            }
            if (sceneReference.Scene1x3Active == false)
            {
                S1x3.SetActive(false);
            }
            if (sceneReference.Scene1x4Active == false)
            {
                S1x4.SetActive(false);
            }
            if (sceneReference.Scene1x5aActive == false)
            {
                S1x5a.SetActive(false);
            }
            if (sceneReference.Scene1x6aActive == false)
            {
                S1x6a.SetActive(false);
            }
            if (sceneReference.Scene1x5bActive == false)
            {
                S1x5b.SetActive(false);
            }
            if (sceneReference.Scene1x6bActive == false)
            {
                S1x6b.SetActive(false);
            }
            if (sceneReference.Scene1x7Active == false)
            {
                S1x7.SetActive(false);
            }
            if (sceneReference.Scene1x8Active == false)
            {
                S1x8.SetActive(false);
            }
            if (sceneReference.Scene1x9Active == false)
            {
                S1x9.SetActive(false);
            }
            if (sceneReference.Scene1x10Active == false)
            {
                S1x10.SetActive(false);
            }
            if (sceneReference.Scene1x11Active == false)
            {
                S1x11.SetActive(false);
            }
            if (sceneReference.Scene1x12Active == false)
            {
                S1x12.SetActive(false);
            }
            if (sceneReference.Scene1xBActive == false)
            {
                S1xB.SetActive(false);
            }
        }
        if (mapType == 2)
        {
            if (sceneReference.Scene2x2Active == false)
            {
                S2x2.SetActive(false);
            }
            if (sceneReference.Scene2x3Active == false)
            {
                S2x3.SetActive(false);
            }
            if (sceneReference.Scene2x4aActive == false)
            {
                S2x4a.SetActive(false);
            }
            if (sceneReference.Scene2x4bActive == false)
            {
                S2x4b.SetActive(false);
            }
            if (sceneReference.Scene2x4cActive == false)
            {
                S2x4c.SetActive(false);
            }
            if (sceneReference.Scene2x5Active == false)
            {
                S2x5.SetActive(false);
            }
            if (sceneReference.Scene2x6Active == false)
            {
                S2x6.SetActive(false);
            }
            if (sceneReference.Scene2x7Active == false)
            {
                S2x7.SetActive(false);
            }
            if (sceneReference.Scene2x8Active == false)
            {
                S2x8.SetActive(false);
            }
            if (sceneReference.Scene2x9Active == false)
            {
                S2x9.SetActive(false);
            }
            if (sceneReference.Scene1x2Active == false)
            {
                S2x10.SetActive(false);
            }
            if (sceneReference.Scene2x11Active == false)
            {
                S2x11.SetActive(false);
            }
            if (sceneReference.Scene1x2Active == false)
            {
                S2x12.SetActive(false);
            }
            if (sceneReference.Scene2x13Active == false)
            {
                S2x13.SetActive(false);
            }
            if (sceneReference.Scene2x14Active == false)
            {
                S2x14.SetActive(false);
            }
            if (sceneReference.Scene2x15Active == false)
            {
                S2x15.SetActive(false);
            }
            if (sceneReference.Scene2x16Active == false)
            {
                S2x16.SetActive(false);
            }
            if (sceneReference.Scene2x17aActive == false)
            {
                S2x17a.SetActive(false);
            }
            if (sceneReference.Scene2x17bActive == false)
            {
                S2x17b.SetActive(false);
            }
            if (sceneReference.Scene2x18Active == false)
            {
                S2x18.SetActive(false);
            }
            if (sceneReference.Scene2x19Active == false)
            {
                S2x19.SetActive(false);
            }
            if (sceneReference.Scene2x20Active == false)
            {
                S2x20.SetActive(false);
            }   
            if (sceneReference.Scene2xB1Active == false)
            {
                S2xB1.SetActive(false);
            }
            if (sceneReference.Scene2xB2Active == false)
            {
                S2xB2.SetActive(false);
            }
        }
        if (mapType == 3)
        {
            if (sceneReference.Scene3x2Active == false)
            {
                S3x2.SetActive(false);
            }
            if (sceneReference.Scene3x3Active == false)
            {
                S3x3.SetActive(false);
            }
            if (sceneReference.Scene3x4Active == false)
            {
                S3x4.SetActive(false);
            }
            if (sceneReference.Scene3x5Active == false)
            {
                S3x5.SetActive(false);
            }
            if (sceneReference.Scene3x6Active == false)
            {
                S3x6.SetActive(false);
            }
            if (sceneReference.Scene3x7Active == false)
            {
                S3x7.SetActive(false);
            }
            if (sceneReference.Scene3x8Active == false)
            {
                S3x8.SetActive(false);
            }
            if (sceneReference.Scene3x9aActive == false)
            {
                S3x9a.SetActive(false);
            }
            if (sceneReference.Scene3x9bActive == false)
            {
                S3x9b.SetActive(false);
            }
            if (sceneReference.Scene3x10Active == false)
            {
                S3x10.SetActive(false);
            }
            if (sceneReference.Scene3x11Active == false)
            {
                S3x11.SetActive(false);
            }
            if (sceneReference.Scene3x12Active == false)
            {
                S3x12.SetActive(false);
            }
            if (sceneReference.Scene3x13Active == false)
            {
                S3x13.SetActive(false);
            }
            if (sceneReference.Scene3x14aActive == false)
            {
                S3x14a.SetActive(false);
            }
            if (sceneReference.Scene3x14bActive == false)
            {
                S3x14b.SetActive(false);
            }
            if (sceneReference.Scene3x14cActive == false)
            {
                S3x14c.SetActive(false);
            }
            if (sceneReference.Scene3x15bActive == false)
            {
                S3x15b.SetActive(false);
            }
            if (sceneReference.Scene3x15cActive == false)
            {
                S3x15c.SetActive(false);
            }
            if (sceneReference.Scene3x16bActive == false)
            {
                S3x16b.SetActive(false);
            }
            if (sceneReference.Scene3x17Active == false)
            {
                S3x17.SetActive(false);
            }
            if (sceneReference.Scene3x18Active == false)
            {
                S3x18.SetActive(false);
            }
            if (sceneReference.Scene3x19Active == false)
            {
                S3x19.SetActive(false);
            }
            if (sceneReference.Scene3x20Active == false)
            {
                S3x20.SetActive(false);
            }
            if (sceneReference.Scene3x21aActive == false)
            {
                S3x21a.SetActive(false);
            }
            if (sceneReference.Scene3x21bActive == false)
            {
                S3x21b.SetActive(false);
            }
            if (sceneReference.Scene3x21cActive == false)
            {
                S3x21c.SetActive(false);
            }
            if (sceneReference.Scene3x21dActive == false)
            {
                S3x21d.SetActive(false);
            }
            if (sceneReference.Scene3x21eActive == false)
            {
                S3x21e.SetActive(false);
            }
            if (sceneReference.Scene3x22Active == false)
            {
                S3x22.SetActive(false);
            }
            if (sceneReference.Scene3xB1Active == false)
            {
                S3xB1.SetActive(false);
            }
            if (sceneReference.Scene3xB2Active == false)
            {
                S3xB2.SetActive(false);
            }
        }
        if (mapType == 4)
        {
            if (sceneReference.Scene4x2Active == false)
            {
                S4x2.SetActive(false);
            }
            if (sceneReference.Scene4x3Active == false)
            {
                S4x3.SetActive(false);
            }
            if (sceneReference.Scene4x4Active == false)
            {
                S4x4.SetActive(false);
            }
            if (sceneReference.Scene4x5aActive == false)
            {
                S4x5a.SetActive(false);
            }
            if (sceneReference.Scene4x5bActive == false)
            {
                S4x5b.SetActive(false);
            }
            if (sceneReference.Scene4x6aActive == false)
            {
                S4x6a.SetActive(false);
            }
            if (sceneReference.Scene4x6bActive == false)
            {
                S4x6b.SetActive(false);
            }
            if (sceneReference.Scene4x7aActive == false)
            {
                S4x7a.SetActive(false);
            }
            if (sceneReference.Scene4x7bActive == false)
            {
                S4x7b.SetActive(false);
            }
            if (sceneReference.Scene4x8Active == false)
            {
                S4x8.SetActive(false);
            }
            if (sceneReference.Scene4x9Active == false)
            {
                S4x9.SetActive(false);
            }
            if (sceneReference.Scene4x10Active == false)
            {
                S4x10.SetActive(false);
            }
            if (sceneReference.Scene4x11Active == false)
            {
                S4x11.SetActive(false);
            }
            if (sceneReference.Scene4x12Active == false)
            {
                S4x12.SetActive(false);
            }
            if (sceneReference.Scene4x13Active == false)
            {
                S4x13.SetActive(false);
            }
            if (sceneReference.Scene4x14Active == false)
            {
                S4x14.SetActive(false);
            }
            if (sceneReference.Scene4xBActive == false)
            {
                S4xB.SetActive(false);
            }
        }
        if (mapType == 5)
        {
            if (sceneReference.Scene5x2Active == false)
            {
                S5x2.SetActive(false);
            }
        }
        #endregion

    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    #region Collision with Map Pieces
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject SceneUnlocker = GameObject.Find("SceneUnlocker");
        scene_unlocker_script levelReference = SceneUnlocker.GetComponent<scene_unlocker_script>();


        if ((col.gameObject.name == "S1") && (preventChilds == true))
        {
            scene = 2;
            if ((levelReference.classic1Done == false) && (levelReference.classic1Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic1Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic1Min == true)
            {
                LevelIndicatorFunctionPerfect();
            }
        }
        if ((col.gameObject.name == "S2") && (preventChilds == true))
        {
            scene = 3;
            if ((levelReference.classic2Done == false) && (levelReference.classic2Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic2Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic2Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S3") && (preventChilds == true))
        {
            scene = 4;
            if ((levelReference.classic3Done == false) && (levelReference.classic3Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic3Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic3Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S4") && (preventChilds == true))
        {
            scene = 5;
            if ((levelReference.classic4Done == false) && (levelReference.classic4Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic4Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic4Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S5") && (preventChilds == true))
        {
            scene = 6;
            if ((levelReference.classic5Done == false) && (levelReference.classic5Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic5Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic5Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S6") && (preventChilds == true))
        {
            scene = 7;
            if ((levelReference.classic6Done == false) && (levelReference.classic6Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic6Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic6Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S7") && (preventChilds == true))
        {
            scene = 8;
            if ((levelReference.classic7Done == false) && (levelReference.classic7Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic7Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic7Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S8") && (preventChilds == true))
        {
            scene = 9;
            if ((levelReference.classic8Done == false) && (levelReference.classic8Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic8Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic8Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S9") && (preventChilds == true))
        {
            scene = 10;
            if ((levelReference.classic9Done == false) && (levelReference.classic9Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic9Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic9Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S10") && (preventChilds == true))
        {
            scene = 11;
            if ((levelReference.classic10Done == false) && (levelReference.classic10Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic10Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic10Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S11") && (preventChilds == true))
        {
            scene = 12;
            if ((levelReference.classic11Done == false) && (levelReference.classic11Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic11Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic11Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S12") && (preventChilds == true))
        {
            scene = 13;
            if ((levelReference.classic12Done == false) && (levelReference.classic12Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic12Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic12Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S13") && (preventChilds == true))
        {
            scene = 14;
            if ((levelReference.classic13Done == false) && (levelReference.classic13Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic13Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic13Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S14") && (preventChilds == true))
        {
            scene = 15;
            if ((levelReference.classic14Done == false) && (levelReference.classic14Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic14Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic14Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S15") && (preventChilds == true))
        {
            scene = 16;
            if ((levelReference.classic15Done == false) && (levelReference.classic15Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic15Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic15Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S16") && (preventChilds == true))
        {
            scene = 17;
            if ((levelReference.classic16Done == false) && (levelReference.classic16Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic16Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic16Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S17") && (preventChilds == true))
        {
            scene = 18;
            if ((levelReference.classic17Done == false) && (levelReference.classic17Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic17Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic17Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S18") && (preventChilds == true))
        {
            scene = 19;
            if ((levelReference.classic18Done == false) && (levelReference.classic18Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic18Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic18Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S19") && (preventChilds == true))
        {
            scene = 20;
            if ((levelReference.classic19Done == false) && (levelReference.classic19Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic19Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic19Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S20") && (preventChilds == true))
        {
            scene = 21;
            if ((levelReference.classic20Done == false) && (levelReference.classic20Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic20Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic20Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S21") && (preventChilds == true))
        {
            scene = 22;
            if ((levelReference.classic21Done == false) && (levelReference.classic21Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic21Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic21Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S22") && (preventChilds == true))
        {
            scene = 23;
            if ((levelReference.classic22Done == false) && (levelReference.classic22Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic22Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic22Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S23") && (preventChilds == true))
        {
            scene = 24;
            if ((levelReference.classic23Done == false) && (levelReference.classic23Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic23Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic23Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S24") && (preventChilds == true))
        {
            scene = 25;
            if ((levelReference.classic24Done == false) && (levelReference.classic24Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic24Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic24Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S25") && (preventChilds == true))
        {
            scene = 26;
            if ((levelReference.classic25Done == false) && (levelReference.classic25Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic25Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic25Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S26") && (preventChilds == true))
        {
            scene = 27;
            if ((levelReference.classic26Done == false) && (levelReference.classic26Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic26Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic26Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S27") && (preventChilds == true))
        {
            scene = 28;
            if ((levelReference.classic27Done == false) && (levelReference.classic27Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic27Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic27Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S28") && (preventChilds == true))
        {
            scene = 29;
            if ((levelReference.classic28Done == false) && (levelReference.classic28Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic28Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic28Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S29") && (preventChilds == true))
        {
            scene = 30;
            if ((levelReference.classic29Done == false) && (levelReference.classic29Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic29Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic29Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S30") && (preventChilds == true))
        {
            scene = 31;
            if ((levelReference.classic30Done == false) && (levelReference.classic30Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic30Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic30Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S31") && (preventChilds == true))
        {
            scene = 32;
            if ((levelReference.classic31Done == false) && (levelReference.classic31Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic31Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic31Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S32") && (preventChilds == true))
        {
            scene = 33;
            if ((levelReference.classic32Done == false) && (levelReference.classic32Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic32Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic32Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S33") && (preventChilds == true))
        {
            scene = 34;
            if ((levelReference.classic33Done == false) && (levelReference.classic33Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic33Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic33Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S34") && (preventChilds == true))
        {
            scene = 35;
            if ((levelReference.classic34Done == false) && (levelReference.classic34Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic34Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic34Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S35") && (preventChilds == true))
        {
            scene = 36;
            if ((levelReference.classic35Done == false) && (levelReference.classic35Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic35Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic35Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S36") && (preventChilds == true))
        {
            scene = 37;
            if ((levelReference.classic36Done == false) && (levelReference.classic36Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic36Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic36Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S37") && (preventChilds == true))
        {
            scene = 38;
            if ((levelReference.classic37Done == false) && (levelReference.classic37Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic37Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic37Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S38") && (preventChilds == true))
        {
            scene = 39;
            if ((levelReference.classic38Done == false) && (levelReference.classic38Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic38Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic38Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S39") && (preventChilds == true))
        {
            scene = 40;
            if ((levelReference.classic39Done == false) && (levelReference.classic39Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic39Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic39Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S40") && (preventChilds == true))
        {
            scene = 41;
            if ((levelReference.classic40Done == false) && (levelReference.classic40Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic40Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic40Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S41") && (preventChilds == true))
        {
            scene = 42;
            if ((levelReference.classic41Done == false) && (levelReference.classic41Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic41Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic41Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S42") && (preventChilds == true))
        {
            scene = 43;
            if ((levelReference.classic42Done == false) && (levelReference.classic42Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic42Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic42Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S43") && (preventChilds == true))
        {
            scene = 44;
            if ((levelReference.classic43Done == false) && (levelReference.classic43Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic43Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic43Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S44") && (preventChilds == true))
        {
            scene = 45;
            if ((levelReference.classic44Done == false) && (levelReference.classic44Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic44Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic44Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S45") && (preventChilds == true))
        {
            scene = 46;
            if ((levelReference.classic45Done == false) && (levelReference.classic45Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic45Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic45Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S46") && (preventChilds == true))
        {
            scene = 47;
            if ((levelReference.classic46Done == false) && (levelReference.classic46Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic46Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic46Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S47") && (preventChilds == true))
        {
            scene = 48;
            if ((levelReference.classic47Done == false) && (levelReference.classic47Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic47Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic47Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S48") && (preventChilds == true))
        {
            scene = 49;
            if ((levelReference.classic48Done == false) && (levelReference.classic48Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic48Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic48Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S49") && (preventChilds == true))
        {
            scene = 50;
            if ((levelReference.classic49Done == false) && (levelReference.classic49Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic49Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic49Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }
        if ((col.gameObject.name == "S50") && (preventChilds == true))
        {
            scene = 51;
            if ((levelReference.classic50Done == false) && (levelReference.classic50Min == false))
            {
                LevelIndicatorFunctionNew();
            }
            if (levelReference.classic50Done == true)
            {
                LevelIndicatorFunctionDone();
            }
            if (levelReference.classic50Min == true)
            {
                LevelIndicatorFunctionPerfect();;
            }
        }

        ////////////////////////////////////
        if (col.gameObject == S1x1)
        {
            scene2 = 2;
        }
        if (col.gameObject == S1x2)
        {
            scene2 = 3;
        }
        if (col.gameObject == S1x3)
        {
            scene2 = 4;
        }
        if (col.gameObject == S1x4)
        {
            scene2 = 5;
        }
        if (col.gameObject == S1x5a)
        {
            scene2 = 6;
        }
        if (col.gameObject == S1x6a)
        {
            scene2 = 7;
        }
        if (col.gameObject == S1x5b)
        {
            scene2 = 8;
        }
        if (col.gameObject == S1x6b)
        {
            scene2 = 9;
        }
        if (col.gameObject == S1x7)
        {
            scene2 = 10;
        }
        if (col.gameObject == S1x8)
        {
            scene2 = 11;
        }
        if (col.gameObject == S1x9)
        {
            scene2 = 12;
        }
        if (col.gameObject == S1x10)
        {
            scene2 = 13;
        }
        if (col.gameObject == S1x11)
        {
            scene2 = 14;
        }
        if (col.gameObject == S1x12)
        {
            scene2 = 15;
        }
        if (col.gameObject == S1xB)
        {
            scene2 = 101;
        }
        if (col.gameObject == S2x1)
        {
            scene2 = 16;
        }
        if (col.gameObject == S2x2)
        {
            scene2 = 17;
        }
        if (col.gameObject == S2x3)
        {
            scene2 = 18;
        }
        if (col.gameObject == S2x4a)
        {
            scene2 = 19;
        }
        if (col.gameObject == S2x4b)
        {
            scene2 = 20;
        }
        if (col.gameObject == S2x4c)
        {
            scene2 = 21;
        }
        if (col.gameObject == S2x5)
        {
            scene2 = 22;
        }
        if (col.gameObject == S2x6)
        {
            scene2 = 23;
        }
        if (col.gameObject == S2x7)
        {
            scene2 = 24;
        }
        if (col.gameObject == S2x8)
        {
            scene2 = 25;
        }
        if (col.gameObject == S2x9)
        {
            scene2 = 26;
        }
        if (col.gameObject == S2x10)
        {
            scene2 = 27;
            MoveCameraLeft();
        }
        if (col.gameObject == S2x11)
        {
            scene2 = 28;
            MoveCameraRight();
        }
        if (col.gameObject == S2x12)
        {
            scene2 = 29;
        }
        if (col.gameObject == S2x13)
        {
            scene2 = 30;
        }
        if (col.gameObject == S2x14)
        {
            scene2 = 31;
        }
        if (col.gameObject == S2x15)
        {
            scene2 = 32;
        }
        if (col.gameObject == S2x16)
        {
            scene2 = 33;
        }
        if (col.gameObject == S2x17a)
        {
            scene2 = 34;
        }
        if (col.gameObject == S2x17b)
        {
            scene2 = 35;
        }
        if (col.gameObject == S2x18)
        {
            scene2 = 36;
        }
        if (col.gameObject == S2x19)
        {
            scene2 = 37;
        }
        if (col.gameObject == S2x20)
        {
            scene2 = 38;
        }
        if (col.gameObject == S2xB1)
        {
            scene2 = 102;
        }
        if (col.gameObject == S2xB2)
        {
            scene2 = 103;
        }
        if (col.gameObject == S3x1)
        {
            scene2 = 39;
        }
        if (col.gameObject == S3x2)
        {
            scene2 = 40;
        }
        if (col.gameObject == S3x3)
        {
            scene2 = 41;
        }
        if (col.gameObject == S3x4)
        {
            scene2 = 42;
        }
        if (col.gameObject == S3x5)
        {
            scene2 = 43;
        }
        if (col.gameObject == S3x6)
        {
            scene2 = 44;
        }
        if (col.gameObject == S3x7)
        {
            scene2 = 45;
        }
        if (col.gameObject == S3x8)
        {
            scene2 = 46;
        }
        if (col.gameObject == S3x9a)
        {
            scene2 = 47;
        }
        if (col.gameObject == S3x9b)
        {
            scene2 = 48;
        }
        if (col.gameObject == S3x10)
        {
            scene2 = 49;
        }
        if (col.gameObject == S3x11)
        {
            scene2 = 50;
        }
        if (col.gameObject == S3x12)
        {
            scene2 = 51;
        }
        if (col.gameObject == S3x13)
        {
            scene2 = 52;
        }
        if (col.gameObject == S3x14a)
        {
            scene2 = 53;
        }
        if (col.gameObject == S3x14b)
        {
            scene2 = 54;
        }
        if (col.gameObject == S3x14c)
        {
            scene2 = 55;
        }
        if (col.gameObject == S3x15b)
        {
            scene2 = 56;
        }
        if (col.gameObject == S3x15c)
        {
            scene2 = 57;
        }
        if (col.gameObject == S3x16b)
        {
            scene2 = 58;
        }
        if (col.gameObject == S3x17)
        {
            scene2 = 59;
        }
        if (col.gameObject == S3x18)
        {
            scene2 = 60;
        }
        if (col.gameObject == S3x19)
        {
            scene2 = 61;
        }
        if (col.gameObject == S3x20)
        {
            scene2 = 62;
        }
        if (col.gameObject == S3x21a)
        {
            scene2 = 63;
        }
        if (col.gameObject == S3x21b)
        {
            scene2 = 64;
        }
        if (col.gameObject == S3x21c)
        {
            scene2 = 65;
        }
        if (col.gameObject == S3x21d)
        {
            scene2 = 66;
        }
        if (col.gameObject == S3x21e)
        {
            scene2 = 67;
        }
        if (col.gameObject == S3x22)
        {
            scene2 = 68;
        }
        if (col.gameObject == S3xB1)
        {
            scene2 = 104;
        }
        if (col.gameObject == S3xB2)
        {
            scene2 = 105;
        }
        if (col.gameObject == S4x1)
        {
            scene2 = 69;
        }
        if (col.gameObject == S4x2)
        {
            scene2 = 70;
        }
        if (col.gameObject == S4x3)
        {
            scene2 = 71;
        }
        if (col.gameObject == S4x4)
        {
            scene2 = 72;
        }
        if (col.gameObject == S4x5a)
        {
            scene2 = 73;
        }
        if (col.gameObject == S4x5b)
        {
            scene2 = 74;
        }
        if (col.gameObject == S4x6a)
        {
            scene2 = 75;
        }
        if (col.gameObject == S4x6b)
        {
            scene2 = 76;
        }
        if (col.gameObject == S4x7a)
        {
            scene2 = 77;
        }
        if (col.gameObject == S4x7b)
        {
            scene2 = 78;
        }
        if (col.gameObject == S4x8)
        {
            scene2 = 79;
        }
        if (col.gameObject == S4x9)
        {
            scene2 = 80;
        }
        if (col.gameObject == S4x10)
        {
            scene2 = 81;
        }
        if (col.gameObject == S4x11)
        {
            scene2 = 82;
        }
        if (col.gameObject == S4x12)
        {
            scene2 = 83;
        }
        if (col.gameObject == S4x13)
        {
            scene2 = 84;
        }
        if (col.gameObject == S4x14)
        {
            scene2 = 85;
        }
        if (col.gameObject == S4xB)
        {
            scene2 = 106;
        }
        if (col.gameObject == S5x1a)
        {
            scene2 = 86;
        }
        if (col.gameObject == S5x1b)
        {
            scene2 = 87;
        }
        if (col.gameObject == S5x1c)
        {
            scene2 = 88;
        }
        if (col.gameObject == S5x1d)
        {
            scene2 = 89;
        }
        if (col.gameObject == S5x2)
        {
            scene2 = 90;
        }
    }

        #endregion

        public void MoveCameraLeft()
    {
        GameObject Camera = GameObject.Find("Main Camera");
        camera_script camReference = Camera.GetComponent<camera_script>();
        if (camReference.cameraMove == 2)
        {
            Debug.Log("1X");
            camReference.cameraMove = 3;
        }
    }
    public void MoveCameraRight()
    {
        GameObject Camera = GameObject.Find("Main Camera");
        camera_script camReference = Camera.GetComponent<camera_script>();
        if (camReference.cameraMove == 0)
        {
            Debug.Log("2X");
            camReference.cameraMove = 1;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        scene = 0;
        scene2 = 0;
    }

    public void LevelIndicatorFunctionNew()
    {
        if (mapType == 0)
        {
            GameObject LevelIndicator = GameObject.Find("classic map icon");
            classic_level_indicator_script levelIconReference = LevelIndicator.GetComponent<classic_level_indicator_script>();
            levelIconReference.status = 0;
        }
    }
    public void LevelIndicatorFunctionDone()
    {
        if (mapType == 0)
        {
            GameObject LevelIndicator = GameObject.Find("classic map icon");
            classic_level_indicator_script levelIconReference = LevelIndicator.GetComponent<classic_level_indicator_script>();
            levelIconReference.status = 1;
        }
    }
    public void LevelIndicatorFunctionPerfect()
    {
        if (mapType == 0)
        {
            GameObject LevelIndicator = GameObject.Find("classic map icon");
            classic_level_indicator_script levelIconReference = LevelIndicator.GetComponent<classic_level_indicator_script>();
            levelIconReference.status = 2;
        }
    }
}
