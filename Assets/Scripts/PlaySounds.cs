using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip introMusic;
    public AudioClip ghostsNormal;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(introMusic);
        audioSource.clip = ghostsNormal;
        audioSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSource.isPlaying == false){
            audioSource.Play();
        }
    }
}
