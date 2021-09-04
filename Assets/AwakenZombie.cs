using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakenZombie : MonoBehaviour
{

    public GameObject Zombie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Zombie.SetActive(true);
        }
    }
}
