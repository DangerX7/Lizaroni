using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_script : MonoBehaviour
{
    public int id;
    public int portalNumber;
    public GameObject player, player2, portal0, portal1, portal2, portal3, portal4, portal5;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    private void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.gameObject.tag.Equals("Player")) && (active == false))
        {
            if (id == 0)
            {
                if (portalNumber == 0)
                {
                    player.transform.position = portal1.transform.position;
                    active = true;
                }
                if (portalNumber == 1)
                {
                    player.transform.position = portal0.transform.position;
                    active = true;
                }
            }
            if (id == 1)
            {
                if (portalNumber == 0)
                {
                    player2.transform.position = portal1.transform.position;
                    active = true;
                }
                if (portalNumber == 1)
                {
                    player2.transform.position = portal0.transform.position;
                    active = true;
                }
            }
        }
    }
    */
}
