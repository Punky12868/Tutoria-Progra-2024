using UnityEngine;

public class SetPosRot : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        target.position = transform.position;
        target.rotation = transform.rotation;
    }
}
