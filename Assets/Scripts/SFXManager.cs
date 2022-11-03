using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip starSFX;
    private AudioSource _audioSourcer;
    // Start is called before the first frame update
    void Awake()
    {
        _audioSourcer = GetComponent<AudioSource>();
    }

    public void StarSound()
    {
        _audioSourcer.PlayOneShot(starSFX);
    }
}
