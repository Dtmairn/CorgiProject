using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class CharacterController : MonoBehaviour
{


	public Transform keyFollowPoint;
	public Key followingKey;
	float dirX;
	[SerializeField]
	float moveSpeed = 5f;
	Rigidbody2D rb;
	AudioSource audioSrc;
	bool isMoving = false;


	bool jump = false;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		audioSrc = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetButtonDown("Jump"))
        {
			jump = true;
        }


		dirX = Input.GetAxis("Horizontal") * moveSpeed;

		if (rb.velocity.x != 0)
			isMoving = true;
		else
			isMoving = false;

		if (isMoving)
		{
			if (!audioSrc.isPlaying)
				audioSrc.Play();
		}
		else
			audioSrc.Stop();
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2(dirX, rb.velocity.y);


		
	}
}