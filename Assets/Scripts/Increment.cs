using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Increment : MonoBehaviour
{
    public Scoring score;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "orb")
        {
            Destroy(other.gameObject);
            score.AddScore(1);
            audioSource.Play();
        }
        
    }
}
