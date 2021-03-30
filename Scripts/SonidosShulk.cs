using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosShulk : MonoBehaviour {
    public AudioClip[] cClips;
    public AudioSource myAudioSource;
    string btnName;

 // Use this for initialization
 void Start () {
        myAudioSource = GetComponent<AudioSource>();
 }
 
 // Update is called once per frame
 void Update () {
  if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "Backslash":
                        myAudioSource.clip = cClips[0];
                        myAudioSource.Play();
                        break;
                    case "SlitEdge":
                        myAudioSource.clip = cClips[1];
                        myAudioSource.Play();
                        break;
                    case "Buster":
                        myAudioSource.clip = cClips[2];
                        myAudioSource.Play();
                        break;
                    case "ShadowEye":
                        myAudioSource.clip = cClips[3];
                        myAudioSource.Play();
                        break;
                    case "AirSlash":
                        myAudioSource.clip = cClips[4];
                        myAudioSource.Play();
                        break;
                    case "StreamEdge":
                        myAudioSource.clip = cClips[5];
                        myAudioSource.Play();
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}