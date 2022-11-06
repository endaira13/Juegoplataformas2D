using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip starSFX;
    public AudioClip bombaSFX;
    public AudioClip victoriaSFX;
    public AudioClip muerteSFX;
    private AudioSource audioSourcer;
    public static SFXManager Instance;
    // Start is called before the first frame update
    void Awake()
    {
        audioSourcer = GetComponent<AudioSource>();
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

    public void StarSound()
    {
        audioSourcer.PlayOneShot(starSFX);
    }
    public void BombaSound()
    {
        audioSourcer.PlayOneShot(bombaSFX);
    }

    public void VictoriaSound()
    {
        audioSourcer.PlayOneShot(victoriaSFX);
    }
    public void MuerteSound()
    {
        audioSourcer.PlayOneShot(muerteSFX);
    }
}
