using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_limit_up_script : MonoBehaviour
{
    public int id;
    public bool X2;

    private void OnTriggerEnter2D(Collider2D col1)
    {
        if (X2 == false)
        {
            if ((col1.gameObject.tag.Equals("wall")) || (col1.gameObject.tag.Equals("wall2")) || (col1.gameObject.tag.Equals("wall3")))
            {
                master_script.current.WallCollisionUpEnter(id);
            }
        }
        else if (X2 == true)
        {
            if ((col1.gameObject.tag.Equals("wall")) || (col1.gameObject.tag.Equals("wall2")) || (col1.gameObject.tag.Equals("wall3")))
            {
                master_script.current.WallCollisionUpEnterX2(id);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col2)
    {
        if (X2 == false)
        {
            if ((col2.gameObject.tag.Equals("wall")) || (col2.gameObject.tag.Equals("wall2")) || (col2.gameObject.tag.Equals("wall3")))
            {
                master_script.current.WallCollisionUpExit(id);
            }
        }
        else if (X2 == true)
        {
            if ((col2.gameObject.tag.Equals("wall")) || (col2.gameObject.tag.Equals("wall2")) || (col2.gameObject.tag.Equals("wall3")))
            {
                master_script.current.WallCollisionUpExitX2(id);
            }
        }
    }
}