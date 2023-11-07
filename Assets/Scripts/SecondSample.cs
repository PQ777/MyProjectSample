using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject myGameObject = new GameObject("MyGameObject");
        BoxCollider boxCollider = myGameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = true;       //  trigger È°¼ºÈ­

        Transform MyTransform = myGameObject.GetComponent<Transform>();
        MyTransform.position = new Vector3(10f, 0f, 0f);

        Destroy(boxCollider);
    }

}
