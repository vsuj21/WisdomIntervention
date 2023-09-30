using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Parameters player;

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
                player.wisdomIntelligence += 1;
                player.charisma += 1;
                break;
            case 2:
                // Handle other choices as needed
                break;
            default:
                break;
        }
    }

  
}
