using UnityEngine;
using TMPro;

public class r_Raycast : MonoBehaviour
{
    [Header("Grab System")]
    [SerializeField] private Transform grabPoint;
    [SerializeField] private float grabRange = 5;

    [SerializeField] private LayerMask GrabMask;

    [SerializeField] private bool usingLerp = false;
    [SerializeField] private float grabTime = 1;

    [Header("Display Settings")]
    [SerializeField] private GameObject panelData;
    [SerializeField] private TMP_Text itemName;
    [SerializeField] private TMP_Text itemPrice;

    [Header("Debug")]
    [SerializeField] private bool debugMode = false;

    private Transform target;
    private Transform cameraPos;

    private void Start()
    {
        cameraPos = Camera.main.transform;

        if (panelData.activeInHierarchy)
        {
            panelData.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (target == null)
            {
                GrabObject();
            }
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (target != null)
            {
                DropObject();
            }
        }

        LookRaycast();

        if (usingLerp)
        {
            TargetFollowLerp();
        }

        DebugMode();
    }

    private void LookRaycast()
    {
        if (target != null)
        {
            if (panelData.activeInHierarchy)
            {
                panelData.SetActive(false);
            }
        }
        else
        {
            RaycastHit hit;
            if (Physics.Raycast(cameraPos.position, cameraPos.forward, out hit, grabRange, GrabMask))
            {
                if (hit.transform.GetComponent<r_Item>())
                {
                    if (!panelData.activeInHierarchy)
                    {
                        itemName.text = "Item Name: " + hit.transform.GetComponent<r_Item>()._data.itemName;
                        itemPrice.text = "Item Price: " + hit.transform.GetComponent<r_Item>()._data.itemPrice;
                        panelData.SetActive(true);
                    }
                }
            }
            else
            {
                if (panelData.activeInHierarchy)
                {
                    panelData.SetActive(false);
                }
            }
        }
    }
    private void GrabObject()
    {
        RaycastHit hit;

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
