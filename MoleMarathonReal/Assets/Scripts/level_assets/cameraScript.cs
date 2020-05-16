using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public Transform target;
    public float smoothspeed = 0f;
    public Vector3 offset;

    void Start()
    {
        offset = new Vector3(0f, 0f, -10f);
    }

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
        transform.position = target.position + offset;

    }
}
