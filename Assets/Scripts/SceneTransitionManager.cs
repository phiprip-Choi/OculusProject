using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitionManager : MonoBehaviour
{
    public string Stage1; // 이동할 씬의 이름

    void Start()
    {
        // 버튼 컴포넌트 가져오기
        Button button = GetComponent<Button>();

        // 버튼에 클릭 이벤트 추가
        button.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        // 주어진 이름의 씬으로 이동
        SceneManager.LoadScene(Stage1);
    }
}