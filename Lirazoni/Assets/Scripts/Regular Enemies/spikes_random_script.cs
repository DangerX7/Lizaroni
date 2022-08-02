using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes_random_script : MonoBehaviour
{
    public GameObject spike;
    public int dirrection;
    public bool updateSwitch = true;
    public int id;
    public int randomType;
    public bool leftW;
    public bool rightW;
    public bool upW;
    public bool downW;


    public bool isReverseTrue;
    public bool invincibile;
    public SpriteRenderer spriteRenderer;
    Vector3 originalPos;
    portal_master_object_script p;
    public bool versus2P_enemy;
    public int moves;

    public Animator animator;
    public bool spinUse;
    public bool spinStateObj; // false = left, true = right

    // Start is called before the first frame update
    void Start()
    {
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
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("spinState", spinStateObj);
        animator.SetBool("isSpinning", spinUse);
        if (GameObject.Find("Portal Master Object") != null)
        {
            if (p.variablesReset == true)  //reset variables
            {
                isReverseTrue = false;
            }
        }
        if (gameObject.activeSelf == false)
        {
            transform.position = originalPos;
        }
        if (updateSwitch == true)
        {
            dirrection = Random.Range(0, 4);
        }
        //dirrection = 0;  // FOR TESTING
        if (dirrection == 4)
        {
            Debug.Log("SHIIIIIIIIIIIIIIT!");
        }
    }
    IEnumerator CoroutineLeft()
    {
        leftW = true;
        yield return new WaitForSeconds(0.2f);
        spinUse = false;
        leftW = false;
    }
    IEnumerator CoroutineRight()
    {
        rightW = true;
        yield return new WaitForSeconds(0.2f);
        spinUse = false;
        rightW = false;
    }
    IEnumerator CoroutineDown()
    {
        upW = true;
        yield return new WaitForSeconds(0.2f);
        spinUse = false;
        upW = false;
    }
    IEnumerator CoroutineUp()
    {
        downW = true;
        yield return new WaitForSeconds(0.2f);
        spinUse = false;
        downW = false;
    }
    private void OnEnemiesAdvance(int id)
    {
        if (id == this.id)
        {
            if (gameObject.activeSelf)
            {
                isReverseTrue = false;
                if (((randomType == 0) && (dirrection == 0)) || ((randomType == 1) && (dirrection == 3)) || ((randomType == 2) && (dirrection == 2)) || ((randomType == 3) && (dirrection == 1)))
                {
                    updateSwitch = false;
                    moves += 1;
                    spinUse = true;
                    spinStateObj = false;
                    Vector3 left = new Vector3(-0.04f, 0, 0);
                    transform.position += left;
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(CoroutineLeft());
                    }
                    if (moves == 16)
                    {
                        updateSwitch = true;
                        moves = 0;
                    }
                }
                if (((randomType == 0) && (dirrection == 1)) || ((randomType == 1) && (dirrection == 0)) || ((randomType == 2) && (dirrection == 3)) || ((randomType == 3) && (dirrection == 2)))
                {
                    updateSwitch = false;
                    moves += 1;
                    spinUse = true;
                    spinStateObj = true;
                    Vector3 right = new Vector3(0.04f, 0, 0);
                    transform.position += right;
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(CoroutineRight());
                    }
                    if (moves == 16)
                    {
                        updateSwitch = true;
                        moves = 0;
                    }
                }
                if (((randomType == 0) && (dirrection == 2)) || ((randomType == 1) && (dirrection == 1)) || ((randomType == 2) && (dirrection == 0)) || ((randomType == 3) && (dirrection == 3)))
                {
                    updateSwitch = false;
                    moves += 1;
                    spinUse = true;
                    spinStateObj = true;
                    Vector3 down = new Vector3(0, -0.04f, 0);
                    transform.position += down;
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(CoroutineDown());
                    }
                    if (moves == 16)
                    {
                        updateSwitch = true;
                        moves = 0;
                    }
                }
                if (((randomType == 0) && (dirrection == 3)) || ((randomType == 1) && (dirrection == 2)) || ((randomType == 2) && (dirrection == 1)) || ((randomType == 3) && (dirrection == 0)))
                {
                    updateSwitch = false;
                    moves += 1;
                    spinUse = true;
                    spinStateObj = false;
                    Vector3 up = new Vector3(0, 0.04f, 0);
                    transform.position += up;
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(CoroutineUp());
                    }
                    if (moves == 16)
                    {
                        updateSwitch = true;
                        moves = 0;
                    }
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
                isReverseTrue = true;
                if (((randomType == 0) && (dirrection == 0)) || ((randomType == 1) && (dirrection == 3)) || ((randomType == 2) && (dirrection == 2)) || ((randomType == 3) && (dirrection == 1)))
                {
                    updateSwitch = false;
                    moves += 1;
                    Vector3 right = new Vector3(0.04f, 0, 0);
                    transform.position += right;
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(CoroutineLeft());
                    }
                    if (moves == 16)
                    {
                        updateSwitch = true;
                        moves = 0;
                    }
                }
                if (((randomType == 0) && (dirrection == 1)) || ((randomType == 1) && (dirrection == 0)) || ((randomType == 2) && (dirrection == 3)) || ((randomType == 3) && (dirrection == 2)))
                {
                    updateSwitch = false;
                    moves += 1;
                    Vector3 left = new Vector3(-0.04f, 0, 0);
                    transform.position += left;
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(CoroutineRight());
                    }
                    if (moves == 16)
                    {
                        updateSwitch = true;
                        moves = 0;
                    }
                }
                if (((randomType == 0) && (dirrection == 2)) || ((randomType == 1) && (dirrection == 1)) || ((randomType == 2) && (dirrection == 0)) || ((randomType == 3) && (dirrection == 3)))
                {
                    updateSwitch = false;
                    moves += 1;
                    Vector3 up = new Vector3(0, 0.04f, 0);
                    transform.position += up;
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(CoroutineDown());
                    }
                    if (moves == 16)
                    {
                        updateSwitch = true;
                        moves = 0;
                    }
                }
                if (((randomType == 0) && (dirrection == 3)) || ((randomType == 1) && (dirrection == 2)) || ((randomType == 2) && (dirrection == 1)) || ((randomType == 3) && (dirrection == 0)))
                {
                    updateSwitch = false;
                    moves += 1;
                    Vector3 down = new Vector3(0, -0.04f, 0);
                    transform.position += down;
                    if (gameObject.activeInHierarchy)
                    {
                        StartCoroutine(CoroutineUp());
                    }
                    if (moves == 16)
                    {
                        updateSwitch = true;
                        moves = 0;
                    }
                }
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D col1)
    {
        Vector3 up = new Vector3(0, 0.64f, 0);
        Vector3 down = new Vector3(0, -0.64f, 0);
        Vector3 left = new Vector3(-0.64f, 0, 0);
        Vector3 right = new Vector3(0.64f, 0, 0);
        GameObject Master = GameObject.Find("MasterObject");
        master_script levelReference = Master.GetComponent<master_script>();

        if ((col1.gameObject.tag.Equals("wall")) || (col1.gameObject.tag.Equals("wall3")) || (col1.gameObject.tag.Equals("Door2")))
        {
            if (leftW == true)
            {
                Debug.Log("Random_left");
                if (isReverseTrue == false)
                {
                    spike.transform.position -= left * levelReference.levelColumns;
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += left * levelReference.levelColumns;
                }
            }
            if (rightW == true)
            {
                Debug.Log("Random_right");
                if (isReverseTrue == false)
                {
                    spike.transform.position -= right * levelReference.levelColumns;
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += right * levelReference.levelColumns;
                }
            }
            if (downW == true)
            {
                Debug.Log("Random_down");
                if (isReverseTrue == false)
                {
                    spike.transform.position -= up * levelReference.levelRows;
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += up * levelReference.levelRows;
                }
            }
            if (upW == true)
            {
                Debug.Log("Random_up");
                if (isReverseTrue == false)
                {
                    spike.transform.position -= down * levelReference.levelRows;
                }
                if (isReverseTrue == true)
                {
                    spike.transform.position += down * levelReference.levelRows;
                }
            }
        }
    }
    public void OnDestroy()
    {
        master_script.current.onEnemiesMove -= OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse -= OnEnemiesAdvanceReverse;
    }
}
