using UnityEngine;

public class TimeControl : MonoBehaviour
{
    [SerializeField] private float newTime = 1;

    private void Update()
    {
        Time.timeScale = newTime;
    }
}
