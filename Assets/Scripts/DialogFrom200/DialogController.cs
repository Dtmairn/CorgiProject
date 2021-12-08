using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
	private List<DialogMessage> messages = new List<DialogMessage>();

	public void StartDialog(List<DialogMessage> newDialog)
	{
		messages.AddRange(newDialog);
		messages[0].DialogText.text = messages[0].Message;
	}

	public void EndDialog()
	{
		if(messages.Count > 0)
		{
			messages[0].DialogText.text = "";
		}
		messages.Clear();
	}

	private void Update()
	{
		if(messages.Count > 0)
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				messages[0].DialogText.text = "";
				messages.Remove(messages[0]);
				if(messages.Count <= 0)
				{
					EndDialog();
					return;
				}
				messages[0].DialogText.text = messages[0].Message;
			}
		}
	}


}
