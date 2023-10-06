using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentSounds : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip movingSound;
    public AudioClip eatingSound;
    public AudioClip deathSound;
    public AudioClip collideWall;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //audioSource.PlayOneShot(introMusic);
        audioSource.clip = movingSound;
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
