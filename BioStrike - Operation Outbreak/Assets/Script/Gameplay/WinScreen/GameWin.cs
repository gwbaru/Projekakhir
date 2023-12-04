using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    public GameObject WinScreen;

    public static GameWin instance;
    public int totalEnemies;
    private int enemiesKilled = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Win()
    {
        enemiesKilled++;

        if (enemiesKilled == totalEnemies)
        {
            EnableWinMenu();
            AudioManagerLevel1.instance.bgmSource.Stop();
            AudioManagerLevel1.instance.PlaySFX("Win");
        }
    }

    public void NextWave1()
    {
        enemiesKilled++;

        if (enemiesKilled == totalEnemies)
        {
            GoToNextWave();
            AudioManagerLevel1.instance.bgmSource.Stop();
            AudioManagerLevel1.instance.PlaySFX("Win");
        }
    }
    public void EnableWinMenu()
    {
        Time.timeScale = 0;
        WinScreen.SetActive(true);
    }

    public void GoToNextWave()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("DialogLevel");
    }

}
