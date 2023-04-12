using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button startBtn, settingBtn, quitBtn, backBtn, musicBtn, soundBtn;
    // [SerializeField] Toggle soundTgl;
    [SerializeField] GameObject settingPannel, mainmenuPannel;
    // [SerializeField] Slider music;
    public static MainMenu Instance;

    void Awake()
    {
        startBtn.onClick.AddListener(OnClickStart);
        settingBtn.onClick.AddListener(OnClickSetting);
        backBtn.onClick.AddListener(OnClickBack);
        musicBtn.onClick.AddListener(OnClickMusic);
        // quitBtn.onClick.AddListener(OnClickQuit);
        // soundTgl.onValueChanged.AddListener(SoundToggle);

        if(!Instance) //if (Instance == null)
        {
            Instance = this;
        }
        // bool isSound = PlayerPrefs.GetInt("Sound") == 1? true : false;
        // float isMusic = PlayerPrefs.GetFloat("Sound");
    }

    // Load Choose Case Scence
    public void OnClickStart()
    {
        SceneManager.LoadScene("ChooseCaseScene");
    }

    // Load pannel Setting
    public void OnClickSetting()
    {
        settingPannel.SetActive(true);
        mainmenuPannel.SetActive(false);
    }

    public void OnClickMusic()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            PlayerPrefs.SetInt("Music_Vol", 1);
        } else {
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("Music_Vol", 0);
        }
    }

    // Load pannel Main Menu
    public void OnClickBack()
    {
        settingPannel.SetActive(false);
        mainmenuPannel.SetActive(true);
    }

    void Start() 
    {
        if (!PlayerPrefs.HasKey("Music_Vol"))
        {
            PlayerPrefs.SetFloat("Music_Vol", 1);
        } else {
            PlayerPrefs.GetFloat("Music_Vol");
        }
        settingPannel.SetActive(false);
        mainmenuPannel.SetActive(true);
    }

}
