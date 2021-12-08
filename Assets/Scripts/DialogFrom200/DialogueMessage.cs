using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable] //This allows us to see this class in the inspector. Note this class is not a monobehaviour.
public class DialogueMessage
{
    public TMP_Text DialogueText;
    public string Message;
}
