using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Show the buildIndex for the current script.
//
// The Build Settings window show 5 added scenes.  These have buildIndex values from
// 0 to 4. Each scene has a version of this script applied.
//
// In the project create 5 scenes called scene1, scene2, scene3, scene4 and scene5.
// In each scene add an empty GameObject and attach this script to it.
//
// Each scene randomly switches to a different scene when the button is clicked.

public class ExampleScript : MonoBehaviour
{
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene name is: " + scene.name + "\nActive Scene index: " + scene.buildIndex);
    }

  //  void OnGUI()
  //  {
  //      GUI.skin.button.fontSize = 20;
  //
  //      if (GUI.Button(new Rect(10, 80, 180, 60), "Change from scene " + scene.buildIndex))
  //      {
  //          int nextSceneIndex = Random.Range(0, 4);
  //          SceneManager.LoadScene(nextSceneIndex, LoadSceneMode.Single);
  //      }
  //  }
}