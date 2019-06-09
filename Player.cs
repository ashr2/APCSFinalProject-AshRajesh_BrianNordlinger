using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public LayerMask groundLayers;
    public float jumpForce = 7;
    public CapsuleCollider col;
    public Transform pos;
    public float moveSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        col.height = 1f;
        col.center = new Vector3(0f, 0.5f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        float lookHorizontal = Input.GetAxis("Mouse X");
        float moveVertical = Input.GetAxis("Vertical");
        if (Input.GetAxis("Jump") > 0f)
        {
            rb.AddForce(Vector3.up, ForceMode.Impulse);
        }
        /*
        if (jump == 0f && pos.position.y > -0.1f || pos.position.y > 3f)
        {
            jump = -1f;
        }
        */
        Vector3 movement = new Vector3(0f, 0f, moveVertical);
        transform.Translate(movement * Time.deltaTime * moveSpeed);
        transform.Rotate(new Vector3(0f, lookHorizontal, 0f));

    }

}