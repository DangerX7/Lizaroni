using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b1_player_detect_script : MonoBehaviour
{
    public bool collisionCheck;

    IEnumerator CoroutineWait()
    {
        GameObject Boss = GameObject.Find("Boss 1");
        boss1_script attackReference = Boss.GetComponent<boss1_script>();
        yield return new WaitForSeconds(0.1f);
        attackReference.exitPLayer = false;
        collisionCheck = true;
        attackReference.phase = 1;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
                StartCoroutine(CoroutineWait());
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        GameObject Boss = GameObject.Find("Boss 1");
        boss1_script attackReference = Boss.GetComponent<boss1_script>();
        if (collision.gameObject.tag.Equals("Player"))
        {
            attackReference.exitPLayer = true;
            collisionCheck = false;
            attackReference.phase = 0;
            attackReference.isAttackingOn = false;
        }
    }
}
