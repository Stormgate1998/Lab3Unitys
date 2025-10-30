using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mouseSensitivity = 2f;
    public Transform playerCamera;

    private float xRotation = 0f;
    private bool controllingRobot = false;
    public RobotMovement robot; // assign in Inspector

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.rotation = new(0, 00, 0, 0);
    }

    void Update()
    {
        // Toggle control mode
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            controllingRobot = !controllingRobot;
        }

        if (controllingRobot)
        {
            robot.HandleInput();
            HandleMouseLook();
        }
        else
        {
            HandlePlayerMovement();
            HandleMouseLook();
        }
    }

    void HandlePlayerMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        transform.position += move * moveSpeed * Time.deltaTime;
    }

    void HandleMouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
