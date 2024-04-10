using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DripNoiseRange : MonoBehaviour
{
    public AudioClip dripSound;
    public float detectionRange = 10f;
    public float soundCooldown = 5f;

    private AudioSource audioSource;
    private Transform player;
    private float lastSoundTime;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Time.time > lastSoundTime + soundCooldown && Vector3.Distance(transform.position, player.position) <= detectionRange)
        {
            PlayZombieSound();
        }
    }

    void PlayZombieSound()
    {
        audioSource.PlayOneShot(dripSound);
        lastSoundTime = Time.time;
    }
}
