using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continuebtn : MonoBehaviour
{
    public void GoToNextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Credit");
        AudioManagerLevel1.instance.PlaySFX("Pause");
    }
}
