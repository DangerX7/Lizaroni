using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike_stand_col_script : MonoBehaviour
{
    public void OnDestroy()
    {
        Destroy(this.transform.parent.gameObject);
    }
}
