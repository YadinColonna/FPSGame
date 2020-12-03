using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour
{
    public PlayableDirector _myTimeline;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _myTimeline.Play();
        }
    }
}
