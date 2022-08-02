using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zNOTES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ////OLD CODE
    /*
     if (switchX == true)
        {
            /*
            if (GameObject.FindWithTag("SpikeUp") != null)
            {
                Vector3 up = new Vector3(0, 0.64f, 0);
                GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeUp");
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].transform.position += up;
                }
            }
            if (GameObject.FindWithTag("SpikeDown") != null)
            {
                Vector3 down = new Vector3(0, -0.64f, 0);
                GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeDown");
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].transform.position += down;
                }
            }
            if (GameObject.FindWithTag("SpikeLeft") != null)
            {
                Vector3 left = new Vector3(-0.64f, 0, 0);
                GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeLeft");
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].transform.position += left;
                }
            }
            if (GameObject.FindWithTag("SpikeRight") != null)
            {
                Vector3 right = new Vector3(0.64f, 0, 0);
                GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeRight");
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].transform.position += right;
                }
            }
           


                switchX = false;
        }
        else if ((switchX2 == true) && (switchX2B == true))
        {
            if (GameObject.FindWithTag("SpikeUp") != null)
            {
              //  StartCoroutine(CountdownSpikeUp());
            }
            if (GameObject.FindWithTag("SpikeDown") != null)
            {
              //  StartCoroutine(CountdownSpikeDown());
            }
            if (GameObject.FindWithTag("SpikeLeft") != null)
            {
              //  StartCoroutine(CountdownSpikeLeft());
            }
            if (GameObject.FindWithTag("SpikeRight") != null)
            {
              //  StartCoroutine(CountdownSpikeRight());
            }


            if (GameObject.FindWithTag("SpikeUpX2") != null)
            {
                Vector3 up2 = new Vector3(0, 0.64f, 0);
                GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeUpX2");
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].transform.position += up2;
                }
                StartCoroutine(ExampleCoroutineWaitUp());
            }
            if (GameObject.FindWithTag("SpikeDownX2") != null)
            {
                Vector3 down2 = new Vector3(0, -0.64f, 0);
                GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeDownX2");
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].transform.position += down2;
                }
                StartCoroutine(ExampleCoroutineWaitDown());
            }
            if (GameObject.FindWithTag("SpikeLeftX2") != null)
            {
                Vector3 left2 = new Vector3(-0.64f, 0, 0);
                GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeLeftX2");
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].transform.position += left2;
                }
                StartCoroutine(ExampleCoroutineWaitLeft());
            }
            if (GameObject.FindWithTag("SpikeRightX2") != null)
            {
                Vector3 right2 = new Vector3(0.64f, 0, 0);
                GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeRightX2");
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].transform.position += right2;
                }
                StartCoroutine(ExampleCoroutineWaitRight());
            }



            switchX2B = false;

        }
        else if (switchX3 == true)
        {
            if (randomEnemy1 != null)
            {
                GameObject Random = GameObject.Find("enemyRandom");
                spikes_random_script randomRef = Random.GetComponent<spikes_random_script>();

                Vector3 up3 = new Vector3(0, 0.32f, 0);
                Vector3 down3 = new Vector3(0, -0.32f, 0);
                Vector3 left3 = new Vector3(0.32f, 0, 0);
                Vector3 right3 = new Vector3(-0.32f, 0, 0);

                if (randomRef.dirrection == 0)
                {
                    Debug.Log("1Up");
                    randomEnemy1.transform.position += up3;
                    randomEnemy2.transform.position += down3;
                    randomEnemy3.transform.position += left3;
                    randomEnemy4.transform.position += right3;
                    StartCoroutine(ExampleCoroutine_A());
                }
                if (randomRef.dirrection == 1)
                {
                    Debug.Log("1Down");
                    randomEnemy1.transform.position += down3;
                    randomEnemy2.transform.position += left3;
                    randomEnemy3.transform.position += right3;
                    randomEnemy4.transform.position += up3;
                    StartCoroutine(ExampleCoroutine_B());
                }
                if (randomRef.dirrection == 2)
                {
                    Debug.Log("1Left");
                    randomEnemy1.transform.position += left3;
                    randomEnemy2.transform.position += right3;
                    randomEnemy3.transform.position += up3;
                    randomEnemy4.transform.position += down3;
                    StartCoroutine(ExampleCoroutine_C());
                }
                if (randomRef.dirrection == 3)
                {
                    Debug.Log("1Right");
                    randomEnemy1.transform.position += right3;
                    randomEnemy2.transform.position += up3;
                    randomEnemy3.transform.position += down3;
                    randomEnemy4.transform.position += left3;
                    StartCoroutine(ExampleCoroutine_D());
                }
            }

            switchX3 = false;
        }


     IEnumerator ExampleCoroutine_A()
    {
        GameObject Random = GameObject.Find("enemyRandom");
        spikes_random_script randomRef = Random.GetComponent<spikes_random_script>();

        Vector3 up3 = new Vector3(0, 0.32f, 0);
        Vector3 down3 = new Vector3(0, -0.32f, 0);
        Vector3 left3 = new Vector3(0.32f, 0, 0);
        Vector3 right3 = new Vector3(-0.32f, 0, 0);

        yield return new WaitForSeconds(0.05f);
        randomEnemy1.transform.position += up3;
        randomEnemy2.transform.position += down3;
        randomEnemy3.transform.position += left3;
        randomEnemy4.transform.position += right3;
    }

     IEnumerator ExampleCoroutineWaitUp()
    {
        yield return new WaitForSeconds(0.01f);
        Vector3 up2 = new Vector3(0, 0.64f, 0);
        GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeUpX2");
        for (int i = 0; i < obj.Length; i++)
        {
            obj[i].transform.position += up2;
        }
    }


    public void EnableEndLimits()
    {
        GameObject Master = GameObject.Find("MasterObject");
        master_script sizeReference = Master.GetComponent<master_script>();

        Vector3 upX = new Vector3(0, 0.64f, 0);
        Vector3 downX = new Vector3(0, -0.64f, 0);
        Vector3 leftX = new Vector3(-0.64f, 0, 0);
        Vector3 rightX = new Vector3(0.64f, 0, 0);

        GameObject b = Instantiate(left_end_limit) as GameObject;
        GameObject c = Instantiate(right_end_limit) as GameObject;
        GameObject d = Instantiate(up_end_limit) as GameObject;
        GameObject e = Instantiate(down_end_limit) as GameObject;

        b.transform.position = player.transform.position + leftX * (sizeReference.levelRows - 1);
        c.transform.position = player.transform.position + rightX * (sizeReference.levelRows - 1);
        d.transform.position = player.transform.position + upX * (sizeReference.levelColumns - 1);
        e.transform.position = player.transform.position + downX * (sizeReference.levelColumns - 1);

    }

    else if (updetect == true) // player and spike advances half of a square
            //    {
            //        Debug.Log("Both-Up");
            //        inv = true;
            //        Vector3 temp = new Vector3(0, 0.32f, 0);
            //        player.transform.position += temp;
            //        switchReference.switchX2 = true;
            //    }


    
    public void SpikesMove()
    {
        // REGULAR SPIKES
        if (GameObject.FindWithTag("SpikeUp") != null)
        {
            Vector3 up = new Vector3(0, 0.04f, 0);
            GameObject[] objA = GameObject.FindGameObjectsWithTag("SpikeUp");
            for (int i = 0; i < objA.Length; i++)
            {
                objA[i].transform.position += up;
            }
        }
        if (GameObject.FindWithTag("SpikeDown") != null)
        {
            Vector3 down = new Vector3(0, -0.04f, 0);
            GameObject[] objB = GameObject.FindGameObjectsWithTag("SpikeDown");
            for (int i = 0; i < objB.Length; i++)
            {
                objB[i].transform.position += down;
            }
        }
        if (GameObject.FindWithTag("SpikeLeft") != null)
        {
            Vector3 left = new Vector3(-0.04f, 0, 0);
            GameObject[] objC = GameObject.FindGameObjectsWithTag("SpikeLeft");
            for (int i = 0; i < objC.Length; i++)
            {
                objC[i].transform.position += left;
            }
        }
        if (GameObject.FindWithTag("SpikeRight") != null)
        {
            Vector3 right = new Vector3(0.04f, 0, 0);
            GameObject[] objD = GameObject.FindGameObjectsWithTag("SpikeRight");
            for (int i = 0; i < objD.Length; i++)
            {
                objD[i].transform.position += right;
            }
        }
        // ENEMIES THAT MOVES 2 SQUARES
        if (GameObject.FindWithTag("SpikeUpX2") != null)
        {
            GameObject DoubleSpike = GameObject.Find("spike up X2");
            spikes_up_script2 spriteReference = DoubleSpike.GetComponent<spikes_up_script2>();
            spriteReference.sprite = false;
            Vector3 up = new Vector3(0, 0.08f, 0);
            GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeUpX2");
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i].transform.position += up;
            }
         //   StartCoroutine(CoroutineWaitUpX2());
        }
        if (GameObject.FindWithTag("SpikeDownX2") != null)
        {
            GameObject DoubleSpike = GameObject.Find("spike down X2");
            spikes_down_script2 spriteReference = DoubleSpike.GetComponent<spikes_down_script2>();
            spriteReference.sprite = false;
            Vector3 down = new Vector3(0, -0.08f, 0);
            GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeDownX2");
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i].transform.position += down;
            }
         //   StartCoroutine(CoroutineWaitDownX2());
        }
        if (GameObject.FindWithTag("SpikeLeftX2") != null)
        {
            GameObject DoubleSpike = GameObject.Find("spike left X2");
            spikes_left_script2 spriteReference = DoubleSpike.GetComponent<spikes_left_script2>();
            spriteReference.sprite = false;
            Vector3 left = new Vector3(-0.08f, 0, 0);
            GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeLeftX2");
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i].transform.position += left;
            }
         //   StartCoroutine(CoroutineWaitLeftX2());
        }
        if (GameObject.FindWithTag("SpikeRightX2") != null)
        {
            GameObject DoubleSpike = GameObject.Find("spike right X2");
            spikes_right_script2 spriteReference = DoubleSpike.GetComponent<spikes_right_script2>();
            spriteReference.sprite = false;
            Vector3 right = new Vector3(0.08f, 0, 0);
            GameObject[] obj = GameObject.FindGameObjectsWithTag("SpikeRightX2");
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i].transform.position += right;
            }
         //   StartCoroutine(CoroutineWaitRightX2());
        }
        //ENEMIES THAT MOVES WITH RANDOM PATTERN
        if (GameObject.Find("enemyRandom1") != null)
        {
            GameObject Random1 = GameObject.Find("enemyRandom1");
            spikes_random_script randomRef1 = Random1.GetComponent<spikes_random_script>();
            randomRef1.updateSwitch = false;

            Vector3 up3A = new Vector3(0, 0.04f, 0);
            Vector3 down3A = new Vector3(0, -0.04f, 0);
            Vector3 left3A = new Vector3(0.04f, 0, 0);
            Vector3 right3A = new Vector3(-0.04f, 0, 0);

            if (randomRef1.dirrection == 0)
            {
                Random1.transform.position += up3A;
            }
            if (randomRef1.dirrection == 1)
            {
                Random1.transform.position += down3A;
            }
            if (randomRef1.dirrection == 2)
            {
                Random1.transform.position += left3A;
            }
            if (randomRef1.dirrection == 3)
            {
                Random1.transform.position += right3A;
            }
        }
        if (GameObject.Find("enemyRandom2") != null)
        {
            GameObject Random2 = GameObject.Find("enemyRandom2");
            spikes_random_script randomRef2 = Random2.GetComponent<spikes_random_script>();
            randomRef2.updateSwitch = false;

            Vector3 up3B = new Vector3(0, 0.04f, 0);
            Vector3 down3B = new Vector3(0, -0.04f, 0);
            Vector3 left3B = new Vector3(0.04f, 0, 0);
            Vector3 right3B = new Vector3(-0.04f, 0, 0);

            if (randomRef2.dirrection == 0)
            {
                Random2.transform.position += down3B;
            }
            if (randomRef2.dirrection == 1)
            {
                Random2.transform.position += left3B;
            }
            if (randomRef2.dirrection == 2)
            {
                Random2.transform.position += right3B;
            }
            if (randomRef2.dirrection == 3)
            {
                Random2.transform.position += up3B;
            }
        }
        if (GameObject.Find("enemyRandom3") != null)
        {
            GameObject Random3 = GameObject.Find("enemyRandom3");
            spikes_random_script randomRef3 = Random3.GetComponent<spikes_random_script>();
            randomRef3.updateSwitch = false;

            Vector3 up3C = new Vector3(0, 0.04f, 0);
            Vector3 down3C = new Vector3(0, -0.04f, 0);
            Vector3 left3C = new Vector3(0.04f, 0, 0);
            Vector3 right3C = new Vector3(-0.04f, 0, 0);

            if (randomRef3.dirrection == 0)
            {
                Random3.transform.position += left3C;
            }
            if (randomRef3.dirrection == 1)
            {
                Random3.transform.position += right3C;
            }
            if (randomRef3.dirrection == 2)
            {
                Random3.transform.position += up3C;
            }
            if (randomRef3.dirrection == 3)
            {
                Random3.transform.position += down3C;
            }
        }
        if (GameObject.Find("enemyRandom4") != null)
        {
            GameObject Random4 = GameObject.Find("enemyRandom4");
            spikes_random_script randomRef4 = Random4.GetComponent<spikes_random_script>();
            randomRef4.updateSwitch = false;

            Vector3 up3D = new Vector3(0, 0.04f, 0);
            Vector3 down3D = new Vector3(0, -0.04f, 0);
            Vector3 left3D = new Vector3(0.04f, 0, 0);
            Vector3 right3D = new Vector3(-0.04f, 0, 0);

            if (randomRef4.dirrection == 0)
            {
                Random4.transform.position += right3D;
            }
            if (randomRef4.dirrection == 1)
            {
                Random4.transform.position += up3D;
            }
            if (randomRef4.dirrection == 2)
            {
                Random4.transform.position += down3D;
            }
            if (randomRef4.dirrection == 3)
            {
                Random4.transform.position += left3D;
            }
        }
        //ENEMIES THAT MOVES DIAGONALY
        if (GameObject.FindWithTag("SpikeUpLeft") != null)
        {
            Vector3 upLeft = new Vector3(-0.04f, 0.04f, 0);
            GameObject[] objA = GameObject.FindGameObjectsWithTag("SpikeUpLeft");
            for (int i = 0; i < objA.Length; i++)
            {
                objA[i].transform.position += upLeft;
            }
        }
        if (GameObject.FindWithTag("SpikeUpRight") != null)
        {
            Vector3 upRight = new Vector3(0.04f, 0.04f, 0);
            GameObject[] objA = GameObject.FindGameObjectsWithTag("SpikeUpRight");
            for (int i = 0; i < objA.Length; i++)
            {
                objA[i].transform.position += upRight;
            }
        }
        if (GameObject.FindWithTag("SpikeDownLeft") != null)
        {
            Vector3 downLeft = new Vector3(-0.04f, -0.04f, 0);
            GameObject[] objA = GameObject.FindGameObjectsWithTag("SpikeDownLeft");
            for (int i = 0; i < objA.Length; i++)
            {
                objA[i].transform.position += downLeft;
            }
        }
        if (GameObject.FindWithTag("SpikeDownRight") != null)
        {
            Vector3 downRight = new Vector3(0.04f, -0.04f, 0);
            GameObject[] objA = GameObject.FindGameObjectsWithTag("SpikeDownRight");
            for (int i = 0; i < objA.Length; i++)
            {
                objA[i].transform.position += downRight;
            }
        }
    }

    */
}
