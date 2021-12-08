using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueControllerTake2 : MonoBehaviour
{
    private List<DialogueMessage> messages = new List<DialogueMessage>();

    public void StartDialogue(List<DialogueMessage> newDialogue)
    {
        messages.AddRange(newDialogue);
        messages[0].DialogueText.text = messages[0].Message;
    }

    public void EndDialogue()
    {
        if (messages.Count > 0)
        {
            messages[0].DialogueText.text = "";
        }
        messages.Clear();
    }

    private void Update()
    {
        if (messages.Count > 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                messages[0].DialogueText.text = "";
                messages.Remove(messages[0]);
                if (messages.Count <= 0)
                {
                    EndDialogue();
                    return;
                }
                messages[0].DialogueText.text = messages[0].Message;
            }
        }
    }


}
