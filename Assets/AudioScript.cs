using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioScript : MonoBehaviour
{
    //public AudioClip introClip;
    //public AudioClip normalGhostClip;
    public AudioSource introSource;
    public AudioSource normalGhostSource;

    // Start is called before the first frame update
    void Start()
    {
        introSource.Play();
        normalGhostSource.PlayDelayed(introSource.clip.length);
    }
    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
