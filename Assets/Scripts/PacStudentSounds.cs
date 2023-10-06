using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentSounds : MonoBehaviour
{

    private Tweener tweener;
    private AudioSource audioSource;
    public AudioClip movingSound;
    public AudioClip eatingSound;
    public AudioClip deathSound;
    public AudioClip collideWall;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GameObject.FindWithTag("GameController").GetComponent<Tweener>();
        audioSource = GetComponent<AudioSource>();
        //audioSource.PlayOneShot(introMusic);
        audioSource.clip = movingSound;
        audioSource.loop = true;
    }

  

    // Update is called once per frame
    void Update()
    {
        if(tweener.movingRightNow){
            if(audioSource.isPlaying == false){
                audioSource.Play();
            }
        }
        
    }
}
