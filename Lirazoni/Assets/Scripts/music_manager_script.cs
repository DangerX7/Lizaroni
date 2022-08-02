using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_manager_script : MonoBehaviour
{

    public bool mute = false;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mute == true)
        {
            audioSrc.mute = !audioSrc.mute;
        }
    }
}
