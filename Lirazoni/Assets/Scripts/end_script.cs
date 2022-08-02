using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutineEnd()); // LOAD TITTLE SCREEN
    }


    IEnumerator ExampleCoroutineEnd()
    {
        yield return new WaitForSeconds(3);
     //   SceneManager.LoadScene("Tittle_Screen");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
