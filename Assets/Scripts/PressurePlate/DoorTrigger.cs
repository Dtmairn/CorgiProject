using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour
{
	public Collider2D doorCollider;

	public DoorScript door;


	public bool ignoreTrigger;



	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}


	void OnTriggerEnter2D(Collider2D other)
	{

		if (ignoreTrigger)
			return;

		if (other.tag == "Player")
			door.DoorOpen();

	}

	void OnTriggerExit2D(Collider2D other)
	{


		if (ignoreTrigger)
			return;

		if (other.tag == "Player")
			door.DoorClose();

	}

	public void Toggle(bool state)
	{
		if (state)
		{

			door.DoorOpen();
			
		}
		else
			door.DoorClose();
		doorCollider.enabled = !state;

	}


	void OnDrawGizmos()
	{
		if (!ignoreTrigger)
		{
			BoxCollider2D box = GetComponent<BoxCollider2D>();

			Gizmos.DrawWireCube(transform.position, new Vector2(box.size.x, box.size.y));

		}


	}
}
