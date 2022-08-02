using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_detect_script : MonoBehaviour
{
    public int dir;
    public bool leftDetect = false;
    public bool rightDetect = false;
    public bool upDetect = false;
    public bool downDetect = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col1)
    {
        if (col1.gameObject.tag.Equals("wall"))
        {
            if (dir == 0)
            {
                leftDetect = true;
            }
            if (dir == 1)
            {
                rightDetect = true;
            }
            if (dir == 2)
            {
                upDetect = true;
            }
            if (dir == 3)
            {
                downDetect = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col2)
    {
        if (col2.gameObject.tag.Equals("wall"))
        {
            if (dir == 0)
            {
                leftDetect = false;
            }
            if (dir == 1)
            {
                rightDetect = false;
            }
            if (dir == 2)
            {
                upDetect = false;
            }
            if (dir == 3)
            {
                downDetect = false;
            }
        }
    }
}
