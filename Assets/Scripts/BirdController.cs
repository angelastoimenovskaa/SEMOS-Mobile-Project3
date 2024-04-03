using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdController : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;
    private Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (GetJumpInput())
        {
            Debug.Log("Player pressed the jump button");
            Jump();
        }

    }

    private bool GetJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Jump()
    {  
        //calsulate the direction and speed;
        Vector2 jumpDirection = new Vector2(0, 1);
        Vector2 jumpVector = jumpDirection * jumpSpeed;

        //reset the speed
        rb.velocity = Vector2.zero;

        //jump
        rb.AddForce(jumpVector, ForceMode2D.Impulse);
        
    }
}
