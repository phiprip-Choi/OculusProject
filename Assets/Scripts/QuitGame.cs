using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    void Start()
    {
        // ��ư ������Ʈ ��������
        Button button = GetComponent<Button>();

        // ��ư�� Ŭ�� �̺�Ʈ �߰�
        button.onClick.AddListener(Quit);
    }

    void Quit()
    {
        // ���� ����
        Application.Quit();
    }
}