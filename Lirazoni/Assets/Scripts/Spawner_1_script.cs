using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_1_script : MonoBehaviour
{
    public int powerUpTyPE;
    public int possition;
    public GameObject Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8;
    public bool poss1Check = false;
    public bool poss2Check = false;
    public bool poss3Check = false;
    public bool poss4Check = false;
    public bool poss5Check = false;
    public bool poss6Check = false;
    public bool poss7Check = false;
    public bool poss8Check = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(powerUpTyPE + "muie");
     //   powerUpTyPE = Random.Range(1, 5);
        possition = Random.Range(1, 8);
        GameObject Master = GameObject.Find("MasterObject");
        master_script switchReference = Master.GetComponent<master_script>();
        if (switchReference.specialMoves == 5)
        {
            powerUpTyPE += 1;

            if (powerUpTyPE == 1)
            {
                if (possition == 1)
                {
                    if (poss1Check == false)
                    {
                        GameObject powerUp1 = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
                        powerUp1.transform.position = Pos1.transform.position;
                        poss1Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 2)
                {
                    if (poss2Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
                        powerUp.transform.position = Pos2.transform.position;
                        poss2Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 3)
                {
                    if (poss3Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
                        powerUp.transform.position = Pos3.transform.position;
                        poss3Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 4)
                {
                    if (poss4Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
                        powerUp.transform.position = Pos4.transform.position;
                        poss4Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 5)
                {
                    if (poss5Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
                        powerUp.transform.position = Pos5.transform.position;
                        poss5Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 6)
                {
                    if (poss6Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
                        powerUp.transform.position = Pos6.transform.position;
                        poss6Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 7)
                {
                    if (poss7Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
                        powerUp.transform.position = Pos7.transform.position;
                        poss7Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 8)
                {
                    if (poss8Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Armour-powerUp")) as GameObject;
                        powerUp.transform.position = Pos8.transform.position;
                        poss8Check = true;
                    }
                    else
                    {

                    }
                }
            }
            if (powerUpTyPE == 2)
            {
                if (possition == 1)
                {
                    if (poss1Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
                        powerUp.transform.position = Pos1.transform.position;
                        poss1Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 2)
                {
                    if (poss2Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
                        powerUp.transform.position = Pos2.transform.position;
                        poss2Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 3)
                {
                    if (poss3Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
                        powerUp.transform.position = Pos3.transform.position;
                        poss3Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 4)
                {
                    if (poss4Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
                        powerUp.transform.position = Pos4.transform.position;
                        poss4Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 5)
                {
                    if (poss5Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
                        powerUp.transform.position = Pos5.transform.position;
                        poss5Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 6)
                {
                    if (poss6Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
                        powerUp.transform.position = Pos6.transform.position;
                        poss6Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 7)
                {
                    if (poss7Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
                        powerUp.transform.position = Pos7.transform.position;
                        poss7Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 8)
                {
                    if (poss8Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("DoubleJump-powerUp")) as GameObject;
                        powerUp.transform.position = Pos8.transform.position;
                        poss8Check = true;
                    }
                    else
                    {

                    }
                }
            }/*
            if (powerUpTyPE == 5)
            {
                if (possition == 1)
                {
                    if (poss1Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Invincibility-powerUp")) as GameObject;
                        powerUp.transform.position = Pos1.transform.position;
                        poss1Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 2)
                {
                    if (poss2Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Invincibility-powerUp")) as GameObject;
                        powerUp.transform.position = Pos2.transform.position;
                        poss2Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 3)
                {
                    if (poss3Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Invincibility-powerUp")) as GameObject;
                        powerUp.transform.position = Pos3.transform.position;
                        poss3Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 4)
                {
                    if (poss4Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Invincibility-powerUp")) as GameObject;
                        powerUp.transform.position = Pos4.transform.position;
                        poss4Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 5)
                {
                    if (poss5Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Invincibility-powerUp")) as GameObject;
                        powerUp.transform.position = Pos5.transform.position;
                        poss5Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 6)
                {
                    if (poss6Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Invincibility-powerUp")) as GameObject;
                        powerUp.transform.position = Pos6.transform.position;
                        poss6Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 7)
                {
                    if (poss7Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Invincibility-powerUp")) as GameObject;
                        powerUp.transform.position = Pos7.transform.position;
                        poss7Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 8)
                {
                    if (poss8Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Invincibility-powerUp")) as GameObject;
                        powerUp.transform.position = Pos8.transform.position;
                        poss8Check = true;
                    }
                    else
                    {

                    }
                }
            }
            if (powerUpTyPE == 4)
            {
                if (possition == 1)
                {
                    if (poss1Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("TimeTravel-powerUp")) as GameObject;
                        powerUp.transform.position = Pos1.transform.position;
                        poss1Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 2)
                {
                    if (poss2Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("TimeTravel-powerUp")) as GameObject;
                        powerUp.transform.position = Pos2.transform.position;
                        poss2Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 3)
                {
                    if (poss3Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("TimeTravel-powerUp")) as GameObject;
                        powerUp.transform.position = Pos3.transform.position;
                        poss3Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 4)
                {
                    if (poss4Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("TimeTravel-powerUp")) as GameObject;
                        powerUp.transform.position = Pos4.transform.position;
                        poss4Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 5)
                {
                    if (poss5Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("TimeTravel-powerUp")) as GameObject;
                        powerUp.transform.position = Pos5.transform.position;
                        poss5Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 6)
                {
                    if (poss6Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("TimeTravel-powerUp")) as GameObject;
                        powerUp.transform.position = Pos6.transform.position;
                        poss6Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 7)
                {
                    if (poss7Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("TimeTravel-powerUp")) as GameObject;
                        powerUp.transform.position = Pos7.transform.position;
                        poss7Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 8)
                {
                    if (poss8Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("TimeTravel-powerUp")) as GameObject;
                        powerUp.transform.position = Pos8.transform.position;
                        poss8Check = true;
                    }
                    else
                    {

                    }
                }
            }*/
            if (powerUpTyPE == 3)
            {
                if (possition == 1)
                {
                    if (poss1Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                        powerUp.transform.position = Pos1.transform.position;
                        poss1Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 2)
                {
                    if (poss2Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                        powerUp.transform.position = Pos2.transform.position;
                        poss2Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 3)
                {
                    if (poss3Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                        powerUp.transform.position = Pos3.transform.position;
                        poss3Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 4)
                {
                    if (poss4Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                        powerUp.transform.position = Pos4.transform.position;
                        poss4Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 5)
                {
                    if (poss5Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                        powerUp.transform.position = Pos5.transform.position;
                        poss5Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 6)
                {
                    if (poss6Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                        powerUp.transform.position = Pos6.transform.position;
                        poss6Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 7)
                {
                    if (poss7Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                        powerUp.transform.position = Pos7.transform.position;
                        poss7Check = true;
                    }
                    else
                    {

                    }
                }
                if (possition == 8)
                {
                    if (poss8Check == false)
                    {
                        GameObject powerUp = Instantiate(Resources.Load("Weapon-powerUp")) as GameObject;
                        powerUp.transform.position = Pos8.transform.position;
                        poss8Check = true;
                    }
                    else
                    {

                    }
                }
            }
            switchReference.specialMoves = 0;
            if (powerUpTyPE >= 3)
            {
                powerUpTyPE = 0;
            }
        }
        
    }
}
