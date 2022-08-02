using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_cursor_limiter : MonoBehaviour
{
    public byte dirrection; // 1-left,2-right,3-up,4-down

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("MapWall"))
        {
            if (dirrection == 1)
            {
                if (GameObject.Find("stage_cursorX") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursorX");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.LeftLimit = true;
                }
                if (GameObject.Find("stage_cursor") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursor");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.LeftLimit = true;
                }
            }
            if (dirrection == 2)
            {
                if (GameObject.Find("stage_cursorX") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursorX");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.RightLimit = true;
                }
                if (GameObject.Find("stage_cursor") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursor");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.RightLimit = true;
                }
            }
            if (dirrection == 3)
            {
                if (GameObject.Find("stage_cursorX") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursorX");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.UpLimit = true;
                }
                if (GameObject.Find("stage_cursor") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursor");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.UpLimit = true;
                }
            }
            if (dirrection == 4)
            {
                if (GameObject.Find("stage_cursorX") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursorX");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.DownLimit = true;
                }
                if (GameObject.Find("stage_cursor") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursor");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.DownLimit = true;
                }
            }
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("MapWall"))
        {
            if (dirrection == 1)
            {
                if (GameObject.Find("stage_cursorX") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursorX");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.LeftLimit = false;
                }
                if (GameObject.Find("stage_cursor") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursor");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.LeftLimit = false;
                }
            }
            if (dirrection == 2)
            {
                if (GameObject.Find("stage_cursorX") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursorX");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.RightLimit = false;
                }
                if (GameObject.Find("stage_cursor") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursor");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.RightLimit = false;
                }
            }
            if (dirrection == 3)
            {
                if (GameObject.Find("stage_cursorX") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursorX");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.UpLimit = false;
                }
                if (GameObject.Find("stage_cursor") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursor");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.UpLimit = false;
                }
            }
            if (dirrection == 4)
            {
                if (GameObject.Find("stage_cursorX") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursorX");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.DownLimit = false;
                }
                if (GameObject.Find("stage_cursor") != null)
                {
                    GameObject MapCursor = GameObject.Find("stage_cursor");
                    map_script edgesReference = MapCursor.GetComponent<map_script>();
                    edgesReference.DownLimit = false;
                }
            }
        }
    }

}
