using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauseDamage : MonoBehaviour
{
    private Rigidbody rgbody;
    public GameObject Zombie;

    private void Start()
    {
        rgbody = Zombie.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zombie")
        {
            rgbody.AddForce(transform.right * 20f);
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(20f);
            }
        }
    }
}
