using System.Collections;
using UnityEngine;

public class CoroutineEx : MonoBehaviour
{
    [SerializeField] private float slowmoTime = 0.5f;
    [SerializeField] private float changeSpeed = 0.5f;
    [SerializeField] private float WaitTime = 2;

    private float currentDeltaTime;
    private float currentUnscaledDeltaTime;

    private bool isCoroutine = false;

    public void Update()
    {
        currentDeltaTime += Time.deltaTime;
        currentUnscaledDeltaTime += Time.unscaledDeltaTime;

        if (Input.GetKeyDown(KeyCode.E) && !isCoroutine)
        {
            StartCoroutine(NuestraCorrutina());
        }
    }

    IEnumerator NuestraCorrutina()
    {
        isCoroutine = true;

        float targetTimeScale = slowmoTime;

        while (Time.timeScale > targetTimeScale)
        {
            Time.timeScale -= changeSpeed * Time.unscaledDeltaTime;
            yield return null;
        }

        yield return new WaitForSecondsRealtime(WaitTime);

        while (Time.timeScale < 1f)
        {
            Time.timeScale += changeSpeed * Time.unscaledDeltaTime;
            yield return null;
        }

        Time.timeScale = 1f;
        isCoroutine = false;
    }
}