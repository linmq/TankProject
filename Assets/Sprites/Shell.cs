﻿using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour 
{
	public GameObject shellExplosionPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider collider)
	{
		GameObject.Instantiate (shellExplosionPrefab, transform.position, transform.rotation);
		GameObject.Destroy (this.gameObject);
	}
}
