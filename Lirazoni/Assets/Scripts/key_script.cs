using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_script : MonoBehaviour
{
    public int keyType;
    public int specialKey;
    /*
    1 - Found in Stage 2-4a - Used for door in Stage 2-10
    2 - Found in Stage 2-4c - Used for door in Stage 2-10
    3 - Found in Stage 1-7  - Used to unlock Bonus level 1
    */
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Key");
            GameObject Master = GameObject.Find("MasterObject");
            master_script keysReference = Master.GetComponent<master_script>();
            sound_manager_script.PlaySound("KeyGet");
            {
                if (keyType == 0)
                {
                    if (specialKey == 0)
                    {
                        keysReference.keys += 1;
                    }
                    if (GameObject.Find("SceneUnlocker") != null)
                    {
                        GameObject SceneManager = GameObject.Find("SceneUnlocker");
                        scene_unlocker_script specialKeysReference = SceneManager.GetComponent<scene_unlocker_script>();
                        GameObject DOOR = GameObject.Find("Door");
                        door_script specialKeysReference2 = DOOR.GetComponent<door_script>();

                        if (specialKey == 1)
                        {
                            specialKeysReference2.s2_10locka = true;
                        }
                        if (specialKey == 2)
                        {
                            specialKeysReference2.s2_10lockb = true;
                        }
                        if (specialKey == 3)
                        {
                            specialKeysReference.Scene1xBActive = true;
                        }
                        if (specialKey == 4)
                        {
                            specialKeysReference.Scene2xB1Active = true;
                        }
                        if (specialKey == 5)
                        {
                            specialKeysReference.Scene2xB2Active = true;
                        }
                        if (specialKey == 6)
                        {
                            specialKeysReference.Scene3xB1Active = true;
                        }
                        if (specialKey == 7)
                        {
                            specialKeysReference.Scene3xB2Active = true;
                        }
                        if (specialKey == 8)
                        {
                            specialKeysReference.Scene4xBActive = true;
                        }
                    }

                }
                else if (keyType == 1)
                {
                    keysReference.keysV += 1;
                }
                Destroy(this.gameObject);
            }
        }
    }
}