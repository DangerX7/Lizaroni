using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_icon_script : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Map = GameObject.Find("stage_cursor");
        map_script mapReference = Map.GetComponent<map_script>();

        animator.SetBool("Enter", mapReference.accessLevel);
        if (mapReference.accessLevel == true)
        {
            Debug.Log("sdfedvefve");
        }
    }
}
