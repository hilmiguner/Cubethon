using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   
    public Transform playerTransform;
    private float lastPositionZ;
    private float score = 0;
    public Text text;
    void Update()
    {
        // variable = default(data_type) is basically means variable == null
        if(lastPositionZ == default(float)) 
        {
            lastPositionZ = playerTransform.position.z;
        }
        score += playerTransform.position.z - lastPositionZ;
        lastPositionZ = playerTransform.position.z;
        text.text = score.ToString("0");
    }
}
