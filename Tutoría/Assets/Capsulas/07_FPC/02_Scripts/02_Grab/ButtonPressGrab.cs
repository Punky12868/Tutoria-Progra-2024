using UnityEngine;

public class ButtonPressGrab : MonoBehaviour
{
    [SerializeField] private Transform grabPoint;
    [SerializeField] private float grabRange = 5;
    [SerializeField] private LayerMask grabMask;

    [SerializeField] private bool debugMode = false;

    private Transform target;
    private Transform cameraPos;

    private void Start()
    {
        cameraPos = Camera.main.transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (target == null)
            {
                GrabObject();
            }
            else
            {
                DropObject();
            }
        }

        DebugMode();
    }

    private void GrabObject()
    {
        RaycastHit hit;
        if (Physics.Raycast(cameraPos.position, cameraPos.forward, out hit, grabRange, grabMask))
        {
            target = hit.transform;
            target.GetComponent<Rigidbody>().isKinematic = true;
            target.transform.SetParent(grabPoint);
            target.transform.localPosition = Vector3.zero;
        }
    }

    private void DropObject()
    {
        target.GetComponent<Rigidbody>().isKinematic = false;
        target.transform.SetParent(null);
        target = null;
    }

    private void DebugMode()
    {
        if (debugMode)
        {
            Debug.DrawRay(cameraPos.position, cameraPos.forward * grabRange, Color.red);
        }
    }
}
