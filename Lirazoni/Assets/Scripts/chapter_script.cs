using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chapter_script : MonoBehaviour
{

    public GameObject cursor, menu, C2, C3, C4, C5;
    public int scene;
    public int limit = 1;

    public bool Chapter2Active;
    public bool Chapter3Active;
    public bool Chapter4Active;
    public bool Chapter5Active;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && (scene != 1) || (Input.GetKeyDown("up")) && (scene != 1))
        {
            Vector3 temp = new Vector3(0, 1, 0);
            cursor.transform.position += temp;
        }
        if (Input.GetKeyDown(KeyCode.S) || (Input.GetKeyDown("down")))
        {
            Vector3 temp = new Vector3(0, -1, 0);
            if (limit == 1)
            {
                // no move
            }
            if (limit == 2)
            {
                if (scene != 2)
                {
                    cursor.transform.position += temp;
                }
            }
            if (limit == 3)
            {
                if (scene != 3)
                {
                    cursor.transform.position += temp;
                }
            }
            if (limit == 4)
            {
                if (scene != 4)
                {
                    cursor.transform.position += temp;
                }
            }
            if (limit == 5)
            {
                if (scene != 5)
                {
                    cursor.transform.position += temp;
                }
            }
        }


        if (Chapter2Active == false)
        {
            C2.SetActive(false);
        }
        else if (Chapter2Active == true)
        {
            C2.SetActive(true);
            limit = 2;
        }

        if (Chapter3Active == false)
        {
            C3.SetActive(false);
        }
        else if (Chapter3Active == true)
        {
            C3.SetActive(true);
            limit = 3;
        }

        if (Chapter4Active == false)
        {
            C4.SetActive(false);
        }
        else if (Chapter4Active == true)
        {
            C4.SetActive(true);
            limit = 4;
        }

        if (Chapter5Active == false)
        {
            C5.SetActive(false);
        }
        else if (Chapter5Active == true)
        {
            C5.SetActive(true);
            limit = 5;
        }

        //   Debug.Log(scene);


        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (scene == 0)
            {
                Debug.Log("Nothing happened");
            }
            if (scene == 1)
            {
                SceneManager.LoadScene("Chapter 1 Map");
            }
            if (scene == 2)
            {
                SceneManager.LoadScene("Chapter 2 Map");
            }
            if (scene == 3)
            {
                SceneManager.LoadScene("Chapter 3 Map");
            }
            if (scene == 4)
            {
                SceneManager.LoadScene("Chapter 4 Map");
            }
            if (scene == 5)
            {
                SceneManager.LoadScene("Chapter 5 Map");
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Tittle_Screen");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //hit.transform.gameObject.name == "name"

        if (col.transform.gameObject.name == ("1"))
        {
            scene = 1;
        }
        if (col.transform.gameObject.name == ("2"))
        {
            scene = 2;
        }
        if (col.transform.gameObject.name == ("3"))
        {
            scene = 3;
        }
        if (col.transform.gameObject.name == ("4"))
        {
            scene = 4;
        }
        if (col.transform.gameObject.name == ("5"))
        {
            scene = 5;
        }
    }
}
