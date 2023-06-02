using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowLocations : MonoBehaviour
{
    Text textObject;
    void Start()
    {
        textObject = gameObject.GetComponent<Text>();
    }
    void Update()
    {
        if (Input.GetKeyDown("Q"))
        {
            //displayText.text = "What ever you want to display";
        }
        else{

        }
    }
}