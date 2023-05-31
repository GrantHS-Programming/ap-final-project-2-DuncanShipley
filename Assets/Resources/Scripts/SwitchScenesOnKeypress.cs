using UnityEngine;
using System.Collections;

public class SwitchScenesOnKeypress : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.LoadLevel("locations");
       
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("Main Scene");

        }
    }
    
}