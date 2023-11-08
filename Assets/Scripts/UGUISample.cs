using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UGUISample : MonoBehaviour
{
    [SerializeField]
    private Text myText;

    [SerializeField]
    private Button myButton;

    public void OnButtonClick()
    {
        Debug.Log("<color=green><b>Button Clicked!</b></color>");
    }

    // Start is called before the first frame update
    void Start()
    {
        if(myText != null)
        {
            myText.text = "<color=red>Hello World</color>";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
