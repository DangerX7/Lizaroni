using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class begin_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutineBegin()); // LOAD TITTLE SCREEN
    }

    IEnumerator ExampleCoroutineBegin()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Tittle_Screen");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
