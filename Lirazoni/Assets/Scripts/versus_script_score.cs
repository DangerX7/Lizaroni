using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class versus_script_score : MonoBehaviour
{
    public byte player; // 1 for player 1, 2 for player 2 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("SceneUnlocker") != null)
        {
            GameObject SceneUnlocker = GameObject.Find("SceneUnlocker");
            scene_unlocker_script sceneReference = SceneUnlocker.GetComponent<scene_unlocker_script>();

            if (player == 1)
            {
                if (sceneReference.win1_1 == true)
                {
                    transform.GetChild(1).gameObject.SetActive(true);
                }
                if (sceneReference.win1_2 == true)
                {
                    transform.GetChild(2).gameObject.SetActive(true);
                }
                if (sceneReference.win1_3 == true)
                {
                    transform.GetChild(3).gameObject.SetActive(true);
                }
                if (sceneReference.p1Victory == true)
                {
                    transform.GetChild(4).gameObject.SetActive(true);
                }
            }
            if (player == 2)
            {
                if (sceneReference.win2_1 == true)
                {
                    transform.GetChild(1).gameObject.SetActive(true);
                }
                if (sceneReference.win2_2 == true)
                {
                    transform.GetChild(2).gameObject.SetActive(true);
                }
                if (sceneReference.win2_3 == true)
                {
                    transform.GetChild(3).gameObject.SetActive(true);
                }
                if (sceneReference.p2Victory == true)
                {
                    transform.GetChild(4).gameObject.SetActive(true);
                }
            }
        }
    }
}
