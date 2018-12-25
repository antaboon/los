
using UnityEngine;

public class Camerafollow : MonoBehaviour {

    public Transform target;
    public float smoothspeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 desiredposition = target.position + offset;
        transform.position = desiredposition;
    }
}
