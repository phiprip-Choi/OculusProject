using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public bool isStart = false;
    public GameObject mainMenu;
    public string nextSceneName;
    public Button startBtn = null;
    public Button retryBtn = null;
    public Button quitBtn = null;

    private void Start()
    {
        mainMenu.SetActive(false);
        startBtn.onClick.AddListener(()=> StartGame());
        retryBtn.onClick.AddListener(() => Retry());
        quitBtn.onClick.AddListener(() => OnClickQuit());    
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
    private void StartGame()
    {
        OVRScreenFade.instance.FadeOut(() =>
        {
            SceneManager.LoadScene(nextSceneName); //이동할 씬 이름이 같아야 함.
        });
        
        Debug.Log("move");
    }

    private void Retry()
    {
        OVRScreenFade.instance.FadeOut(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //이동할 씬 이름이 같아야 함.
        });
    }

    private void OnClickNewGame()
    {
        Debug.Log("눌림");
    }

    private void OnClickQuit()
    {
#if UNITY_EDITER
        UnityEditor.EditorApplication.isPlaying =false;
#else
        OVRScreenFade.instance.FadeOut(() => { Application.Quit(); });
#endif
    }

}
