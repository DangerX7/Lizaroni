using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_ups_script : MonoBehaviour
{
    public int customPoss;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Power-Up Spawner MS") != null)
        {
            GameObject Spawner = GameObject.Find("Power-Up Spawner MS");
            Spawner_1_script possReference = Spawner.GetComponent<Spawner_1_script>();
            customPoss = possReference.possition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnDestroy()
    {
        if (GameObject.Find("Power-Up Spawner MS") != null)
        {
            GameObject Spawner = GameObject.Find("Power-Up Spawner MS");
            Spawner_1_script possReference = Spawner.GetComponent<Spawner_1_script>();
            if  (customPoss == 1)
            {
                possReference.poss1Check = false;
            }
            if (customPoss == 2)
            {
                possReference.poss2Check = false;
            }
            if (customPoss == 3)
            {
                possReference.poss3Check = false;
            }
            if (customPoss == 4)
            {
                possReference.poss4Check = false;
            }
            if (customPoss == 5)
            {
                possReference.poss5Check = false;
            }
            if (customPoss == 6)
            {
                possReference.poss6Check = false;
            }
            if (customPoss == 7)
            {
                possReference.poss7Check = false;
            }
            if (customPoss == 8)
            {
                possReference.poss8Check = false;
            }
        }
    }
}
