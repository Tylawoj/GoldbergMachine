﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitPing : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ping")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            collision.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
