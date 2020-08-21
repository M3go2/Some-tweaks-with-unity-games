using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

  private Animator animator;
  private NavMeshAgent agent;

  // Use this for initialization
  void Awake()
  {
    animator = GetComponent<Animator>();
    agent = GetComponent<NavMeshAgent>();
  }

  // Update is called once per frame
  void Update()
  {
    animator.SetFloat("Speed", agent.velocity.magnitude);
  }
}
