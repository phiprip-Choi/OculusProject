using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverLoadScene : MonoBehaviour
{

    public string GameOver;
    private float gameTime = 15;

    void Update()
    {
        gameTime -= Time.deltaTime;
        Debug.Log((int)gameTime);
        if ((int)gameTime == 0)
        {
            SceneManager.LoadScene(GameOver);
            Debug.Log("게임 종료");
        }
    }

}
