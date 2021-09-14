using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static Player instance = null;
    public AudioClip grunt, wheel;
    public AudioSource audioPlayer;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    public void PlayGrunt()
    {
        audioPlayer.PlayOneShot(grunt);
    }

    public void PlayWheel()
    {
        audioPlayer.PlayOneShot(wheel);
    }

}
