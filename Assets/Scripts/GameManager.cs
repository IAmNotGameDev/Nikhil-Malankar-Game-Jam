using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TMP_Text timeText;
    private float startTime;


    public static GameManager Instance;
    public int coins = 0;
    public TextMeshProUGUI Points;

    public GameObject Gameover;
    // Start is called before the first frame update
    private void Awake()
    {

            Instance = this;
        
       
    }
    private void Start()
    {
        Gameover.SetActive(false);
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
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        Gameover.SetActive(true);
    }
}
