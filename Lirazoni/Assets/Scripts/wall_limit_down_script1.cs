using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_limit_down_script1 : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter2D(Collider2D col1)
    {
        if ((col1.gameObject.tag.Equals("wall")) || (col1.gameObject.tag.Equals("wall2")) || (col1.gameObject.tag.Equals("wall3")))
        {
            master_script.current.WallCollisionDownEnter(id);
        }
    }

    private void OnTriggerExit2D(Collider2D col2)
    {
        if ((col2.gameObject.tag.Equals("wall")) || (col2.gameObject.tag.Equals("wall2")) || (col2.gameObject.tag.Equals("wall3")))
        {
            master_script.current.WallCollisionDownExit(id);
        }
    }
}