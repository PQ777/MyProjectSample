using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSample : MonoBehaviour
{
    public GameObject prefab;       // 타입은 GameObject / 이름은 prefab
    private void Awake()
    {
        Debug.Log("Awake Called");    
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Called");
        GameObject newGameObject = Instantiate(prefab);              // prefabs에 받아온다
        newGameObject.tag = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Called");
    }
}
