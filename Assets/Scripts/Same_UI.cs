using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Same_UI : MonoBehaviour
{
    public Transform target1;
    public Transform target2;   

    public GameObject optionSound;
    public GameObject startMenu;
    public Button Back_btn;

    private void Start()
    {
        
            Back_btn.onClick.AddListener(() => OnClickBack());
        
    }

    void LateUpdate()
    {
       
        {
            target2.position = target1.position;
            target2.rotation = target1.rotation;
            
        }
       
    }

    private void OnClickBack()
    {
        
            optionSound.SetActive(false);
            startMenu.SetActive(true);
       
    }
}
