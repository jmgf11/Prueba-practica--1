using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newCamPos = new Vector2(player.transform.position.x, player.transform.position.y);
        transform.position = new Vector3(newCamPos.x, newCamPos.y, transform.position.z);
    }
}
