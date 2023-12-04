using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class LevelScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject Layar1;

    [SerializeField] private GameObject Layar2;
    [SerializeField] private GameObject Layar3;
    [SerializeField] private GameObject Layar4;
    [SerializeField] private GameObject Layar5;

    public void ToLayar1()
    {
        Layar1.SetActive(true);
        Layar2.SetActive(false);
        Layar3.SetActive(false);
        Layar4.SetActive(false);
        Layar5.SetActive(false);
        Time.timeScale = 0;
    }

    public void ToLayar2()
    {
        Layar1.SetActive(false);
        Layar2.SetActive(true);
        Layar3.SetActive(false);
        Layar4.SetActive(false);
        Layar5.SetActive(false);
        Time.timeScale = 0;
    }

    public void ToLayar3()
    {
        Layar1.SetActive(false);
        Layar2.SetActive(false);
        Layar3.SetActive(true);
        Layar4.SetActive(false);
        Layar5.SetActive(false);
        Time.timeScale = 0;
    }

    public void ToLayar4()
    {
        Layar1.SetActive(false);
        Layar2.SetActive(false);
        Layar3.SetActive(false);
        Layar4.SetActive(true);
        Layar5.SetActive(false);
        Time.timeScale = 0;
    }

    public void ToLayarAkhir()
    {
        Layar1.SetActive(false);
        Layar2.SetActive(false);
        Layar3.SetActive(false);
        Layar4.SetActive(false);
        Layar5.SetActive(true);
        Time.timeScale = 0;
    }

    public void ToLevel1_1()
    {
        SceneManager.LoadScene("Level 1.1");
        Time.timeScale = 1;
    }

}
