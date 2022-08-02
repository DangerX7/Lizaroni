using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class moves_text_script_versus : MonoBehaviour
{
    Text text;
    public int coinAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject P1 = GameObject.Find("Player");
        player_script endRef1 = P1.GetComponent<player_script>();
        GameObject P2 = GameObject.Find("Player2");
        player_script endRef2 = P2.GetComponent<player_script>();
        if ((endRef1.endCheck == false) || (endRef2.endCheck == false))
        {
            coinAmount += 1;
        }
        if ((endRef1.countReset == true) && (endRef2.countReset == true))
        {
            Debug.Log("Morti mati!");
            coinAmount = 0;
        }
        text.text = coinAmount.ToString();
    }
}
