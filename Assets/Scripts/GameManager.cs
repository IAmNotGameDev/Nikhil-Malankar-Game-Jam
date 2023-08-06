using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public TMP_Text timeText;
    private float startTime;


    public static GameManager Instance;
    public int coins = 0;
    public List<GameObject> Coins;
    public TextMeshProUGUI Points;

    public GameObject Gameover;
    public GameObject WinCanvas;

    public GameObject Menu;
    // Start is called before the first frame update
    private void Awake()
    {

            Instance = this;
       Time.timeScale = 0f;

    }
    private void Start()
    {

        Gameover.SetActive(false);
        WinCanvas.SetActive(false);
        Menu.SetActive(true);
        startTime = Time.time;
    }
    private void Update()
    {
        Points.text = coins.ToString();
        float elapsedTime = Time.time - startTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);

        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeText.text = "Time: " + timeString;

        /*if (Input.GetButtonDown("Fire1"))
        {
            GamepadRestart();
        }*/
    }

 /*   public void GamepadRestart()
    {
        Gameover.SetActive(false);
        WinCanvas.SetActive(false);
        Menu.SetActive(false);
        Time.timeScale = 1f;
    }*/
    public void GameOver()
    {
        Time.timeScale = 0f;
        Gameover.SetActive(true);
    }
    public void btc()
    {
        Time.timeScale = 1f;
        Menu.SetActive(false);

    }
    public void Win()
    {
        if(Coins.Count == coins)
        {
            Time.timeScale = 0f;
            WinCanvas.SetActive(true);
        }
        else
        {
            Debug.Log("You not colleted all coins");
        }
        
    }
}
