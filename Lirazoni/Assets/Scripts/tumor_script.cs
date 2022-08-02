using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tumor_script : MonoBehaviour
{
    public bool versusTumor;
    private Vector3 scaleChange;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        if(versusTumor == false)
        {
            scaleChange = new Vector3(-0.0125f, -0.0125f, -0.0125f);
        }
        if (versusTumor == true)
        {
            scaleChange = new Vector3(-0.032f, -0.032f, -0.032f);
        }

        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;
    }


    private void OnEnemiesAdvance(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                GameObject Master = GameObject.Find("MasterObject");
                master_script switchReference = Master.GetComponent<master_script>();
                if (switchReference.movesChange == true)
                {
                    transform.localScale -= scaleChange;
                    // scaleChange = -scaleChange;
                }
            }
        }
    }
    private void OnEnemiesAdvanceReverse(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                GameObject Master = GameObject.Find("MasterObject");
                master_script switchReference = Master.GetComponent<master_script>();
                if (switchReference.movesChange == true)
                {
                    transform.localScale -= scaleChange;
                    // scaleChange = -scaleChange;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnDestroy()
    {
        master_script.current.onEnemiesMove -= OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse -= OnEnemiesAdvanceReverse;
    }
}
