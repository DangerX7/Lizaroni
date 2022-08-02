using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classic_level_indicator_script : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite nothing, Xnew, perfect;
    public byte status; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (status == 0)
        {
            spriteRenderer.sprite = Xnew;
        }
        if (status == 1)
        {
            spriteRenderer.sprite = nothing;
        }
        if (status == 2)
        {
            spriteRenderer.sprite = perfect;
        }
    }
}
