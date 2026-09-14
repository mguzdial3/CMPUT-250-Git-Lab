using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platypuh : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        // Get the Audio Source component attached to this GameObject
        audio = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audio.Play();
        }   
    }
}
