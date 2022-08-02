using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss3_projectile_script : MonoBehaviour
{
    public GameObject spike;
    public int id;
    public int dirrection; // 0-left,1-right,2-up,3-down
    public int type;

    public Animator animator;
    public int spin;

    // Start is called before the first frame update
    void Start()
    {
        master_script.current.onEnemiesMove += OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse += OnEnemiesAdvanceReverse;
    }
    IEnumerator SpinTimer()
    {
        spin = Random.Range(1, 3);
        yield return new WaitForSeconds(0.15f);
        spin = 0;
    }
    private void OnEnemiesAdvance(int id)
    {
        if (id == this.id)
        {
            StartCoroutine(SpinTimer());
            if (type == 0)
            {
                Vector3 left = new Vector3(-0.04f, 0, 0);
                Vector3 right = new Vector3(0.04f, 0, 0);
                Vector3 up = new Vector3(0, 0.04f, 0);
                Vector3 down = new Vector3(0, -0.04f, 0);
                if (dirrection == 0)
                {
                    transform.position += left;
                }
                if (dirrection == 1)
                {
                    transform.position += right;
                }
                if (dirrection == 2)
                {
                    transform.position += up;
                }
                if (dirrection == 3)
                {
                    transform.position += down;
                }
            }
            if (type == 1)
            {
                Vector3 left = new Vector3(-0.08f, 0, 0);
                Vector3 right = new Vector3(0.08f, 0, 0);
                Vector3 up = new Vector3(0, 0.08f, 0);
                Vector3 down = new Vector3(0, -0.08f, 0);
                if (dirrection == 0)
                {
                    transform.position += left;
                }
                if (dirrection == 1)
                {
                    transform.position += right;
                }
                if (dirrection == 2)
                {
                    transform.position += up;
                }
                if (dirrection == 3)
                {
                    transform.position += down;
                }
            }
        }
    }
    private void OnEnemiesAdvanceReverse(int id)
    {
        if (id == this.id)
        {
            if (type == 0)
            {
                StartCoroutine(SpinTimer());
                Vector3 left = new Vector3(-0.04f, 0, 0);
                Vector3 right = new Vector3(0.04f, 0, 0);
                Vector3 up = new Vector3(0, 0.04f, 0);
                Vector3 down = new Vector3(0, -0.04f, 0);
                if (dirrection == 0)
                {
                    transform.position -= left;
                }
                if (dirrection == 1)
                {
                    transform.position -= right;
                }
                if (dirrection == 2)
                {
                    transform.position -= up;
                }
                if (dirrection == 3)
                {
                    transform.position -= down;
                }
            }
            if (type == 1)
            {
                Vector3 left = new Vector3(-0.08f, 0, 0);
                Vector3 right = new Vector3(0.08f, 0, 0);
                Vector3 up = new Vector3(0, 0.08f, 0);
                Vector3 down = new Vector3(0, -0.08f, 0);
                if (dirrection == 0)
                {
                    transform.position -= left;
                }
                if (dirrection == 1)
                {
                    transform.position -= right;
                }
                if (dirrection == 2)
                {
                    transform.position -= up;
                }
                if (dirrection == 3)
                {
                    transform.position -= down;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("wall"))
        {
            Destroy(this.gameObject);
        }
    }
    public void OnDestroy()
    {
        master_script.current.onEnemiesMove -= OnEnemiesAdvance;
        master_script.current.onEnemiesMoveReverse -= OnEnemiesAdvanceReverse;
    }

    public void Update()
    {
        animator.SetInteger("spin", spin);
    }
}