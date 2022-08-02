using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b4_player_up_detect_script : MonoBehaviour
{
    public bool collisionCheck;

    IEnumerator CoroutineWait()
    {
        GameObject Boos4_Real = GameObject.Find("Real");
        boss4a_script Boss4_1Reference = Boos4_Real.GetComponent<boss4a_script>();
        if (Boss4_1Reference.type == 0)
        {
            GameObject RightLimit = GameObject.Find("right player detect 0");
            b4_player_right_detect_script rightRef0 = RightLimit.GetComponent<b4_player_right_detect_script>();
            GameObject leftLimit = GameObject.Find("left player detect 0");
            b4_player_left_detect_script leftRef0 = leftLimit.GetComponent<b4_player_left_detect_script>();
            GameObject DownLimit = GameObject.Find("down player detect 0");
            b4_player_down_detect_script downRef0 = DownLimit.GetComponent<b4_player_down_detect_script>();
            rightRef0.collisionCheck = false;
            leftRef0.collisionCheck = false;
            downRef0.collisionCheck = false;
        }

        yield return new WaitForSeconds(0.0000001f);
        collisionCheck = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("PLAYER COLLIDED UP!");
            StartCoroutine(CoroutineWait());
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collisionCheck = false;
        }
    }
}
