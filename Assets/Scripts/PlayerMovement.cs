using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

    //FixedUpdate() is usually used when physics is involved, instead of Update()
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(transform.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
