using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    static Music instance;

    bool muted;

    AudioSource audiosource;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); 
        } else
        {
            Destroy(this.gameObject); 
        }
        audiosource = this.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            muted = !muted;
        }
        if(muted)
        {
            audiosource.enabled = false;
        } else {
            audiosource.enabled = true;
        }
    }
}
