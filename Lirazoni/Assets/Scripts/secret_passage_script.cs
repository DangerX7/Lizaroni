using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secret_passage_script : MonoBehaviour
{
    public GameObject wall, passage;

    public byte switchType; //1-enter, 2-exit. 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (switchType == 1)
            {
                wall.SetActive(false);
                passage.SetActive(true);
            }
            if (switchType == 2)
            {
                passage.SetActive(false);
                wall.SetActive(true);
            }
        }
    }
}
