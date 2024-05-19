using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.tag);
        if (other.tag == "Door") OVRScreenFade.instance.FadeOut(() => { SceneManager.LoadScene("Stage1 - 2"); });
    }
}
