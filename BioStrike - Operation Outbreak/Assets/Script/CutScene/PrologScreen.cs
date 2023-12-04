using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrologScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject Screen1;

    [SerializeField] private GameObject Screen2;

    [SerializeField] private GameObject Screen3;

    [SerializeField] private GameObject Screen4;

    [SerializeField] private GameObject Screen5;

    [SerializeField] private GameObject Screen6;

    [SerializeField] private GameObject Screen7;

    [SerializeField] private GameObject Screen8;

    [SerializeField] private GameObject Screen9;

    [SerializeField] private GameObject Screen10;


    public void ToScreen1()
    {
        Screen1.SetActive(true);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Time.timeScale = 0;
    }

    public void ToScreen2()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(true);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Time.timeScale = 0;
    }

    public void ToScreen3()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(true);
        Screen4.SetActive(false);
        Time.timeScale = 0;
    }

    public void ToScreen4()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(true);
        Time.timeScale = 0;
    }

    public void ToLevel1()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1;
    }
}
