using UnityEngine;
using System.Collections;

public class ToggleObjectTrigger : MonoBehaviour
{
	public GameObject Object;


	void OnTriggerEnter (Collider other) 
	{ //this is looking for another object with the tag "player"
		if (other.gameObject.tag == "Player")
		{
			Object.SetActive(false);
		}
	}
		
}