using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area_text_script : MonoBehaviour
{
    public byte digit;
    public SpriteRenderer spriteRenderer;
    public Sprite z0, z1, z2, z3, z4, z5, z6, z7, z8, z9, zA, zB, zC, zD, zE, zline;

    IEnumerator CoroutineWait()
    {
        yield return new WaitForSeconds(0.001f);

        GameObject Master = GameObject.Find("MasterObject");
        master_script areaReference = Master.GetComponent<master_script>();

        if (areaReference.sceneIndex == 60) // level 1-1
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        //////////////////////////////////////////////////////////////////
        if (areaReference.sceneIndex == 61) // level 1-2
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 62) // level 1-3
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 63) // level 1-4
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 64) // level 1-5a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zA;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 65) // level 1-5b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 66) // level 1-6a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z6;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zA;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 67) // level 1-6b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z6;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 68) // level 1-7
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z7;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 69) // level 1-8
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z8;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 70) // level 1-9
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z9;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 71) // level 1-10
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z0;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 72) // level 1-11
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 73) // level 1-12
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 74) // level 1-B
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 75) // level 2-1
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 76) // level 2-2
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 77) // level 2-3
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 78) // level 2-4a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zA;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 79) // level 2-4b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 80) // level 2-4c
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zC;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 81) // level 2-5
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 82) // level 2-6
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z6;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 83) // level 2-7
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z7;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 84) // level 2-8
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z8;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 85) // level 2-9
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z9;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 86) // level 2-10
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z0;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 87) // level 2-11
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 88) // level 2-12
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 89) // level 2-13
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 90) // level 2-14
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 91) // level 2-15
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 92) // level 2-16
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z6;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 93) // level 2-17a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z7;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zA;
            }
        }
        if (areaReference.sceneIndex == 94) // level 2-17b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z7;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zB;
            }
        }
        if (areaReference.sceneIndex == 95) // level 2-18
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z8;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 96) // level 2-19
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z9;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 97) // level 2-20
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z0;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 98) // level 2-B1
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 99) // level 2-B2
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 100) // level 3-1
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 101) // level 3-2
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 102) // level 3-3
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 103) // level 3-4
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 104) // level 3-5
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 105) // level 3-6
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z6;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 106) // level 3-7
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z7;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 107) // level 3-8
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z8;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 108) // level 3-9a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z9;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zA;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 109) // level 3-9b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z9;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 110) // level 3-10
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z0;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 111) // level 3-11
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 112) // level 3-12
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 113) // level 3-13
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 114) // level 3-14a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zA;
            }
        }
        if (areaReference.sceneIndex == 115) // level 3-14b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zB;
            }
        }
        if (areaReference.sceneIndex == 116) // level 3-14c
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zC;
            }
        }
        if (areaReference.sceneIndex == 117) // level 3-15b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zB;
            }
        }
        if (areaReference.sceneIndex == 118) // level 3-15c
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zC;
            }
        }
        if (areaReference.sceneIndex == 119) // level 3-16b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z6;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zB;
            }
        }
        if (areaReference.sceneIndex == 120) // level 3-17
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z7;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 121) // level 3-18
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z8;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 122) // level 3-19
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z9;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 123) // level 3-20
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z0;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 124) // level 3-21a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zA;
            }
        }
        if (areaReference.sceneIndex == 125) // level 3-21b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zB;
            }
        }
        if (areaReference.sceneIndex == 126) // level 3-21c
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zC;
            }
        }
        if (areaReference.sceneIndex == 127) // level 3-21d
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zD;
            }
        }
        if (areaReference.sceneIndex == 128) // level 3-21e
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                spriteRenderer.sprite = zE;
            }
        }
        if (areaReference.sceneIndex == 129) // level 3-22
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 130) // level 3-B1
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 131) // level 3-B2
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 132) // level 4-1
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 133) // level 4-2
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 134) // level 4-3
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 135) // level 4-4
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 136) // level 4-5a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zA;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 137) // level 4-5b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 138) // level 4-6a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z6;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zA;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 139) // level 4-6b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z6;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 140) // level 4-7a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z7;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zA;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 141) // level 4-7b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z7;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 142) // level 4-8
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z8;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 143) // level 4-9
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z9;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 144) // level 4-10
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z0;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 145) // level 4-11
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 146) // level 4-12
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 147) // level 4-13
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z3;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 148) // level 4-14
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 149) // level 4-B
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z4;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 150) // level 5-1a
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zA;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 151) // level 5-1b
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zB;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 152) // level 5-1c
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zC;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 153) // level 5-1d
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z1;
            }
            if (digit == 4)
            {
                spriteRenderer.sprite = zD;
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
        if (areaReference.sceneIndex == 154) // level 5-2
        {
            if (digit == 1)
            {
                spriteRenderer.sprite = z5;
            }
            if (digit == 2)
            {
                spriteRenderer.sprite = zline;
            }
            if (digit == 3)
            {
                spriteRenderer.sprite = z2;
            }
            if (digit == 4)
            {
                Destroy(this.gameObject);
            }
            if (digit == 5)
            {
                Destroy(this.gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoroutineWait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
