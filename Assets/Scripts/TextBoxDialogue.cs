using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxDialogue : MonoBehaviour
{
    public Dialogue dialogue;

    public UniversalDialogueManager dialogueManager;

    public Animator animator;

    public GameObject textBox;
    public void Start()
    {
        textBox.SetActive(false);
    }

    public void StartDialogue()
    {
        textBox.SetActive(true);
        dialogueManager.StartDialogue(dialogue);
        animator.SetBool("Start", true);
    }

    public void Update()
    {
        if(dialogueManager.dialogueOver == true)
        {
            animator.SetBool("End", true);
        }
    }

}
