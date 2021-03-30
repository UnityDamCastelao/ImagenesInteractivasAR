using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosNoe : MonoBehaviour {
    public AudioClip[] bClips;
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
                    case "DONoe":
                        myAudioSource.clip = bClips[0];
                        myAudioSource.Play();
                        break;
                    case "RENoe":
                        myAudioSource.clip = bClips[1];
                        myAudioSource.Play();
                        break;
                    case "MINoe":
                        myAudioSource.clip = bClips[2];
                        myAudioSource.Play();
                        break;
                    case "FANoe":
                        myAudioSource.clip = bClips[3];
                        myAudioSource.Play();
                        break;
                    case "SOLNoe":
                        myAudioSource.clip = bClips[4];
                        myAudioSource.Play();
                        break;
                    case "LANoe":
                        myAudioSource.clip = bClips[5];
                        myAudioSource.Play();
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}