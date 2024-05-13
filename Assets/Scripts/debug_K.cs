using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class debug_K : MonoBehaviour
{
    public Button yourbutton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
