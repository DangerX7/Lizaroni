using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class wall_limits_script : MonoBehaviour
{
    public int id;
    public byte limitType;
    /*
    0-left
    1-right
    2-up
    3-down
    4-left (double jump)
    5-right (double jump)
    6-up (double jump)
    7-down (double jump)
    */

    private void OnTriggerEnter2D(Collider2D col1)
    {
        if (limitType == 0)
        {
            if ((col1.gameObject.tag.Equals("wall")) || (col1.gameObject.tag.Equals("wall2")))
            {
                master_script.current.WallCollisionLeftEnter(id);
            }
        }
        else if (limitType == 1)
        {
            if ((col1.gameObject.tag.Equals("wall")) || (col1.gameObject.tag.Equals("wall2")))
            {
                master_script.current.WallCollisionRightEnter(id);
            }
        }
        else if (limitType == 2)
        {
            if ((col1.gameObject.tag.Equals("wall")) || (col1.gameObject.tag.Equals("wall2")))
            {
                master_script.current.WallCollisionDownEnter(id);
            }
        }
        else if (limitType == 3)
        {
            if ((col1.gameObject.tag.Equals("wall")) || (col1.gameObject.tag.Equals("wall2")))
            {
                master_script.current.WallCollisionUpEnter(id);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col2)
    {
        if (limitType == 0)
        {
            if ((col2.gameObject.tag.Equals("wall")) || (col2.gameObject.tag.Equals("wall2")))
            {
                master_script.current.WallCollisionLeftExit(id);
            }
        }
        else if (limitType == 1)
        {
            if ((col2.gameObject.tag.Equals("wall")) || (col2.gameObject.tag.Equals("wall2")))
            {
                master_script.current.WallCollisionRightExit(id);
            }
        }
        else if (limitType == 2)
        {
            if ((col2.gameObject.tag.Equals("wall")) || (col2.gameObject.tag.Equals("wall2")))
            {
                master_script.current.WallCollisionDownExit(id);
            }
        }
        else if (limitType == 3)
        {
            if ((col2.gameObject.tag.Equals("wall")) || (col2.gameObject.tag.Equals("wall2")))
            {
                master_script.current.WallCollisionUpExit(id);
            }
        }
    }
}