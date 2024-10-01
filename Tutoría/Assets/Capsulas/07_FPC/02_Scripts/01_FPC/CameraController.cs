using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;
    [SerializeField] private Transform bodyTarget;

    [SerializeField] private float sensitivity = 1;

    private float x, y;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        x += Input.GetAxis("Mouse X") * (sensitivity * 100) * Time.deltaTime;
        y -= Input.GetAxis("Mouse Y") * (sensitivity * 100) * Time.deltaTime;
        y = Mathf.Clamp(y, -90, 90);

        cameraTarget.rotation = Quaternion.Euler(y, x, 0);
        bodyTarget.rotation = Quaternion.Euler(Vector3.up * x);
    }
}
