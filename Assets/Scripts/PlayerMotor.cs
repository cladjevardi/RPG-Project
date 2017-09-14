using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] // Make sure we always have a NavMeshAgent to get
public class PlayerMotor : MonoBehaviour {

    NavMeshAgent agent; // Reference to NavMeshAgent

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveToPoint(Vector3 point)
    {
        agent.SetDestination(point);
    }
}
