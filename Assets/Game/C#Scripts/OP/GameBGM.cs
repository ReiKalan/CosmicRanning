using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMOP : MonoBehaviour
{
    public AudioClip BGMSound;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
}
