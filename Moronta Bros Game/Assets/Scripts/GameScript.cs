﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public WebServiceClient webService;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            webService.postPlayerScore("Alvaro Ramirez", 20);

        }
        if (Input.GetButtonDown("Fire1"))
        {
            webService.getScores();

        }
    }
}
