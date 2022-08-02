using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_pointer_script : MonoBehaviour
{
    public GameObject cursor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        (this.gameObject).transform.position = cursor.transform.position;
    }
}
