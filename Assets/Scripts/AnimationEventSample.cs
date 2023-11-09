using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventSample : MonoBehaviour
{
    public void OnAnimationEvent(int value)
    {
        Debug.Log("InAnimationEvent called: " + value);
    }

}
