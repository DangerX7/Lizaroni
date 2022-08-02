using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_script1 : MonoBehaviour
{
    public bool death2 = false;

    private void OnTriggerStay2D(Collider2D collider)
    {
        if ((collider.gameObject.tag.Equals("SpikeUp")) || (collider.gameObject.tag.Equals("SpikeDown")) || (collider.gameObject.tag.Equals("SpikeLeft")) || (collider.gameObject.tag.Equals("SpikeRight")) || (collider.gameObject.tag.Equals("SpikeUpX2")) || (collider.gameObject.tag.Equals("SpikeDownX2")) || (collider.gameObject.tag.Equals("SpikeLeftX2")) || (collider.gameObject.tag.Equals("SpikeRightX2")) || (collider.gameObject.tag.Equals("spikeRandom")) || (collider.gameObject.tag.Equals("SpikeUpLeft")) || (collider.gameObject.tag.Equals("SpikeUpRight")) || (collider.gameObject.tag.Equals("SpikeDownLeft")) || (collider.gameObject.tag.Equals("SpikeDownRight")))
        {
            death2 = true;
        }
    }
}
