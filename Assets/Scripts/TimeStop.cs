using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{
    public void PlayClick()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void StopClick()
    {
        Time.timeScale = 0;
    }
}
