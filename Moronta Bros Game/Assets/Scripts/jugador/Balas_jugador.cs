using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas_jugador : MonoBehaviour
{
    public float impulseForce = 10.0f;

    public float tiempo;
    public GameObject proyectil;

    // Start is called before the first frame update

    void Start()
    {


        StartCoroutine(salto());
    }

    // Update is called once per frame
    void Update()
    {



    }


    IEnumerator salto()
    {


        while (true)
        {


            GetComponent<Rigidbody2D>().AddForce(Vector2.right * impulseForce, ForceMode2D.Impulse);
            yield return new WaitForSeconds(tiempo);
            Destroy(proyectil);






        }



    }
}