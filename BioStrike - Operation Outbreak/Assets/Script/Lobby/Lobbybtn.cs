using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobbybtn : MonoBehaviour
{

    [SerializeField]
    private GameObject LobbyScreen;

    [SerializeField]
    private GameObject SoundSettingScreen;

    [SerializeField]
    private GameObject MoveSettingScreen;

    [SerializeField]
    private GameObject HannaStoryScreen;

    [SerializeField]
    private GameObject DrStoryScreen;

    [SerializeField]
    private GameObject WeaponStoryScreen;

    public void Start()
    {
        AudioManagerLobby.instance.bgmSource.Stop();
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        AudioManagerLobby.instance.bgmSource.Stop();
        AudioManagerLobby.instance.PlaySFX("UI");
        SceneManager.LoadScene("CutSceneProlog");
    }

    public void GoToCredit()
    {
        Time.timeScale = 1;
        AudioManagerLobby.instance.bgmSource.Stop();
        SceneManager.LoadScene("Credit");
        AudioManagerLobby.instance.PlaySFX("UI");
    }

    public void Backlobby()
    {
        LobbyScreen.SetActive(true);
        SoundSettingScreen.SetActive(false);
        MoveSettingScreen.SetActive(false);
        HannaStoryScreen.SetActive(false);
        DrStoryScreen.SetActive(false);
        WeaponStoryScreen.SetActive(false);
        Time.timeScale = 1;
        AudioManagerLobby.instance.PlaySFX("UI");
    }

    public void SoundSetting()
    {
        LobbyScreen.SetActive(false);
        SoundSettingScreen.SetActive(true);
        MoveSettingScreen.SetActive(false);
        HannaStoryScreen.SetActive(false);
        DrStoryScreen.SetActive(false);
        WeaponStoryScreen.SetActive(false);
        Time.timeScale = 0;
        AudioManagerLobby.instance.PlaySFX("UI");
        //AudioManagerLobby.instance.PlayBGM("Lobby");
    }

    public void MoveSetting()
    {
        LobbyScreen.SetActive(false);
        SoundSettingScreen.SetActive(false);
        MoveSettingScreen.SetActive(true);
        HannaStoryScreen.SetActive(false);
        DrStoryScreen.SetActive(false);
        WeaponStoryScreen.SetActive(false);
        Time.timeScale = 0;
        AudioManagerLobby.instance.PlaySFX("UI");
    }

    public void StoryHanna()
    {
        LobbyScreen.SetActive(false);
        SoundSettingScreen.SetActive(false);
        MoveSettingScreen.SetActive(false);
        HannaStoryScreen.SetActive(true);
        DrStoryScreen.SetActive(false);
        WeaponStoryScreen.SetActive(false);
        Time.timeScale = 0;
        AudioManagerLobby.instance.PlaySFX("UI");
    }

    public void StoryDr()
    {
        LobbyScreen.SetActive(false);
        SoundSettingScreen.SetActive(false);
        MoveSettingScreen.SetActive(false);
        HannaStoryScreen.SetActive(false);
        DrStoryScreen.SetActive(true);
        WeaponStoryScreen.SetActive(false);
        Time.timeScale = 0;
        AudioManagerLobby.instance.PlaySFX("UI");
    }

    public void StoryWeapon()
    {
        LobbyScreen.SetActive(false);
        SoundSettingScreen.SetActive(false);
        MoveSettingScreen.SetActive(false);
        HannaStoryScreen.SetActive(false);
        DrStoryScreen.SetActive(false);
        WeaponStoryScreen.SetActive(true);
        Time.timeScale = 0;
        AudioManagerLobby.instance.PlaySFX("UI");
    }

}
