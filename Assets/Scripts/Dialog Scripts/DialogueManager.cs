﻿using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Video Tutorial
// https://www.youtube.com/watch?v=So8DpNh3XOE
// Important Classes/Functions:
// DialogueManager.cs Line 45 PlayDialogue Starts the text animation
// DialogueUtility.cs Line 28 ProcessInputString Parses the text and pulls out any special tags/commands
// DialogueVertexAnimator.cs Line 23 AnimateTextIn Takes the processed text and dialogue commands and performs the text vertex animation
public class DialogueManager : MonoBehaviour
{
    public TMP_Text textBox;
    public AudioClip typingClip;
    // public AudioSourceGroup audioSourceGroup;

    public Button playDialogue1Button;
    public Button playDialogue2Button;
    public Button playDialogue3Button;

    [TextArea]
    public string dialogue1;
    [TextArea]
    public string dialogue2;
    [TextArea]
    public string dialogue3;

    private DialogueVertexAnimator dialogueVertexAnimator;
    void Awake() {
        // dialogueVertexAnimator = new DialogueVertexAnimator(textBox, audioSourceGroup);
        dialogueVertexAnimator = new DialogueVertexAnimator(textBox);
        playDialogue1Button.onClick.AddListener(delegate { PlayDialogue1(); });
        playDialogue2Button.onClick.AddListener(delegate { PlayDialogue2(); });
        playDialogue3Button.onClick.AddListener(delegate { PlayDialogue3(); });
    }

    private void PlayDialogue1() {
        PlayDialogue(dialogue1);
    }

    private void PlayDialogue2() {
        PlayDialogue(dialogue2);
    }

    private void PlayDialogue3() {
        PlayDialogue(dialogue3);
    }


    private Coroutine typeRoutine = null;
    void PlayDialogue(string message) {
        this.EnsureCoroutineStopped(ref typeRoutine);
        dialogueVertexAnimator.textAnimating = false;
        List<DialogueCommand> commands = DialogueUtility.ProcessInputString(message, out string totalTextMessage);
        typeRoutine = StartCoroutine(dialogueVertexAnimator.AnimateTextIn(commands, totalTextMessage, null));
    }
}
