using Unity.VisualScripting;
using UnityEngine;

public enum GameState
{
    MainMenu,
    LevelSelect,
    Game,
    Won,
    Lost
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private GameState currentGameState;

    public GameState GameState { get { return currentGameState; } }

    private void Awake() {
        // Singleton code
        if(instance == null)
            instance = this;

        else if(instance != this)
            Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeGameState(GameState.Game);
    }

    public void ChangeGameState(GameState gameState) {
        switch(gameState) {
            case GameState.MainMenu:
                break;
            case GameState.LevelSelect:
                break;
            case GameState.Game:
                break;
            case GameState.Won:
                break;
            case GameState.Lost:
                break;
        }

        currentGameState = gameState;
    }
}
