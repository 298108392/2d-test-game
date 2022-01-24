using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 noMov;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        noMov.y = Input.GetAxisRaw("Vertical");
        noMov.x = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + noMov * moveSpeed * Time.fixedDeltaTime);
    }

}
