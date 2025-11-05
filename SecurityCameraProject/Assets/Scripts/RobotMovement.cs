using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    public float moveSpeed = 5f;     // Speed of forward/backward movement
    public float rotationSpeed = 100f; // Speed of rotation

    public void HandleInput()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, rotate, 0);
    }
}
