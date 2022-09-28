using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackgroundMusic : MonoBehaviour
{
    public string MusicName;
    public void Start()
    {
        FindObjectOfType<AudioManager>().Play(MusicName);
    }
}
