using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScriptControl : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public Image player_image;
    public GameObject optionsPanel1;
    public GameObject optionsPanel2;
    public GameObject optionsPanel3;
    public bool waitingforchoice = false;
    public Parameters player;
    public TextMeshProUGUI scores;
    public TMP_InputField Name;
    public string playername;



    public string[] dialogues = {
        "Oh! no, it's already 8am",
        "I am getting late",
        "What should I do now?" , 
        " "
    };
    
    public Sprite[] sprites;
    private int currentDialogueIndex = 0;
    

    void Start()
    {
        
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
        player_image.sprite = sprites[currentDialogueIndex];
       
        if (currentDialogueIndex == 2)
        {
            optionsPanel1.SetActive(true);
            waitingforchoice = true;
           
        }
        if (currentDialogueIndex == 4)
        {
            optionsPanel2.SetActive(true);
            waitingforchoice = true;
        }
        if (currentDialogueIndex == 8)
        {
            optionsPanel3.SetActive(true);
            waitingforchoice = true;
        }
        
    }
    public void HandleChoice(int choice)
    {
        // Update parameters based on the choice
        switch (choice)
        {
            case 1:
                player.wisdom += 1;
                player.Intelligence += 1;
                player.charisma += 1;
                dialogues = dialogues.Concat(new string[] { "Feels Fresh, Oh no! I am gonna miss the bus",
                "what should I do about the breakfast",
                }).ToArray();
                break;
            case 2:
                player.charisma -= 1;
                player.Intelligence -= 1;
                
                dialogues = dialogues.Concat(new string[] { "It doesn't feel good. I should have brushed",
                "what should I do about the breakfast"}).ToArray();
                break;
            case 3:
                player.charisma += 2;
                player.strength += 3;
                dialogues = dialogues.Concat(new string[] { "Feels energetic",
                "Oops, I missed the bus",
                "I will ask for a lift"," "}).ToArray();
                break;
            case 4:
                player.charisma -= 1;
                player.strength+=1;
                player.Intelligence-=1;
                dialogues = dialogues.Concat(new string[] { "I feel hungry now :(",
                "oh! The bus arrived",
                "Let me get into the bus, but I still feel hungry"," "}).ToArray(); 
                break;
            default:
                player.wisdom += 1;
                break;
         
        }
        
    }
    public void Displayscore(string name)
    {
        scores.text = $" Hey {name}! your Score is:\nWisdom: {player.wisdom}\nIntelligence:{player.Intelligence} \nCharisma: {player.charisma}\nStrength: {player.strength}";
    }
   
    public void entername()
    {
        
        
        playername = Name.text;
        
        Displayscore(playername);
        optionsPanel3.SetActive(false);
        
    }
    public void MakeChoice(int choice)
    {
        // Handle player's choice and update parameters
        HandleChoice(choice);
        
        optionsPanel1.SetActive(false);
        optionsPanel2.SetActive(false);
        waitingforchoice = false;
        DisplayNextDialogue();
        
       
    }
}
