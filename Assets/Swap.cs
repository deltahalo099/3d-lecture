using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour {

	public GameObject openBook;
	public GameObject closedBook;

	void OnTriggerEnter (Collider collider)
	{
		Debug.Log ("Object is within trigger");
		closedBook.SetActive(false);
		openBook.SetActive(true);

	}
	
}
