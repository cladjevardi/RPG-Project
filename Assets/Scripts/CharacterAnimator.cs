using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {

    const float locomotionAnimationSmoothTime = 0.2f; // Smoothes the transition between animation types

    NavMeshAgent agent;
    Animator animator;
    

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>(); // Initializes the NavMeshAgent
        animator = GetComponentInChildren<Animator>(); // Finds the animator initializes it
	}
	
	// Update is called once per frame
	void Update () {
        float speedPercent = agent.velocity.magnitude / agent.speed; // Current speed / max possible speed
        animator.SetFloat("speedPercent", speedPercent, locomotionAnimationSmoothTime, Time.deltaTime); // Calculates when to switch between animations
	}
}
