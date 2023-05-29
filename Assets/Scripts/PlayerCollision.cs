using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody playerRB;

    //OnCollisionEnter() is an Unity event. It gets called when object of this script collided with another object.
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            //To turn off the script, we use "script_object.enable = false"
            movement.enabled = false;
            playerRB.constraints = RigidbodyConstraints.None;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
