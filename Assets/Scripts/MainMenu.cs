using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public bool isStart = false;
    public string nextSceneName;
    public GameObject mainMenu;
    public Button startBtn = null;
    public Button retryBtn = null;
    public Button quitBtn = null;
    public Button optionBtn = null;
    public GameObject optionSound;
    public GameObject startMenu;

    private void Start()
    {
        mainMenu.SetActive(false);

        optionSound.SetActive(false);

        startBtn.onClick.AddListener(() => StartGame());
        retryBtn.onClick.AddListener(() => Retry());

        quitBtn.onClick.AddListener(() => OnClickQuit());
        optionBtn.onClick.AddListener(() => OnClickOption());
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            mainMenu.SetActive(!mainMenu.activeSelf);
            transform.GetChild(2).gameObject.SetActive(!mainMenu.activeSelf);
            transform.GetComponent<VRPlayer>().enabled = !mainMenu.activeSelf;
        }
    }

    private void Retry()
    {
        OVRScreenFade.instance.FadeOut(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //이동할 씬의 이름이 같아야 함
        });
    }

    private void OnClickNewGame()
    {
        Debug.Log("move");
    }

    private void StartGame()
    {
        OVRScreenFade.instance.FadeOut(() =>
        {
            SceneManager.LoadScene(nextSceneName); //이동할 씬 이름이 같아야 함.
        });
        
        Debug.Log("move");
    }

    

    
    private void OnClickQuit()
    {
#if UNITY_EDITER
        UnityEditor.EditorApplication.isPlaying =false;
#else
        OVRScreenFade.instance.FadeOut(() => { Application.Quit(); });
#endif
    }

    private void OnClickOption()
    {
        startMenu.SetActive(false);
        optionSound.SetActive(true);
    }
}
