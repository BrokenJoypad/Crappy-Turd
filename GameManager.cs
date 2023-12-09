using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    public static GameManager Instance;

    [Header("Game State")]
    [SerializeField] int CurrentScore = 0;
    [SerializeField] bool PlayerAlive = true;
    // Awake is called before Start
    void Awake()
    {
       
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional: Keeps the GameManager alive between scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementCurrentScore(int amount)
    {
        CurrentScore += amount;
    }

    public int ReturnScore()
    {
        return CurrentScore;
    }

    public bool SetPlayerState(bool alive)
    {
        PlayerAlive = alive;
        return PlayerAlive;
    }

    public bool ReturnPlayerState()
    {
        return PlayerAlive;
    }
}
