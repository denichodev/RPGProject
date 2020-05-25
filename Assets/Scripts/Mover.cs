using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = target.position;

    }
}
