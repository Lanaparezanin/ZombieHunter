using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class zombiemove : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform igrac;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.SetDestination(igrac.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
