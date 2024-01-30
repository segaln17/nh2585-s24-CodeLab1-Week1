using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    //declaring new variable bowlUI so I can change the status of the UI
    public GameObject bowlUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //upon hitting the trigger, change the active setting of the UI to true so it appears
        bowlUI.SetActive(true);
    }
}
