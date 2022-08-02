using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_manager_script : MonoBehaviour
{

    public static AudioClip spikeSound, keySound, doorSound, perfectSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        spikeSound = Resources.Load<AudioClip>("death");
        keySound = Resources.Load<AudioClip>("KeyGet");
        doorSound = Resources.Load<AudioClip>("LevelClear");
        perfectSound = Resources.Load<AudioClip>("PerfectWin");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "SpikeHit":
                audioSrc.PlayOneShot(spikeSound);
                break;
            case "KeyGet":
                audioSrc.PlayOneShot(keySound);
                break;
            case "EnterDoor":
                audioSrc.PlayOneShot(doorSound);
                break;
            case "PerfectWin":
                audioSrc.PlayOneShot(perfectSound);
                break;
        }
    }
}

