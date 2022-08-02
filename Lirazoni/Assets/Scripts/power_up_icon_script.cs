using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_up_icon_script : MonoBehaviour
{
    public bool iconAttack;
    public bool iconArmour;
    public bool iconInvincibility;
    public bool iconDash;
    public bool iconTimeTravel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iconAttack == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (iconAttack == false)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

        if (iconArmour == true)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (iconArmour == false)
        {
            transform.GetChild(1).gameObject.SetActive(false);
        }

        if (iconInvincibility == true)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else if (iconInvincibility == false)
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }

        if (iconDash == true)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (iconDash == false)
        {
            transform.GetChild(3).gameObject.SetActive(false);
        }

        if (iconTimeTravel == true)
        {
            transform.GetChild(4).gameObject.SetActive(true);
        }
        else if (iconTimeTravel == false)
        {
            transform.GetChild(4).gameObject.SetActive(false);
        }
    }
}
