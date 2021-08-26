using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject deathScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            deathScreen.SetActive(true);
            Debug.Log("Entered collider");
        }
    }
}
