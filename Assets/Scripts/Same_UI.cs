using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Same_UI : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public GameObject optionSound;
    public GameObject startMenu;

    void LateUpdate()
    {
        if (target1 != null && target2 != null)
        {
            target2.position = target1.position;
            target2.rotation = target1.rotation;
        }
        else
        {
            Debug.LogError("Target Transforms are not assigned.");
        }
    }
    public void OnClickBack()
    {
        optionSound.SetActive(false);
        startMenu.SetActive(true);
    }
}
