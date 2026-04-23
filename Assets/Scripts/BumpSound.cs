using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip bump;
    [SerializeField] AudioClip crash;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Cube(1)")
        {
            audio.PlayOneShot(bump, 0.001f);
        }
        if (collision.gameObject.tag == "domino")
        {
            audio.PlayOneShot(crash);
        }
        if (collision.gameObject.tag == "ramp")
        {
            audio.PlayOneShot(bump);
        }
        if (collision.gameObject.tag == "Player")
        {
            audio.PlayOneShot(bump);
        }
        if (collision.gameObject.tag == "sphere")
        {
            audio.PlayOneShot(bump);
        }
    }
}
