using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitionManager : MonoBehaviour
{
    public string Stage1; // �̵��� ���� �̸�

    void Start()
    {
        // ��ư ������Ʈ ��������
        Button button = GetComponent<Button>();

        // ��ư�� Ŭ�� �̺�Ʈ �߰�
        button.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        // �־��� �̸��� ������ �̵�
        SceneManager.LoadScene(Stage1);
    }
}