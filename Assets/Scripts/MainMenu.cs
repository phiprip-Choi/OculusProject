using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameScnesCtrl()
    {
        SceneManager.LoadScene("Stage1"); //�̵��� �� �̸��� ���ƾ� ��.
        Debug.Log("move");
    }
    public void OnClickNewGame()
    {
        Debug.Log("����");
    }

    public void OnClickQuit()
    {
#if UNITY_EDITER
        UnityEditor.EditorApplication.isPlaying =false;
#else
        Application.Quit();
#endif
        Debug.Log("����");
    }

}
