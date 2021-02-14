using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Snapshot : MonoBehaviour
{

    [SerializeField] AudioMixerSnapshot Outside;
    [SerializeField] AudioMixerSnapshot Inside;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Inside.TransitionTo(1f);    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Outside.TransitionTo(1f);
    }
}
