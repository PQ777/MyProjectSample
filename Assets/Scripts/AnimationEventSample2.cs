using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventSample2 : MonoBehaviour
{
    public Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        animation.wrapMode = WrapMode.Loop;
    }

    // Update is called once per frame
    void Update()
    {
        animation.CrossFade("walk");
    }
}
