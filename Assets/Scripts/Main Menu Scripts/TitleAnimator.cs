using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleAnimator : MonoBehaviour
{
    public TMP_Text Title;
    private DialogueVertexAnimator dialogueVertexAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        dialogueVertexAnimator = new DialogueVertexAnimator(Title);
        PlayDialogue("<anim:wave>"+Title.text+"</anim>");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Coroutine typeRoutine = null;
    void PlayDialogue(string message) {
        this.EnsureCoroutineStopped(ref typeRoutine);
        dialogueVertexAnimator.textAnimating = false;
        List<DialogueCommand> commands = DialogueUtility.ProcessInputString(message, out string totalTextMessage);
        typeRoutine = StartCoroutine(dialogueVertexAnimator.AnimateTextIn(commands, totalTextMessage, null));
    }
}
