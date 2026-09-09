using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The duration of a full day in seconds.")]
    public float dayDurationInSeconds = 120f;

    void Update()
    {
        if (dayDurationInSeconds > 0)
        {
            // Calculate how many degrees the light should rotate per second (360 degrees in a full day)
            float degreesPerSecond = 360f / dayDurationInSeconds;
            
            // Rotate the directional light around its X axis
            transform.Rotate(Vector3.right * (degreesPerSecond * Time.deltaTime));
        }
    }
}
