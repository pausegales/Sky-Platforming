using UnityEngine;

public class CircleMove : MonoBehaviour
{
    public Vector3 centerPoint;   // The center point around which the object will move
    public float radius = 2f;     // Radius of the circular path
    public float speed = 1f;      // Velocity of the movement

    private float angle = 0f;     // Current angle in radians

    private void Update()
    {
        // Calculate the new position on the circular path
        float x = centerPoint.x + Mathf.Cos(angle) * radius;
        float y = centerPoint.y;
        float z = centerPoint.z + Mathf.Sin(angle) * radius;  // Use the same z value as the center point

        // Update the object's position
        transform.position = new Vector3(x, y, z);

        // Increment the angle based on the speed and deltaTime
        angle += speed * Time.deltaTime;

        // Reset the angle when it completes a full circle (2*pi radians)
        if (angle >= Mathf.PI * 2f)
        {
            angle = 0f;
        }
    }
}
