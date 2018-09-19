﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class Zombie : MonoBehaviour {

    private Animator animator;
    private GameObject player;
    private NavMeshAgent navMesh;
    private float distancia;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
        navMesh = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        navMesh.destination = player.transform.position;
        distancia = Vector3.Distance(transform.position, player.transform.position);
        animator.SetFloat("distancia", distancia);
        if (Vector3.Distance(transform.position, player.transform.position) < 1.5f)
        {
            Debug.Log("Está perto");
        }
	}
}
