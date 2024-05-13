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
        OVRScreenFade.instance.FadeOut(() =>
        {
            SceneManager.LoadScene("Stage1"); //이동할 씬 이름이 같아야 함.
        });
        
        Debug.Log("move");
    }
    public void OnClickNewGame()
    {
        Debug.Log("눌림");
    }

    public void OnClickQuit()
    {
#if UNITY_EDITER
        UnityEditor.EditorApplication.isPlaying =false;
#else
        Application.Quit();
#endif
        Debug.Log("눌림");
    }

}
