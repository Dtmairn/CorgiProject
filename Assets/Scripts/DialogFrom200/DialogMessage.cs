using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] //This allows us to see this class in the inspector. Note this class is not a monobehaviour.
public class DialogMessage
{
	public Text DialogText;
	public string Message;
}
