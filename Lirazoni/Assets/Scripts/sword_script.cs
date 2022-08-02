using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_script : MonoBehaviour
{
    public bool youDestroyedAWall;
    public GameObject crackedWallRef;
    public bool preventLackeysKill;

    IEnumerator WallCrush()
    {
        youDestroyedAWall = true;
        yield return new WaitForSeconds(0.3f);
        youDestroyedAWall = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag.Equals("RegularEnemy")) || (((collision.gameObject.tag.Equals("JumpEnemy")) && preventLackeysKill == false)))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "crackedWall")
        {
            //Destroy(collision.gameObject);
            //crackedWallRef.SetActive(false);
               GameObject Wall = GameObject.Find("crackedWall");
               wall_script switchReference = Wall.GetComponent<wall_script>();
               switchReference.destroyCheck = true;

            StartCoroutine(WallCrush());
        }
    }
}
