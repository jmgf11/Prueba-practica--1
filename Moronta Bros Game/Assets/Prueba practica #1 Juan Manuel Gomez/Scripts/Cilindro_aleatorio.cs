using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro_aleatorio : MonoBehaviour
{
    public GameObject Redcilindro, Greencilindro, Yellowcilindro, Bluecilindro;
    Vector3 _startingPosition = new Vector3(0, 7.5f);
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(NEXTCILLYNDER());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject NEXTCILLYNDER()
    {

        switch (Random.Range(0, 4))
        {
            case 0:
                return Redcilindro;
            case 1:
                return Bluecilindro;
            case 2:
                return Yellowcilindro;
            default:
                return Greencilindro;

        }
    }
    }

