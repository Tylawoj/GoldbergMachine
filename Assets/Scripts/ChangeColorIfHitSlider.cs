﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitSlider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Slider")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
