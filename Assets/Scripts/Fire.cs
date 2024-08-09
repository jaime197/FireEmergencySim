using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField, Range(0f, 1f)] private float currentIntensity = 1.0f;
    private float[] startIntensities = new float[0];

    [SerializeField] private ParticleSystem[] fireParticleSystems = new ParticleSystem[0];

    public GameObject endUI;
    public GameObject alarmSound;

    public GameObject narrator; // Reference to the Narrator object
    private PlayQuickSound4 playQuickSound; // Reference to the PlayQuickSound1 script

    private bool hasEnded = false; // Flag to prevent multiple calls

    private void Start()
    {
        startIntensities = new float[fireParticleSystems.Length];

        for (int i = 0; i < fireParticleSystems.Length; i++)
        {
            startIntensities[i] = fireParticleSystems[i].emission.rateOverTime.constant;
        }
    }

    private void Update()
    {
        ChangeIntensity();

        if (currentIntensity < 0.1 && !hasEnded)
        {
            EndGame();
            hasEnded = true; // Set flag to true
        }
    }

    public bool TryExtinguish(float amount)
    {
        currentIntensity -= amount;

        ChangeIntensity();

        return currentIntensity <= 0f;
    }

    private void ChangeIntensity()
    {
        for (int i = 0; i < fireParticleSystems.Length; i++)
        {
            var emission = fireParticleSystems[i].emission;
            emission.rateOverTime = currentIntensity * startIntensities[i];
        }
    }

    private void EndGame()
    {
        endUI.SetActive(true);

        AudioSource audioSource = alarmSound.GetComponent<AudioSource>();

        audioSource.Stop();

        playQuickSound = narrator.GetComponent<PlayQuickSound4>();

        playQuickSound.Play();
    }
}
