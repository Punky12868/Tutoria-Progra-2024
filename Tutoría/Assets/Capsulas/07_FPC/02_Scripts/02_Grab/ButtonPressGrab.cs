using UnityEngine;

public class ButtonPressGrab : MonoBehaviour
{
    [SerializeField] private Transform grabPoint;
    [SerializeField] private float grabRange = 5;

    [SerializeField] private bool usingLayerMask;
    [SerializeField] private LayerMask GrabMask;
    [SerializeField] private LayerMask IgnoreMask;

    [SerializeField] private bool usingLerp = false;
    [SerializeField] private float grabTime = 1;

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

        if (usingLerp)
        {
            TargetFollowLerp();
        }

        DebugMode();
    }

    private void GrabObject()
    {
        RaycastHit hit;

        if (usingLayerMask)
        {
            if (Physics.Raycast(cameraPos.position, cameraPos.forward, out hit, grabRange, GrabMask))
            {
                if (!usingLerp)
                {
                    target = hit.transform;
                    target.GetComponent<Rigidbody>().isKinematic = true;
                    target.transform.SetParent(grabPoint);
                    target.transform.localPosition = Vector3.zero;
                }
                else
                {
                    target = hit.transform;
                    target.GetComponent<Rigidbody>().useGravity = false;
                }
            }
        }
        else
        {
            if (Physics.Raycast(cameraPos.position, cameraPos.forward, out hit, grabRange, ~IgnoreMask))
            {
                if (hit.transform.GetComponent<r_Item>())
                {
                    if (!usingLerp)
                    {
                        target = hit.transform;
                        target.GetComponent<Rigidbody>().isKinematic = true;
                        target.transform.SetParent(grabPoint);
                        target.transform.localPosition = Vector3.zero;
                    }
                    else
                    {
                        target = hit.transform;
                        target.GetComponent<Rigidbody>().useGravity = false;
                    }
                }
            }
        }
    }

    private void DropObject()
    {
        if (!usingLerp)
        {
            target.GetComponent<Rigidbody>().isKinematic = false;
            target.transform.SetParent(null);
            target = null;
        }
        else
        {
            target.GetComponent<Rigidbody>().useGravity = true;
            target = null;
        }
    }

    private void TargetFollowLerp()
    {
        if (target != null)
        {
            target.position = Vector3.Lerp(target.position, grabPoint.position, grabTime * Time.deltaTime);
            target.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

    private void DebugMode()
    {
        if (debugMode)
        {
            Debug.DrawRay(cameraPos.position, cameraPos.forward * grabRange, Color.red);
        }
    }
}
