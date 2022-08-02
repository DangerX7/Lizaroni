using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra_collision_script : MonoBehaviour
{
    public byte dir;
    public bool playerInUpSight;
    public bool playerInDownSight;
    public bool playerInLeftSight;
    public bool playerInRightSight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if (dir == 1)
            {
                playerInUpSight = true;
            }
            if (dir == 2)
            {
                playerInDownSight = true;
            }
            if (dir == 3)
            {
                playerInLeftSight = true;
            }
            if (dir == 4)
            {
                playerInRightSight = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D col2)
    {
        if (col2.gameObject.tag.Equals("Player"))
        {
            if (dir == 1)
            {
                playerInUpSight = false;
            }
            if (dir == 2)
            {
                playerInDownSight = false;
            }
            if (dir == 3)
            {
                playerInLeftSight = false;
            }
            if (dir == 4)
            {
                playerInRightSight = false;
            }
        }
    }
}
