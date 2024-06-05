using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    Vector3 offset;

    Vector3 newpos;

    Vector3 newRotation;

    [SerializeField] GameObject Player;


    // Start is called before the first frame update
    void Start() => offset = Player.transform.position - transform.position;

    // Update is called once per frame
    void Update()
    {
        newpos = transform.position;
        newpos.x = Player.transform.position.x - offset.x;
        newpos.z = Player.transform.position.z - offset.z;
        newpos.y = Player.transform.position.y - offset.y;
        transform.position = newpos;

       

    }
}

