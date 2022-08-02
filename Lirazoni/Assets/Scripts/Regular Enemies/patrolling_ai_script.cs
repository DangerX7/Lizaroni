using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolling_ai_script : MonoBehaviour
{
    public int id;
    public float moveNumber;
    public bool goingRight;
    /* Position notes
    GOING LEFT
    move number = 0 -- Center-Up
    move number = 1 -- Left-Up
    move number = 2 -- Left-Center
    move number = 3 -- Left-Down
    move number = 4 -- Center-Down
    move number = 5 -- Right-Down
    move number = 6 -- Right-Center
    move number = 7 -- Right-Up
    GOING RIGHT
    move number = 0 -- Center-Up
    move number = 1 -- Right-Up
    move number = 2 -- Right-Center
    move number = 3 -- Right-Down
    move number = 4 -- Center-Down
    move number = 5 -- Left-Down
    move number = 6 -- Left-Center
    move number = 7 -- Left-Up
    */
    public SpriteRenderer spriteRenderer;
 //   public Sprite leftX, rightX, upX, downX;
    public bool invincibile;
    Vector3 originalPos;
    portal_master_object_script p;
    public bool dirCheck;
    public float moveCheck;
    public bool versus2P_enemy;

    public Animator animator;
    public int animations;
    public short animationAction;
    public float counter;
    public bool hitbox;
    public short hitboxCounter;

    // Start is called before the first frame update
    void Start()
    {
        dirCheck = goingRight;
        moveCheck = moveNumber;
        if (GameObject.Find("Portal Master Object") != null)
        {
            p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
        }
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        if (invincibile == true)
        {
            gameObject.tag = "ArmourEnemy";
            spriteRenderer.color = new Color(0.32f, 0.32f, 0.32f, 1f);
        }
        if (goingRight == false)
        {
            if (moveNumber == 0)
            {
                animations = 17;
                //   spriteRenderer.sprite = leftX;
            }
            if (moveNumber == 1)
            {
                animations = 16;
                //   spriteRenderer.sprite = downX;
            }
            if (moveNumber == 2)
            {
                animations = 16;
                //   spriteRenderer.sprite = downX;
            }
            if (moveNumber == 3)
            {
                animations = 18;
                //   spriteRenderer.sprite = rightX;
            }
            if (moveNumber == 4)
            {
                animations = 18;
                Debug.Log("MDSFEDG");
                //    spriteRenderer.sprite = rightX;
            }
            if (moveNumber == 5)
            {
                animations = 15;
                //   spriteRenderer.sprite = upX;
            }
            if (moveNumber == 6)
            {
                animations = 15;
                //    spriteRenderer.sprite = upX;
            }
            if (moveNumber == 7)
            {
                animations = 17;
                //   spriteRenderer.sprite = leftX;
            }
        }
        else if (goingRight == true)
        {
            if (moveNumber == 0)
            {
                animations = 18;
                //   spriteRenderer.sprite = rightX;
            }
            if (moveNumber == 1)
            {
                animations = 16;
                //   spriteRenderer.sprite = downX;
            }
            if (moveNumber == 2)
            {
                animations = 16;
                //   spriteRenderer.sprite = downX;
            }
            if (moveNumber == 3)
            {
                animations = 17;
                //   spriteRenderer.sprite = leftX;
            }
            if (moveNumber == 4)
            {
                animations = 17;
                //   spriteRenderer.sprite = leftX;
            }
            if (moveNumber == 5)
            {
                animations = 15;
                //   spriteRenderer.sprite = upX;
            }
            if (moveNumber == 6)
            {
                animations = 15;
                //   spriteRenderer.sprite = upX;
            }
            if (moveNumber == 7)
            {
                animations = 18;
                //   spriteRenderer.sprite = rightX;
            }
        }

        master_script.current.onEnemiesMoveHalf += EnemyMoveHalf;
        master_script.current.onEnemiesMoveReverseHalf += EnemyMoveReverseHalf;
        master_script.current.onHitboxActivate += HitboxActivate;
    }

    public void HitboxActivate(int id)
    {
        hitbox = false;
    }

    public void EnemyMoveHalf(int id)
    {
        counter += 1;
        Vector3 up = new Vector3(0, 0.08f, 0);
        Vector3 down = new Vector3(0, -0.08f, 0);
        Vector3 left = new Vector3(-0.08f, 0, 0);
        Vector3 right = new Vector3(0.08f, 0, 0);
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                hitboxCounter += 1;
                if (hitboxCounter == 2)
                {
                    hitbox = true;
                    hitboxCounter = 0;
                }
                moveNumber += 0.125f;
                if (goingRight == false)
                {
                    if ((moveNumber > 0) && (moveNumber <= 1))
                    {
                        animations = 13;
                        transform.position += left;
                        //    spriteRenderer.sprite = leftX;
                    }
                    if (moveNumber == 1)
                    {
                        animations = 7;
                    }
                    if ((moveNumber > 1) && (moveNumber <= 2))
                    {
                        animations = 12;
                        transform.position += down;
                        //  StartCoroutine(Action());
                        //    spriteRenderer.sprite = downX;
                    }
                    if (moveNumber == 2)
                    {
                        animations = 16;
                    }
                    if ((moveNumber > 2) && (moveNumber <= 3))
                    {
                        animations = 12;
                        //   spriteRenderer.sprite = downX;
                        transform.position += down;
                    }
                    if (moveNumber == 3)
                    {
                        animations = 6;
                    }
                    if ((moveNumber > 3) && (moveNumber <= 4))
                    {
                        animations = 14;
                        //   spriteRenderer.sprite = rightX;
                        transform.position += right;
                    }
                    if (moveNumber == 4)
                    {
                        animations = 18;
                    }
                    if ((moveNumber > 4) && (moveNumber <= 5))
                    {
                        animations = 14;
                        //   spriteRenderer.sprite = rightX;
                        transform.position += right;
                    }
                    if (moveNumber == 5)
                    {
                        animations = 4;
                    }
                    if ((moveNumber > 5) && (moveNumber <= 6))
                    {
                        animations = 11;
                        //   spriteRenderer.sprite = upX;
                        transform.position += up;
                    }
                    if (moveNumber == 6)
                    {
                        animations = 15;
                    }
                    if ((moveNumber > 6) && (moveNumber <= 7))
                    {
                        animations = 11;
                        //   spriteRenderer.sprite = upX;
                        transform.position += up;
                    }
                    if (moveNumber == 7)
                    {
                        animations = 1;
                    }
                    if ((moveNumber > 7) && (moveNumber <= 8))
                    {
                        animations = 13;
                        //    spriteRenderer.sprite = leftX;
                        transform.position += left;
                    }
                    if (moveNumber == 8)
                    {
                        animations = 17;
                    }
                }
                else if (goingRight == true)
                {
                    if ((moveNumber > 0) && (moveNumber <= 1))
                    {
                        animations = 14;
                        //    spriteRenderer.sprite = rightX;
                        transform.position += right;
                    }
                    if (moveNumber == 1)
                    {
                        animations = 8;
                    }
                    if ((moveNumber > 1) && (moveNumber <= 2))
                    {
                        animations = 12;
                        //   spriteRenderer.sprite = downX;
                        transform.position += down;
                    }
                    if (moveNumber == 2)
                    {
                        animations = 16;
                    }
                    if ((moveNumber > 2) && (moveNumber <= 3))
                    {
                        animations = 12;
                        //    spriteRenderer.sprite = downX;
                        transform.position += down;
                    }
                    if (moveNumber == 3)
                    {
                        animations = 2;
                    }
                    if ((moveNumber > 3) && (moveNumber <= 4))
                    {
                        animations = 13;
                        //    spriteRenderer.sprite = leftX;
                        transform.position += left;
                    }
                    if (moveNumber == 4)
                    {
                        animations = 17;
                    }
                    if ((moveNumber > 4) && (moveNumber <= 5))
                    {
                        animations = 13;
                        //   spriteRenderer.sprite = leftX;
                        transform.position += left;
                    }
                    if (moveNumber == 5)
                    {
                        animations = 3;
                    }
                    if ((moveNumber > 5) && (moveNumber <= 6))
                    {
                        animations = 11;
                        //    spriteRenderer.sprite = upX;
                        transform.position += up;
                    }
                    if (moveNumber == 6)
                    {
                        animations = 15;
                    }
                    if ((moveNumber > 6) && (moveNumber <= 7))
                    {
                        animations = 11;
                        //   spriteRenderer.sprite = upX;
                        transform.position += up;
                    }
                    if (moveNumber == 7)
                    {
                        animations = 5;
                    }
                    if ((moveNumber > 7) && (moveNumber <= 8))
                    {
                        animations = 14;
                        //   spriteRenderer.sprite = rightX;
                        transform.position += right;
                    }
                    if (moveNumber == 8)
                    {
                        animations = 18;
                    }
                }



                if (moveNumber == 8)
                {
                    moveNumber = 0;
                }
            }
        }

        if (counter == 16)
        {
            counter = 0;
        }
    }

    public void EnemyMoveReverseHalf(int id)
    {
        counter -= 1;
        Vector3 up = new Vector3(0, 0.08f, 0);
        Vector3 down = new Vector3(0, -0.08f, 0);
        Vector3 left = new Vector3(-0.08f, 0, 0);
        Vector3 right = new Vector3(0.08f, 0, 0);
        if ((id == this.id) && (counter > -9))
        {
            if (gameObject.activeSelf)
            {
                moveNumber -= 0.125f;
                if (goingRight == false)
                {
                    if ((moveNumber < 0) && (moveNumber >= -1))
                    {
                        animations = 14;
                        //   spriteRenderer.sprite = rightX;
                        transform.position += right;
                    }
                    if (moveNumber == -1)
                    {
                        animations = 8;
                    }
                    if ((moveNumber < 7) && (moveNumber >= 6))
                    {
                        animations = 12;
                        //   spriteRenderer.sprite = downX;
                        transform.position += down;
                    }
                    if (moveNumber == 6)
                    {
                        animations = 16;
                    }
                    if ((moveNumber < 6) && (moveNumber >= 5))
                    {
                        animations = 12;
                        //   spriteRenderer.sprite = downX;
                        transform.position += down;
                    }
                    if (moveNumber == 5)
                    {
                        animations = 2;
                    }
                    if ((moveNumber < 5) && (moveNumber >= 4))
                    {
                        animations = 13;
                        //   spriteRenderer.sprite = leftX;
                        transform.position += left;
                    }
                    if (moveNumber == 4)
                    {
                        animations = 14;
                    }
                    if ((moveNumber < 4) && (moveNumber >= 3))
                    {
                        animations = 13;
                        //   spriteRenderer.sprite = leftX;
                        transform.position += left;
                    }
                    if (moveNumber == 3)
                    {
                        animations = 3;
                    }
                    if ((moveNumber < 3) && (moveNumber >= 2))
                    {
                        animations = 11;
                        //   spriteRenderer.sprite = upX;
                        transform.position += up;
                    }
                    if (moveNumber == 2)
                    {
                        animations = 15;
                    }
                    if ((moveNumber < 2) && (moveNumber >= 1))
                    {
                        animations = 11;
                        //    spriteRenderer.sprite = upX;
                        transform.position += up;
                    }
                    if (moveNumber == 1)
                    {
                        animations = 5;
                    }
                    if ((moveNumber < 1) && (moveNumber >= 0))
                    {
                        animations = 14;
                        //   spriteRenderer.sprite = rightX;
                        transform.position += right;
                    }
                    if (moveNumber == 0)
                    {
                        animations = 18;
                    }
                }
                else if (goingRight == true)
                {
                    if ((moveNumber < 0) && (moveNumber >= -1))
                    {
                        animations = 13;
                        //   spriteRenderer.sprite = leftX;
                        transform.position += left;
                    }
                    if (moveNumber == -1)
                    {
                        animations = 7;
                    }
                    if ((moveNumber < 7) && (moveNumber >= 6))
                    {
                        animations = 12;
                        //  spriteRenderer.sprite = downX;
                        transform.position += down;
                    }
                    if (moveNumber == 6)
                    {
                        animations = 16;
                    }
                    if ((moveNumber < 6) && (moveNumber >= 5))
                    {
                        animations = 12;
                        //   spriteRenderer.sprite = downX;
                        transform.position += down;
                    }
                    if (moveNumber == 5)
                    {
                        animations = 6;
                    }
                    if ((moveNumber < 5) && (moveNumber >= 4))
                    {
                        animations = 14;
                        //   spriteRenderer.sprite = rightX;
                        transform.position += right;
                    }
                    if (moveNumber == 4)
                    {
                        animations = 18;
                    }
                    if ((moveNumber < 4) && (moveNumber >= 3))
                    {
                        animations = 24;
                        //   spriteRenderer.sprite = rightX;
                        transform.position += right;
                    }
                    if (moveNumber == 3)
                    {
                        animations = 4;
                    }
                    if ((moveNumber < 3) && (moveNumber >= 2))
                    {
                        animations = 11;
                        //   spriteRenderer.sprite = upX;
                        transform.position += up;
                    }
                    if (moveNumber == 2)
                    {
                        animations = 15;
                    }
                    if ((moveNumber < 2) && (moveNumber >= 1))
                    {
                        animations = 11;
                        //   spriteRenderer.sprite = upX;
                        transform.position += up;
                    }
                    if (moveNumber == 1)
                    {
                        animations = 1;
                    }
                    if ((moveNumber < 1) && (moveNumber >= 0))
                    {
                        animations = 13;
                        //   spriteRenderer.sprite = leftX;
                        transform.position += left;
                    }
                    if (moveNumber == 0)
                    {
                        animations = 14;
                    }
                }



                if (moveNumber == -1)
                {
                    moveNumber = 7;
                }
            }
        }

        if (counter == -16)
        {
            counter = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("animation", animations);

        #region Extra Hitbox
        if (hitbox == true)
        {
            //    Debug.Log("Active");
            gameObject.tag = "RegularEnemy";
        }
        else if (hitbox == false)
        {
            //   Debug.Log("Not");
            gameObject.tag = "Untagged";
        }

        GameObject UpDirCheck = transform.GetChild(1).gameObject;
        extra_collision_script hitboxReferenceUp = UpDirCheck.GetComponent<extra_collision_script>();
        GameObject DownDirCheck = transform.GetChild(2).gameObject;
        extra_collision_script hitboxReferenceDown = DownDirCheck.GetComponent<extra_collision_script>();
        GameObject LeftDirCheck = transform.GetChild(3).gameObject;
        extra_collision_script hitboxReferenceLeft = LeftDirCheck.GetComponent<extra_collision_script>();
        GameObject RightDirCheck = transform.GetChild(4).gameObject;
        extra_collision_script hitboxReferenceRight = RightDirCheck.GetComponent<extra_collision_script>();

        if (goingRight == false)
        {
            if (((hitboxReferenceUp.playerInUpSight == true) && ((moveNumber >= 5) && (moveNumber < 6.875f)))
                || ((hitboxReferenceDown.playerInDownSight == true) && ((moveNumber >= 1) && (moveNumber < 2.875f)))
                || ((hitboxReferenceLeft.playerInLeftSight == true) && ((moveNumber >= 7) && (moveNumber < 7.875f)) || ((moveNumber >= 0) && (moveNumber < 0.875f)))
                || ((hitboxReferenceRight.playerInRightSight == true) && ((moveNumber >= 3) && (moveNumber < 4.875f))))
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }

            if (((hitboxReferenceUp.playerInUpSight == false) && (hitboxReferenceDown.playerInDownSight == false)
             && (hitboxReferenceLeft.playerInLeftSight == false) && (hitboxReferenceRight.playerInRightSight == false))
             || ((hitboxReferenceUp.playerInUpSight == true) && (moveNumber == 6.875f))
             || ((hitboxReferenceDown.playerInDownSight == true) && (moveNumber == 2.875f))
             || ((hitboxReferenceLeft.playerInLeftSight == true) && ((moveNumber == 7.875f) || (moveNumber == 0.875f)))
             || ((hitboxReferenceRight.playerInRightSight == true) && (moveNumber == 4.875f)))
            {
                transform.GetChild(0).gameObject.SetActive(false);
            }
        }
        if (goingRight == true)
        {
            if (((hitboxReferenceUp.playerInUpSight == true) && ((moveNumber >= 5) && (moveNumber < 6.875f)))
                || ((hitboxReferenceDown.playerInDownSight == true) && ((moveNumber >= 1) && (moveNumber < 2.875f)))
                || ((hitboxReferenceRight.playerInRightSight == true) && ((moveNumber >= 7) && (moveNumber < 7.875f)) || ((moveNumber >= 0) && (moveNumber < 0.875f)))
                || ((hitboxReferenceLeft.playerInLeftSight == true) && ((moveNumber >= 3) && (moveNumber < 4.875f))))
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }

            if (((hitboxReferenceUp.playerInUpSight == false) && (hitboxReferenceDown.playerInDownSight == false)
             && (hitboxReferenceLeft.playerInLeftSight == false) && (hitboxReferenceRight.playerInRightSight == false))
             || ((hitboxReferenceUp.playerInUpSight == true) && (moveNumber == 6.875f))
             || ((hitboxReferenceDown.playerInDownSight == true) && (moveNumber == 2.875f))
             || ((hitboxReferenceRight.playerInRightSight == true) && ((moveNumber == 7.875f) || (moveNumber == 0.875f)))
             || ((hitboxReferenceLeft.playerInLeftSight == true) && (moveNumber == 4.875f)))
            {
                transform.GetChild(0).gameObject.SetActive(false);
            }
        }
        #endregion



        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                if (dirCheck == false)
                {
                    goingRight = false;
                }
                if (dirCheck == true)
                {
                    goingRight = true;
                }
                if (moveCheck == 0)
                {
                    moveNumber = 0;
                }
                if (moveCheck == 1)
                {
                    moveNumber = 1;
                }
                if (moveCheck == 2)
                {
                    moveNumber = 2;
                }
                if (moveCheck == 3)
                {
                    moveNumber = 3;
                }
                if (moveCheck == 4)
                {
                    moveNumber = 4;
                }
                if (moveCheck == 5)
                {
                    moveNumber = 5;
                }
                if (moveCheck == 6)
                {
                    moveNumber = 6;
                }
                if (moveCheck == 7)
                {
                    moveNumber = 7;
                }
            }
        }
        if (gameObject.activeSelf == false)
        {
            transform.position = originalPos;
        }
    }

    public void OnDestroy()
    {
        master_script.current.onEnemiesMoveHalf -= EnemyMoveHalf;
        master_script.current.onEnemiesMoveReverseHalf -= EnemyMoveReverseHalf;
        master_script.current.onHitboxActivate -= HitboxActivate;
    }
}
