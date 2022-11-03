using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(transform.position);

        //transform.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            transform.position = new Vector3(transform.position.x,
                                                transform.position.y + 0.001f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - 0.001f,
                                                transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x,
                                               transform.position.y - 0.001f, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + 0.001f,
                                                transform.position.y, 0);
        }
    }
}