using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float health = 10f;

    Animator animator;
    zombiemove scriptForMovement;
    Collider collider;
    NavMeshAgent navmesh;

    /**/private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        scriptForMovement = gameObject.GetComponent<zombiemove>();
        collider = gameObject.GetComponent<Collider>();
        navmesh = gameObject.GetComponent<NavMeshAgent>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("isShot", true);
        //scriptForMovement.enabled = false;
        Destroy(scriptForMovement);
        //Destroy(collider);
        Destroy(navmesh);
        //Destroy(gameObject);
    }
}
