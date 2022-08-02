using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_script : MonoBehaviour
{
    Text StatsText;
    public int textType; // 1 = moves, 2 = time_minutes, 3 = time_seconds, 4 = current_keys, 5 = required_keys, 6 = minimum moves

    int movesCount;
    int seconds;
    float timer = 0.0f;
    int minutes;//NEW*
    bool change;
    int current;
    int required;
    // Start is called before the first frame update
    void Start()
    {
        StatsText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Master = GameObject.Find("MasterObject");
        master_script multiReference = Master.GetComponent<master_script>();
        movesCount = multiReference.moves;
        current = multiReference.keys;
        required = multiReference.lockKeys;

        GameObject PauseMenu = GameObject.Find("Pause Object");
        pause_script timerReference = PauseMenu.GetComponent<pause_script>();

        if (multiReference.levelType == 2)
        {
            GameObject Player = GameObject.Find("Player");
            player_script endCheck = Player.GetComponent<player_script>();
            GameObject Player2 = GameObject.Find("Player2");
            player_script endCheck2 = Player2.GetComponent<player_script>();

            if ((((endCheck.endCheck == false) && (endCheck2.endCheck == false)) || ((endCheck.endCheck == true) && (endCheck2.endCheck == false)) || ((endCheck.endCheck == false) && (endCheck2.endCheck == true))) && (timerReference.timerLock == false))
            {
                timer += Time.deltaTime;
            }

            seconds = (int)timer; //Convert float to int
        }
        else
        {
            if (GameObject.Find("Player") != null)
            {
                GameObject Player = GameObject.Find("Player");
                player_script endCheck = Player.GetComponent<player_script>();


                if (endCheck.endCheck == false)
                {
                    timer += Time.deltaTime;
                }
                seconds = (int)timer; //Convert float to int
            }
        }


        if ((seconds == 60) && (change == false))
        {
            minutes += 1;
            timer = 0.0f;
            change = true;
        }
        if (seconds == 1)
        {
            change = false;
        }


        if (textType == 1)
        {
            StatsText.text = movesCount.ToString();
        }
        if (textType == 2)
        {
            StatsText.text = minutes.ToString();
        }
        if (textType == 3)
        {
            StatsText.text = seconds.ToString();
        }
        if (textType == 4)
        {
            StatsText.text = current.ToString();
        }
        if (textType == 5)
        {
            StatsText.text = required.ToString();
        }
        if (textType == 6)
        {
            StatsText.text = (multiReference.minMoves).ToString();
        }
    }
}
