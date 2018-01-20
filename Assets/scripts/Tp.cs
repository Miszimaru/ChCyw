using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour 
{
	public GameObject destination;
    public string transportTag = "Medicine";
	void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag (transportTag) || collider.gameObject.layer == 1) 
		{
			Vector3 targetPosition = destination.transform.position;
			targetPosition += destination.transform.forward * 2;
			collider.transform.position = targetPosition;
			collider.transform.Rotate (collider.transform.up, 90);
		}
	}
}