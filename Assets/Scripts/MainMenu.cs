using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public Button retryBtn;
    public Button quitBtn;

    private void Start()
    {
        mainMenu.SetActive(false);
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
    private void GameScnesCtrl()
    {
        OVRScreenFade.instance.FadeOut(() =>
        {
            SceneManager.LoadScene("Stage1 - 2"); //�̵��� �� �̸��� ���ƾ� ��.
        });
        
        Debug.Log("move");
    }

    private void Retry()
    {
        OVRScreenFade.instance.FadeOut(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //�̵��� �� �̸��� ���ƾ� ��.
        });
    }

    private void OnClickNewGame()
    {
        Debug.Log("����");
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
