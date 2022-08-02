using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_extra_script : MonoBehaviour
{

    public bool isPortalOneTimeUsage;
    public GameObject PortalMaster;

    IEnumerator CoroutineWait()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("I did it!");
        Destroy(PortalMaster.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag.Equals("Player")) && (isPortalOneTimeUsage == true))
        {
            StartCoroutine(CoroutineWait());
        }
    }

}
