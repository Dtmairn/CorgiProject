using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueActorTake2 : MonoBehaviour
{
    public List<DialogueMessage> Messages;
    public DialogueControllerTake2 DialogueControl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DialogueControl.StartDialogue(Messages);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        DialogueControl.EndDialogue();
    }
}

