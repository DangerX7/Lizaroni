using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWallCheck : MonoBehaviour
{
    public bool secondaryCollisionCheck;
    public bool collisionEnabler;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")))
        {
            secondaryCollisionCheck = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")))
        {
            secondaryCollisionCheck = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (collisionEnabler == false)    // enable or dissable collider for not getting read when it doesn't need to
        {
            GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("Collision Dissabled!");
        }
        else if (collisionEnabler == true)
        {
            GetComponent<BoxCollider2D>().enabled = true;
            Debug.Log("Collision Enabled!");
        }
        */
    }
}
