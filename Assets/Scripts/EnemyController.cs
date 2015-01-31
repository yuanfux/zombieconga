﻿using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float speed = -1;
	private Transform spawnPoint;
	private Camera mycam;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(speed, 0);
		spawnPoint = GameObject.Find("SpawnPoint").transform;
		mycam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnBecameInvisible()
	{
		if (mycam == null)
			return;
		float yMax = Camera.main.orthographicSize - 0.5f;
		transform.position = new Vector3( spawnPoint.position.x, 
		                                 Random.Range(-yMax, yMax), 
		                                 transform.position.z );
	}
}
