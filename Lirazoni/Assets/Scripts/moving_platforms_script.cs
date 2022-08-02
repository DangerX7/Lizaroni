using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_platforms_script : MonoBehaviour
{
    public byte platformType; // 0 left-right, 1 right-left, 2 down-up, 3 up-down
    public bool moveReturn;
    public int id;
    public bool isReverseTrue;
    public int moves;
    public int movesLimit;
    public SpriteRenderer dirrection;
    public Sprite left, right, up, down;

    // Start is called before the first frame update
    void Start()
    {
        movesLimit = movesLimit * 16;
        dirrection = GetComponent<SpriteRenderer>();
        if (platformType == 0)
        {
            dirrection.sprite = right;
        }
        if (platformType == 1)
        {
            dirrection.sprite = left;
        }
        if (platformType == 2)
        {
            dirrection.sprite = up;
        }
        if (platformType == 3)
        {
            dirrection.sprite = down;
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
                moves += 1;
                isReverseTrue = false;
                if (moves == movesLimit)
                {
                    if ((moveReturn == false) && (moves > 0))
                    {
                        moveReturn = true;
                        moves = 0;
                        if (platformType == 0)
                        {
                            dirrection.sprite = left;
                        }
                        if (platformType == 1)
                        {
                            dirrection.sprite = right;
                        }
                        if (platformType == 2)
                        {
                            dirrection.sprite = down;
                        }
                        if (platformType == 3)
                        {
                            dirrection.sprite = up;
                        }
                    }
                    if ((moveReturn == true) && (moves > 0))
                    {
                        moveReturn = false;
                        moves = 0;
                        if (platformType == 0)
                        {
                            dirrection.sprite = right;
                        }
                        if (platformType == 1)
                        {
                            dirrection.sprite = left;
                        }
                        if (platformType == 2)
                        {
                            dirrection.sprite = up;
                        }
                        if (platformType == 3)
                        {
                            dirrection.sprite = down;
                        }
                    }
                }
                else
                {
                    if (moveReturn == false)
                    {
                        if (platformType == 0)
                        {
                            MoveRight();
                        }
                        if (platformType == 1)
                        {
                            MoveLeft();
                        }
                        if (platformType == 2)
                        {
                            MoveUp();
                        }
                        if (platformType == 3)
                        {
                            MoveDown();
                        }
                    }
                    else
                    {
                        if (platformType == 0)
                        {
                            MoveLeft();
                        }
                        if (platformType == 1)
                        {
                            MoveRight();
                        }
                        if (platformType == 2)
                        {
                            MoveDown();
                        }
                        if (platformType == 3)
                        {
                            MoveUp();
                        }
                    }
                }
            }
        }
    }
    private void OnEnemiesAdvanceReverse(int id)//////////////////////////////////
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                moves -= 1;
                isReverseTrue = true;
                MoveLeft();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveUp()
    {
        Vector3 up = new Vector3(0, 0.04f, 0);
        transform.position += up;
    }
    public void MoveDown()
    {
        Vector3 down = new Vector3(0, -0.04f, 0);
        transform.position += down;
    }
    public void MoveLeft()
    {
        Vector3 left = new Vector3(-0.04f, 0, 0);
        transform.position += left;
    }
    public void MoveRight()
    {
        Vector3 right = new Vector3(0.04f, 0, 0);
        transform.position += right;
    }
}
