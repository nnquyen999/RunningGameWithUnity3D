using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingkeyboard : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(0, 5, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.velocity = new Vector3(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.velocity = new Vector3(0, 0, -5);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.velocity = new Vector3(-5, 0, 0);
        }
    }
}
