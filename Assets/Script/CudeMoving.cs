using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CudeMoving : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        }
    }
}
