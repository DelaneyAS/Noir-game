using UnityEngine;
using System.Collections;

public class AnimationCollisionCheck : MonoBehaviour 
{
	private Animator animator;

	void Awake () 
	{  //when this script loads it hunts for the animator component on the attached object
		animator = GetComponent <Animator>();
	}
	void OnTriggerEnter (Collider other) 
	{ //this is looking for another object with the tag "player"
		if (other.gameObject.tag == "Player")
		{
			animator.SetBool ("Open", true);
			//here you could spawn treasure
	}
	}
	void OnTriggerExit (Collider other) 
	{ //this is waiting for the "player" to leave the area
		if (other.gameObject.tag == "Player")
		{
			animator.SetBool ("Open", false);
		}
	}
}
