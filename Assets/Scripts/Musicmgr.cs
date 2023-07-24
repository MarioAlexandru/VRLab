using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicmgr : MonoBehaviour
{
    public AudioSource music;
    public AudioSource explicatii;
    // Start is called before the first frame update
    void Start()
    {
        music.Play();
    }
    public void OnRecorder()
    {
        explicatii.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
