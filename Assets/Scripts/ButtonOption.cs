using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class ButtonOption : MonoBehaviour
{
    public GameObject buttonOption;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            buttonOption.SetActive(true);
        }
    }
}
