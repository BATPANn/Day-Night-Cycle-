using UnityEngine;

public class DayNightScript : MonoBehaviour
{


    public Light sun;

    public float DayDuration = 15f;

    private float time; // check how much time has passed


    // Update is called once per frame
    void Update()
    {


        time += Time.deltaTime;

        float angle = (time / DayDuration) * 360f;

        sun.transform.rotation = Quaternion.Euler(angle - 90, 170, 0f); // rotate the sun, give it a little tilt 

        float t = Mathf.Sin(time / DayDuration * Mathf.PI * 2f) * 0.5f * 0.5f; // goes from 0 to 1 smoothly in a sin wave

        sun.intensity = Mathf.Lerp(0.1f, 1f, t);


    }
}
