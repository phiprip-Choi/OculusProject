using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    void Start()
    {
        // 버튼 컴포넌트 가져오기
        Button button = GetComponent<Button>();

        // 버튼에 클릭 이벤트 추가
        button.onClick.AddListener(Quit);
    }

    void Quit()
    {
        // 게임 종료
        Application.Quit();
    }
}