﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player_controllerrojo : MonoBehaviour
{
    public float velocidad;


    Score score_Manager;


    // private void Awake()
    //{
    //    score_Manager = GameObject.Find("ScoreManagerText").GetComponent<Score_Manager>();
    //}

    // Start is called before the first frame update


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {






    }

    void FixedUpdate()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        gameObject.transform.position = new Vector2(transform.position.x + (horizontal * velocidad),
           transform.position.y + (vertical * velocidad));
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "rojo")
        {
            print("colision");
            Destroy(collision.gameObject);
           // score_Manager.IncrementScore();
        }
        else
        {
            print("respuesta incorrecta");
        }

    }



}