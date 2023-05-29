using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset = new Vector3(0f, 1.5f, -5f);

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
