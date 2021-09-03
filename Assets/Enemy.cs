using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float health = 10f;
    
    Animator animator;
    zombiemove scriptForMovement;
    Collider collider;
    NavMeshAgent navmesh;
    private GameObject ZombieController;

    /**/private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        scriptForMovement = gameObject.GetComponent<zombiemove>();
        collider = gameObject.GetComponent<Collider>();
        navmesh = gameObject.GetComponent<NavMeshAgent>();
        //ZombieController = gameObject.Find("ZombieController");
        ZombieController = transform.GetChild(31).gameObject;
        //ZombieController.SetActive(false);
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
        //Debug.Log("DIE");
        animator.SetBool("isShot", true);
        //scriptForMovement.enabled = false;
        Destroy(scriptForMovement);
        //Destroy(collider);
        Destroy(navmesh);
        Destroy(ZombieController);
        //Destroy(gameObject);
    }

    
}
