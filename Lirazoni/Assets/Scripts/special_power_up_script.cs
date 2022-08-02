using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class special_power_up_script : MonoBehaviour
{

    public int type;
    //1-Start 1-7 with attack power-up



    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("SceneUnlocker") != null)
        {
            GameObject Unlocker = GameObject.Find("SceneUnlocker");
            scene_unlocker_script itemReference2 = Unlocker.GetComponent<scene_unlocker_script>();

            if ((type == 1) && (itemReference2.stage_1_7_attack_power_up > 0))
            {
                Destroy(this.gameObject);
            }
            if ((type == 2) && (itemReference2.stage_2_19_dash_power_up > 0))
            {
                Destroy(this.gameObject);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
