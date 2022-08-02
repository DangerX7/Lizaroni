using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b2_wall_detect_script : MonoBehaviour
{
    public bool wallCheck;
    public bool boss4Check;
    public int id;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (boss4Check == false)
        {
            if (collision.gameObject.tag.Equals("wall"))
            {
                wallCheck = true;
            }
        }
        if (boss4Check == true)
        {
        //    GameObject Boss4 = GameObject.Find("Clone");
        //    boss4_script Boss4Reference = Boss4.GetComponent<boss4_script>();
            if ((collision.gameObject.tag.Equals("wall")) || (collision.gameObject.tag.Equals("wall2")))
            {
                //    Boss4Reference.moveLOCK = true;
            //    Debug.Log("WALL COLLISION!");
                wallCheck = true;
            }
        }

    }
    void OnTriggerExit2D(Collider2D collision2)
    {
        if (boss4Check == false)
        {
            if (collision2.gameObject.tag.Equals("wall"))
            {
                wallCheck = false;
            }
        }
        if (boss4Check == true)
        {
         //   GameObject Boss4 = GameObject.Find("Clone");
         //   boss4_script Boss4Reference = Boss4.GetComponent<boss4_script>();
            if ((collision2.gameObject.tag.Equals("wall")) || (collision2.gameObject.tag.Equals("wall2")) || (collision2.gameObject.tag.Equals("Boss")))
            {
                //    Boss4Reference.moveLOCK = false;
                //   Debug.Log("WALL COLLISION!");
                    wallCheck = false;
            }
        }
    }
}
