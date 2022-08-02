using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b1_fire_script : MonoBehaviour
{
    public byte dirrection; // 1-left, 2-right, 3-up, 4-down
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator CoroutineAdvance()
    {
        GameObject Boss1 = GameObject.Find("Boss 1");
        boss1_script bossReference = Boss1.GetComponent<boss1_script>();
        bossReference.exitPLayer = true;
        transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        transform.GetChild(3).gameObject.SetActive(false);
        bossReference.exitPLayer = false;
        (this.gameObject).SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CoroutineAdvance());
    }
}
