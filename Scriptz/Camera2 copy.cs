﻿using UnityEngine;

public class Camera2 : MonoBehaviour
{

	public Transform player;
	public Vector3 offset;

	// Update is called once per frame
	void Update()
	{
		transform.position = player.position + offset;
	}
}
//camera follows without rotating during crashes