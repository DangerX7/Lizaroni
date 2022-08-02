using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dev_keyboardV : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator Reset()
    {
        GameObject Play = GameObject.Find("Player");
        player_script countRef = Play.GetComponent<player_script>();
        countRef.countReset = true;
        yield return new WaitForSeconds(0.001f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    IEnumerator Previous()
    {
        GameObject Play = GameObject.Find("Player");
        player_script countRef = Play.GetComponent<player_script>();
        countRef.countReset = true;
        yield return new WaitForSeconds(0.001f);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) - 1);
    }
    IEnumerator Next()
    {
        GameObject Play = GameObject.Find("Player");
        player_script countRef = Play.GetComponent<player_script>();
        countRef.countReset = true;
        yield return new WaitForSeconds(0.001f);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Reset current level
        {
            StartCoroutine(Reset());
        }
        if (Input.GetKeyDown(KeyCode.O)) // Load previous level
        {
            StartCoroutine(Previous());
        }
        if (Input.GetKeyDown(KeyCode.P)) // Load next level
        {
            StartCoroutine(Next());
        }
    }
}
