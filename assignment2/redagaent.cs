using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class redagent : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("ball").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(target.position);
    }
}
