using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxPlayer : MonoBehaviour
{
    public static sfxPlayer Instance;
    [SerializeField] private AudioClip death;
    [SerializeField] private AudioClip hit;
    [SerializeField] private AudioClip explode;
    [SerializeField] private AudioClip egun;
    [SerializeField] private AudioClip gun;
    private AudioSource sfxSource;

    private void Awake()
    {
        sfxSource = GetComponent<AudioSource>();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Dedsfx()
    {
        sfxSource.PlayOneShot(death);
    }

    public void Explodesfx()
    {
      sfxSource.PlayOneShot(explode);
    }

    public void Gunsfx()
    {
        sfxSource.PlayOneShot(gun);
    }

    public void Hitsfx()
    {
        sfxSource.PlayOneShot(hit);
    }
}
