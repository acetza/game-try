using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    [SerializeField]
    double verticalForce = 16;
    [SerializeField]
    double jumpForce = 1024;
    Vector2 jumpForceVector;
    Vector2 forceRight, forceLeft;
    // Start is called before the first frame update
    void Start()
    {
        jumpForceVector = new Vector2(0, (float)jumpForce);
        forceRight = new Vector2((float)verticalForce, 0);
        forceLeft = new Vector2((float)-verticalForce, 0);
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.AddForce(forceRight);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.AddForce(forceLeft);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(jumpForceVector);
        }
    }
}
