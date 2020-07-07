using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Vector3 _movementSpeed = new Vector3(10, 20);
    Vector3 _deltaPos = new Vector3();
    //const float MIN_LIM_Y = -20.4f, MAX_LIM_Y=17.3f;
    //const float MIN_LIM_X = -34.0f, MAX_LIM_X =34.9f;
    public Transform firePoint;
    public GameObject bala;
    Vector2 jumpvelcityToAdd = new Vector2(0f, 10f);
    public float jumpvalue;
    Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) //&& Mathf.Abs(rigidbody.velocity.y) < 0.01f
        {
            
            rigidbody.velocity = jumpvelcityToAdd + rigidbody.velocity;
           // rigidbody.AddForce(Vector3.up * jumpvalue, ForceMode.Impulse);
            
        }

        _deltaPos.x = Input.GetAxis("Horizontal") * _movementSpeed.x;
        
        _deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x,
            gameObject.transform.position.y,
            gameObject.transform.position.z);

        if (Input.GetButtonDown("Fire1")){
            Disparo();
        }
    }

    void Disparo()
    {
        Instantiate(bala, firePoint.position, firePoint.rotation);

    } 
}
