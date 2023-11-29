using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ScreenshakeTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerTag")
        {
            timeline.Play();
            Debug.Log("Played Timeline");
        }
    }
}
