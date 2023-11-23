using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objectivebtn : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjectiveScreen;

    [SerializeField]
    private GameObject PlayScreen;

    public void PauseGame()
    {
        Time.timeScale = 0;
        PlayScreen.SetActive(false);
        ObjectiveScreen.SetActive(true);
        AudioManagerLevel1.instance.PlaySFX("Pause");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PlayScreen.SetActive(true);
        ObjectiveScreen.SetActive(false);
        AudioManagerLevel1.instance.PlaySFX("Pause");
    }
}
