using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingkeyboard : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float movermentSpeed = 6f;
    [SerializeField] float jumpLevel = 5f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rigidbody.velocity = new Vector3(horizontalInput * movermentSpeed, rigidbody.velocity.y, verticalInput * movermentSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpLevel, rigidbody.velocity.z);
        }

        
    }

    bool IsGround()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }

    protected virtual void Moving()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, 5f, rigidbody.velocity.z);
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
