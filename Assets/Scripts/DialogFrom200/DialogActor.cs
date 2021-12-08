using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogActor : MonoBehaviour
{
	public List<DialogMessage> Messages;
	public DialogController DialogControl;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		DialogControl.StartDialog(Messages);
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		DialogControl.EndDialog();
	}
}
