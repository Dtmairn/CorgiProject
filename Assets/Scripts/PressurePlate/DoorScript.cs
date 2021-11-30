using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour
{
	Animator anim;

	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void DoorOpen()
	{
		anim.SetBool("Opens", true);
	}

	public void DoorClose()
	{
		anim.SetBool("Opens", false);
	}

	void CollEnable()
	{
		GetComponent<Collider2D>().enabled = true;
	}

	void CollDisable()
	{
		GetComponent<Collider2D>().enabled = false;
	}



}