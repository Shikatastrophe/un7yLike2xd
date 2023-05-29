using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    private AudioSource audio;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        Invoke("Play", time);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Mouse0))
        {
            SceneManager.LoadScene(1);
        }
    }

    private void Play()
    {
        audio.Play();
    }
}
