﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour 
{
	public GameObject destination;
	void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag ("Player") || collider.gameObject.layer == 1) 
		{
			Vector3 targetPosition = destination.transform.position;
			targetPosition += destination.transform.forward * 2;
			collider.transform.position = targetPosition;
			collider.transform.Rotate (collider.transform.up, 180);
		}
	}
}