using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmgr : MonoBehaviour
{
    public List<AudioClip> Clips;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play(int clipNum)
    {
        source.PlayOneShot(Clips[clipNum]);
    }
}