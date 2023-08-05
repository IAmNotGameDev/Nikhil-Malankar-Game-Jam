using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SM : MonoBehaviour
{
    public void GameScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
