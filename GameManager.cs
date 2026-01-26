using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float timeToCompleteLevel;

    public Text timerText;

    public static GameManager instance;

    public GameObject endScreen;

    public Text infoText;

    private bool noTime;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToCompleteLevel -= Time.deltaTime;
        if(timeToCompleteLevel < 0)
        {
            timeToCompleteLevel = 0;
        }
        timerText.text = timeToCompleteLevel.ToString("0");
        
        if (timeToCompleteLevel <= 0)
        {
            if(noTime == false)
            {
                noTime = true;
                Debug.Log("Jugador se ha quedado sin tiempo");
                infoText.text = "El jugador se ha quedado sin tiempo";
                Time.timeScale = 0f;  
                endScreen.SetActive(true); 
            }
            
        }
    }
    public void LoseGame()
    {
        infoText.text = "El jugador ha perdido";
        Time.timeScale = 0f;
        endScreen.SetActive(true);
    }
    public void WinGame()
    {
        infoText.text = "El Jugador ha completado el nivel";
        Time.timeScale = 0f;
        endScreen.SetActive(true);
    }
    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
