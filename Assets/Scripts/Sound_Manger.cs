using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manger : MonoBehaviour
{
    public AudioSource background_music;
    // Start is called before the first frame update
   public void SetMusicVolume(float volume)
    {
        background_music.volume = volume;
    }
}
