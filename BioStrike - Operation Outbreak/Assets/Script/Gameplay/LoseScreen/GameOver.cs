using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject LoseScreen;

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        AudioManagerLevel1.instance.PlaySFX("Coin");
        AudioManagerLevel1.instance.bgmSource.Stop();
        Time.timeScale = 0;
        LoseScreen.SetActive(true);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Lobby");
        AudioManagerLevel1.instance.PlaySFX("Pause");
    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        AudioManagerLevel1.instance.PlaySFX("Pause");
    }
}
