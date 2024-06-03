using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_ : MonoBehaviour
{
    public bool isStart = false;
    public GameObject OptionMenu;
    public GameObject Canvas_opt;

    public Button option_btn = null;
    public Button retry_btn = null;
    public Button mainMenu_btn = null;
    public Button quit_btn = null;
    public Button back_btn = null;
    public string MainMenuSceneName;

    public float distanceFromPlayer = -0.5f;
    public float heightAdjustment = -0.2f;
    public GameObject player;

    public Slider volumeSlider; // ���� �����̴�
    public AudioSource backgroundMusic; // ��� ���� ����� �ҽ�

    private void Start()
    {
        OptionMenu.SetActive(false);
        Canvas_opt.SetActive(false);

        option_btn.onClick.AddListener(() => OptionCanvas());
        back_btn.onClick.AddListener(() => OnClickBack());
        retry_btn.onClick.AddListener(() => GameRetry());
        mainMenu_btn.onClick.AddListener(() => LoadMainMenu());
        quit_btn.onClick.AddListener(() => GameQuit());

        volumeSlider.onValueChanged.AddListener(SetVolume);
        volumeSlider.value = backgroundMusic.volume;
    }

    private void Update()
    {
        if (Canvas_opt.activeSelf)
        {
            return;
        }

        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (OptionMenu.activeSelf)
            {
                OptionMenu.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
                Transform playerTransform = player.transform;
                Vector3 playerPosition = playerTransform.position;
                Vector3 forwardDirection = playerTransform.forward;

                // UI ��ġ ���� (�÷��̾� �� �Ÿ���ŭ)
                Vector3 newPosition = playerPosition + forwardDirection * distanceFromPlayer;
                newPosition.y += heightAdjustment;

                OptionMenu.transform.position = newPosition;

                OptionMenu.SetActive(true);
            }
        }
    }
    private void OptionCanvas()
    {
        
        OptionMenu.SetActive(false);
        Canvas_opt.SetActive(true);
        
    }

    private void OnClickBack()
    {
        
        OptionMenu.SetActive(true);
        Canvas_opt.SetActive(false);
    }

    private void GameRetry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //GetActiveScene�� �ش� ���� �̸��� �����´�.
    }

    private void LoadMainMenu()
    {
        Time.timeScale = 1;
        OVRScreenFade.instance.FadeOut(() =>
        {
            SceneManager.LoadScene(MainMenuSceneName); //�̵��� �� �̸��� ���ƾ� ��.
        });
    }

    private void GameQuit()
    {
        Time.timeScale = 1;
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        OVRScreenFade.instance.FadeOut(() => { Application.Quit(); });
#endif
    }

    private void SetVolume(float volume)
    {
        backgroundMusic.volume = volume;
    }
}