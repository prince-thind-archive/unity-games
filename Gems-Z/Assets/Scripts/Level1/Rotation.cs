using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float Sensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float moveY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        xRotation -= moveY;
        xRotation = Mathf.Clamp(xRotation, -90f , 90f);

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * moveX);
    }
}