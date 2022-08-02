using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_2_target_script : MonoBehaviour
{

    public byte mapDifference;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = new Vector3(0, -1.28f, 0);
        GameObject Enemy2 = transform.parent.gameObject;
        spikes_down_script2 teleportReference = Enemy2.GetComponent<spikes_down_script2>();
        if (teleportReference.targetReset == true)
        {
            Debug.Log("Reset!");
            (this.gameObject).transform.position = Enemy2.transform.position + difference;
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector3 down = new Vector3(0, -0.64f, 0);

        GameObject Enemy2 = transform.parent.gameObject;
        spikes_down_script2 teleportReference = Enemy2.GetComponent<spikes_down_script2>();
        GameObject Master = GameObject.Find("MasterObject");
        master_script levelReference = Master.GetComponent<master_script>();

        if ((col.gameObject.tag.Equals("wall")) || (col.gameObject.tag.Equals("wall3")) || (col.gameObject.tag.Equals("Door2")) || (((col.gameObject.tag.Equals("wallDown")))))
        {
            if (teleportReference.targetReset == true)
            {
                Debug.Log("Normaaaal!");
            }
            if (teleportReference.targetReset == false)
            {
                Debug.Log("Normal!");
                (this.gameObject).transform.position -= down * (levelReference.levelRows + mapDifference);
            }
        }
    }
}
