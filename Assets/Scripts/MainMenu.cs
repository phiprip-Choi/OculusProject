using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public bool isStart = false;
    public string nextSceneName;
    public Button startBtn = null;
    public Button quitBtn = null;
    public Button optionBtn = null;
    public GameObject optionSound;
    public GameObject startMenu;

    private void Start()
    {
        
        optionSound.SetActive(false);

        startBtn.onClick.AddListener(()=> StartGame());
      
        quitBtn.onClick.AddListener(() => OnClickQuit());   
        optionBtn.onClick.AddListener(() => OnClickOption());
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
