using System.Collections;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    [SerializeField] private float time;
    private Coroutine Coroutine;
    public IEnumerator Timer()
    {
        while (true)
        {
            time += Time.deltaTime;
            yield return null;
        }
    }

    public void StartTimer()
    {
        Coroutine = StartCoroutine(Timer());
    }

    public void StopTimer()
    {
        StopCoroutine(Coroutine);
    }
}
