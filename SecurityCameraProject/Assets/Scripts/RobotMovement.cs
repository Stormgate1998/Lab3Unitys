using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    public float moveSpeed = 5f;     // Speed of forward/backward movement
    public float rotationSpeed = 100f; // Speed of rotation

    void Update()
    {
        // Get input from vertical axis (W/S or Up/Down arrows)
      //  float moveInput = Input.GetAxis("Vertical");

        // Get input from horizontal axis (A/D or Left/Right arrows)
      //  float rotationInput = Input.GetAxis("Horizontal");

        // Move the robot forward or backward
       // transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        // Rotate the robot left or right
        //transform.Rotate(Vector3.up * rotationInput * rotationSpeed * Time.deltaTime);
    }

    public void HandleInput()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, rotate, 0);
    }
}
