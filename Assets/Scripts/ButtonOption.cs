using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using UnityEngine.UI;

public class ButtonOption : MonoBehaviour
{
    public GameObject buttonOption;
    public float distanceFromPlayer = 0.1f;
    public GameObject player;

    private void Start()
    {
        buttonOption.SetActive(false);
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
           
            if (buttonOption.activeSelf)
            {
                buttonOption.SetActive(false);
                Time.timeScale = 1;
            }
            else 
            {
                Time.timeScale = 0; //����


                Transform playerTransform = player.transform;
                Vector3 playerPosition = playerTransform.position;
                Vector3 forwardDirection = playerTransform.forward;

                // UI ��ġ ���� (�÷��̾� �� �Ÿ���ŭ)
                Vector3 newPosition = playerPosition + forwardDirection * distanceFromPlayer;
                buttonOption.transform.position = newPosition;

               

                

                buttonOption.SetActive(true);//
            }
        }
    }
}