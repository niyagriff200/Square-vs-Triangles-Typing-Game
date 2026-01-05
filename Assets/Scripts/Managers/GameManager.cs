using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance => instance;

    [Header("Game States")]
    [SerializeField] private GameObject splashScreenState;
    public GameObject SplashScreenState => splashScreenState;

    [SerializeField] private GameObject mainMenuState;
    public GameObject MainMenuState => mainMenuState;

    [SerializeField] private GameObject gameplayState;
    public GameObject GameplayState => gameplayState;

    [SerializeField] private GameObject gameOverState;
    public GameObject GameOverState => gameOverState;

    [SerializeField] private GameObject settingsState;
    public GameObject SettingsState => settingsState;

    [SerializeField] private GameObject creditsState;
    public GameObject CreditsState => creditsState;

    [Header("Level Data")]
    [SerializeField] private LevelData currentLevelData;
    public LevelData CurrentLevelData
    {
        get { return currentLevelData; }
        set { currentLevelData = value; }
    }

    [Header("Audio Clips")]
    [SerializeField] private AudioClip backgroundMusic;
    public AudioClip BackgroundMusic => backgroundMusic;

    [Header("Player Settings")]
    [SerializeField] private List<Transform> lanePositions;
    public List<Transform> LanePositions => lanePositions;

    [SerializeField] private float startingLives;
    public float StartingLives => startingLives;

    [SeralizedField] private bool wrapLines = true;
    public bool WrapLines => wrapLines;

    //[Header("Enemy Settings")]


    //[Header("Score Tracker")]

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
