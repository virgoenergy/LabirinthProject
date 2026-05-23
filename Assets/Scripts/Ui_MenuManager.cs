using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ui_MenuManager : MonoBehaviour
{

    [SerializeField] Button newGameBtn;

    [SerializeField] Button settingBtn;

    [SerializeField] GameObject mainMenuScreen;
    [SerializeField] GameObject settingsScreen;

    [SerializeField] SceneAsset firstLevelScene;


    private void Awake()
    {
        mainMenuScreen.SetActive(true);
        settingsScreen.SetActive(false);

        newGameBtn.onClick.AddListener(() => LoadFirstScene());
        settingBtn.onClick.AddListener(() => OpenSettingsScreen());
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(firstLevelScene.name);
    }


    private void OpenSettingsScreen()
    {
        mainMenuScreen.SetActive(false);
        settingsScreen.SetActive(true);
    }
}
