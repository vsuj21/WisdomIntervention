using TMPro;
using UnityEngine;

public class ScriptControl : MonoBehaviour
{
    public TextMeshProUGUI text1;

    

    public string[] dialogues = {
        "Oh! no, it's already 8am",
        "I am getting late",
        
    };
    private int currentDialogueIndex = 0;

    void Start()
    {
        DisplayCurrentDialogue();
    }

    public void Next()
    {
        currentDialogueIndex = Mathf.Min(currentDialogueIndex + 1, dialogues.Length - 1);
        DisplayCurrentDialogue();
    }

    public void Previous()
    {
        currentDialogueIndex = Mathf.Max(currentDialogueIndex - 1, 0);
        DisplayCurrentDialogue();
    }

    private void DisplayCurrentDialogue()
    {
        text1.text = dialogues[currentDialogueIndex];
       
    }
}
