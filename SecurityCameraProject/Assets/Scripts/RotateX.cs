using UnityEngine;

public class RotateX : MonoBehaviour
{
    public float spinSpeed;

    // Update is called once per frame

    public float jumpForce = 5.0f;
    private void Start()
    {
    }
    void Update()
    {
        transform.Rotate(Vector3.right, spinSpeed * Time.deltaTime);

    }

}
