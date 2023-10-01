using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Parameters player;
    public TextMeshProUGUI scores;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void HandleChoice(int choice)
    {
        // Update parameters based on the choice
        switch (choice)
        {
            case 1:
                player.wisdom += 1;
                player.charisma += 1;
                break;
            case 2:
                // Handle other choices as needed
                break;
            default:
                break;
        }
    }
    public void Displayscore()
    {
        scores.text = $"  Scores:\nWisdom: {player.wisdom}\nIntelligence:{player.Intelligence} \nCharisma: {player.charisma}\nStrength: {player.strength}";
    }


}
