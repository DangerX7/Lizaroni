using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b2_player_detect_script : MonoBehaviour
{
    public bool collisionCheckUp;
    public bool collisionCheckDown;
    public bool collisionCheckLeft;
    public bool collisionCheckRight;
    public int type; // 1Up,2Down,3Left,4Right

    IEnumerator CoroutineWait()
    {
        yield return new WaitForSeconds(0.000001f);
        if (type == 1)
        {
            collisionCheckUp = true;
            collisionCheckDown = false;
            collisionCheckLeft = false;
            collisionCheckRight = false;
        }
        if (type == 2)
        {
            collisionCheckUp = false;
            collisionCheckDown = true;
            collisionCheckLeft = false;
            collisionCheckRight = false;
        }
        if (type == 3)
        {
            collisionCheckUp = false;
            collisionCheckDown = false;
            collisionCheckLeft = true;
            collisionCheckRight = false;
        }
        if (type == 4)
        {
            collisionCheckUp = false;
            collisionCheckDown = false;
            collisionCheckLeft = false;
            collisionCheckRight = true;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("PLAYER COLLISION!");
            StartCoroutine(CoroutineWait());
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (type == 1)
            {
                collisionCheckUp = false;
            }
            if (type == 2)
            {
                Debug.Log("down exit");
                collisionCheckDown = false;
            }
            if (type == 3)
            {
                collisionCheckLeft = false;
            }
            if (type == 4)
            {
                collisionCheckRight = false;
            }
        }
    }
}
