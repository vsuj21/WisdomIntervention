using TMPro;
using UnityEngine;

public class ScriptControl : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public GameObject optionsPanel;
    public bool waitingforchoice = false;
    

    
    public string[] dialogues = {
        "Oh! no, it's already 8am",
        "I am getting late",
        "What should I do now?"  
    };
    private int currentDialogueIndex = 0;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.Instance;
        DisplayCurrentDialogue();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && !waitingforchoice)
        {
            DisplayNextDialogue();
        }
    }

    public void DisplayNextDialogue()
    {
        if (waitingforchoice)
        {
            return;
        }
        currentDialogueIndex = Mathf.Min(currentDialogueIndex + 1, dialogues.Length - 1);
        DisplayCurrentDialogue();
    }

    private void DisplayCurrentDialogue()
    {
        text1.text = dialogues[currentDialogueIndex];

       
        if (currentDialogueIndex == 2)
        {
            optionsPanel.SetActive(true);
            waitingforchoice = true;
           
        }
    }
    

    public void MakeChoice(int choice)
    {
        // Handle player's choice and update parameters
        gameManager.HandleChoice(choice);

        optionsPanel.SetActive(false);
        waitingforchoice = false;
        DisplayNextDialogue();
        GameManager.Instance.Displayscore();
       
    }
}
